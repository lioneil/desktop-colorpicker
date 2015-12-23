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

namespace DesktopColorpicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Size = Properties.Settings.Default.MainFormSize;
            this.Location = Properties.Settings.Default.MainFormLocation;
        }

        //private bool allowVisible = false;
        //protected override void SetVisibleCore(bool value)
        //{
         //   if (!allowVisible)
          //  {
           //     value = false;
            //    if (!this.IsHandleCreated) CreateHandle();
            //}
        //}

        private void eyeDropperMain_ScreenCaptured(Bitmap capturedPixels, Color capturedColor)
        {
            capturedPixels.SetResolution(3000, 3000);
            try
            {
                // Store color in PictureBox
                panelPreviewer.BackColor = capturedColor;

                // Store to textboxes
                textBoxRed.Text = capturedColor.R.ToString();
                textBoxGreen.Text = capturedColor.G.ToString();
                textBoxBlue.Text = capturedColor.B.ToString();

                // Convert to HEX
                textBoxHex.Text = ColorValueConverter.RGBToHex(capturedColor);
                textBoxRGB.Text = ColorValueConverter.toRGB(capturedColor);

                // HSL
                textBoxHSL.Text = ColorValueConverter.RGBToHSL(capturedColor);

                string HSLAsArray = ColorValueConverter.RGBToHSL(capturedColor, false, true);
                string[] hslarray = HSLAsArray.Split(new[]{'|'}, StringSplitOptions.RemoveEmptyEntries);
                textBoxHue.Text = hslarray[0];
                textBoxSaturation.Text = hslarray[1];
                textBoxLuminance.Text = hslarray[2];


            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Copy to Clipboard
                CopyToClipboard();
            }
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
            //try
            //{
                if(Properties.Settings.Default.IsTopMost == true) {
                    checkBoxTopMost.CheckState = CheckState.Checked;
                }
            //}
            //catch (Exception)
            //{
                //throw;
            //}
            

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load the previous settings from last session
            LoadSettingsFromLastSession();
            numericUpDownZoomFactor.Value = Properties.Settings.Default.ZoomSize;
        }

        private void eyeDropperMain_BeginScreenCapture(object sender, EventArgs e)
        {
            eyeDropperMain.PixelPreviewZoom = (float)numericUpDownZoomFactor.Value;
            eyeDropperMain.PreviewLocation = new Point(-14,-14);
            eyeDropperMain.PixelPreviewSize = new Size(this.ClientSize.Width, (this.ClientSize.Height / 2)-2);
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            switch (keyData)
            {
                case Keys.Up:
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 1);
                    break;
                case Keys.Right:
                    Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y);
                    break;
                case Keys.Down:
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    break;
                case Keys.Left:
                    Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y);
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

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

    }
}
