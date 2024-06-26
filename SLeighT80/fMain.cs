﻿using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using SharpDX.XInput;
using SLeighT80.Machines.Invaders;
using SLeighT80.Processors.i8080;
using SLeighT80.Processors;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;

namespace SLeighT80
{
    public partial class fMain : Form
    {
        // Our space invaders machine
        readonly i8080 m_machine = new i8080(new byte[65536]);

        // An 8080 machine code file
        string m_filename = string.Empty;

        // A cool (but basic) control I found that displays binary data in hex format
        //private readonly ByteViewer m_byteViewer;

        // Set to true when in full screen mode
        bool m_fullscreen;

        /// <summary>
        /// 
        /// </summary>
        public fMain()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            KeyPreview = true;

            // Install the 8080 instruction set to this machine
            new i8080InstructionSet().InstallTo(m_machine);
            m_machine.Optimize();

            // Initialize XInput
            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };

            foreach (var selectController in controllers)
            {
                if (selectController.IsConnected)
                {
                    m_machine.controller = selectController;
                    break;
                }
            }

            int ic = 0;
            foreach (var inst in m_machine.InstructionSet.Values)
            {
                if (inst.ExecutionMethod != null)
                {
                    ic++;
                }
            }

            txt_Console.Text += "Loaded the 8080 instruction set\r\n";
            txt_Console.Text += "Implementation is ";
            txt_Console.Text += (100.0 * ic / 256.0).ToString();
            txt_Console.Text += "% complete\r\n";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            Loader.UpdateSupportedGames();
            ColourMap.UpdateSupportedColorMaps();
            string[] args = Environment.GetCommandLineArgs();
            bool fullScreen = false;

