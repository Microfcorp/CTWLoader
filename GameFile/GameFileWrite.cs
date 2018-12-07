using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTW_loader.GameFile 
{
    class GameFileWrite : IDisposable
    {

        public GameFileWrite(string path, string files, string text)
        {
            if (File.Exists(@path) & ZipFile.IsZipFile(@path))
            {
                using (ZipFile zip = new ZipFile(@path))
                {
                    //Console.WriteLine(zip.UpdateFile(@files, text).Info);
                    //Console.WriteLine(zip[@files].Info);                    
                    File.WriteAllText(Environment.CurrentDirectory + "\\" + files, text);
                    zip.UpdateFile(Environment.CurrentDirectory + "\\" + files, Helpers.GetPathDirectory(files));
                    zip.Save();
                    //Directory.Delete(Environment.CurrentDirectory + "\\" + files.Split('/')[0].Split('\\')[0], true);
                }
            }
            else
            {
                path = path.Substring(0, path.Length - 8);
                try
                {
                    File.WriteAllText(path + "\\" + files, text);
                }
                catch
                {
                    File.WriteAllText(path + "\\" + files.ToLower(), text);
                }
            }
        }

        public void Dispose()
        {
            
        }
    }
}
