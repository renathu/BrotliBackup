using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;
using Brotli;
using System.Threading.Tasks;
using BrotliBackup.Forms;
using System.Windows.Forms;

namespace BrotliBackup
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
