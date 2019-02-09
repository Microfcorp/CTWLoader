using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CTW_loader.Theme;

namespace CTW_loader.SDK.Theme
{
    public partial class ThemeSDK : Form
    {
        public new string Name;
        public Color MainColor;
        public string Animation;

        struct Back
        {
            public Point position;
            public float rang;
            public string path;
        }

        List<Back> Backgrounds = new List<Back>();

        public string Animationpath { get; private set; }

        public ThemeSDK()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Name:");
            Name = result;
            toolStripStatusLabel1.Text = Name;
        }

        private void mainColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                MainColor = colorDialog1.Color;
                label2.Text = "Main Color: " + MainColor.ToArgb() + " ("+MainColor.Name+")";
            }
        }

        private void backgroungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backgrounds.Add(new Back());
            comboBox1.Items.Add(comboBox1.Items.Count + 1);
            comboBox1.SelectedIndex = comboBox1.Items.Count-1;            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog opg = new OpenFileDialog();

            if(opg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = opg.FileName;
                pictureBox1.ImageLocation = textBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            Back tmp = Backgrounds[index];
            tmp.position = new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            tmp.rang = (int)numericUpDown3.Value;
            tmp.path = textBox1.Text;
            Backgrounds[index] = tmp;
            label3.Text = "Background counts: " + Backgrounds.Count.ToString();
        }

        private void animationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opg = new OpenFileDialog();

            if (opg.ShowDialog() == DialogResult.OK)
            {
                label10.Text = "Animation: " + opg.FileName;
                Animation = opg.SafeFileName;
                Animationpath = opg.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            string v = "";
            if (checkBox1.Checked) v += "Elize ";
            if (checkBox2.Checked) v += "StarWars ";
            if (checkBox3.Checked) v += "Mario ";
            label4.Text = String.Format("Musics: {0}: {1}", v.Split(' ').Length-1, v);
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             *  Name=New Year;
                MainColor=-16711681;
                Background=480|250|999|sneg.png,10|20|999|tree.png;
                Anim=salyut.gif;
                Music=JeengleBels:,Thanebaum:
             * */
            string export = "";
            var writer = GameFile.ThemeFiles.Writer.Create(Environment.CurrentDirectory + "\\tmp");

            export += String.Format("Name={0};\n",Name);
            export += String.Format("MainColor={0};\n", MainColor.ToArgb().ToString());
            export += String.Format("Background=");
            foreach (var item in Backgrounds)
            {
                export += String.Format("{0}|{1}|{2}|{3},", item.position.X.ToString(), item.position.Y.ToString(), item.rang.ToString(), item.path.Split('\\')[item.path.Split('\\').Length-1]);
                GameFile.ThemeFiles.Writer.AddFiles(item.path);
            }
            export = export.Substring(0, export.Length - 1);
            export += String.Format(";\n");
            export += String.Format("Anim={0};\n", Animation);
            export += String.Format("Music=");
            if(checkBox1.Checked) export += String.Format("Elize:,");
            if (checkBox2.Checked) export += String.Format("StarWars:,");
            export = export.Substring(0, export.Length - 1);
            export = export.Replace("\r","");

            
            GameFile.ThemeFiles.Writer.AddConfig(export);
            GameFile.ThemeFiles.Writer.AddFiles(Animationpath);

            Console.WriteLine(writer.DoWork(true,true));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            /*
            Back tmp = new Back();
            tmp.position = new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            tmp.rang = (int)numericUpDown3.Value;
            tmp.path = textBox1.Text;
            Backgrounds.Add(tmp);
            label3.Text = "Background counts: " + Backgrounds.Count.ToString();
            */

            var back = Backgrounds[index];
            numericUpDown1.Value = back.position.X;
            numericUpDown2.Value = back.position.Y;
            numericUpDown3.Value = (decimal)back.rang;
            pictureBox1.ImageLocation = back.path;
            textBox1.Text = back.path;
        }
    }
}
