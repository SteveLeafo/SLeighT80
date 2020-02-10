using System;
using System.ComponentModel.Design;
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

namespace SLeighT80
{
    public partial class Form1 : Form
    {
        // Our space invaders machine
        i8080 machine = new i8080();

        // An 8080 machine code file
        string filename = string.Empty;

        // A cool (but basic) control I found that displays binary data in hex format
        private ByteViewer byteviewer;

        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

           
            KeyPreview = true;

            byteviewer = new ByteViewer();
            byteviewer.Dock = DockStyle.Fill;
            this.tabPage1.Controls.Add(byteviewer);

            // Install the 8080 instruction set to this machine
            i8080InstructionSet.Install(machine);
            machine.Optimize();

            // Initialize XInput
            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };

            foreach (var selectControler in controllers)
            {
                if (selectControler.IsConnected)
                {
                    machine.controller = selectControler;
                    break;
                }
            }

            int ic = 0;
            foreach (var inst in machine.InstructionSet.Values)
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
                            // TODO, actuall unzip these files.
                            if (args[i + 1].Contains("invaders.zip"))
                            {
                                Loader.LoadSpaceInvaders(machine);
                                StartEmulation();
                            }
                            if (args[i + 1].Contains("lrescue.zip"))
                            {
                                Loader.LoadLunarRescue(machine);
                                StartEmulation();
                            }
                            if (args[i + 1].Contains("balloon.zip"))
                            {
                                Loader.LoadBalloonWars(machine);
                                StartEmulation();
                            }
                            if (args[i + 1].Contains("galxwarst.zip"))
                            {
                                Loader.LoadGalaxyWars(machine);
                                StartEmulation();
                            }
                            if (args[i + 1].Contains("cosmo.zip"))
                            {
                                Loader.LoadCosmo(machine);
                                StartEmulation();
                            }
                            if (args[i + 1].Contains("lupin3a.zip"))
                            {
                                Loader.LoadLupin3(machine);
                                StartEmulation();
                            }
                            if (args[i + 1].Contains("ozmawars.zip"))
                            {
                                Loader.LoadOsmaWars(machine);
                                StartEmulation();
                            }
                            if (args[i + 1].Contains("indianbt.zip"))
                            {
                                Loader.LoadIndianBattle(machine);
                                StartEmulation();
                            }
                        }
                    }
                }
            }
            base.OnLoad(e);
            if (fullScreen)
            {
                toggleFullscreen();
            }
        }

        /// <summary>Z
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    machine.Reset(0);

                    machine.HasConsole = true;

                    filename = ofd.FileName;

                    File.ReadAllBytes(ofd.FileName).CopyTo(machine.RAM, 0x100);
                    machine.PC = 0x100;
                    machine.IntallOutputRoutines();                   

                    tabControl1.SelectedIndex = 4;
                    txt_Console.Text += "\r\n";

                    textBox1.Text = Disassembler.Disassemble(machine.RAM, machine.InstructionSet);

                    RefreshUI();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshUI()
        {
            txt_Register_A.Text = machine.A.ToString("x2");
            txt_Register_B.Text = machine.B.ToString("x2");
            txt_Register_C.Text = machine.C.ToString("x2");
            txt_Register_D.Text = machine.D.ToString("x2");
            txt_Register_E.Text = machine.E.ToString("x2");
            txt_Register_F.Text = machine.F.ToString("x2");
            txt_Register_H.Text = machine.H.ToString("x2");
            txt_Register_L.Text = machine.L.ToString("x2");

            txt_Pointer_IP.Text = machine.PC.ToString("x2");
            txt_Pointer_SP.Text = machine.SP.ToString("x2");

            txt_Port_1_In.Text = machine.PORT_IN_1.ToString("x2");
            txt_Port_2_In.Text = machine.PORT_IN_2.ToString("x2");
            //txt_Port_3_In.Text = machine.PC.ToString("x2");
            //txt_Port_1_Out.Text = machine.PORT_OUT_1.ToString("x2");
            txt_Port_3_Out.Text = machine.PORT_OUT_3.ToString("x2");
            txt_Port_5_Out.Text = machine.PORT_OUT_5.ToString("x2");


            checkBox1.Checked = (machine.F & (byte)i8080.Flags.S) != 0;
            checkBox2.Checked = (machine.F & (byte)i8080.Flags.Z) != 0;
            checkBox6.Checked = (machine.F & (byte)i8080.Flags.P) != 0;
            checkBox7.Checked = (machine.F & 2) != 0;
            checkBox8.Checked = (machine.F & (byte)i8080.Flags.C) != 0;

            byteviewer.SetBytes(machine.RAM);

            byte[] buf = new byte[100];
            Invalidate();
            if (machine.PC < machine.RAM.Length - 100)
            {
                Array.Copy(machine.RAM, machine.PC, buf, 0, 100);
            }
            txt_NextInstruction.Text = Disassembler.Disassemble(buf, machine.InstructionSet, true, machine.PC);
            txt_LocalRAM.Text = Disassembler.Disassemble(buf, machine.InstructionSet, false, machine.PC);

            foreach (var line in machine.Console)
            {
                txt_Console.Text += line;
            }
            machine.Console.Clear();

            txt_CompletedInstructions.Text = machine.NumberOfExecutedInstructions.ToString() + "    /   " + machine.Cycles.ToString();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assembleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembler.Assemble("C:\\Games\\8080\\a.out", txt_Assembly_Code.Text, machine.InstructionOpCodes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            machine.RunNext();
            RefreshUI();
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
                    if (machine.On)
                    {
                        machine.RunNext();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            RefreshUI();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            machine.Reset(0);

            File.ReadAllBytes(filename).CopyTo(machine.RAM, 0x100);

            textBox1.Text = Disassembler.Disassemble(machine.RAM, machine.InstructionSet);
            txt_CompletedInstructions.Text = "";
            RefreshUI();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (machine != null)
            {
                if (machine.On)
                {
                    return;
                }
            }
            base.OnPaintBackground(e);
        }

        /// <summary>
        /// 
        /// </summary>
        private bool _CursorShown = true;
        public bool CursorShown
        {
            get
            {
                return _CursorShown;
            }
            set
            {
                if (value == _CursorShown)
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

                _CursorShown = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (machine != null)
            {
                if (machine.On)
                {
                    e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                    e.Graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                    //Speed
                    //e.Graphics.InterpolationMode = InterpolationMode.Low;
                    //e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;
                    //e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;
                    //e.Graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
                    //e.Graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                    //Quality
                    //e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    //e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                    //e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    //e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                    //e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    Machines.Invaders.Screen.Paint(e.Graphics, machine, ClientRectangle, menuStrip1.Height, machine.ScaleFactor);
                    if (fullscreen)
                    {
                        CursorShown = false;
                    }
                    else
                    {
                        CursorShown = true;
                    }
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

            machine.On = true;
            btn_Next.Enabled = false;
            btn_Next_N.Enabled = false;

            Thread t = new Thread(() => Run(machine));
            this.tableLayoutPanel7.Visible = false;
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
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D1)
            {
                lunarToolStripMenuItem_Click(this, null);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D2)
            {
                balloonToolStripMenuItem_Click(this, null);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D3)
            {
                invadersToolStripMenuItem_Click(this, null);
                e.Handled = true;
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D4)
            {
                galaxyWarsToolStripMenuItem_Click(this, null);
                e.Handled = true;
            }
            else if (e.KeyData == Keys.F11)
            {
                toggleFullscreen();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.C)
            {
                machine.PORT_IN_1 |= 0x01;
                e.Handled = true;
            }
            else if (e.KeyData == Keys.D1)
            {
                machine.PORT_IN_1 |= 0x04;  // 1P
                e.Handled = true;
            }
            else if (e.KeyData == Keys.D2)
            {
                machine.PORT_IN_1 |= 0x02;  // 1P
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Left)
            {
                machine.PORT_IN_1 |= 0x20;
                // Can't move left and right at the same time 
                machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x40));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Right)
            {
                machine.PORT_IN_1 |= 0x40;
                // Can't move left and right at the same time 
                machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x20));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Space)
            {
                machine.PORT_IN_1 |= 0x10;
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
                machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x01));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.D1)
            {
                machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x04));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Left)
            {
                machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x20));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Right)
            {
                machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x40));
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Space)
            {
                machine.PORT_IN_1 = unchecked((byte)(machine.PORT_IN_1 & (byte)~0x10));
                e.Handled = true;
            }

            base.OnKeyUp(e);
        }   

        /// <summary>
        /// 
        /// </summary>
        private void StopEmulation()
        {
            this.tableLayoutPanel7.Visible = true;
            machine.On = false;
            btn_Next.Enabled = true;
            btn_Next_N.Enabled = true;
            RefreshUI();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="machine"></param>
        public static void Run(i8080 machine)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int ticks = (int)(1000.0 / 60.0 / 2.0) * 10000;

            bool top = true;

            int c = 0;
            long t = 0;
            while (machine.On)
            {
                machine.RunNext();

                if (t > ticks)
                {
                    if (machine.Interupt((byte)(top ? 0xcf : 0xd7)))
                    {
                        top = !top;
                    }
                    sw.Restart();
                }
                if (c % 100 == 0)
                {
                    t = sw.ElapsedTicks;
                    
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
        private void lunarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loader.LoadLunarRescue(machine);
            RefreshUI();
            StartEmulation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void balloonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loader.LoadBalloonWars(machine);
            RefreshUI();
            StartEmulation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void invadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loader.LoadSpaceInvaders(machine);
            RefreshUI();
            StartEmulation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void galaxyWarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loader.LoadGalaxyWars(machine);
            RefreshUI();
            StartEmulation();
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
            Tests.Run(machine);
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
            toggleFullscreen();
        }

        /// <summary>
        /// 
        /// </summary>
        void toggleFullscreen()
        {
            if (!fullscreen)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                machine.ScaleFactor = 4;
                menuStrip1.Visible = false;
                Refresh();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                machine.ScaleFactor = 3;
                menuStrip1.Visible = true;
                Refresh();
            }
            fullscreen = !fullscreen;
             
        }
        bool fullscreen = false;
    }
}
