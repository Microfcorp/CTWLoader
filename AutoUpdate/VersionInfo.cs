using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CTW_loader.AutoUpdate
{
    class VersionInfo
    {
        public string Version
        {
            get;
            private set;
        }
        public int[] Versions
        {
            get
            {
                return new int[]{ int.Parse(Version.Split('.')[0]), int.Parse(Version.Split('.')[1]), int.Parse(Version.Split('.')[2]) };
            }
        }
        public string News
        {
            get;
            private set;
        }
        public DateTime Date
        {
            get;
            private set;
        }
        public string Path
        {
            get;
            private set;
        }
        public Uri URLPath
        {
            get
            {
                return new Uri("https://microfcorp.000webhostapp.com/ctw/" + Path);
            }
        }
        public int SizeFile
        {
            get;
            private set;
        }       
        internal VersionInfo(string Version, string News, string Date, string Path, string sizefile)
        {
            this.Version = Version;
            this.News = News;
            this.Date = DateTime.Parse(Date);
            this.Path = Path;
            this.SizeFile = int.Parse(sizefile);
        }
        internal VersionInfo(string Version, string News, DateTime Date, string Path, string sizefile)
        {
            this.Version = Version;
            this.News = News;
            this.Date = Date;
            this.Path = Path;
            this.SizeFile = int.Parse(sizefile);
        }

        public static VersionInfo Parse(string req)
        {
            SortedList<string, string> SL = new SortedList<string, string>();
            foreach (var item in req.Split(';'))
            {
                SL.Add(item.Split('=')[0], item.Split('=')[1]);
            }
            return new VersionInfo(SL["v"], SL["news"], SL["d"], SL["path"], SL["size"]);
        }
    }
}
