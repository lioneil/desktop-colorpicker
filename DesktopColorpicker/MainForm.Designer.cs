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
            this.hideMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.eyeDropperMain = new Unity3.Eyedropper.EyeDropper();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxColorDialogButton = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericUpDownZoomFactor = new System.Windows.Forms.NumericUpDown();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxColorName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTipCenter = new System.Windows.Forms.ToolTip(this.components);
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelPreviewer = new System.Windows.Forms.Panel();
            this.panelPalletteContainer = new System.Windows.Forms.Panel();
            this.panelPalletteNormalColor = new System.Windows.Forms.Panel();
            this.panelPalletteLightestColor = new System.Windows.Forms.Panel();
            this.panelPalletteLighterColor = new System.Windows.Forms.Panel();
            this.panelPalletteDarkerColor = new System.Windows.Forms.Panel();
            this.panelPalletteDarkestColor = new System.Windows.Forms.Panel();
            this.panelBaseLeft = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBoxPalletteContainer = new System.Windows.Forms.PictureBox();
            this.mainContextMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorDialogButton)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomFactor)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.panelPreviewer.SuspendLayout();
            this.panelPalletteContainer.SuspendLayout();
            this.panelBaseLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalletteContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideMenuToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.mainContextMenu.Name = "contextMenuStrip1";
            this.mainContextMenu.Size = new System.Drawing.Size(146, 98);
            // 
            // hideMenuToolStripMenuItem
            // 
            this.hideMenuToolStripMenuItem.Checked = true;
            this.hideMenuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideMenuToolStripMenuItem.Name = "hideMenuToolStripMenuItem";
            this.hideMenuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.hideMenuToolStripMenuItem.Text = "Menu";
            this.hideMenuToolStripMenuItem.Click += new System.EventHandler(this.hideMenuToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexToolStripMenuItem,
            this.rGBToolStripMenuItem,
            this.hSLToolStripMenuItem});
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.copyToClipboardToolStripMenuItem.Text = "&Copy";
            // 
            // hexToolStripMenuItem
            // 
            this.hexToolStripMenuItem.Checked = true;
            this.hexToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hexToolStripMenuItem.Name = "hexToolStripMenuItem";
            this.hexToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.hexToolStripMenuItem.Text = "Hex";
            this.hexToolStripMenuItem.Click += new System.EventHandler(this.hexToolStripMenuItem_Click);
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.rGBToolStripMenuItem.Text = "RGB";
            this.rGBToolStripMenuItem.Click += new System.EventHandler(this.rGBToolStripMenuItem_Click);
            // 
            // hSLToolStripMenuItem
            // 
            this.hSLToolStripMenuItem.Name = "hSLToolStripMenuItem";
            this.hSLToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.hSLToolStripMenuItem.Text = "HSL";
            this.hSLToolStripMenuItem.Click += new System.EventHandler(this.hSLToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.showToolStripMenuItem.Text = "Hide";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.ToolTipText = "Close the Application";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // textBoxHex
            // 
            this.textBoxHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxHex.Location = new System.Drawing.Point(23, 34);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(150, 20);
            this.textBoxHex.TabIndex = 4;
            this.textBoxHex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxHex_MouseClick);
            this.textBoxHex.TextChanged += new System.EventHandler(this.textBoxHex_TextChanged);
            this.textBoxHex.Enter += new System.EventHandler(this.textBoxHex_Enter);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMenu.Controls.Add(this.groupBox6);
            this.panelMenu.Controls.Add(this.groupBox5);
            this.panelMenu.Controls.Add(this.groupBox4);
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.groupBoxColors);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(186, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(120, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(190, 420);
            this.panelMenu.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.eyeDropperMain);
            this.groupBox6.Location = new System.Drawing.Point(6, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(27, 33);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            // 
            // eyeDropperMain
            // 
            this.eyeDropperMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eyeDropperMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeDropperMain.Location = new System.Drawing.Point(2, 8);
            this.eyeDropperMain.MaximumSize = new System.Drawing.Size(22, 22);
            this.eyeDropperMain.MinimumSize = new System.Drawing.Size(22, 22);
            this.eyeDropperMain.Name = "eyeDropperMain";
            this.eyeDropperMain.PixelPreviewSize = new System.Drawing.Size(250, 250);
            this.eyeDropperMain.PreviewLocation = new System.Drawing.Point(0, 0);
            this.eyeDropperMain.PreviewPositionStyle = Unity3.Eyedropper.EyeDropper.ePreviewPositionStyle.Manual;
            this.eyeDropperMain.SelectedColor = System.Drawing.Color.Empty;
            this.eyeDropperMain.ShowColorPreview = false;
            this.eyeDropperMain.Size = new System.Drawing.Size(22, 22);
            this.eyeDropperMain.TabIndex = 0;
            this.eyeDropperMain.Text = "Eyedropper";
            this.toolTipCenter.SetToolTip(this.eyeDropperMain, "Drag to pick colors");
            this.eyeDropperMain.BeginScreenCapture += new System.EventHandler(this.eyeDropperMain_BeginScreenCapture);
            this.eyeDropperMain.ScreenCaptured += new Unity3.Eyedropper.EyeDropper.ScreenCapturedArgs(this.eyeDropperMain_ScreenCaptured);
            this.eyeDropperMain.EndScreenCapture += new System.EventHandler(this.eyeDropperMain_EndScreenCapture);
            this.eyeDropperMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.eyeDropperMain_MouseMove);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxColorDialogButton);
            this.groupBox5.Location = new System.Drawing.Point(36, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(30, 33);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // pictureBoxColorDialogButton
            // 
            this.pictureBoxColorDialogButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.pictureBoxColorDialogButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxColorDialogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxColorDialogButton.Image = global::DesktopColorpicker.Properties.Resources._1458023981_Color_palette;
            this.pictureBoxColorDialogButton.Location = new System.Drawing.Point(4, 8);
            this.pictureBoxColorDialogButton.Name = "pictureBoxColorDialogButton";
            this.pictureBoxColorDialogButton.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxColorDialogButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxColorDialogButton.TabIndex = 29;
            this.pictureBoxColorDialogButton.TabStop = false;
            this.toolTipCenter.SetToolTip(this.pictureBoxColorDialogButton, "Click to show Color Dialog Box");
            this.pictureBoxColorDialogButton.Click += new System.EventHandler(this.pictureBoxColorDialogButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox3);
            this.groupBox4.Controls.Add(this.checkBoxTopMost);
            this.groupBox4.Location = new System.Drawing.Point(69, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(47, 33);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DesktopColorpicker.Properties.Resources._1458027624_Pin;
            this.pictureBox3.Location = new System.Drawing.Point(19, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTopMost.Location = new System.Drawing.Point(5, 12);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTopMost.TabIndex = 1;
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.numericUpDownZoomFactor);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(119, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(64, 33);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DesktopColorpicker.Properties.Resources._1458027644_Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(2, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // numericUpDownZoomFactor
            // 
            this.numericUpDownZoomFactor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownZoomFactor.Location = new System.Drawing.Point(27, 9);
            this.numericUpDownZoomFactor.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownZoomFactor.Name = "numericUpDownZoomFactor";
            this.numericUpDownZoomFactor.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownZoomFactor.TabIndex = 2;
            this.numericUpDownZoomFactor.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownZoomFactor.ValueChanged += new System.EventHandler(this.numericUpDownZoomFactor_ValueChanged);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColors.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxColors.Controls.Add(this.label1);
            this.groupBoxColors.Controls.Add(this.textBoxColorName);
            this.groupBoxColors.Controls.Add(this.pictureBox1);
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
            this.groupBoxColors.Location = new System.Drawing.Point(6, 32);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(177, 381);
            this.groupBoxColors.TabIndex = 25;
            this.groupBoxColors.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Color Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxColorName
            // 
            this.textBoxColorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColorName.AutoCompleteCustomSource.AddRange(new string[] {
            "red",
            "blue",
            "yellow"});
            this.textBoxColorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxColorName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxColorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxColorName.Location = new System.Drawing.Point(26, 332);
            this.textBoxColorName.Name = "textBoxColorName";
            this.textBoxColorName.Size = new System.Drawing.Size(145, 20);
            this.textBoxColorName.TabIndex = 7;
            this.textBoxColorName.TextChanged += new System.EventHandler(this.textBoxColorName_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DesktopColorpicker.Properties.Resources._1458029640_Copy;
            this.pictureBox1.Location = new System.Drawing.Point(153, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTipCenter.SetToolTip(this.pictureBox1, "Copy current selected color");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.groupBox3.Location = new System.Drawing.Point(26, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 100);
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
            this.textBoxHue.Size = new System.Drawing.Size(68, 20);
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
            this.textBoxSaturation.Size = new System.Drawing.Size(68, 20);
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
            this.textBoxLuminance.Size = new System.Drawing.Size(68, 20);
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
            this.label10.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 178);
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
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "RGBA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 18);
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
            this.groupBox2.Location = new System.Drawing.Point(26, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 82);
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
            this.textBoxBlue.Size = new System.Drawing.Size(68, 20);
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
            this.textBoxGreen.Size = new System.Drawing.Size(68, 20);
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
            this.textBoxRed.Size = new System.Drawing.Size(68, 20);
            this.textBoxRed.TabIndex = 11;
            // 
            // textBoxHSL
            // 
            this.textBoxHSL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxHSL.Location = new System.Drawing.Point(25, 193);
            this.textBoxHSL.Name = "textBoxHSL";
            this.textBoxHSL.Size = new System.Drawing.Size(146, 20);
            this.textBoxHSL.TabIndex = 6;
            this.textBoxHSL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxHSL_MouseClick);
            this.textBoxHSL.Enter += new System.EventHandler(this.textBoxHSL_Enter);
            // 
            // textBoxRGB
            // 
            this.textBoxRGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.textBoxRGB.Location = new System.Drawing.Point(25, 72);
            this.textBoxRGB.Name = "textBoxRGB";
            this.textBoxRGB.Size = new System.Drawing.Size(146, 20);
            this.textBoxRGB.TabIndex = 5;
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
            this.radioButtonRGB.Location = new System.Drawing.Point(6, 75);
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
            this.radioButtonHSL.Location = new System.Drawing.Point(6, 196);
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
            this.radioButtonHex.Location = new System.Drawing.Point(6, 37);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHex.TabIndex = 22;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Tag = "textBoxHex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            this.radioButtonHex.CheckedChanged += new System.EventHandler(this.radioButtonHex_CheckedChanged);
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.ContextMenuStrip = this.mainContextMenu;
            this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
            this.mainNotifyIcon.Text = "Desktop Colorpicker";
            this.mainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainNotifyIcon_MouseDoubleClick);
            // 
            // toolTipCenter
            // 
            this.toolTipCenter.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTipCenter_Draw);
            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 420);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStripMain.Size = new System.Drawing.Size(376, 22);
            this.statusStripMain.TabIndex = 4;
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelMain.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabelMain.Text = "Initializing...";
            // 
            // panelPreviewer
            // 
            this.panelPreviewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelPreviewer.Controls.Add(this.pictureBoxPalletteContainer);
            this.panelPreviewer.Controls.Add(this.panelPalletteContainer);
            this.panelPreviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPreviewer.Location = new System.Drawing.Point(0, 0);
            this.panelPreviewer.Name = "panelPreviewer";
            this.panelPreviewer.Size = new System.Drawing.Size(186, 420);
            this.panelPreviewer.TabIndex = 0;
            this.panelPreviewer.TabStop = true;
            // 
            // panelPalletteContainer
            // 
            this.panelPalletteContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelPalletteContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelPalletteContainer.Controls.Add(this.panelPalletteNormalColor);
            this.panelPalletteContainer.Controls.Add(this.panelPalletteLightestColor);
            this.panelPalletteContainer.Controls.Add(this.panelPalletteLighterColor);
            this.panelPalletteContainer.Controls.Add(this.panelPalletteDarkerColor);
            this.panelPalletteContainer.Controls.Add(this.panelPalletteDarkestColor);
            this.panelPalletteContainer.Location = new System.Drawing.Point(3, 306);
            this.panelPalletteContainer.Name = "panelPalletteContainer";
            this.panelPalletteContainer.Size = new System.Drawing.Size(106, 111);
            this.panelPalletteContainer.TabIndex = 3;
            // 
            // panelPalletteNormalColor
            // 
            this.panelPalletteNormalColor.BackColor = System.Drawing.Color.White;
            this.panelPalletteNormalColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPalletteNormalColor.Location = new System.Drawing.Point(3, 76);
            this.panelPalletteNormalColor.Name = "panelPalletteNormalColor";
            this.panelPalletteNormalColor.Size = new System.Drawing.Size(30, 30);
            this.panelPalletteNormalColor.TabIndex = 3;
            this.panelPalletteNormalColor.Click += new System.EventHandler(this.panelPalletteNormalColor_Click);
            this.panelPalletteNormalColor.MouseHover += new System.EventHandler(this.panelPalletteNormalColor_MouseHover);
            // 
            // panelPalletteLightestColor
            // 
            this.panelPalletteLightestColor.BackColor = System.Drawing.Color.White;
            this.panelPalletteLightestColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPalletteLightestColor.Location = new System.Drawing.Point(3, 18);
            this.panelPalletteLightestColor.Name = "panelPalletteLightestColor";
            this.panelPalletteLightestColor.Size = new System.Drawing.Size(30, 30);
            this.panelPalletteLightestColor.TabIndex = 2;
            this.panelPalletteLightestColor.Click += new System.EventHandler(this.panelPalletteLightestColor_Click);
            this.panelPalletteLightestColor.MouseHover += new System.EventHandler(this.panelPalletteLightestColor_MouseHover);
            // 
            // panelPalletteLighterColor
            // 
            this.panelPalletteLighterColor.BackColor = System.Drawing.Color.White;
            this.panelPalletteLighterColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPalletteLighterColor.Location = new System.Drawing.Point(3, 47);
            this.panelPalletteLighterColor.Name = "panelPalletteLighterColor";
            this.panelPalletteLighterColor.Size = new System.Drawing.Size(30, 30);
            this.panelPalletteLighterColor.TabIndex = 2;
            this.panelPalletteLighterColor.Click += new System.EventHandler(this.panelPalletteLighterColor_Click);
            this.panelPalletteLighterColor.MouseHover += new System.EventHandler(this.panelPalletteLighterColor_MouseHover);
            // 
            // panelPalletteDarkerColor
            // 
            this.panelPalletteDarkerColor.BackColor = System.Drawing.Color.White;
            this.panelPalletteDarkerColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPalletteDarkerColor.Location = new System.Drawing.Point(32, 76);
            this.panelPalletteDarkerColor.Name = "panelPalletteDarkerColor";
            this.panelPalletteDarkerColor.Size = new System.Drawing.Size(30, 30);
            this.panelPalletteDarkerColor.TabIndex = 2;
            this.panelPalletteDarkerColor.Click += new System.EventHandler(this.panelPalletteDarkerColor_Click);
            this.panelPalletteDarkerColor.MouseHover += new System.EventHandler(this.panelPalletteDarkerColor_MouseHover);
            // 
            // panelPalletteDarkestColor
            // 
            this.panelPalletteDarkestColor.BackColor = System.Drawing.Color.White;
            this.panelPalletteDarkestColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPalletteDarkestColor.Location = new System.Drawing.Point(61, 76);
            this.panelPalletteDarkestColor.Name = "panelPalletteDarkestColor";
            this.panelPalletteDarkestColor.Size = new System.Drawing.Size(30, 30);
            this.panelPalletteDarkestColor.TabIndex = 2;
            this.panelPalletteDarkestColor.Click += new System.EventHandler(this.panelPalletteDarkestColor_Click);
            this.panelPalletteDarkestColor.MouseHover += new System.EventHandler(this.panelPalletteDarkestColor_MouseHover);
            // 
            // panelBaseLeft
            // 
            this.panelBaseLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelBaseLeft.Controls.Add(this.panelPreviewer);
            this.panelBaseLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaseLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBaseLeft.Name = "panelBaseLeft";
            this.panelBaseLeft.Size = new System.Drawing.Size(186, 420);
            this.panelBaseLeft.TabIndex = 2;
            // 
            // pictureBoxPalletteContainer
            // 
            this.pictureBoxPalletteContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPalletteContainer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPalletteContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPalletteContainer.Location = new System.Drawing.Point(173, 0);
            this.pictureBoxPalletteContainer.Name = "pictureBoxPalletteContainer";
            this.pictureBoxPalletteContainer.Size = new System.Drawing.Size(14, 64);
            this.pictureBoxPalletteContainer.TabIndex = 4;
            this.pictureBoxPalletteContainer.TabStop = false;
            this.pictureBoxPalletteContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPalletteContainer_Paint);
            this.pictureBoxPalletteContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPalletteContainer_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(376, 442);
            this.ContextMenuStrip = this.mainContextMenu;
            this.Controls.Add(this.panelBaseLeft);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Desktop Colorpicker";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainContextMenu.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorDialogButton)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoomFactor)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.panelPreviewer.ResumeLayout(false);
            this.panelPalletteContainer.ResumeLayout(false);
            this.panelBaseLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPalletteContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.Panel panelMenu;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTipCenter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxColorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem hideMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSLToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.Panel panelPreviewer;
        private System.Windows.Forms.PictureBox pictureBoxColorDialogButton;
        private Unity3.Eyedropper.EyeDropper eyeDropperMain;
        private System.Windows.Forms.Panel panelPalletteContainer;
        private System.Windows.Forms.Panel panelPalletteLightestColor;
        private System.Windows.Forms.Panel panelPalletteLighterColor;
        private System.Windows.Forms.Panel panelPalletteDarkerColor;
        private System.Windows.Forms.Panel panelPalletteDarkestColor;
        private System.Windows.Forms.Panel panelBaseLeft;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Panel panelPalletteNormalColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBoxPalletteContainer;
    }
}

