using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetStudioGUI
{
    static class Program
    {
        //[DllImport( "kernel32.dll" )]
        //static extern bool AttachConsole( int dwProcessId );
        //private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //AttachConsole( ATTACH_PARENT_PROCESS );
            //Console.WriteLine(args.Length);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length >= 2)
            {
                string loadFolder = args[0];
                string saveFolder = args[1];
                var form = new AssetStudioGUIForm(loadFolder, saveFolder);
                Application.Run();
            } else {
                var form = new AssetStudioGUIForm();
                Application.Run(form);
            }
        }
    }
}
