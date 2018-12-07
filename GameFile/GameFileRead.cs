using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTW_loader.GameFile
{
    public class GameFileRead : IDisposable
    {
        StreamReader atr;
        string fil = "";
        public GameFileRead(string path, string files)
        {
            if (File.Exists(path) & ZipFile.IsZipFile(path))
            {
                using (ZipFile zip = new ZipFile(@path))
                {
                    //Console.WriteLine(zip[@files].Info);

                    zip[@files].Extract(Environment.CurrentDirectory + "\\", ExtractExistingFileAction.OverwriteSilently);

                    atr = new StreamReader(Environment.CurrentDirectory + "\\" + files);
                    fil = files;
                }
            }
            else
            {
                path = path.Substring(0, path.Length - 8);
                try
                {
                    atr = new StreamReader(path + "\\" + files);
                }
                catch
                {
                    atr = new StreamReader(path + "\\" + files.ToLower());
                }
            }
        }

        public void Dispose()
        {
            ((IDisposable)atr).Dispose();
            //Directory.Delete(Environment.CurrentDirectory + "\\" + fil.Split('/')[0].Split('\\')[0], true);
        }

        public StreamReader Open()
        {
            StreamReader str = (atr);            
            return (str);            
        }
        public StreamReader Open(Encoding enc)
        {
            StreamReader str = new StreamReader((atr.BaseStream), enc);
            return (str);
        }
    }
}
