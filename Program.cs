using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTW_loader.ComandArgs;
using CTW_loader.AutoUpdate;

namespace CTW_loader
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Updater.Cheek();

            var parser = new Parser(args);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(parser.FindParams("-themesdk")) Application.Run(new SDK.Theme.ThemeSDK());
            else if (parser.FindParams("-aboutbox")) Application.Run(new AboutBox1());
            else if (parser.FindParams("-main")) Application.Run(new Form1());
            else Application.Run(new Form1());
        }
    }
}
