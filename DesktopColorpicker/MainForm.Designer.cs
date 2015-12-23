namespace DesktopColorpicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEXwithoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.panelBaseLeft = new System.Windows.Forms.Panel();
            this.panelPreviewer = new System.Windows.Forms.Panel();
            this.eyeDropperMain = new Unity3.Eyedropper.EyeDropper();
            this.numericUpDownZoomFactor = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxHue = new System.Windows.Forms.TextBox();
            this.textBoxSaturation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLuminance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxHSL = new System.Windows.Forms.TextBox();
            this.textBoxRGB = new System.Windows.Forms.TextBox();
            this.radioButtonRGB = new System.Windows.Forms.RadioButton();
            this.radioButtonHSL = new System.Windows.Forms.RadioButton();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainContextMenu.SuspendLayout();
            this.panelBaseLeft.SuspendLayout();
            this.panelPreviewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomFactor)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.mainContextMenu.Name = "contextMenuStrip1";
            this.mainContextMenu.Size = new System.Drawing.Size(172, 76);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showToolStripMenuItem.Text = "Hide";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hEXwithoutToolStripMenuItem,
            this.hTMLToolStripMenuItem,
            this.rGBToolStripMenuItem});
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            // 
            // hEXwithoutToolStripMenuItem
            // 
            this.hEXwithoutToolStripMenuItem.Name = "hEXwithoutToolStripMenuItem";
            this.hEXwithoutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.hEXwithoutToolStripMenuItem.Text = "HEX (without #)";
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.rGBToolStripMenuItem.Text = "RGB";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.ToolTipText = "Close the Application";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // textBoxHex
            // 
            this.textBoxHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxHex.Location = new System.Drawing.Point(23, 28);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(112, 20);
            this.textBoxHex.TabIndex = 1;
            this.textBoxHex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxHex_MouseClick);
            this.textBoxHex.Enter += new System.EventHandler(this.textBoxHex_Enter);
            // 
            // panelBaseLeft
            // 
            this.panelBaseLeft.Controls.Add(this.panelPreviewer);
            this.panelBaseLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaseLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBaseLeft.Name = "panelBaseLeft";
            this.panelBaseLeft.Size = new System.Drawing.Size(326, 352);
            this.panelBaseLeft.TabIndex = 2;
            // 
            // panelPreviewer
            // 
            this.panelPreviewer.Controls.Add(this.eyeDropperMain);
            this.panelPreviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPreviewer.Location = new System.Drawing.Point(0, 0);
            this.panelPreviewer.Name = "panelPreviewer";
            this.panelPreviewer.Size = new System.Drawing.Size(326, 352);
            this.panelPreviewer.TabIndex = 2;
            // 
            // eyeDropperMain
            // 
            this.eyeDropperMain.Location = new System.Drawing.Point(3, 3);
            this.eyeDropperMain.MaximumSize = new System.Drawing.Size(22, 22);
            this.eyeDropperMain.MinimumSize = new System.Drawing.Size(22, 22);
            this.eyeDropperMain.Name = "eyeDropperMain";
            this.eyeDropperMain.PixelPreviewSize = new System.Drawing.Size(250, 250);
            this.eyeDropperMain.PreviewLocation = new System.Drawing.Point(0, 0);
            this.eyeDropperMain.PreviewPositionStyle = Unity3.Eyedropper.EyeDropper.ePreviewPositionStyle.Manual;
            this.eyeDropperMain.SelectedColor = System.Drawing.Color.Empty;
            this.eyeDropperMain.Size = new System.Drawing.Size(22, 22);
            this.eyeDropperMain.TabIndex = 0;
            this.eyeDropperMain.Text = "Eyedropper";
            this.eyeDropperMain.BeginScreenCapture += new System.EventHandler(this.eyeDropperMain_BeginScreenCapture);
            this.eyeDropperMain.ScreenCaptured += new Unity3.Eyedropper.EyeDropper.ScreenCapturedArgs(this.eyeDropperMain_ScreenCaptured);
            // 
            // numericUpDownZoomFactor
            // 
            this.numericUpDownZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownZoomFactor.Location = new System.Drawing.Point(35, 9);
            this.numericUpDownZoomFactor.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownZoomFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownZoomFactor.Name = "numericUpDownZoomFactor";
            this.numericUpDownZoomFactor.Size = new System.Drawing.Size(33, 20);
            this.numericUpDownZoomFactor.TabIndex = 8;
            this.numericUpDownZoomFactor.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownZoomFactor.ValueChanged += new System.EventHandler(this.numericUpDownZoomFactor_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBoxColors);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(120, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 352);
            this.panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxTopMost);
            this.groupBox4.Location = new System.Drawing.Point(7, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(64, 33);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTopMost.Location = new System.Drawing.Point(5, 11);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(57, 17);
            this.checkBoxTopMost.TabIndex = 1;
            this.checkBoxTopMost.Text = "On Top";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownZoomFactor);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(75, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 33);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zoom";
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColors.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxColors.Controls.Add(this.groupBox3);
            this.groupBoxColors.Controls.Add(this.label10);
            this.groupBoxColors.Controls.Add(this.label3);
            this.groupBoxColors.Controls.Add(this.label2);
            this.groupBoxColors.Controls.Add(this.groupBox2);
            this.groupBoxColors.Controls.Add(this.textBoxHSL);
            this.groupBoxColors.Controls.Add(this.textBoxRGB);
            this.groupBoxColors.Controls.Add(this.textBoxHex);
            this.groupBoxColors.Controls.Add(this.radioButtonRGB);
            this.groupBoxColors.Controls.Add(this.radioButtonHSL);
            this.groupBoxColors.Controls.Add(this.radioButtonHex);
            this.groupBoxColors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.groupBoxColors.Location = new System.Drawing.Point(7, 31);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(139, 313);
            this.groupBoxColors.TabIndex = 25;
            this.groupBoxColors.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBoxHue);
            this.groupBox3.Controls.Add(this.textBoxSaturation);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxLuminance);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(26, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 100);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // textBoxHue
            // 
            this.textBoxHue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxHue.Location = new System.Drawing.Point(71, 18);
            this.textBoxHue.Name = "textBoxHue";
            this.textBoxHue.Size = new System.Drawing.Size(30, 20);
            this.textBoxHue.TabIndex = 11;
            // 
            // textBoxSaturation
            // 
            this.textBoxSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaturation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxSaturation.Location = new System.Drawing.Point(71, 44);
            this.textBoxSaturation.Name = "textBoxSaturation";
            this.textBoxSaturation.Size = new System.Drawing.Size(30, 20);
            this.textBoxSaturation.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Saturation";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hue";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLuminance
            // 
            this.textBoxLuminance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLuminance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLuminance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxLuminance.Location = new System.Drawing.Point(71, 70);
            this.textBoxLuminance.Name = "textBoxLuminance";
            this.textBoxLuminance.Size = new System.Drawing.Size(30, 20);
            this.textBoxLuminance.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Luminance";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "HSL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "RGB";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "HEX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxBlue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxGreen);
            this.groupBox2.Controls.Add(this.textBoxRed);
            this.groupBox2.Location = new System.Drawing.Point(26, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 82);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Green";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxBlue.Location = new System.Drawing.Point(71, 58);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(30, 20);
            this.textBoxBlue.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Red";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Blue";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxGreen.Location = new System.Drawing.Point(71, 33);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(30, 20);
            this.textBoxGreen.TabIndex = 16;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxRed.Location = new System.Drawing.Point(71, 10);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(30, 20);
            this.textBoxRed.TabIndex = 11;
            // 
            // textBoxHSL
            // 
            this.textBoxHSL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxHSL.Location = new System.Drawing.Point(25, 187);
            this.textBoxHSL.Name = "textBoxHSL";
            this.textBoxHSL.Size = new System.Drawing.Size(108, 20);
            this.textBoxHSL.TabIndex = 4;
            this.textBoxHSL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxHSL_MouseClick);
            this.textBoxHSL.Enter += new System.EventHandler(this.textBoxHSL_Enter);
            // 
            // textBoxRGB
            // 
            this.textBoxRGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxRGB.Location = new System.Drawing.Point(25, 66);
            this.textBoxRGB.Name = "textBoxRGB";
            this.textBoxRGB.Size = new System.Drawing.Size(108, 20);
            this.textBoxRGB.TabIndex = 3;
            this.textBoxRGB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxRGB_MouseClick);
            this.textBoxRGB.TextChanged += new System.EventHandler(this.textBoxRGB_TextChanged);
            this.textBoxRGB.Enter += new System.EventHandler(this.textBoxRGB_Enter);
            // 
            // radioButtonRGB
            // 
            this.radioButtonRGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonRGB.AutoSize = true;
            this.radioButtonRGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.radioButtonRGB.Location = new System.Drawing.Point(6, 69);
            this.radioButtonRGB.Name = "radioButtonRGB";
            this.radioButtonRGB.Size = new System.Drawing.Size(14, 13);
            this.radioButtonRGB.TabIndex = 23;
            this.radioButtonRGB.Tag = "textBoxRGB";
            this.radioButtonRGB.UseVisualStyleBackColor = true;
            this.radioButtonRGB.CheckedChanged += new System.EventHandler(this.radioButtonRGB_CheckedChanged);
            // 
            // radioButtonHSL
            // 
            this.radioButtonHSL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonHSL.AutoSize = true;
            this.radioButtonHSL.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.radioButtonHSL.Location = new System.Drawing.Point(6, 190);
            this.radioButtonHSL.Name = "radioButtonHSL";
            this.radioButtonHSL.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHSL.TabIndex = 24;
            this.radioButtonHSL.Tag = "textBoxHSL";
            this.radioButtonHSL.UseVisualStyleBackColor = true;
            this.radioButtonHSL.CheckedChanged += new System.EventHandler(this.radioButtonHSL_CheckedChanged);
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Checked = true;
            this.radioButtonHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.radioButtonHex.Location = new System.Drawing.Point(6, 31);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHex.TabIndex = 22;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Tag = "textBoxHex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.ContextMenuStrip = this.mainContextMenu;
            this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
            this.mainNotifyIcon.Text = "Desktop Colorpicker";
            this.mainNotifyIcon.Visible = true;
            this.mainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainNotifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(326, 352);
            this.ContextMenuStrip = this.mainContextMenu;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBaseLeft);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 390);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Desktop Colopicker";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainContextMenu.ResumeLayout(false);
            this.panelBaseLeft.ResumeLayout(false);
            this.panelPreviewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomFactor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Unity3.Eyedropper.EyeDropper eyeDropperMain;
        private System.Windows.Forms.Panel panelBaseLeft;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.Panel panelPreviewer;
        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEXwithoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxRGB;
        private System.Windows.Forms.TextBox textBoxHSL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.NumericUpDown numericUpDownZoomFactor;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxHue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSaturation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLuminance;
        private System.Windows.Forms.RadioButton radioButtonHSL;
        private System.Windows.Forms.RadioButton radioButtonRGB;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
    }
}

