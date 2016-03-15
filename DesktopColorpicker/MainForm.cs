using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Unity3.Eyedropper;
using DesktopColorpicker.Classes;
using System.Runtime.InteropServices;
using System.Threading;
using System.Reflection;
using WindowsInput;

namespace DesktopColorpicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Size = Properties.Settings.Default.MainFormSize;
            this.Location = Properties.Settings.Default.MainFormLocation;

            // Load all known color on textBoxColorName's AutoComplete Collection
            Automaton c = new Automaton();
            this.textBoxColorName.AutoCompleteCustomSource = c.GetAllKnownColors();
        }

        private void eyeDropperMain_ScreenCaptured(Bitmap capturedPixels, Color capturedColor)
        {
            capturedPixels.SetResolution(3000, 3000);
            ExtractTheColors(capturedColor);
        }

        private void CopyToClipboard()
        {
            try
            {
                var checkedButton = groupBoxColors.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                var controlString = checkedButton.Tag.ToString();
                var selectedTextBox = this.Controls.Find(controlString, true);

                // save to Settings the active radio
                Properties.Settings.Default.CopyToClipboardMode = checkedButton.ToString();

                // Automaton.CopyToClipBoard(textBoxHex.Text);
                Automaton.CopyToClipBoard(selectedTextBox[0].Text);
                toolStripStatusLabelMain.Text = "Copied to clipboard: " + selectedTextBox[0].Text;
                statusStripMain.Refresh();
            }
            catch (Exception)
            {
                
                // throw;
            }
            
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void LoadSettingsFromLastSession()
        { 
            // which checkbox to check
            try
            {
                string checkedButton = Properties.Settings.Default.CopyToClipboardMode;
                (this.Controls.Find(checkedButton, true)[0] as RadioButton).Checked = true;

            }
            catch (Exception)
            {
                //throw;
            }

            // Load Zoom Level
            try
            {
                numericUpDownZoomFactor.Value = Properties.Settings.Default.ZoomSize;
            }
            catch (Exception)
            {
                //throw;
            }

            // Top Most
            if (Properties.Settings.Default.IsTopMost == true) 
            {
                checkBoxTopMost.CheckState = CheckState.Checked;
            }
            
            // Is Menu Hidden
            panelMenu.Visible = !Properties.Settings.Default.IsMenuHidden;
            if (Properties.Settings.Default.IsMenuHidden == true)
            {
                hideMenuToolStripMenuItem.CheckState = CheckState.Unchecked;
                this.MinimumSize = new Size(Properties.Settings.Default.MainFormDefaultMinWidth, Properties.Settings.Default.MainFormDefaultMinHeight);
            }

            // Form Size
            this.Size = Properties.Settings.Default.MainFormSize;

            // Load the Last Color
            ExtractTheColors(Properties.Settings.Default.LastColor);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load the previous settings from last session
            LoadSettingsFromLastSession();
            toolStripStatusLabelMain.Text = "Ready";
            statusStripMain.Refresh();
        }

        private void eyeDropperMain_BeginScreenCapture(object sender, EventArgs e)
        {
            // height
            int eH = eyeDropperMain.Height/2;
            int eW = eyeDropperMain.Width/2;
            Point locationOnForm = eyeDropperMain.FindForm().PointToClient(eyeDropperMain.Parent.PointToScreen(eyeDropperMain.Location));
            eyeDropperMain.PixelPreviewZoom = (float)numericUpDownZoomFactor.Value;
            eyeDropperMain.PreviewLocation = new Point(-locationOnForm.X - eW, -locationOnForm.Y - eH);
            eyeDropperMain.PixelPreviewSize = new Size(panelPreviewer.ClientSize.Width, (panelPreviewer.ClientSize.Height / 2));
            toolStripStatusLabelMain.Text = "Capturing colors...";
            statusStripMain.Refresh();
        }

        
        private void MainForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void panelThumb_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
            
        //    switch (keyData)
        //    {
        //        case Keys.Up:
        //            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 1);
        //            break;
        //        case Keys.Right:
        //            Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y);
        //            break;
        //        case Keys.Down:
        //            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
        //            break;
        //        case Keys.Left:
        //            Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y);
        //            break;
        //        default:
        //            break;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            showToolStripMenuItem.PerformClick();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showlabel = showToolStripMenuItem;
            if ("Show" == showlabel.Text)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                mainNotifyIcon.Visible = false;
                showlabel.Text = "Hide";
            }
            else 
            {
                Hide();
                mainNotifyIcon.Visible = true;

                Thread.Sleep(1000);
                mainNotifyIcon.ShowBalloonTip(1000, "Desktop Colorpicker", "Application minimized to the system tray", ToolTipIcon.Info);
            
                showlabel.Text = "Show";
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                showToolStripMenuItem.PerformClick();
            }
        }

        private void mainNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showToolStripMenuItem.PerformClick();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainFormSize = this.Size;
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainFormLocation = this.Location;
        }

        private void textBoxHex_Enter(object sender, EventArgs e)
        {
            Automaton.SelectAll(textBoxHex);
        }

        private void textBoxHex_MouseClick(object sender, MouseEventArgs e)
        {
            Automaton.SelectAll(textBoxHex);
        }

        private void textBoxRGB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxRGB_Enter(object sender, EventArgs e)
        {
            Automaton.SelectAll(textBoxRGB);
        }

        private void textBoxHSL_Enter(object sender, EventArgs e)
        {
            Automaton.SelectAll(textBoxHSL);
        }

        private void textBoxRGB_MouseClick(object sender, MouseEventArgs e)
        {
            Automaton.SelectAll(textBoxRGB);
        }

        private void textBoxHSL_MouseClick(object sender, MouseEventArgs e)
        {
            Automaton.SelectAll(textBoxHSL);
        }

        private void radioButtonRGB_CheckedChanged(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void radioButtonHSL_CheckedChanged(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void numericUpDownZoomFactor_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ZoomSize = numericUpDownZoomFactor.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTopMost.CheckState == CheckState.Checked)
            {
                this.TopMost = true;
                Properties.Settings.Default.IsTopMost = true;
            }
            else
            {
                this.TopMost = false;
                Properties.Settings.Default.IsTopMost = false;
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTipCenter.Show("Always on top", pictureBox3);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTipCenter.Show("Zoom Level (1-20)", pictureBox2);
        }

        private void textBoxColorName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Color colorName = Color.FromName(textBoxColorName.Text);
                if (colorName.IsKnownColor)
                {
                    panelPreviewer.BackColor = colorName;
                    ExtractTheColors(colorName);
                }
            }
            catch (Exception)
            {
                
                // throw;
            }
        }

        void ExtractTheColors(Color colorName)
        {
            try
            {
                // Store color in PictureBox
                panelPreviewer.BackColor = colorName;

                // Store to textboxes
                textBoxRed.Text = colorName.R.ToString();
                textBoxGreen.Text = colorName.G.ToString();
                textBoxBlue.Text = colorName.B.ToString();

                // Convert to HEX
                textBoxHex.Text = ColorValueConverter.RGBToHex(colorName);
                textBoxRGB.Text = ColorValueConverter.toRGBA(colorName);

                // HSL
                textBoxHSL.Text = ColorValueConverter.RGBToHSL(colorName);

                string HSLAsArray = ColorValueConverter.RGBToHSL(colorName, false, true);
                string[] hslarray = HSLAsArray.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                textBoxHue.Text = hslarray[0];
                textBoxSaturation.Text = hslarray[1];
                textBoxLuminance.Text = hslarray[2];

                // KnownColor
                textBoxColorName.Text = ColorValueConverter.ColorToKnownColor(colorName);

                // Save the Color to Settings
                Properties.Settings.Default.LastColor = colorName;

                // Populate Pallette
                panelPalletteLighterColor.BackColor = ControlPaint.Light(colorName, (Single)1.01);//ColorValueConverter.ColorAdjust(colorName, 1.4);
                panelPalletteLightestColor.BackColor = ControlPaint.Light(colorName, (Single)1.05);
                panelPalletteDarkerColor.BackColor = ControlPaint.Dark(colorName, 0.01F);
                panelPalletteDarkestColor.BackColor = ControlPaint.Dark(colorName, 0.05F);
                panelPalletteNormalColor.BackColor = colorName;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Copy to Clipboard
                CopyToClipboard();
                this.Text = Properties.Settings.Default.AppTitle + " - " + ColorValueConverter.RGBToHex(colorName).ToUpper();
            }
        }

        private void textBoxHex_TextChanged(object sender, EventArgs e)
        {
            var colorString = textBoxHex.Text;
            var hexCharCount = 6;
            try
            {
                if (colorString.Length > hexCharCount)
                {
                    var hex = ColorTranslator.FromHtml(colorString);
                    ExtractTheColors(hex);
                }
                
            }
            catch (Exception ex)
            {
                // throw ex;
            }
        }

        private void hideMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hideMenuToolStripMenuItem.Checked)
            {
                // Menu is Hidden
                hideMenuToolStripMenuItem.CheckState = CheckState.Unchecked;
                this.MinimumSize = new Size(Properties.Settings.Default.MainFormDefaultMinWidth, Properties.Settings.Default.MainFormDefaultMinHeight);
                Properties.Settings.Default.IsMenuHidden = true;

                groupBoxColors.Visible = false;
                panelMenu.Height = 40;
                panelMenu.Dock = DockStyle.Top;
            }
            else
            {
                // Menu is Shown
                hideMenuToolStripMenuItem.CheckState = CheckState.Checked;
                panelMenu.Visible = true;
                this.MinimumSize = Properties.Settings.Default.MainFormDefaultSize;
                Properties.Settings.Default.IsMenuHidden = false;

                groupBoxColors.Visible = true;
                panelMenu.Dock = DockStyle.Right;
            }
        }

        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void copyToClipboardToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void hexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hexToolStripMenuItem.Checked)
            {
                hexToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else
            {
                hexToolStripMenuItem.CheckState = CheckState.Checked;
                rGBToolStripMenuItem.CheckState = CheckState.Unchecked;
                hSLToolStripMenuItem.CheckState = CheckState.Unchecked;
                radioButtonHex.Checked = true;
            }
        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rGBToolStripMenuItem.Checked)
            {
                rGBToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else
            {
                rGBToolStripMenuItem.CheckState = CheckState.Checked;
                hexToolStripMenuItem.CheckState = CheckState.Unchecked;
                hSLToolStripMenuItem.CheckState = CheckState.Unchecked;
                radioButtonRGB.Checked = true;
            }
        }

        private void hSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hSLToolStripMenuItem.Checked)
            {
                hSLToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else
            {
                hSLToolStripMenuItem.CheckState = CheckState.Checked;
                hexToolStripMenuItem.CheckState = CheckState.Unchecked;
                rGBToolStripMenuItem.CheckState = CheckState.Unchecked;
                radioButtonHSL.Checked = true;
            }
        }

        private void panelPalletteDarkestColor_MouseHover(object sender, EventArgs e)
        {
            //toolTipCenter.Show("Copy " + GetTheColorViaRadioButton(panelPalletteDarkestColor.BackColor), panelPalletteDarkestColor);
        }

        private void panelPalletteDarkerColor_MouseHover(object sender, EventArgs e)
        {
            toolTipCenter.Show("Copy " + GetTheColorViaRadioButton(panelPalletteDarkerColor.BackColor), panelPalletteDarkerColor);
        }

        private void panelPalletteLighterColor_MouseHover(object sender, EventArgs e)
        {
            toolTipCenter.Show("Copy " + GetTheColorViaRadioButton(panelPalletteLighterColor.BackColor), panelPalletteLighterColor);
        }

        private void panelPalletteLightestColor_MouseHover(object sender, EventArgs e)
        {
            toolTipCenter.Show(ColorValueConverter.RGBToHex(panelPalletteLightestColor.BackColor).ToString(), panelPalletteLightestColor);
        }

        private void panelPalletteDarkestColor_Click(object sender, EventArgs e)
        {
            Color c = panelPalletteDarkestColor.BackColor;
            String s = GetTheColorViaRadioButton(c);
            Automaton.CopyToClipBoard(s);
            toolStripStatusLabelMain.Text = "Copied to clipboard: " + s;
            statusStripMain.Refresh();
        }

        public String GetTheColorViaRadioButton(Color c)
        {
            String color = "";
            var checkedRadioButton = Automaton.GetCheckedRadio(new List<RadioButton>(new RadioButton[] { radioButtonHex, radioButtonRGB, radioButtonHSL }));
            var tag = checkedRadioButton.Tag.ToString();
            switch (tag)
            {
                case "textBoxHex":
                    color = ColorValueConverter.RGBToHex(c);
                    break;
                case "textBoxRGB":
                    color = ColorValueConverter.toRGBA(c);
                    break;
                case "textBoxHSL":
                    color = ColorValueConverter.RGBToHSL(c);
                    break;
            }
            return color;
        }

        private void pictureBoxColorDialogButton_Click(object sender, EventArgs e)
        {
            ColorDialog codia = new ColorDialog();
            if (codia.ShowDialog() != DialogResult.Cancel)
            {
                Color c = codia.Color;
                ExtractTheColors(c);
            }
        }

        private void eyeDropperMain_EndScreenCapture(object sender, EventArgs e)
        {
            toolStripStatusLabelMain.Text = "Ready";
            statusStripMain.Refresh();
        }

        private void panelPalletteDarkerColor_Click(object sender, EventArgs e)
        {
            Color c = panelPalletteDarkerColor.BackColor;
            String s = GetTheColorViaRadioButton(c);
            Automaton.CopyToClipBoard(s);
            toolStripStatusLabelMain.Text = "Copied to clipboard: " + s;
            statusStripMain.Refresh();
        }

        private void panelPalletteLighterColor_Click(object sender, EventArgs e)
        {
            Color c = panelPalletteLighterColor.BackColor;
            String s = GetTheColorViaRadioButton(c);
            Automaton.CopyToClipBoard(s);
            toolStripStatusLabelMain.Text = "Copied to clipboard: " + s;
            statusStripMain.Refresh();
        }

        private void panelPalletteLightestColor_Click(object sender, EventArgs e)
        {
            Color c = panelPalletteLightestColor.BackColor;
            String s = GetTheColorViaRadioButton(c);
            Automaton.CopyToClipBoard(s);
            toolStripStatusLabelMain.Text = "Copied to clipboard: " + s;
            statusStripMain.Refresh();
        }

        private void panelPalletteNormalColor_MouseHover(object sender, EventArgs e)
        {
            toolTipCenter.Show("Copy " + GetTheColorViaRadioButton(panelPalletteNormalColor.BackColor), panelPalletteNormalColor);
        }

        private void panelPalletteNormalColor_Click(object sender, EventArgs e)
        {
            Color c = panelPalletteNormalColor.BackColor;
            String s = GetTheColorViaRadioButton(c);
            Automaton.CopyToClipBoard(s);
            toolStripStatusLabelMain.Text = "Copied to clipboard: " + s;
            statusStripMain.Refresh();
        }

        private void panelPalletteDarkestColor_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void panelPalletteDarkestColor_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void toolTipCenter_Draw(object sender, DrawToolTipEventArgs e)
        {
            
        }    

    }
}
