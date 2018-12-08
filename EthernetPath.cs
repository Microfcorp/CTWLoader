using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using MicLocalizationSystem;
using CTW_loader.Perioding;

namespace CTW_loader
{
    public partial class EthernetPath : Form
    {
        LangParam lng = null;
        public EthernetPath(LangParam lng)
        {
            InitializeComponent();
            this.lng = lng;
            #region Код локализации
                label1.Text = lng.GetLangText("DownloadingFileCTW");
                groupBox1.Text = lng.GetLangText("SaveFile");
                groupBox3.Text = lng.GetLangText("UploadFile");
                button2.Text = lng.GetLangText("Upload");
                label5.Text = lng.GetLangText("PathToFile");
                label6.Text = lng.GetLangText("DescreptFile");
                label2.Text = lng.GetLangText("SelectFile");
                button1.Text = lng.GetLangText("Downloading");
                загрузкаФайлаToolStripMenuItem.Text = lng.GetLangText("UploadingFiles");
                скачиваниеФаловToolStripMenuItem.Text = lng.GetLangText("DownloadingFiles");
            #endregion
        }

        private void EthernetPath_Load(object sender, EventArgs e)
        {
            //35082edf2c60f6b428aec7ce61d26486
            GetPaths();
            Change();
        }

        private void Change()
        {
            label7.Text = Period.Value.ToString() + "/10";
            if(Period.Value <= 0)
            {
                button2.Text = "0/10";
                button2.Enabled = false;
            }
            if(DateTime.Now >= Period.Time.AddDays(1))
            {               
                Period.SetValue(10);
                Change();
            }
        }

        private void скачиваниеФаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox3.Visible = false;
            GetPaths();
        }
        private void GetPaths()
        {
            /*WebClient wc = new WebClient();
             *
             *wc.DownloadFile("http://microfcorp.000webhostapp.com/ctw/getpaths.php?secur=35082edf2c60f6b428aec7ce61d26486", save_path + name);
             *
            */
            comboBox1.Items.Clear();
            string[] req = ConnectWeb("http://microfcorp.000webhostapp.com/ctw/getpaths.php?secur=35082edf2c60f6b428aec7ce61d26486").Split(';');
            foreach (var item in req)
            {
                if (item.Split('^')[0] != "")
                    comboBox1.Items.Add(item.Split('^')[0]);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] req = ConnectWeb("http://microfcorp.000webhostapp.com/ctw/getpaths.php?secur=35082edf2c60f6b428aec7ce61d26486").Split(';');
            foreach (var item in req)
            {
                if (item.Split('^')[0] == comboBox1.Text)
                {
                    groupBox2.Text = item.Split('^')[0];
                    label3.Text = item.Split('^')[1];
                    label4.Text = item.Split('^')[2];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            Directory.CreateDirectory(Environment.CurrentDirectory + "\\DownloadingPath");
            wc.DownloadFile(@"http://microfcorp.000webhostapp.com/ctw/getpath.php?path=paths/" + @groupBox2.Text.Replace(" ", "%20"), Environment.CurrentDirectory + "\\DownloadingPath" + "\\" + @groupBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = CTWLoader_Formating.DialogOpenPath();
            if (textBox1.Text.Split('.')[textBox1.Text.Split('.').Length - 1] != "CTWLoader")
            {
                textBox1.Text = "";
                MessageBox.Show(lng.GetLangText("ErrorFile"), lng.GetLangText("Text"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text, desk = textBox2.Text;

            //ConnectWeb(String.Format("http://microfcorp.000webhostapp.com/ctw/newpath.php?name={0}&desk={1}&pat={2}", path.Split('\\')[path.Split('\\').Length - 1], desk, File.ReadAllText(path)));
            Period.SetValue(Period.Value - 1);
            Change();
        }

        private void загрузкаФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
