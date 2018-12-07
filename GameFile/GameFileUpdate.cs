using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTW_loader.GameFile
{
    class GameFileUpdate : IDisposable
    {
        public GameFileUpdate(string path, string pathonarchive, string file)
        {
            if (File.Exists(@path) & ZipFile.IsZipFile(@path))
            {
                using (ZipFile zip = new ZipFile(@path))
                {
                    //Console.WriteLine(zip.UpdateFile(@files, text).Info);
                    //Console.WriteLine(zip[@files].Info);                    
                    zip.UpdateFile(file, pathonarchive);
                    zip.Save();
                    //Directory.Delete(Environment.CurrentDirectory + "\\" + files.Split('/')[0].Split('\\')[0], true);
                }
            }
            else
            {
                path = path.Substring(0, path.Length - 8);
                try
                {
                    File.Copy(path + "\\" + pathonarchive, file, true);
                }
                catch
                {
                    File.Copy(path + "\\" + pathonarchive.ToLower(), file, true);
                }
            }
        }

        public void Dispose()
        {

        }
    }
}
