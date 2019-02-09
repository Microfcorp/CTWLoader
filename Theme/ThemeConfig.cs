using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;

namespace CTW_loader.Theme
{
    class ThemeConfig
    {
        public String Name
        {
            get;
            private set;
        }
        public Color MainColor
        {
            get;
            private set;
        }
        public Background[] Backgrounds
        {
            get;
            private set;
        }
        public Image Anim
        {
            get;
            private set;
        }
        public FileMelody[] Musics
        {
            get;
            private set;
        }

        public Music[] MusicsConvert
        {
            get
            {
                List<Music> tmp = new List<Music>();
                foreach (var item in Musics)
                {
                    tmp.Add(item.music);
                }
                return tmp.ToArray();
            }
        }

        public string Info
        {
            get
            {
                return String.Format("Name: {0} Main Color: {1} Backgrounds counts: {2} Anim: {3} Musics counts {4}", Name, MainColor, Backgrounds.Length.ToString(), (Anim != null) ? "OK" : "Error", Musics.Length.ToString());
            }
        }

        public static ThemeConfig FromText(SortedList<string, string> Config, string path)
        {
            ThemeConfig rmp = new ThemeConfig();
            rmp.Name = Config["Name"];
            rmp.MainColor = Color.FromArgb(Convert.ToInt32(Config["MainColor"]));
            List<Background> tmp = new List<Background>();
            foreach (var item in Config["Background"].Split(','))
            {
                Background bg = new Background();
                bg.Point = new Point(Convert.ToInt32(item.Split('|')[0]), Convert.ToInt32(item.Split('|')[1]));
                bg.Angle = Convert.ToInt32(item.Split('|')[2]);

                using (ZipFile zip = new ZipFile(@path))
                {
                    zip[item.Split('|')[3]].Extract(Environment.CurrentDirectory + "\\", ExtractExistingFileAction.OverwriteSilently);
                    StreamReader atr = new StreamReader(Environment.CurrentDirectory + "\\" + item.Split('|')[3]);
                    bg.Image = (Bitmap)Image.FromStream(atr.BaseStream);
                    atr.Close();                  
                    zip.Save();
                }
                File.Delete(Environment.CurrentDirectory + "\\" + item.Split('|')[3]);
                tmp.Add(bg);
            }
            rmp.Backgrounds = tmp.ToArray();
            using (ZipFile zip = new ZipFile(@path))
            {
                zip[Config["Anim"]].Extract(Environment.CurrentDirectory + "\\Temp\\", ExtractExistingFileAction.OverwriteSilently);
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Temp\\");
                StreamReader atr = new StreamReader(Environment.CurrentDirectory + "\\Temp\\" + Config["Anim"]);            
                rmp.Anim = Image.FromStream(atr.BaseStream);
                //atr.Close();
                zip.Save();     
            }
            //File.Delete(Environment.CurrentDirectory + "\\" + Config["Anim"]);
            List<FileMelody> Musicss = new List<FileMelody>();
            foreach (var item in Config["Music"].Split(','))
            {
                FileMelody fm = new FileMelody();
                fm.SetName(item);
                Musicss.Add(fm);
            }
            rmp.Musics = Musicss.ToArray();
            return rmp;
        }
    }

    class FileMelody
    {
        public Music music
        {
            get;
            private set;
        }
        public void SetName(string name)
        {
            switch (name)
            {
                case "JeengleBels:":
                    music = new Musics.JeengleBels();
                    break;
                case "Elize:":
                    music = new Musics.Elize();
                    break;
                case "StarWars:":
                    music = new Musics.StarWars();
                    break;
                case "Thanebaum:":
                    music = new Musics.Thanebaum();
                    break;
                case "Mario:":
                    music = new Musics.Mario();
                    break;
            }
        }
    }

    class Background
    {
        public Point Point
        {
            get;
            internal set;
        }

        public Bitmap Image
        {
            get;
            internal set;
        }

        private float ang = 0f;

        public float Angle
        {
            set
            {
                if(value == 999f)
                {
                    ang = Modules.RandomAng();
                }
                else
                {
                    ang = value;
                }
            }
            get
            {
                return ang;
            }
        }

    }
}
