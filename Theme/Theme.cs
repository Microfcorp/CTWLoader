using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTW_loader.Theme
{
    public class Theme
    {
        private Theme(Color c, string N)
        {
            MainColor = c;
            Name = N;
            Controls = new List<Control>();
        }

        private Color MainColor = Color.Transparent;
        private string Name = "";
        List<Control> Controls = new List<Control>();

        public Color GetMainColor
        {
            get { return MainColor; }
        }
        public string GetName
        {
            get { return Name; }
        }

        public List<Control> AddToControl(Control cn)
        {
            Controls.Add(cn);
            return Controls;
        }
        public List<Control> AddToControl(Control[] cn)
        {
            Controls.AddRange(cn);
            return Controls;
        }

        public static ThemeConfig LoadFile(string path)
        {
            ThemeConfig tm = new ThemeConfig();
            Directory.CreateDirectory(Environment.CurrentDirectory + "\\Temp\\");
            if (File.Exists(path) & ZipFile.IsZipFile(path))
            {
                using (ZipFile zip = new ZipFile(@path))
                {
                    zip["config.cfg"].Extract(Environment.CurrentDirectory + "\\Temp\\", ExtractExistingFileAction.OverwriteSilently);

                    StreamReader atr = new StreamReader(Environment.CurrentDirectory + "\\Temp\\" + "config.cfg");
                    string config = File.ReadAllText(Environment.CurrentDirectory + "\\Temp\\" + "config.cfg").Replace("\n","");
                    config = (config.EndsWith(";")) ? config.Substring(0, config.Length - 1) : config;
                    SortedList<string, string> Config = new SortedList<string, string>();
                    foreach (var item in config.Split(';'))
                    {
                        Config.Add(item.Split('=')[0], item.Split('=')[1]);
                    }
                    atr.Close();
                    tm = ThemeConfig.FromText(Config, path);
                    zip.Save();
                }
                File.Delete(Environment.CurrentDirectory + "\\Temp\\" + "config.cfg");
            }
            //Console.WriteLine(tm.Info);
            return tm;
        }
    }
}