            for (int i = 1; i < args.Length; ++i)
            {
                if (args[i] == "-f")
                {
                    fullScreen = true;
                }
                if (args[i] == "-g")
                {
                    if (i < args.Length - 1)
                    {
                        if (File.Exists(args[i + 1]))
                        {
                            if (Path.GetExtension(args[i + 1]).ToUpper().Contains("ZIP"))
                            {
                                StopEmulation();
                                OpenZipFile(args[i + 1]);
                                StartEmulation();
                            }
                        }
                    }
                }
            }
            base.OnLoad(e);
            if (fullScreen)
            {
                ToggleFullscreen();
            }
        }

        /// <summary>Z
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
            tabControl1.SelectedIndex = 4;
            txt_Console.Text += "\r\n";

            textBox1.Text = Disassembler.Disassemble(m_machine.RAM, m_machine.InstructionSet);

            RefreshDebugInformation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        void Open(bool start = false)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(ofd.FileName).ToUpper().Contains("ZIP"))
                    {
                        OpenZipFile(ofd.FileName);
                        if (start)
                        {
                            StartEmulation();
                        }
                    }
                    else
                    {
                        m_machine.Reset(0);

                        m_machine.HasConsole = true;

                        m_filename = ofd.FileName;

                        File.ReadAllBytes(ofd.FileName).CopyTo(m_machine.RAM, 0x100);
                        m_machine.PC = 0x100;
                        m_machine.IntallOutputRoutines();

                        tabControl1.SelectedIndex = 4;
                        txt_Console.Text += "\r\n";

                        textBox1.Text = Disassembler.Disassemble(m_machine.RAM, m_machine.InstructionSet);

                        RefreshDebugInformation();
                    }
                }
            }
        }

        /// <summary>
        /// Attempts to extract a zip file 
        /// </summary>
        /// <param name="fileName"></param>
        void OpenZipFile(string fileName)
        {
            List<KeyValuePair<string, int>> data;

            if (Loader.SupportedGames.TryGetValue(Path.GetFileName(fileName), out data))
            {
                ColourMap.SetColorMap(fileName);
                Sound.SetActiveSample(fileName);

                try
                {
                    StopEmulation();
                    using (var file = File.OpenRead(fileName))
                    using (var zip = new ZipArchive(file, ZipArchiveMode.Read))
                    {
                        m_machine.Reset(0);
                        foreach (var f in data)
                        {
                            ZipArchiveEntry entry = zip.Entries.FirstOrDefault(a => a.Name == f.Key);
                            if (entry != null)
                            {
                                using (var stream = entry.Open())
                                {
                                    using (var memoryStream = new MemoryStream())
                                    {
                                        stream.CopyTo(memoryStream);
                                        memoryStream.ToArray().CopyTo(m_machine.RAM, f.Value);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error loading game");
                }
            }
            else
            {
                MessageBox.Show("Unsupported game");
            }
        }

        // Ports
        byte PORT_IN_1 = 0;
        byte PORT_IN_2 = 1;

        byte PORT_OUT_3 = 2;
        byte PORT_OUT_5 = 3;

        byte SHIFT_LSB = 4;
        byte SHIFT_MSB = 5;
        byte SHIFT_OFFSET = 6;

        /// <summary>
        /// 
        /// </summary>
        private void RefreshDebugInformation()
        {
            txt_Register_A.Text = m_machine.Registers[0].ToString("x2");
            txt_Register_B.Text = m_machine.Registers[1].ToString("x2");
            txt_Register_C.Text = m_machine.Registers[2].ToString("x2");
            txt_Register_D.Text = m_machine.Registers[3].ToString("x2");
            txt_Register_E.Text = m_machine.Registers[4].ToString("x2");
            txt_Register_F.Text = m_machine.Registers[5].ToString("x2");
            txt_Register_H.Text = m_machine.Registers[6].ToString("x2");
            txt_Register_L.Text = m_machine.Registers[7].ToString("x2");

            txt_Pointer_IP.Text = m_machine.PC.ToString("x2");
            txt_Pointer_SP.Text = m_machine.SP.ToString("x2");

            txt_Port_1_In.Text = m_machine.Ports[PORT_IN_1].ToString("x2");
            txt_Port_2_In.Text = m_machine.Ports[PORT_IN_2].ToString("x2");
            //txt_Port_3_In.Text = machine.PC.ToString("x2");
            //txt_Port_1_Out.Text = machine.PORT_OUT_1.ToString("x2");
            txt_Port_3_Out.Text = m_machine.Ports[PORT_OUT_3].ToString("x2");
            txt_Port_5_Out.Text = m_machine.Ports[PORT_OUT_5].ToString("x2");


            //checkBox1.Checked = (m_machine.F & (byte)i8080.Flags.S) != 0;
            //checkBox2.Checked = (m_machine.F & (byte)i8080.Flags.Z) != 0;
            //checkBox6.Checked = (m_machine.F & (byte)i8080.Flags.P) != 0;
            //checkBox7.Checked = (m_machine.F & 2) != 0;
            //checkBox8.Checked = (m_machine.F & (byte)i8080.Flags.C) != 0;

            //m_byteViewer.SetBytes(m_machine.RAM);

            byte[] buf = new byte[100];
            Invalidate();
            if (m_machine.PC < m_machine.RAM.Length - 100)
            {
                Array.Copy(m_machine.RAM, m_machine.PC, buf, 0, 100);
            }
            txt_NextInstruction.Text = Disassembler.Disassemble(buf, m_machine.InstructionSet, true, m_machine.PC);
            txt_LocalRAM.Text = Disassembler.Disassemble(buf, m_machine.InstructionSet, false, m_machine.PC);

            foreach (var line in m_machine.Console)
            {
                txt_Console.Text += line;
            }
            m_machine.Console.Clear();

            txt_CompletedInstructions.Text = m_machine.NumberOfExecutedInstructions.ToString() + "    /   " + m_machine.Cycles.ToString();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assembleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\Games");
            Directory.CreateDirectory("C:\\Games\\8080");
            textBox3.Text = Assembler.Assemble("C:\\Games\\8080\\a.out", txt_Assembly_Code.Text, m_machine.InstructionOpCodes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            m_machine.RunNext();
            RefreshDebugInformation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("c:\\GAMES\\c#.txt"))
            {
                File.Delete("c:\\GAMES\\c#.txt");
            }

            Int64 steps;
            if (Int64.TryParse(txt_Steps.Text, out steps))
            {
                for (int i = 0; i < steps; ++i)
                {
                    if (m_machine.On)
                    {
                        m_machine.RunNext();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            RefreshDebugInformation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            m_machine.Reset(0);

            //File.ReadAllBytes(m_filename).CopyTo(m_machine.RAM, 0x100);
            m_machine.PC = 0x100;

            textBox1.Text = Disassembler.Disassemble(m_machine.RAM, m_machine.InstructionSet);
            txt_CompletedInstructions.Text = "";
            RefreshDebugInformation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (m_machine != null)
            {
                if (m_machine.On)
                {
                    return;
                }
            }
            base.OnPaintBackground(e);
        }

        /// <summary>
        /// 
        /// </summary>
        private bool m_cursorShown = true;
        public bool CursorShown
        {
            get
            {
                return m_cursorShown;
            }
            set
            {
                if (value == m_cursorShown)
                {
                    return;
                }

                if (value)
                {
                    Cursor.Show();
                }
                else
                {
                    Cursor.Hide();
                }

                m_cursorShown = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (m_machine != null)
            {
                if (m_machine.On)
                {
                    e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                    e.Graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                    Machines.Invaders.Screen.Paint(e.Graphics, m_machine, ClientRectangle, menuStrip1.Height, m_machine.ScaleFactor);
                    CursorShown = !m_fullscreen;
                    Invalidate();
                    return;
                }
            }
            base.OnPaint(e);
        }

        /// <summary>
        /// 
        /// </summary>
        private void StartEmulation()
        {
            StopEmulation();
            Thread.Sleep(20);

            m_machine.On = true;
            btn_Next.Enabled = false;
            btn_Next_N.Enabled = false;

            Thread t = new Thread(() => Run(m_machine));
            tableLayoutPanel7.Visible = false;
            Invalidate();
            t.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            CheckKeyboard(e);
            base.OnKeyDown(e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        private void CheckKeyboard(KeyEventArgs e)
        {
            if (e.KeyData == Keys.F11)
            {
                ToggleFullscreen();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.C)
            {
                m_machine.Ports[PORT_IN_1] |= 0x01;
                e.Handled = true;
            }
            else if (e.KeyData == Keys.D1)
            {
                m_machine.Ports[PORT_IN_1] |= 0x04;  // 1P
                e.Handled = true;
            }
            else if (e.KeyData == Keys.D2)
            {
                m_machine.Ports[PORT_IN_1] |= 0x02;  // 1P
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Left)
            {
                m_machine.Ports[PORT_IN_1] |= 0x20;
                // Can't move left and right at the same time 
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x40));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Up)
            {
                m_machine.Ports[PORT_IN_1] |= 0x80;
                // Can't move left and right at the same time 
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x08));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Down)
            {
                m_machine.Ports[PORT_IN_1] |= 0x08;
                // Can't move left and right at the same time 
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x80));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Right)
            {
                m_machine.Ports[PORT_IN_1] |= 0x40;
                // Can't move left and right at the same time 
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x20));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Space)
            {
                m_machine.Ports[PORT_IN_1] |= 0x10;
                e.Handled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyData == Keys.C)
            {
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x01));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.D1)
            {
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x04));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.D2)
            {
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x02));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Left)
            {
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x20));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Right)
            {
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x40));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Up)
            {
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x80));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Down)
            {
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x08));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Space)
            {
                m_machine.Ports[PORT_IN_1] = unchecked((byte)(m_machine.Ports[PORT_IN_1] & (byte)~0x10));
                e.Handled = true;
            }

            base.OnKeyUp(e);
        }

        /// <summary>
        /// 
        /// </summary>
        private void StopEmulation()
        {
            tableLayoutPanel7.Visible = true;
            m_machine.On = false;
            btn_Next.Enabled = true;
            btn_Next_N.Enabled = true;
            RefreshDebugInformation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="machine"></param>
        public static void Run(i8080 machine)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();

            int ticks = (int)(1000.0 / 60.0 / 2.0) * 10000;

            bool top = true;

            int c = 0;
            long t = 0;
            double s1;
            double s2;
            double clockRate = 0;

            machine.MemoryProtection = true;

            while (machine.On)
            {
                if (c % 100 == 0)
                {
                    s1 = (double)(machine.Cycles + 1);
                    s2 = (double)(sw.ElapsedMilliseconds + 1);
                    clockRate = s1 / s2;
                }

                if (clockRate < 2000)
                {
                    machine.RunNext();
                }
                if (t > ticks)
                {
                    if (machine.Interupt((byte)(top ? 0xcf : 0xd7)))
                    {
                        top = !top;
                    }
                    sw2.Restart();
                }
                if (c % 100 == 0)
                {
                    t = sw2.ElapsedTicks;

                }

                //if (c % 250 == 0)
                //{
                //    Thread.Sleep(1);
                //}
                if (c % 25 == 0)
                {
                    if (machine.controller != null)
                    {
                        if (machine.controller.IsConnected)
                        {
                            Input.Check(machine);
                        }
                    }
                }
                c++;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartEmulation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopEmulation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopEmulation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Tests.Run(m_machine);
            if (Tests.FailCount > 0)
            {
                MessageBox.Show(this, "There were failures.", "Error!");
            }
            else
            {
                MessageBox.Show(this, "All tests passed.", "Awesome!");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFullscreen();
        }

        /// <summary>
        /// 
        /// </summary>
        void ToggleFullscreen()
        {
            if (!m_fullscreen)
            {
                TopMost = true;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                m_machine.ScaleFactor = 4;
                menuStrip1.Visible = false;
                Refresh();
            }
            else
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.FixedSingle;
                m_machine.ScaleFactor = 3;
                menuStrip1.Visible = true;
                Refresh();
            }
            m_fullscreen = !m_fullscreen;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (fAbout aboutBox = new fAbout())
            {
                aboutBox.ShowDialog(this);
            }
        }

        private void loadAoutFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.ReadAllBytes("C:\\Games\\8080\\a.out").CopyTo(m_machine.RAM, 0x100);
            m_machine.PC = 0x100;

            tabControl1.SelectedIndex = 0;
            txt_Console.Text += "\r\n";

            textBox1.Text = Disassembler.Disassemble(m_machine.RAM, m_machine.InstructionSet);

            RefreshDebugInformation();
        }

        private void saveASMFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Browse 8080 ASM Files";
                saveFileDialog.DefaultExt = "asm";
                saveFileDialog.InitialDirectory = "C:\\Games\\8080\\ASM";
                saveFileDialog.Filter = "8080 ASM Files (*.asm)|*.asm";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txt_Assembly_Code.Text);
                }
            }
        }

        private void openASMFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Browse 8080 ASM Files";
                openFileDialog.DefaultExt = "asm";
                openFileDialog.InitialDirectory = "C:\\Games\\8080\\ASM";
                openFileDialog.Filter = "8080 ASM Files (*.asm)|*.asm";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    this.txt_Assembly_Code.Text = File.ReadAllText(openFileDialog.FileName);
                    tabControl1.SelectedIndex = 1;
                }
            }
        }
    }
}
