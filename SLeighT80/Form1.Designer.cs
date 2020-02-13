using SLeighT80.Machines.Invaders;

namespace SLeighT80
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openASMFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assembleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAoutFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_LocalRAM = new System.Windows.Forms.TextBox();
            this.txt_NextInstruction = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Pointer_SP = new System.Windows.Forms.TextBox();
            this.txt_Pointer_IP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Register_C = new System.Windows.Forms.TextBox();
            this.txt_Register_F = new System.Windows.Forms.TextBox();
            this.txt_Register_A = new System.Windows.Forms.TextBox();
            this.txt_Register_B = new System.Windows.Forms.TextBox();
            this.txt_Register_E = new System.Windows.Forms.TextBox();
            this.txt_Register_L = new System.Windows.Forms.TextBox();
            this.txt_Register_D = new System.Windows.Forms.TextBox();
            this.txt_Register_H = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_CompletedInstructions = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.txt_Port_1_In = new System.Windows.Forms.TextBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.txt_Port_2_In = new System.Windows.Forms.TextBox();
            this.txt_Port_3_In = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.txt_Port_1_Out = new System.Windows.Forms.TextBox();
            this.txt_Port_3_Out = new System.Windows.Forms.TextBox();
            this.txt_Port_5_Out = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Assembly_Code = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txt_Console = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Next_N = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_Steps = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assemblerToolStripMenuItem,
            this.emulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // assemblerToolStripMenuItem
            // 
            this.assemblerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openASMFileToolStripMenuItem,
            this.assembleToolStripMenuItem,
            this.loadAoutFileToolStripMenuItem});
            this.assemblerToolStripMenuItem.Name = "assemblerToolStripMenuItem";
            this.assemblerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.assemblerToolStripMenuItem.Text = "Assembler";
            // 
            // openASMFileToolStripMenuItem
            // 
            this.openASMFileToolStripMenuItem.Name = "openASMFileToolStripMenuItem";
            this.openASMFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openASMFileToolStripMenuItem.Text = "Open .ASM file";
            // 
            // assembleToolStripMenuItem
            // 
            this.assembleToolStripMenuItem.Name = "assembleToolStripMenuItem";
            this.assembleToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.assembleToolStripMenuItem.Text = "Assemble";
            this.assembleToolStripMenuItem.Click += new System.EventHandler(this.assembleToolStripMenuItem_Click);
            // 
            // loadAoutFileToolStripMenuItem
            // 
            this.loadAoutFileToolStripMenuItem.Name = "loadAoutFileToolStripMenuItem";
            this.loadAoutFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.loadAoutFileToolStripMenuItem.Text = "Load a.out file";
            // 
            // emulationToolStripMenuItem
            // 
            this.emulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.fullScreenToolStripMenuItem});
            this.emulationToolStripMenuItem.Name = "emulationToolStripMenuItem";
            this.emulationToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.emulationToolStripMenuItem.Text = "Emulation";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.tabControl1, 6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 714);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(642, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_LocalRAM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_NextInstruction, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 688);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_LocalRAM
            // 
            this.txt_LocalRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_LocalRAM.Location = new System.Drawing.Point(324, 415);
            this.txt_LocalRAM.Multiline = true;
            this.txt_LocalRAM.Name = "txt_LocalRAM";
            this.txt_LocalRAM.Size = new System.Drawing.Size(315, 270);
            this.txt_LocalRAM.TabIndex = 1;
            // 
            // txt_NextInstruction
            // 
            this.txt_NextInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_NextInstruction.Location = new System.Drawing.Point(3, 415);
            this.txt_NextInstruction.Multiline = true;
            this.txt_NextInstruction.Name = "txt_NextInstruction";
            this.txt_NextInstruction.Size = new System.Drawing.Size(315, 270);
            this.txt_NextInstruction.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.txt_Pointer_SP, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txt_Pointer_IP, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label61, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label1, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_Register_C, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_Register_F, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_Register_A, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_Register_B, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_Register_E, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_Register_L, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_Register_D, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_Register_H, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label12, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.label13, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label14, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label15, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.label16, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.txt_CompletedInstructions, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.label63, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 406);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txt_Pointer_SP
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_Pointer_SP, 5);
            this.txt_Pointer_SP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Pointer_SP.Location = new System.Drawing.Point(80, 183);
            this.txt_Pointer_SP.Name = "txt_Pointer_SP";
            this.txt_Pointer_SP.Size = new System.Drawing.Size(232, 20);
            this.txt_Pointer_SP.TabIndex = 1;
            // 
            // txt_Pointer_IP
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_Pointer_IP, 5);
            this.txt_Pointer_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Pointer_IP.Location = new System.Drawing.Point(80, 157);
            this.txt_Pointer_IP.Name = "txt_Pointer_IP";
            this.txt_Pointer_IP.Size = new System.Drawing.Size(232, 20);
            this.txt_Pointer_IP.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 26);
            this.label17.TabIndex = 0;
            this.label17.Text = "SP";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label61, 3);
            this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label61.Location = new System.Drawing.Point(3, 124);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(168, 30);
            this.label61.TabIndex = 0;
            this.label61.Text = "Pointers";
            this.label61.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label20, 4);
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(245, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Registers";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 26);
            this.label18.TabIndex = 0;
            this.label18.Text = "PC";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(254, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "<--";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(157, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "F";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "B";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "D";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "H";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(157, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "C";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(157, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "E";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(157, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "L";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Register_C
            // 
            this.txt_Register_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Register_C.Location = new System.Drawing.Point(177, 49);
            this.txt_Register_C.Name = "txt_Register_C";
            this.txt_Register_C.Size = new System.Drawing.Size(71, 20);
            this.txt_Register_C.TabIndex = 1;
            // 
            // txt_Register_F
            // 
            this.txt_Register_F.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Register_F.Location = new System.Drawing.Point(177, 23);
            this.txt_Register_F.Name = "txt_Register_F";
            this.txt_Register_F.Size = new System.Drawing.Size(71, 20);
            this.txt_Register_F.TabIndex = 1;
            // 
            // txt_Register_A
            // 
            this.txt_Register_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Register_A.Location = new System.Drawing.Point(80, 23);
            this.txt_Register_A.Name = "txt_Register_A";
            this.txt_Register_A.Size = new System.Drawing.Size(71, 20);
            this.txt_Register_A.TabIndex = 1;
            // 
            // txt_Register_B
            // 
            this.txt_Register_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Register_B.Location = new System.Drawing.Point(80, 49);
            this.txt_Register_B.Name = "txt_Register_B";
            this.txt_Register_B.Size = new System.Drawing.Size(71, 20);
            this.txt_Register_B.TabIndex = 1;
            // 
            // txt_Register_E
            // 
            this.txt_Register_E.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Register_E.Location = new System.Drawing.Point(177, 75);
            this.txt_Register_E.Name = "txt_Register_E";
            this.txt_Register_E.Size = new System.Drawing.Size(71, 20);
            this.txt_Register_E.TabIndex = 1;
            // 
            // txt_Register_L
            // 
            this.txt_Register_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Register_L.Location = new System.Drawing.Point(177, 101);
            this.txt_Register_L.Name = "txt_Register_L";
            this.txt_Register_L.Size = new System.Drawing.Size(71, 20);
            this.txt_Register_L.TabIndex = 1;
            // 
            // txt_Register_D
            // 
            this.txt_Register_D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Register_D.Location = new System.Drawing.Point(80, 75);
            this.txt_Register_D.Name = "txt_Register_D";
            this.txt_Register_D.Size = new System.Drawing.Size(71, 20);
            this.txt_Register_D.TabIndex = 1;
            // 
            // txt_Register_H
            // 
            this.txt_Register_H.Location = new System.Drawing.Point(80, 101);
            this.txt_Register_H.Name = "txt_Register_H";
            this.txt_Register_H.Size = new System.Drawing.Size(38, 20);
            this.txt_Register_H.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(254, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "<--";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(254, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "<--";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(254, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "<--";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(279, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "PSW";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(279, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 26);
            this.label14.TabIndex = 0;
            this.label14.Text = "B";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(279, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "D";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(279, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 26);
            this.label16.TabIndex = 0;
            this.label16.Text = "H";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_CompletedInstructions
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txt_CompletedInstructions, 5);
            this.txt_CompletedInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_CompletedInstructions.Location = new System.Drawing.Point(80, 232);
            this.txt_CompletedInstructions.Name = "txt_CompletedInstructions";
            this.txt_CompletedInstructions.Size = new System.Drawing.Size(232, 20);
            this.txt_CompletedInstructions.TabIndex = 4;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label63, 5);
            this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label63.Location = new System.Drawing.Point(3, 216);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(270, 13);
            this.label63.TabIndex = 3;
            this.label63.Text = "Completed Instructions";
            this.label63.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 12;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.18823F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.81177F));
            this.tableLayoutPanel4.Controls.Add(this.label21, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label22, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label23, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label24, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.label25, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.label26, 6, 1);
            this.tableLayoutPanel4.Controls.Add(this.label27, 7, 1);
            this.tableLayoutPanel4.Controls.Add(this.label28, 8, 1);
            this.tableLayoutPanel4.Controls.Add(this.label29, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label30, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.label31, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.label32, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.label33, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.label34, 6, 2);
            this.tableLayoutPanel4.Controls.Add(this.label35, 7, 2);
            this.tableLayoutPanel4.Controls.Add(this.label36, 8, 2);
            this.tableLayoutPanel4.Controls.Add(this.checkBox1, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.checkBox2, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.checkBox3, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.checkBox4, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.checkBox5, 5, 3);
            this.tableLayoutPanel4.Controls.Add(this.checkBox6, 6, 3);
            this.tableLayoutPanel4.Controls.Add(this.txt_Port_1_In, 4, 15);
            this.tableLayoutPanel4.Controls.Add(this.checkBox7, 7, 3);
            this.tableLayoutPanel4.Controls.Add(this.checkBox8, 8, 3);
            this.tableLayoutPanel4.Controls.Add(this.label37, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label39, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.label40, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.label41, 2, 7);
            this.tableLayoutPanel4.Controls.Add(this.label42, 2, 8);
            this.tableLayoutPanel4.Controls.Add(this.label43, 2, 9);
            this.tableLayoutPanel4.Controls.Add(this.label44, 2, 10);
            this.tableLayoutPanel4.Controls.Add(this.label45, 2, 11);
            this.tableLayoutPanel4.Controls.Add(this.label46, 2, 12);
            this.tableLayoutPanel4.Controls.Add(this.label47, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.label48, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.label49, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.label50, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.label51, 1, 10);
            this.tableLayoutPanel4.Controls.Add(this.label52, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.label53, 1, 12);
            this.tableLayoutPanel4.Controls.Add(this.label38, 3, 5);
            this.tableLayoutPanel4.Controls.Add(this.label55, 3, 7);
            this.tableLayoutPanel4.Controls.Add(this.label54, 3, 6);
            this.tableLayoutPanel4.Controls.Add(this.label56, 3, 8);
            this.tableLayoutPanel4.Controls.Add(this.label57, 3, 9);
            this.tableLayoutPanel4.Controls.Add(this.label58, 3, 10);
            this.tableLayoutPanel4.Controls.Add(this.label59, 3, 11);
            this.tableLayoutPanel4.Controls.Add(this.label60, 3, 12);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label62, 0, 14);
            this.tableLayoutPanel4.Controls.Add(this.label64, 1, 15);
            this.tableLayoutPanel4.Controls.Add(this.label65, 1, 16);
            this.tableLayoutPanel4.Controls.Add(this.label66, 1, 17);
            this.tableLayoutPanel4.Controls.Add(this.txt_Port_2_In, 4, 16);
            this.tableLayoutPanel4.Controls.Add(this.txt_Port_3_In, 4, 17);
            this.tableLayoutPanel4.Controls.Add(this.label67, 6, 15);
            this.tableLayoutPanel4.Controls.Add(this.txt_Port_1_Out, 9, 15);
            this.tableLayoutPanel4.Controls.Add(this.txt_Port_3_Out, 9, 16);
            this.tableLayoutPanel4.Controls.Add(this.txt_Port_5_Out, 9, 17);
            this.tableLayoutPanel4.Controls.Add(this.label68, 6, 16);
            this.tableLayoutPanel4.Controls.Add(this.label69, 6, 17);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(324, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 18;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(315, 406);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(66, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 1);
            this.label21.TabIndex = 0;
            this.label21.Text = "7";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(86, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 1);
            this.label22.TabIndex = 0;
            this.label22.Text = "6";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(106, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 1);
            this.label23.TabIndex = 0;
            this.label23.Text = "5";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(126, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 1);
            this.label24.TabIndex = 0;
            this.label24.Text = "4";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(146, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 1);
            this.label25.TabIndex = 0;
            this.label25.Text = "3";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(166, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 1);
            this.label26.TabIndex = 0;
            this.label26.Text = "2";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(186, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(13, 1);
            this.label27.TabIndex = 0;
            this.label27.Text = "1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(206, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 1);
            this.label28.TabIndex = 0;
            this.label28.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(66, 20);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "S";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(86, 20);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Z";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(106, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(126, 20);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(14, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "A";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(146, 20);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(13, 13);
            this.label33.TabIndex = 0;
            this.label33.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(166, 20);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(14, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "P";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(186, 20);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(13, 13);
            this.label35.TabIndex = 0;
            this.label35.Text = "1";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(206, 20);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(14, 13);
            this.label36.TabIndex = 0;
            this.label36.Text = "C";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(14, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(86, 36);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(14, 14);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(106, 36);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(14, 14);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(126, 36);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(14, 14);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(146, 36);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(14, 14);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(166, 36);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(14, 14);
            this.checkBox6.TabIndex = 1;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // txt_Port_1_In
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.txt_Port_1_In, 2);
            this.txt_Port_1_In.Location = new System.Drawing.Point(126, 193);
            this.txt_Port_1_In.Name = "txt_Port_1_In";
            this.txt_Port_1_In.Size = new System.Drawing.Size(34, 20);
            this.txt_Port_1_In.TabIndex = 1;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(186, 36);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(14, 14);
            this.checkBox7.TabIndex = 1;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(206, 36);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(14, 14);
            this.checkBox8.TabIndex = 1;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Location = new System.Drawing.Point(66, 53);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(14, 13);
            this.label37.TabIndex = 0;
            this.label37.Text = "S";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Location = new System.Drawing.Point(86, 53);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(14, 13);
            this.label39.TabIndex = 0;
            this.label39.Text = "-";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Location = new System.Drawing.Point(86, 66);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(14, 13);
            this.label40.TabIndex = 0;
            this.label40.Text = "-";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Location = new System.Drawing.Point(86, 79);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(14, 13);
            this.label41.TabIndex = 0;
            this.label41.Text = "-";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label42.Location = new System.Drawing.Point(86, 92);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(14, 13);
            this.label42.TabIndex = 0;
            this.label42.Text = "-";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Location = new System.Drawing.Point(86, 105);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(14, 13);
            this.label43.TabIndex = 0;
            this.label43.Text = "-";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Location = new System.Drawing.Point(86, 118);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(14, 13);
            this.label44.TabIndex = 0;
            this.label44.Text = "-";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Location = new System.Drawing.Point(86, 131);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(14, 13);
            this.label45.TabIndex = 0;
            this.label45.Text = "-";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Location = new System.Drawing.Point(86, 144);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(14, 13);
            this.label46.TabIndex = 0;
            this.label46.Text = "-";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label47.Location = new System.Drawing.Point(66, 66);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(14, 13);
            this.label47.TabIndex = 0;
            this.label47.Text = "Z";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label48.Location = new System.Drawing.Point(66, 79);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(14, 13);
            this.label48.TabIndex = 0;
            this.label48.Text = "0";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Location = new System.Drawing.Point(66, 92);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(14, 13);
            this.label49.TabIndex = 0;
            this.label49.Text = "A";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label50.Location = new System.Drawing.Point(66, 105);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(14, 13);
            this.label50.TabIndex = 0;
            this.label50.Text = "0";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label51.Location = new System.Drawing.Point(66, 118);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(14, 13);
            this.label51.TabIndex = 0;
            this.label51.Text = "P";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Location = new System.Drawing.Point(66, 131);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(14, 13);
            this.label52.TabIndex = 0;
            this.label52.Text = "1";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Location = new System.Drawing.Point(66, 144);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(14, 13);
            this.label53.TabIndex = 0;
            this.label53.Text = "C";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label38, 6);
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Location = new System.Drawing.Point(106, 53);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(114, 13);
            this.label38.TabIndex = 0;
            this.label38.Text = "Sign Flag";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label55, 6);
            this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label55.Location = new System.Drawing.Point(106, 79);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(114, 13);
            this.label55.TabIndex = 0;
            this.label55.Text = "Not used, always zero";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label54, 6);
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Location = new System.Drawing.Point(106, 66);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(114, 13);
            this.label54.TabIndex = 0;
            this.label54.Text = "Zero Flag";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label56, 7);
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Location = new System.Drawing.Point(106, 92);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(134, 13);
            this.label56.TabIndex = 0;
            this.label56.Text = "Auxiliary Carry or Half Flag";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label57, 6);
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.Location = new System.Drawing.Point(106, 105);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(114, 13);
            this.label57.TabIndex = 0;
            this.label57.Text = "Not used, always zero";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label58, 6);
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Location = new System.Drawing.Point(106, 118);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(114, 13);
            this.label58.TabIndex = 0;
            this.label58.Text = "Parity Flag";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label59, 6);
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Location = new System.Drawing.Point(106, 131);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(114, 13);
            this.label59.TabIndex = 0;
            this.label59.Text = "Not used, always one";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label60, 6);
            this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label60.Location = new System.Drawing.Point(106, 144);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(114, 13);
            this.label60.TabIndex = 0;
            this.label60.Text = "Carry Flag";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label19, 7);
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "F (Flags)";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label62, 6);
            this.label62.Location = new System.Drawing.Point(3, 177);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(31, 13);
            this.label62.TabIndex = 0;
            this.label62.Text = "Ports";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label64, 3);
            this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label64.Location = new System.Drawing.Point(66, 190);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(54, 26);
            this.label64.TabIndex = 0;
            this.label64.Text = "Port1 In";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label65, 3);
            this.label65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label65.Location = new System.Drawing.Point(66, 216);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(54, 26);
            this.label65.TabIndex = 0;
            this.label65.Text = "Port2 In";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label66, 3);
            this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label66.Location = new System.Drawing.Point(66, 242);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(54, 164);
            this.label66.TabIndex = 0;
            this.label66.Text = "Port3 In";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Port_2_In
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.txt_Port_2_In, 2);
            this.txt_Port_2_In.Location = new System.Drawing.Point(126, 219);
            this.txt_Port_2_In.Name = "txt_Port_2_In";
            this.txt_Port_2_In.Size = new System.Drawing.Size(34, 20);
            this.txt_Port_2_In.TabIndex = 1;
            // 
            // txt_Port_3_In
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.txt_Port_3_In, 2);
            this.txt_Port_3_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Port_3_In.Location = new System.Drawing.Point(126, 245);
            this.txt_Port_3_In.Name = "txt_Port_3_In";
            this.txt_Port_3_In.Size = new System.Drawing.Size(34, 20);
            this.txt_Port_3_In.TabIndex = 1;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label67, 3);
            this.label67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label67.Location = new System.Drawing.Point(166, 190);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(54, 26);
            this.label67.TabIndex = 0;
            this.label67.Text = "Port1 Out";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Port_1_Out
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.txt_Port_1_Out, 2);
            this.txt_Port_1_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Port_1_Out.Location = new System.Drawing.Point(226, 193);
            this.txt_Port_1_Out.Name = "txt_Port_1_Out";
            this.txt_Port_1_Out.Size = new System.Drawing.Size(34, 20);
            this.txt_Port_1_Out.TabIndex = 1;
            // 
            // txt_Port_3_Out
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.txt_Port_3_Out, 2);
            this.txt_Port_3_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Port_3_Out.Location = new System.Drawing.Point(226, 219);
            this.txt_Port_3_Out.Name = "txt_Port_3_Out";
            this.txt_Port_3_Out.Size = new System.Drawing.Size(34, 20);
            this.txt_Port_3_Out.TabIndex = 1;
            // 
            // txt_Port_5_Out
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.txt_Port_5_Out, 2);
            this.txt_Port_5_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Port_5_Out.Location = new System.Drawing.Point(226, 245);
            this.txt_Port_5_Out.Name = "txt_Port_5_Out";
            this.txt_Port_5_Out.Size = new System.Drawing.Size(34, 20);
            this.txt_Port_5_Out.TabIndex = 1;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label68, 3);
            this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label68.Location = new System.Drawing.Point(166, 216);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(54, 26);
            this.label68.TabIndex = 0;
            this.label68.Text = "Port3 Out";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label69, 3);
            this.label69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label69.Location = new System.Drawing.Point(166, 242);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(54, 164);
            this.label69.TabIndex = 0;
            this.label69.Text = "Port5 Out";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(642, 688);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assembler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(642, 688);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(3, 16);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(630, 113);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Assembly_Code);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 544);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assembly Code";
            // 
            // txt_Assembly_Code
            // 
            this.txt_Assembly_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Assembly_Code.Location = new System.Drawing.Point(3, 16);
            this.txt_Assembly_Code.Multiline = true;
            this.txt_Assembly_Code.Name = "txt_Assembly_Code";
            this.txt_Assembly_Code.Size = new System.Drawing.Size(630, 525);
            this.txt_Assembly_Code.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(642, 688);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Disassembly";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(642, 688);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Memory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txt_Console);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(642, 688);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Console";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txt_Console
            // 
            this.txt_Console.BackColor = System.Drawing.Color.Black;
            this.txt_Console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Console.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Console.ForeColor = System.Drawing.Color.Lime;
            this.txt_Console.Location = new System.Drawing.Point(0, 0);
            this.txt_Console.Multiline = true;
            this.txt_Console.Name = "txt_Console";
            this.txt_Console.Size = new System.Drawing.Size(642, 688);
            this.txt_Console.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 6;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_Next, 5, 1);
            this.tableLayoutPanel7.Controls.Add(this.btn_Next_N, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.txt_Steps, 3, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(656, 749);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(578, 723);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Run Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Next_N
            // 
            this.btn_Next_N.Location = new System.Drawing.Point(497, 723);
            this.btn_Next_N.Name = "btn_Next_N";
            this.btn_Next_N.Size = new System.Drawing.Size(75, 23);
            this.btn_Next_N.TabIndex = 3;
            this.btn_Next_N.Text = "Run Next (n)";
            this.btn_Next_N.UseVisualStyleBackColor = true;
            this.btn_Next_N.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 723);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 723);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_Steps
            // 
            this.txt_Steps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Steps.Location = new System.Drawing.Point(213, 723);
            this.txt_Steps.Name = "txt_Steps";
            this.txt_Steps.Size = new System.Drawing.Size(278, 20);
            this.txt_Steps.TabIndex = 4;
            this.txt_Steps.Text = "5000000000";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 773);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Intel 8080 Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Register_C;
        private System.Windows.Forms.TextBox txt_Register_F;
        private System.Windows.Forms.TextBox txt_Register_A;
        private System.Windows.Forms.TextBox txt_Register_B;
        private System.Windows.Forms.TextBox txt_Register_E;
        private System.Windows.Forms.TextBox txt_Register_L;
        private System.Windows.Forms.TextBox txt_Register_D;
        private System.Windows.Forms.TextBox txt_Register_H;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Pointer_IP;
        private System.Windows.Forms.TextBox txt_Pointer_SP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Assembly_Code;
        private System.Windows.Forms.ToolStripMenuItem assemblerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openASMFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assembleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAoutFileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txt_Console;
        private System.Windows.Forms.TextBox txt_NextInstruction;
        private System.Windows.Forms.TextBox txt_LocalRAM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox txt_CompletedInstructions;
        private System.Windows.Forms.Button btn_Next_N;
        private System.Windows.Forms.TextBox txt_Steps;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem emulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Port_1_In;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox txt_Port_2_In;
        private System.Windows.Forms.TextBox txt_Port_3_In;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox txt_Port_1_Out;
        private System.Windows.Forms.TextBox txt_Port_3_Out;
        private System.Windows.Forms.TextBox txt_Port_5_Out;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
    }
}

