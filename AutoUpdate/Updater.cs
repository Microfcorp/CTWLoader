using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CTW_loader.Ethernet;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace CTW_loader.AutoUpdate
{
    class Updater
    {
        public static VersionInfo GetServerVersion()
        {
            string req = Controller.ConnectWeb(Controller.PathToMicrof + "update.php?type=cheek");
            return VersionInfo.Parse(req);
        }

        public static VersionInfo CurrentVersion
        {
            get
            {
                return new VersionInfo(CTW_loader.AutoUpdate.CurrentVersion.v, CTW_loader.AutoUpdate.CurrentVersion.news, CTW_loader.AutoUpdate.CurrentVersion.Date, "", "0");

            }
        }

        public static bool NeedUpdate(VersionInfo server)
        {
            if(server.Date > CurrentVersion.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine($"Decompressed: {fileToDecompress.Name}");
                    }
                }
            }
        }

        public static void Update(VersionInfo VI)
        {
            //Controller.DownloadFile(VI.Path, VI.SizeFile);
            //Directory.CreateDirectory(Environment.CurrentDirectory + "\\New Version\\");
            //File.Move(VI.Path, Environment.CurrentDirectory + "\\New Version\\CTWLoader.tar.gz");
            Decompress(new FileInfo(Environment.CurrentDirectory + "\\CTWLoader.tar.gz"));
            File.Delete(Environment.CurrentDirectory + "\\CTWLoader.tar.gz");
            MessageBox.Show("Распакуйте файл CTWLoader.tar куда вам угодно и запускайте новую версию");
        }

        public static bool Cheek()
        {
            VersionInfo VI = Updater.GetServerVersion();

            if (Updater.NeedUpdate(VI))
            {
                if(MessageBox.Show("Доступна новая версия("+CurrentVersion.Version+")! Обновить?", "CTWLoader", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) == DialogResult.Yes)
                {
                    Update(VI);                   
                }
                return true;
            }
            return false;
        }

    }
}
