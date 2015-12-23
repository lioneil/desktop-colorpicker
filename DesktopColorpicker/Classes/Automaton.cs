using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DesktopColorpicker.Classes
{
    class Automaton
    {
        /// <summary>
        /// Copies the string parameter
        /// to the clipboard.
        /// </summary>
        /// <param name="str"></param>
        public static void CopyToClipBoard(String str)
        {
            Clipboard.SetText(str);
        }

        public static void SelectAll(TextBox tb)
        {
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }

        public static void CloseToTray(Form that, NotifyIcon icon)
        {
            icon.Visible = true;
            that.WindowState = FormWindowState.Minimized;
            that.Hide();
        }
        public static void OpenFromTray(Form that, NotifyIcon icon)
        {
            icon.Visible = false;
            that.WindowState = FormWindowState.Normal;
            that.Show();
        }


        public static void ChangeCheck(Form form, List<RadioButton> list)
        {
            list.ForEach(r => r.CheckedChanged += (o, e) =>
            {
                if (r.Checked) list.ForEach(rb => rb.Checked = rb == r);
            });
            
        }

        public String GetCheckedRadio(List<RadioButton> list)
        {
            string ss = "";
            foreach (RadioButton r in list)
            {
                ss = r.Tag.ToString();
            }
            return ss;
        }
    }
}
