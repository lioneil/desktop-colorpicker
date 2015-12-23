using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Unity3.EyeDropper
{
    public class CursorHandler
    {
        [DllImport("user32.dll")] 
        private static extern IntPtr LoadCursorFromFile(string fileName );


        public static Cursor LoadCursor(string resourcePath)
        {
            Cursor c = new Cursor(getCursorHandle(resourcePath));
            return c;
        }


        private static IntPtr getCursorHandle(string resourcePath)
        {
            //Load cursor from Manifest Resource to Stream 
            Stream streamFrom =
            Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
            Stream streamTo =
            File.Create(Environment.GetEnvironmentVariable("TEMP") + @"\~cur.tmp");
            BinaryReader br = new BinaryReader(streamFrom);
            BinaryWriter bw = new BinaryWriter(streamTo);
            //Write cursor to temporary file 
            bw.Write(br.ReadBytes((int)streamFrom.Length));
            bw.Flush();
            bw.Close();
            br.Close();
            bw = null;
            br = null;
            streamFrom.Close();
            streamTo.Close();
            streamFrom = null;
            streamTo = null;
            //Load handle of temporary cursor file 
            IntPtr hwdCursor = LoadCursorFromFile(
            Environment.GetEnvironmentVariable("TEMP") + @"\~cur.tmp");
            //Delete temporary cursor file 
            File.Delete(Environment.GetEnvironmentVariable("TEMP") + @"\~cur.tmp");
            return hwdCursor;
        }
    }
}
