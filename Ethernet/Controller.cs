using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTW_loader.Ethernet
{
    class Controller
    {
        public static string PathToMicrof
        {
            get
            {
                return "https://microfcorp.000webhostapp.com/ctw/";
            }
        }
        public static string PathToMicrofNoHTTPS
        {
            get
            {
                return "http://microfcorp.000webhostapp.com/ctw/";
            }
        }
        public static string ConnectWeb(string url)
        {
            string tmp = "";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        tmp += line;
                    }
                }
            }
            response.Close();
            return tmp;
        }

        public static void Count(object x)
        {
            ProgressBar pb = (x as ProgressBar);
            FileInfo fi = new FileInfo(FileName);
            pb.Invoke(new Action(() =>
            {
                pb.Value = (int)(fi.Length/2);
            }));
            
        }
        private static int MaxSize = 0;
        private static string FileName = "";
        static Thread myThread = new Thread(new ParameterizedThreadStart(Count));
        private static void Close(object sender, FormClosingEventArgs e)
        {
            myThread.Abort();
        }
        public static void DownloadFile(string filename, int maxsize)
        {
            Form frm = new Form();
            frm.Size = new System.Drawing.Size(400,100);
            //frm.BackColor = System.Drawing.Color.Black;
            Label lb = new Label();
            lb.ForeColor = System.Drawing.Color.Black;
            lb.Text = "Идёт загрузка. Пожалуйста подождите и не закрываете данное окно";
            lb.AutoSize = true;
            lb.Location = new System.Drawing.Point(10,10);
            //frm.Controls.Add(lb);
            //frm.FormClosing += Close;

            MaxSize = maxsize/2;
            FileName = filename;
            string remoteUri = PathToMicrof + filename;
            string fileName = filename, myStringWebResource = null;
            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri + fileName;
            //Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the current filesystem folder.
            MessageBox.Show("Загрузка начинается");

            CTW_loader.Theme.MusicsControls ms = new CTW_loader.Theme.MusicsControls();
            ms.SetMusic(new Theme.Musics.Mario());
            ms.Play();

            frm.Show();            
            //myThread.Start(pb); // запускаем поток

            myWebClient.DownloadFile(remoteUri, fileName);
            ms.Stop();
            MessageBox.Show("Загрузка завершена");
            //Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
            //Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Application.StartupPath);
        }
    }
}
