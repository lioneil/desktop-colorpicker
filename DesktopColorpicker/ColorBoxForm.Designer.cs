namespace DesktopColorpicker
{
    partial class ColorBoxForm
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
            ColorPicker.HSL hsl1 = new ColorPicker.HSL();
            ColorPicker.HSL hsl2 = new ColorPicker.HSL();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorBoxForm));
            this.colorBox1 = new ColorPicker.ColorBox();
            this.verticalColorSlider1 = new ColorPicker.VerticalColorSlider();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorBox1
            // 
            hsl1.H = 1D;
            hsl1.L = 1D;
            hsl1.S = 1D;
            this.colorBox1.cbHSL = hsl1;
            this.colorBox1.cbRGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorBox1.DrawStyle = ColorPicker.ColorBox.eDrawStyle.Hue;
            this.colorBox1.Location = new System.Drawing.Point(15, 27);
            this.colorBox1.MarkerColor = System.Drawing.Color.Black;
            this.colorBox1.Name = "colorBox1";
            this.colorBox1.Size = new System.Drawing.Size(260, 263);
            this.colorBox1.TabIndex = 0;
            // 
            // verticalColorSlider1
            // 
            hsl2.H = 1D;
            hsl2.L = 1D;
            hsl2.S = 1D;
            this.verticalColorSlider1.cbHSL = hsl2;
            this.verticalColorSlider1.DrawStyle = ColorPicker.VerticalColorSlider.eDrawStyle.Hue;
            this.verticalColorSlider1.Location = new System.Drawing.Point(280, 27);
            this.verticalColorSlider1.Name = "verticalColorSlider1";
            this.verticalColorSlider1.RGB = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.verticalColorSlider1.Size = new System.Drawing.Size(40, 263);
            this.verticalColorSlider1.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(449, 27);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Select";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Color:";
            // 
            // ColorBoxForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(544, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.verticalColorSlider1);
            this.Controls.Add(this.colorBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Color Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorPicker.ColorBox colorBox1;
        private ColorPicker.VerticalColorSlider verticalColorSlider1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;

    }
}