using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.IO.Compression;
using Ionic.Zip;
using Microsoft.Win32;
using System.Diagnostics;
using MicLocalizationSystem;

namespace CTW_loader
{
    public partial class Form1 : Form
    {

        //string puttogame = "C://main.pak";
        string puttogame = "";
        Panel[] pn = null;

        LangParam lng = LocalizationSettings.LoadLangParamFromFile(LocalizationSettings.GetLangSystem(), Environment.CurrentDirectory + "\\Language\\");


        public Form1()
        {
            InitializeComponent();
            pn = new Panel[] { panel1, panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12, panel15, panel16, panel17 };           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            closopen(false, pn, panel1);
            open();
            

            #region Код Локализации
            this.Name = lng.GetLangText("FormName");

            this.label2.Text = lng.GetLangText("SoftLogo");

            this.label88.Text = lng.GetLangText("label88");
            this.label87.Text = lng.GetLangText("label87");
            this.label86.Text = lng.GetLangText("label86");
            this.label85.Text = lng.GetLangText("label85");
            this.label84.Text = lng.GetLangText("label84");
            this.label83.Text = lng.GetLangText("label83");
            this.label82.Text = lng.GetLangText("label82");
            this.label81.Text = lng.GetLangText("label81");
            this.label80.Text = lng.GetLangText("label80");
            this.label79.Text = lng.GetLangText("label79");
            this.label78.Text = lng.GetLangText("label78");
            this.label77.Text = lng.GetLangText("label77");
            this.label76.Text = lng.GetLangText("label76");
            this.label62.Text = lng.GetLangText("label62");
            this.label61.Text = lng.GetLangText("label61");
            this.label60.Text = lng.GetLangText("label60");
            this.label59.Text = lng.GetLangText("label59");
            this.label73.Text = lng.GetLangText("label73");
            this.label72.Text = lng.GetLangText("label72");
            this.label71.Text = lng.GetLangText("label71");
            this.label70.Text = lng.GetLangText("label70");
            this.label69.Text = lng.GetLangText("label69");
            this.label68.Text = lng.GetLangText("label68");
            this.label67.Text = lng.GetLangText("label67");
            this.label66.Text = lng.GetLangText("label66");
            this.label65.Text = lng.GetLangText("label65");
            this.label64.Text = lng.GetLangText("label64");
            this.label63.Text = lng.GetLangText("label63");
            this.label28.Text = lng.GetLangText("label28");
            this.label27.Text = lng.GetLangText("label27");
            this.label26.Text = lng.GetLangText("label26");
            this.label25.Text = lng.GetLangText("label25");
            this.label24.Text = lng.GetLangText("label24");
            this.label23.Text = lng.GetLangText("label23");
            this.label22.Text = lng.GetLangText("label22");
            this.label21.Text = lng.GetLangText("label21");
            this.label20.Text = lng.GetLangText("label20");
            this.label19.Text = lng.GetLangText("label19");
            this.label18.Text = lng.GetLangText("label18");
            this.label17.Text = lng.GetLangText("label17");
            this.label1.Text = lng.GetLangText("label1");
            this.label16.Text = lng.GetLangText("label16");
            this.label3.Text = lng.GetLangText("label3");
            this.label15.Text = lng.GetLangText("label15");
            this.label4.Text = lng.GetLangText("label4");
            this.label14.Text = lng.GetLangText("label14");
            this.label5.Text = lng.GetLangText("label5");
            this.label13.Text = lng.GetLangText("label13");
            this.label6.Text = lng.GetLangText("label6");
            this.label12.Text = lng.GetLangText("label12");
            this.label7.Text = lng.GetLangText("label7");
            this.label11.Text = lng.GetLangText("label11");
            this.label8.Text = lng.GetLangText("label8");
            this.label10.Text = lng.GetLangText("label10");
            this.label9.Text = lng.GetLangText("label9");
            this.label39.Text = lng.GetLangText("label39");
            this.label38.Text = lng.GetLangText("label38");
            this.label37.Text = lng.GetLangText("label37");
            this.label36.Text = lng.GetLangText("label36");
            this.label35.Text = lng.GetLangText("label35");
            this.label34.Text = lng.GetLangText("label34");
            this.label33.Text = lng.GetLangText("label33");
            this.label32.Text = lng.GetLangText("label32");
            this.label31.Text = lng.GetLangText("label31");
            this.label30.Text = lng.GetLangText("label30");
            this.label29.Text = lng.GetLangText("label29");
            this.label56.Text = lng.GetLangText("label56");
            this.label57.Text = lng.GetLangText("label57");
            this.label58.Text = lng.GetLangText("label58");
            this.label55.Text = lng.GetLangText("label55");
            this.label54.Text = lng.GetLangText("label54");
            this.label53.Text = lng.GetLangText("label53");
            this.label42.Text = lng.GetLangText("label42");
            this.label41.Text = lng.GetLangText("label41");
            this.label52.Text = lng.GetLangText("label52");
            this.label51.Text = lng.GetLangText("label51");
            this.label50.Text = lng.GetLangText("label50");
            this.label49.Text = lng.GetLangText("label49");
            this.label48.Text = lng.GetLangText("label48");
            this.label47.Text = lng.GetLangText("label47");
            this.label46.Text = lng.GetLangText("label46");
            this.label45.Text = lng.GetLangText("label45");
            this.label44.Text = lng.GetLangText("label44");
            this.label43.Text = lng.GetLangText("label43");

            this.button14.Text = lng.GetLangText("button14");
            this.button5.Text = lng.GetLangText("button5");
            this.button4.Text = lng.GetLangText("button4");
            this.button10.Text = lng.GetLangText("button10");
            this.button8.Text = lng.GetLangText("button8");
            this.button7.Text = lng.GetLangText("button7");
            this.button9.Text = lng.GetLangText("button9");
            this.button21.Text = lng.GetLangText("button21");
            this.Bestyary.Text = lng.GetLangText("Bestyary");
            this.button20.Text = lng.GetLangText("button20");
            this.button19.Text = lng.GetLangText("button19");
            this.button18.Text = lng.GetLangText("button18");
            this.button17.Text = lng.GetLangText("button17");
            this.button11.Text = lng.GetLangText("button11");
            this.button3.Text = lng.GetLangText("button3");
            this.button2.Text = lng.GetLangText("button2");
            this.button6.Text = lng.GetLangText("button6");

            this.checkBox5.Text = lng.GetLangText("checkBox5");
            this.checkBox4.Text = lng.GetLangText("checkBox4");
            this.checkBox3.Text = lng.GetLangText("checkBox3");
            this.checkBox2.Text = lng.GetLangText("checkBox2");
            this.checkBox6.Text = lng.GetLangText("checkBox6");
            this.checkBox7.Text = lng.GetLangText("checkBox7");
            this.checkBox1.Text = lng.GetLangText("checkBox1");

            this.мираToolStripMenuItem.Text = lng.GetLangText("worldToolStripMenuItem");
            this.гномовToolStripMenuItem.Text = lng.GetLangText("gnomsToolStripMenuItem");
            this.созданиеКрафтаToolStripMenuItem.Text = lng.GetLangText("createcraftsToolStripMenuItem");
            this.уровниГномовToolStripMenuItem.Text = lng.GetLangText("levelgnomToolStripMenuItem");
            this.музыкиToolStripMenuItem.Text = lng.GetLangText("musicToolStripMenuItem");
            this.быстрыеДействияToolStripMenuItem.Text = lng.GetLangText("smartToolStripMenuItem");
            this.монологаШаманаГоблиновToolStripMenuItem.Text = lng.GetLangText("monologToolStripMenuItem");
            this.имёнГномовToolStripMenuItem.Text = lng.GetLangText("namegnomToolStripMenuItem");
            this.логотипаЗагрузкиToolStripMenuItem.Text = lng.GetLangText("logoToolStripMenuItem");
            this.предметовToolStripMenuItem.Text = lng.GetLangText("itemToolStripMenuItem");
            this.дераваТехнологийToolStripMenuItem.Text = lng.GetLangText("technoToolStripMenuItem");
            this.уровнейToolStripMenuItem.Text = lng.GetLangText("levelToolStripMenuItem");
            this.сохраненийToolStripMenuItem.Text = lng.GetLangText("saveToolStripMenuItem");
            this.скиловToolStripMenuItem.Text = lng.GetLangText("skilToolStripMenuItem");
            this.названияСуществToolStripMenuItem.Text = lng.GetLangText("nameenemToolStripMenuItem");

            this.редактированиеToolStripMenuItem.Text = lng.GetLangText("EditParam");
            this.настройкиToolStripMenuItem.Text = lng.GetLangText("Sett");
            this.путьКИгреToolStripMenuItem.Text = lng.GetLangText("PutToGame");
            this.выходToolStripMenuItem.Text = lng.GetLangText("Exit");
            this.запуститьИгруToolStripMenuItem.Text = lng.GetLangText("LoadGame");
            this.оПрограммеToolStripMenuItem.Text = lng.GetLangText("About");
            this.языкПрограммыToolStripMenuItem.Text = lng.GetLangText("Lang");
            #endregion

            Language[] lngs = LocalizationSettings.GetFromFolder(Environment.CurrentDirectory + "\\Language\\");//Get an array of all localization files
            foreach (var item in lngs)
            {
                ToolStripMenuItem tmp = new ToolStripMenuItem();
                tmp.Text = item.GetName();
                tmp.Click += SmenaLang;
                языкПрограммыToolStripMenuItem.DropDownItems.Add(tmp);
            }
        }

        public void SmenaLang(object sender, EventArgs e)
        {
            string lang = ((ToolStripMenuItem)sender).Text;
            Language lg = LocalizationSettings.GetLangName(lang, Environment.CurrentDirectory + "\\Language\\");//Get a localized file name
            LangParam lng = LocalizationSettings.LoadLangParamFromFile(lg, Environment.CurrentDirectory + "\\Language\\");
            #region Код Локализации
            this.Name = lng.GetLangText("FormName");

            this.label2.Text = lng.GetLangText("SoftLogo");

            this.label88.Text = lng.GetLangText("label88");
            this.label87.Text = lng.GetLangText("label87");
            this.label86.Text = lng.GetLangText("label86");
            this.label85.Text = lng.GetLangText("label85");
            this.label84.Text = lng.GetLangText("label84");
            this.label83.Text = lng.GetLangText("label83");
            this.label82.Text = lng.GetLangText("label82");
            this.label81.Text = lng.GetLangText("label81");
            this.label80.Text = lng.GetLangText("label80");
            this.label79.Text = lng.GetLangText("label79");
            this.label78.Text = lng.GetLangText("label78");
            this.label77.Text = lng.GetLangText("label77");
            this.label76.Text = lng.GetLangText("label76");
            this.label62.Text = lng.GetLangText("label62");
            this.label61.Text = lng.GetLangText("label61");
            this.label60.Text = lng.GetLangText("label60");
            this.label59.Text = lng.GetLangText("label59");
            this.label73.Text = lng.GetLangText("label73");
            this.label72.Text = lng.GetLangText("label72");
            this.label71.Text = lng.GetLangText("label71");
            this.label70.Text = lng.GetLangText("label70");
            this.label69.Text = lng.GetLangText("label69");
            this.label68.Text = lng.GetLangText("label68");
            this.label67.Text = lng.GetLangText("label67");
            this.label66.Text = lng.GetLangText("label66");
            this.label65.Text = lng.GetLangText("label65");
            this.label64.Text = lng.GetLangText("label64");
            this.label63.Text = lng.GetLangText("label63");
            this.label28.Text = lng.GetLangText("label28");
            this.label27.Text = lng.GetLangText("label27");
            this.label26.Text = lng.GetLangText("label26");
            this.label25.Text = lng.GetLangText("label25");
            this.label24.Text = lng.GetLangText("label24");
            this.label23.Text = lng.GetLangText("label23");
            this.label22.Text = lng.GetLangText("label22");
            this.label21.Text = lng.GetLangText("label21");
            this.label20.Text = lng.GetLangText("label20");
            this.label19.Text = lng.GetLangText("label19");
            this.label18.Text = lng.GetLangText("label18");
            this.label17.Text = lng.GetLangText("label17");
            this.label1.Text = lng.GetLangText("label1");
            this.label16.Text = lng.GetLangText("label16");
            this.label3.Text = lng.GetLangText("label3");
            this.label15.Text = lng.GetLangText("label15");
            this.label4.Text = lng.GetLangText("label4");
            this.label14.Text = lng.GetLangText("label14");
            this.label5.Text = lng.GetLangText("label5");
            this.label13.Text = lng.GetLangText("label13");
            this.label6.Text = lng.GetLangText("label6");
            this.label12.Text = lng.GetLangText("label12");
            this.label7.Text = lng.GetLangText("label7");
            this.label11.Text = lng.GetLangText("label11");
            this.label8.Text = lng.GetLangText("label8");
            this.label10.Text = lng.GetLangText("label10");
            this.label9.Text = lng.GetLangText("label9");
            this.label39.Text = lng.GetLangText("label39");
            this.label38.Text = lng.GetLangText("label38");
            this.label37.Text = lng.GetLangText("label37");
            this.label36.Text = lng.GetLangText("label36");
            this.label35.Text = lng.GetLangText("label35");
            this.label34.Text = lng.GetLangText("label34");
            this.label33.Text = lng.GetLangText("label33");
            this.label32.Text = lng.GetLangText("label32");
            this.label31.Text = lng.GetLangText("label31");
            this.label30.Text = lng.GetLangText("label30");
            this.label29.Text = lng.GetLangText("label29");
            this.label56.Text = lng.GetLangText("label56");
            this.label57.Text = lng.GetLangText("label57");
            this.label58.Text = lng.GetLangText("label58");
            this.label55.Text = lng.GetLangText("label55");
            this.label54.Text = lng.GetLangText("label54");
            this.label53.Text = lng.GetLangText("label53");
            this.label42.Text = lng.GetLangText("label42");
            this.label41.Text = lng.GetLangText("label41");
            this.label52.Text = lng.GetLangText("label52");
            this.label51.Text = lng.GetLangText("label51");
            this.label50.Text = lng.GetLangText("label50");
            this.label49.Text = lng.GetLangText("label49");
            this.label48.Text = lng.GetLangText("label48");
            this.label47.Text = lng.GetLangText("label47");
            this.label46.Text = lng.GetLangText("label46");
            this.label45.Text = lng.GetLangText("label45");
            this.label44.Text = lng.GetLangText("label44");
            this.label43.Text = lng.GetLangText("label43");

            this.button14.Text = lng.GetLangText("button14");
            this.button5.Text = lng.GetLangText("button5");
            this.button4.Text = lng.GetLangText("button4");
            this.button10.Text = lng.GetLangText("button10");
            this.button8.Text = lng.GetLangText("button8");
            this.button7.Text = lng.GetLangText("button7");
            this.button9.Text = lng.GetLangText("button9");
            this.button21.Text = lng.GetLangText("button21");
            this.Bestyary.Text = lng.GetLangText("Bestyary");
            this.button20.Text = lng.GetLangText("button20");
            this.button19.Text = lng.GetLangText("button19");
            this.button18.Text = lng.GetLangText("button18");
            this.button17.Text = lng.GetLangText("button17");
            this.button11.Text = lng.GetLangText("button11");
            this.button3.Text = lng.GetLangText("button3");
            this.button2.Text = lng.GetLangText("button2");
            this.button6.Text = lng.GetLangText("button6");

            this.checkBox5.Text = lng.GetLangText("checkBox5");
            this.checkBox4.Text = lng.GetLangText("checkBox4");
            this.checkBox3.Text = lng.GetLangText("checkBox3");
            this.checkBox2.Text = lng.GetLangText("checkBox2");
            this.checkBox6.Text = lng.GetLangText("checkBox6");
            this.checkBox7.Text = lng.GetLangText("checkBox7");
            this.checkBox1.Text = lng.GetLangText("checkBox1");

            this.мираToolStripMenuItem.Text = lng.GetLangText("worldToolStripMenuItem");
            this.гномовToolStripMenuItem.Text = lng.GetLangText("gnomsToolStripMenuItem");
            this.созданиеКрафтаToolStripMenuItem.Text = lng.GetLangText("createcraftsToolStripMenuItem");
            this.уровниГномовToolStripMenuItem.Text = lng.GetLangText("levelgnomToolStripMenuItem");
            this.музыкиToolStripMenuItem.Text = lng.GetLangText("musicToolStripMenuItem");
            this.быстрыеДействияToolStripMenuItem.Text = lng.GetLangText("smartToolStripMenuItem");
            this.монологаШаманаГоблиновToolStripMenuItem.Text = lng.GetLangText("monologToolStripMenuItem");
            this.имёнГномовToolStripMenuItem.Text = lng.GetLangText("namegnomToolStripMenuItem");
            this.логотипаЗагрузкиToolStripMenuItem.Text = lng.GetLangText("logoToolStripMenuItem");
            this.предметовToolStripMenuItem.Text = lng.GetLangText("itemToolStripMenuItem");
            this.дераваТехнологийToolStripMenuItem.Text = lng.GetLangText("technoToolStripMenuItem");
            this.уровнейToolStripMenuItem.Text = lng.GetLangText("levelToolStripMenuItem");
            this.сохраненийToolStripMenuItem.Text = lng.GetLangText("saveToolStripMenuItem");
            this.скиловToolStripMenuItem.Text = lng.GetLangText("skilToolStripMenuItem");
            this.названияСуществToolStripMenuItem.Text = lng.GetLangText("nameenemToolStripMenuItem");

            this.редактированиеToolStripMenuItem.Text = lng.GetLangText("EditParam");
            this.настройкиToolStripMenuItem.Text = lng.GetLangText("Sett");
            this.путьКИгреToolStripMenuItem.Text = lng.GetLangText("PutToGame");
            this.выходToolStripMenuItem.Text = lng.GetLangText("Exit");
            this.запуститьИгруToolStripMenuItem.Text = lng.GetLangText("LoadGame");
            this.оПрограммеToolStripMenuItem.Text = lng.GetLangText("About");
            this.языкПрограммыToolStripMenuItem.Text = lng.GetLangText("Lang");
            #endregion
        }

        private void open()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.OpenSubKey("CTWLoader");
            if (helloKey != null)
            {
                string login = helloKey.GetValue("Game").ToString();
                helloKey.Close();

                puttogame = login;
            }
            if (File.Exists(puttogame))
            {

                XmlDocument xml556 = new XmlDocument();
                xml556.PreserveWhitespace = true;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/beastiary.xml");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                        {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);
                            
                            xml556.LoadXml(read1.ReadToEnd().ToString());

                            var nade1 = xml556.SelectSingleNode("/root");

                            //MessageBox.Show(nade1.ChildNodes.Count.ToString());
                            for (int i = 0; i < nade1.ChildNodes.Count; i++)
                            {
                                //MessageBox.Show(nade1.ChildNodes.Item(i).Name);
                                if (nade1.ChildNodes.Item(i).Name == "beast")
                                {
                                comboBox24.Items.Add(nade1.ChildNodes.Item(i).Attributes["creature"].Value);
                                }
                            }
                            // xml.Load(@"C:\world.xml");
                        }
                    }
                    zipToOpen1.Close();
                }
                /////////////////////////////////////////////////////////////////////////
                XmlDocument xml55 = new XmlDocument();
                xml55.PreserveWhitespace = true;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("Lang/Russian/data/skills.xml");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                        {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);

                            xml55.LoadXml(read1.ReadToEnd().ToString());

                            var nade1 = xml55.SelectSingleNode("/root/skills");
                            for (int i = 0; i < nade1.ChildNodes.Count; i++)
                            {
                                if (nade1.ChildNodes.Item(i).Name == "skill")
                                {
                                    comboBox23.Items.Add(nade1.ChildNodes.Item(i).Attributes["name"].Value);
                                }
                            }
                            // xml.Load(@"C:\world.xml");
                        }
                    }
                    zipToOpen1.Close();
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\
                string[] path = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dekovir\\crafttheworld\\saves\\");
                foreach (var item in path)
                {
                   comboBox21.Items.Add(item.Split('\\')[item.Split('\\').Length - 1]);
                }
                
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\
                string line = "";
                string line1 = "";
                string rrra = "";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////\\
                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("Lang/Russian/data/tech_locale.csv");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open(), Encoding.UTF8))
                        {
                            foreach (var item in read1.ReadToEnd().Split('\n'))
                            {
                                rrra += item.Split(';')[0] + ";";
                                comboBox8.Items.Add(item.Split(';')[item.Split(';').Length - 1]);
                                comboBox7.Items.Add(item.Split(';')[0]);
                            }
                        }
                    }
                    zipToOpen1.Close();
                }

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////\\
                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/default_techtree.csv");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open(), Encoding.UTF8))
                        {
                            string rrr = read1.ReadToEnd().Replace("<", "");
                            numericUpDown1.Maximum = Convert.ToDecimal(rrr.Split(';').Length - 2);
                            for (int i = 0; i < rrr.Split(';').Length; i++)
                            {
                                for (int ia = 0; ia < rrr.Split(';')[i].Split(',').Length; ia++)
                                {
                                    
                                    ////
                                    foreach (var item in rrra.Split(';'))
                                    {
                                       if(rrr.Split(';')[i].Split(',')[ia] == item)
                                        {
                                           // MessageBox.Show(rrr.Split(';')[i].Split(',')[ia]);
                                            //comboBox7.Items.Add(rrr.Split(';')[i].Split(',')[ia]);
                                        }
                                        else
                                        {                                           
                                            //;
                                        }
                                    }
                                    if (!rrra.Contains(rrr.Split(';')[i].Split(',')[ia]))
                                    {
                                        comboBox6.Items.Add(rrr.Split(';')[i].Split(',')[ia]);
                                    }
                                    ////
                                    //comboBox6.Items.Add(rrr.Split(';')[i].Split(',')[ia]);
                                }
                            }
                            
                        }
                    }
                    zipToOpen1.Close();
                }

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////\\
                XmlDocument xml4 = new XmlDocument();
                xml4.PreserveWhitespace = true;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("Lang/Russian/data/local/craft_resources.xml");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                        {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);

                            xml4.LoadXml(read1.ReadToEnd().ToString());
                            // xml.Load(@"C:\world.xml");
                        }
                    }
                    zipToOpen1.Close();
                }
                XmlDocument xml6 = new XmlDocument();
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/craft_resources.xml");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                        {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);

                            xml6.LoadXml(read1.ReadToEnd().ToString());
                            // xml.Load(@"C:\world.xml");
                        }
                    }
                    zipToOpen1.Close();
                }

                XmlDocument xml61 = new XmlDocument();
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/craft_resources.xml");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                        {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);

                            xml61.LoadXml(read1.ReadToEnd().ToString());
                            // xml.Load(@"C:\world.xml");
                        }
                    }
                    zipToOpen1.Close();
                }

                var node15 = xml4.SelectSingleNode("/locals");

                for (int i = 1; i < node15.ChildNodes.Count; i++)
                {
                    //MessageBox.Show(node1.ChildNodes.Item(i).FirstChild.Value.ToString());
                    if (node15.ChildNodes.Item(i).Name.ToString().Substring(node15.ChildNodes.Item(i).Name.Length - 1) == "T")
                    {
                        var node2 = xml6.SelectSingleNode("/root/resource[@title='" + "%" + ((node15.ChildNodes.Item(i).Name.ToString())) + "']");
                        if (node2 != null)
                        {
                            comboBox2.Items.Add(node15.ChildNodes.Item(i).Name.ToString().Substring(0, node15.ChildNodes.Item(i).Name.Length - 1));
                            /////////////////\\\\\\\\\\\\\\\\                           
                            comboBox1.Items.Add(xml61.SelectSingleNode("/root/resource[@title='" + "%" + ((node15.ChildNodes.Item(i).Name.ToString())) + "']").Attributes["name"].Value);
                            comboBox5.Items.Add(xml61.SelectSingleNode("/root/resource[@title='" + "%" + ((node15.ChildNodes.Item(i).Name.ToString())) + "']").Attributes["name"].Value);
                        }
                    }
                    //MessageBox.Show(node1.ChildNodes.Item(i).Name.ToString().Substring(node1.ChildNodes.Item(i).Name.Length - 1));
                    i++;
                }                

                using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry = archive.GetEntry("Lang/Russian/data/shaman_dialogs.txt");

                        using (StreamReader read = new StreamReader(readmeEntry.Open(), Encoding.UTF8))
                        {
                            line = read.ReadLine();

                            //Continue to read until you reach end of file
                            while (line != null)
                            {
                                //write the lie to console window
                                //Console.WriteLine(line);
                                richTextBox1.Text += line + Environment.NewLine;
                                //Read the next line
                                line = read.ReadLine();
                            }

                            read.Close();
                        }
                    }
                    zipToOpen.Close();
                }

                string tmp = "";
                using (FileStream zipToOpen3 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive3 = new ZipArchive(zipToOpen3, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry3 = archive3.GetEntry("data/char_levels.txt");

                        using (StreamReader read3 = new StreamReader(readmeEntry3.Open()))
                        {
                            //charlvl = read3.ReadToEnd();
                            while (!read3.EndOfStream)
                            {
                                tmp = read3.ReadLine();
                                //charlvl += tmp + "\n";
                            }
                            //Console.Write(tmp);

                            /*tmp = tmp.Substring(0, tmp.Length - 2);
                            string[] words = tmp.Split(new char[] { ' ' });
                            bool tm = false;
                            string opit = "";
                            foreach (string s in words)
                            {
                                if (!tm)
                                {                                   
                                    lvl = Convert.ToInt32(s);
                                    tm = true;
                                }
                                else if (tm)
                                {
                                    opit = s;
                                    tm = false;
                                }
                                
                                label35.Text = lvl.ToString();
                                label36.Text = opit;
                            }*/
                            //MessageBox.Show(charlvl);
                        }

                        using (StreamReader read4 = new StreamReader(readmeEntry3.Open()))
                        {
                            comboBox20.Items.Clear();

                            string temp = read4.ReadToEnd();

                            charlvl = temp + Environment.NewLine;

                            string[] temp1 = temp.Split('\n');
                            foreach (var item in temp1)
                            {
                                //MessageBox.Show(item);
                                comboBox20.Items.Add(item.Split(' ')[0]);
                                label35.Text = item.Split(' ')[0];
                                label36.Text = item.Split(' ')[1];
                            }

                            //MessageBox.Show(charlvl);
                        }

                    }
                    zipToOpen3.Close();
                }
                XmlDocument xml1 = new XmlDocument();
            //xml.PreserveWhitespace = false;
            
                using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry = archive.GetEntry("data/world.xml");

                        using (StreamReader read = new StreamReader(readmeEntry.Open()))
                        {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);
                            xml1.LoadXml(read.ReadToEnd().ToString());
                            // xml.Load(@"C:\world.xml");
                            read.Close();
                        }                                             
                    }
                    zipToOpen.Close();
                }
                

                var node = xml1.SelectSingleNode("/root/param[@name='ChanceOfBreak']");
                maskedTextBox1.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='RiseFallTime']");
                maskedTextBox2.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='HouseTotemRadius']");
                maskedTextBox3.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='DirectControlSpeedRatio']");
                textBox8.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='HealtRestoreTime']");
                maskedTextBox5.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='InvalidTaskLifeTime']");
                maskedTextBox6.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='DiaryMaxViewQuests']");
                maskedTextBox7.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='DayTime']");
                maskedTextBox8.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='NightTime']");
                maskedTextBox9.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='RespawnWorkerTimeFreq']");
                maskedTextBox10.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='HouseMinArea']");
                maskedTextBox11.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='ManaRestoreTime']");
                maskedTextBox12.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='ChanceNearTreeProcent']");
                maskedTextBox13.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='AutoSaveTime']");
                maskedTextBox14.Text = node.Attributes["value"].Value;
                node = xml1.SelectSingleNode("/root/param[@name='MaxMonoResEat']");
                maskedTextBox15.Text = node.Attributes["value"].Value;

                //Console.WriteLine("Текущее значение ChanceOfBreak: {0}", node.Attributes["value"].Value);
                //Console.Write("Введите новое значение: ");


                xml1 = null;
                //System.Threading.Thread.Sleep(5000);
                XmlDocument xml = new XmlDocument();
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/creatures.xml");

                    using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                    {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);
                            
                        xml.LoadXml(read1.ReadToEnd().ToString());
                        // xml.Load(@"C:\world.xml");
                    }
                }
                    zipToOpen1.Close();
                }

            var node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/healt");
            maskedTextBox16.Text = node1.Attributes["value"].Value;
            node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/satiety");
            maskedTextBox17.Text = node1.Attributes["value"].Value;
            node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/walk_speed");
            maskedTextBox18.Text = node1.Attributes["value"].Value;
            node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/fall_height");
            maskedTextBox19.Text = node1.Attributes["value"].Value;
            node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/capacity");
            maskedTextBox20.Text = node1.Attributes["value"].Value;
            node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/attack");
            textBox7.Text = node1.Attributes["value"].Value;
            node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/water_die_time");
            maskedTextBox22.Text = node1.Attributes["value"].Value;
            node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/climbs_speed");
            maskedTextBox23.Text = node1.Attributes["value"].Value;

                //Console.WriteLine("Текущее значение ChanceOfBreak: {0}", node.Attributes["value"].Value);
                //Console.Write("Введите новое значение: ");

                try
                {
                    using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                        {
                            ZipArchiveEntry readmeEntry1 = archive1.GetEntry("Lang/Russian/data/names_female.txt");

                            using (StreamReader read2 = new StreamReader(readmeEntry1.Open(), Encoding.UTF8))
                            {
                                //string dat = read.ReadToEnd().ToString();                      
                                //Console.Write(dat);
                                //System.Threading.Thread.Sleep(5000);
                                line = read2.ReadLine();
                                //Continue to read until you reach end of file
                                while (line != null)
                                {
                                    //Read the next line
                                    
                                    comboBox4.Items.Add(line);
line = read2.ReadLine();
                                }

                                // xml.Load(@"C:\world.xml");
                            }
                        }
                        zipToOpen1.Close();
                    }
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////\\
                }
                finally
                {
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\
                    using (FileStream zipToOpen11 = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive11 = new ZipArchive(zipToOpen11, ZipArchiveMode.Read))
                        {
                            ZipArchiveEntry readmeEntry11 = archive11.GetEntry("Lang/Russian/data/names.txt");

                            using (StreamReader read1 = new StreamReader(readmeEntry11.Open(), Encoding.UTF8))
                            {
                                //string dat = read.ReadToEnd().ToString();                      
                                //Console.Write(dat);
                                //System.Threading.Thread.Sleep(5000);

                                line1 = read1.ReadLine();

                                //Continue to read until you reach end of file
                                while (line1 != null)
                                {
                                    //Read the next line
                                    
                                    comboBox3.Items.Add(line1);
line1 = read1.ReadLine();
                                }
                                // xml.Load(@"C:\world.xml");
                            }
                        }
                        zipToOpen11.Close();
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(puttogame))
            {
                XmlDocument xml = new XmlDocument();
                xml.PreserveWhitespace = true;
                using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry = archive.GetEntry("data/world.xml");

                        using (StreamReader read = new StreamReader(readmeEntry.Open()))
                        {
                            xml.LoadXml(read.ReadToEnd().ToString());
                            //Console.Write(read.ReadToEnd().ToString());
                        }
                    }
                    zipToOpen.Close();
                }
                var node = xml.SelectSingleNode("/root/param[@name='ChanceOfBreak']");
                node.Attributes["value"].Value = maskedTextBox1.Text;
                node = xml.SelectSingleNode("/root/param[@name='RiseFallTime']");
                node.Attributes["value"].Value = maskedTextBox2.Text;
                node = xml.SelectSingleNode("/root/param[@name='HouseTotemRadius']");
                node.Attributes["value"].Value = maskedTextBox3.Text;
                node = xml.SelectSingleNode("/root/param[@name='DirectControlSpeedRatio']");
                node.Attributes["value"].Value = textBox8.Text;
                node = xml.SelectSingleNode("/root/param[@name='HealtRestoreTime']");
                node.Attributes["value"].Value = maskedTextBox5.Text;
                node = xml.SelectSingleNode("/root/param[@name='InvalidTaskLifeTime']");
                node.Attributes["value"].Value = maskedTextBox6.Text;
                node = xml.SelectSingleNode("/root/param[@name='DiaryMaxViewQuests']");
                node.Attributes["value"].Value = maskedTextBox7.Text;
                node = xml.SelectSingleNode("/root/param[@name='DayTime']");
                node.Attributes["value"].Value = maskedTextBox8.Text;
                node = xml.SelectSingleNode("/root/param[@name='NightTime']");
                node.Attributes["value"].Value = maskedTextBox9.Text;
                node = xml.SelectSingleNode("/root/param[@name='RespawnWorkerTimeFreq']");
                node.Attributes["value"].Value = maskedTextBox10.Text;
                node = xml.SelectSingleNode("/root/param[@name='HouseMinArea']");
                node.Attributes["value"].Value = maskedTextBox11.Text;
                node = xml.SelectSingleNode("/root/param[@name='ManaRestoreTime']");
                node.Attributes["value"].Value = maskedTextBox12.Text;
                node = xml.SelectSingleNode("/root/param[@name='ChanceNearTreeProcent']");
                node.Attributes["value"].Value = maskedTextBox13.Text;
                node = xml.SelectSingleNode("/root/param[@name='AutoSaveTime']");
                node.Attributes["value"].Value = maskedTextBox14.Text;
                node = xml.SelectSingleNode("/root/param[@name='MaxMonoResEat']");
                node.Attributes["value"].Value = maskedTextBox15.Text;
                //xml.Save(@"C:\world.xml");
                using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        ZipArchiveEntry readmeEntry = archive.GetEntry("data/world.xml");
                        using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                        {
                            writer.WriteLine(xml.OuterXml);

                        }
                    }
                }
            }
        }
        private void путьКИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frb = new FolderBrowserDialog();
            if (frb.ShowDialog() == DialogResult.OK)
            {
                puttogame = frb.SelectedPath + "\\main.pak";
                if (File.Exists(puttogame))
                {
                    RegistryKey currentUserKey = Registry.CurrentUser;
                    RegistryKey helloKey = currentUserKey.CreateSubKey("CTWLoader");
                    helloKey.SetValue("Game", puttogame);
                    helloKey.Close();

                    open();
                }
                else
                {
                    MessageBox.Show(lng.GetLangText("GameNotFoundDesc"), lng.GetLangText("GameNotFound"));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(puttogame))
            {
                XmlDocument xml = new XmlDocument();
                xml.PreserveWhitespace = true;
                using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry = archive.GetEntry("data/creatures.xml");

                        using (StreamReader read = new StreamReader(readmeEntry.Open()))
                        {
                            xml.LoadXml(read.ReadToEnd().ToString());
                            //Console.Write(read.ReadToEnd().ToString());
                        }
                    }
                    zipToOpen.Close();
                }
                var node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/healt");
                node1.Attributes["value"].Value = maskedTextBox16.Text;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/satiety");
                node1.Attributes["value"].Value = maskedTextBox17.Text;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/walk_speed");
                node1.Attributes["value"].Value = maskedTextBox18.Text;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/fall_height");
                node1.Attributes["value"].Value = maskedTextBox19.Text;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/capacity");
                node1.Attributes["value"].Value = maskedTextBox20.Text;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/attack");
                node1.Attributes["value"].Value = textBox7.Text;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/water_die_time");
                node1.Attributes["value"].Value = maskedTextBox22.Text;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/climbs_speed");
                node1.Attributes["value"].Value = maskedTextBox23.Text;
                //xml.Save(@"C:\world.xml");
                using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        ZipArchiveEntry readmeEntry = archive.GetEntry("data/creatures.xml");
                        using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                        {
                            writer.WriteLine(xml.OuterXml);

                        }
                    }
                    zipToOpen.Close();
                }
            }
        }

        private void гномовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel2);
        }

        private void мираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox5.Text != "" & comboBox1.Text != "")
            {
                string namerec = comboBox5.Text;
                string[] pola = { maskedTextBox24.Text, maskedTextBox25.Text, maskedTextBox26.Text, maskedTextBox27.Text, maskedTextBox28.Text, maskedTextBox29.Text, maskedTextBox30.Text, maskedTextBox31.Text, maskedTextBox32.Text };
                string rasprec = "";
                string namepol = comboBox1.Text;
                int coliz = 0;


                XmlDocument xml6 = new XmlDocument();
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/recipes.xml");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                        {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);

                            xml6.LoadXml(read1.ReadToEnd().ToString());
                            // xml.Load(@"C:\world.xml");
                        }
                    }
                    zipToOpen1.Close();
                }

                var node12 = xml6.SelectSingleNode("root");

                for (int i = 0; i < node12.ChildNodes.Count; i++)
                {
                    if (node12.ChildNodes.Item(i).Name == "recipe")
                    {
                        if (node12.ChildNodes.Item(i).Attributes["name"].Value == namerec)
                        {
                            MessageBox.Show(lng.GetLangText("FormName"), lng.GetLangText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto got;
                        }
                    }
                }

                if (maskedTextBox33.Text != "")
                {
                    coliz = Convert.ToInt32(maskedTextBox33.Text);
                }

                foreach(string tmp in pola)
                {
                    if (tmp != "")
                    {
                        rasprec += tmp/* + ","*/;
                    }
                }

                if(coliz != 0)
                {
                    namepol += "=" + coliz;
                }
                //MessageBox.Show(recipec);

                /////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////////
                //7
                
                if (File.Exists(puttogame))
                {

                    XmlDocument xml = new XmlDocument();
                    xml.PreserveWhitespace = true;
                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/recipes.xml");

                            using (StreamReader read = new StreamReader(readmeEntry.Open()))
                            {
                                xml.LoadXml(read.ReadToEnd().ToString());
                                //Console.Write(read.ReadToEnd().ToString());
                            }
                        }
                        zipToOpen.Close();
                    }

                    
                    var node2 = xml.CreateElement("recipe");
                    node2.Attributes.Append(xml.CreateAttribute("name")).Value = namerec;
                    node2.Attributes.Append(xml.CreateAttribute("ingredients")).Value = rasprec;
                    node2.Attributes.Append(xml.CreateAttribute("produce")).Value = namepol;
                    node2.Attributes.Append(xml.CreateAttribute("group")).Value = "1";
                    node2.Attributes.Append(xml.CreateAttribute("save")).Value = "true";
                    node2.Attributes.Append(xml.CreateAttribute("craft_need")).Value = "";
                    xml.SelectSingleNode("root").AppendChild(node2);
                    xml.SelectSingleNode("root").AppendChild(xml.CreateWhitespace(Environment.NewLine));

                    /*recipec = "<recipe name=\"" + namerec + "\" ingredients=\"" + rasprec + "\" produce=\"" + namepol + "\" group=\"1\" save=\"true\" craft_need=\"\" />";

                    temp = temp.Substring(0, temp.Length - 8);
                    temp += recipec;
                    temp += @"</root>";*/
                    //Console.Write(temp);

                    //xml.Save(@"C:\world.xml");
                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/recipes.xml");
                            using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                            {
                                //throw new Exception("AAAA");
                                writer.WriteLine(xml.OuterXml);
                            }
                        }
                        zipToOpen.Close();
                    }

                    string temper = "";

                    if (checkBox7.Checked)
                    {
                        if (File.Exists(puttogame))
                        {

                            XmlDocument xml1 = new XmlDocument();
                            xml1.PreserveWhitespace = true;
                            using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                            {
                                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                                {
                                    ZipArchiveEntry readmeEntry = archive.GetEntry("data/blocks.xml");

                                    using (StreamReader read = new StreamReader(readmeEntry.Open()))
                                    {
                                        xml1.LoadXml(read.ReadToEnd().ToString());
                                        //Console.Write(read.ReadToEnd().ToString());
                                    }
                                }
                                zipToOpen.Close();
                            }

                            var node1 = xml1.SelectSingleNode("root/block[@name='" + namepol.Split('=')[0] + "']");
                            //MessageBox.Show(namepol.Split('=')[0]);
                            if (node1 != null) {
                                node1.Attributes["backcraft"].Value = "true";
                            }

                        }
                    }

                    if (checkBox1.Checked)
                    {
                        using (FileStream zipToOpen2 = new FileStream(@puttogame, FileMode.Open))
                        {
                            using (ZipArchive archive2 = new ZipArchive(zipToOpen2, ZipArchiveMode.Read))
                            {
                                ZipArchiveEntry readmeEntry2 = archive2.GetEntry("data/default_techtree.csv");

                                using (StreamReader read2 = new StreamReader(readmeEntry2.Open()))
                                {
                                    temper = read2.ReadToEnd();
                                    //Console.Write(read.ReadToEnd().ToString());
                                }
                            }
                            zipToOpen2.Close();
                        }
                        string gtw = "";
                        // var pars1 = temper.Split(';')[3].Split(',')[temper.Split(';')[3].Split(',').Length - 1] + "," + comboBox1.Text;
                        var itog = temper.Split(';')[Convert.ToInt32(numericUpDown1.Value)].Split(',')[0];

                        for (int i = 1; i < temper.Split(';')[Convert.ToInt32(numericUpDown1.Value)].Split(',').Length; i++)
                        {
                            itog += "," + temper.Split(';')[Convert.ToInt32(numericUpDown1.Value)].Split(',')[i];
                        }
                        itog += "," + comboBox1.Text;
                        //MessageBox.Show(itog);

                        for (int i = 0; i < temper.Split(';').Length; i++)
                        {
                            if(i != Convert.ToInt32(numericUpDown1.Value))
                            {
                                gtw += temper.Split(';')[i] + ";";
                            }
                            else
                            {
                                gtw += itog + ";";
                            }
                        }

                        //MessageBox.Show(gtw.Remove(gtw.Length - 1, 1));

                        /*string subString = "club,";
                        int indexOfSubstring = temper.IndexOf(subString) + 5; // равно 6
                        //Console.WriteLine(indexOfSubstring);

                        temper = temper.Insert(indexOfSubstring, comboBox1.Text + ",");*/

                        //Console.WriteLine(temper);

                        // temper = comboBox1.Text + "," + temper;
                        // MessageBox.Show(temper);
                        //return;
                        using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                        {
                            using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                            {
                                ZipArchiveEntry readmeEntry = archive.GetEntry("data/default_techtree.csv");
                                using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                                {
                                    writer.WriteLine(gtw.Remove(gtw.Length - 1, 1));

                                }
                            }
                            zipToOpen.Close();
                        }

                    }
                }

            }
            else
            {
                MessageBox.Show(lng.GetLangText("NullParam"));
            }

            got:;
        }

        private void созданиеКрафтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel3);
        }

        private void музыкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel4);

        }
        private void entermusicaudiofile_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/tempaudio");

            OpenFileDialog opg = new OpenFileDialog();
            opg.Filter = "OGG File (*.ogg)|*.ogg;|MP3 File (*.mp3)|*.mp3;";
            if (opg.ShowDialog() != DialogResult.OK) { return; };
            File.Copy(opg.FileName, Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_gameplay.tmp");
            Process.Start("ffmpeg.exe", string.Format(" -i \"{0}\" -vn \"{1}\"", Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_gameplay.tmp", Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_gameplay.mp3")).WaitForExit();
            Process.Start("ffmpeg.exe", string.Format(" -i \"{0}\" -vn \"{1}\"", Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_gameplay.tmp", Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_gameplay.ogg")).WaitForExit();
            //if (opg.SafeFileName != "CraftTheWorld_gameplay.mp3") { MessageBox.Show("Убедитесь в правильном названии файла, он должен называться CraftTheWorld_gameplay"); return; }
            opg.SupportMultiDottedExtensions = false;
            opg.Multiselect = false;
            opg.Title = lng.GetLangText("OpenMusicGameplay");
            //MessageBox.Show( opg.FileName);
            opg_FileName = Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_gameplay.mp3";
            textBox2.Text = opg.FileName;
            opg1_FileName = Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_gameplay.ogg";
            textBox3.Text = Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_gameplay.ogg";
            File.Delete(Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_gameplay.tmp");
        }

        private void entermusicoggaudiofile_Click(object sender, EventArgs e)
        {

        }
        string opg_FileName = "";
        string opg1_FileName = "";
        string opg2_FileName = "";
        string opg3_FileName = "";

        private void enterspokoggaudiofile_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/tempaudio");
            OpenFileDialog opg2 = new OpenFileDialog();
            opg2.Filter = "OGG File (*.ogg)|*.ogg;|MP3 File (*.mp3)|*.mp3;";
            if (opg2.ShowDialog() != DialogResult.OK) { return; };
            File.Copy(opg2.FileName, Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_noKalimba.tmp");
            Process.Start("ffmpeg.exe", string.Format(" -i \"{0}\" -vn \"{1}\"", Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_noKalimba.tmp", Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_noKalimba.ogg")).WaitForExit();
            //if (opg2.SafeFileName != "CraftTheWorld_noKalimba.ogg") { MessageBox.Show("Убедитесь в правильном названии файла, он должен называться CraftTheWorld_noKalimba"); return; }
            opg2.SupportMultiDottedExtensions = false;
            opg2.Multiselect = false;
            opg2.Title = lng.GetLangText("OpenMusicSlept");
            //MessageBox.Show(opg2.FileName);
            opg2_FileName = Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_noKalimba.ogg";
            textBox4.Text = opg2.FileName;
            File.Delete(Environment.CurrentDirectory + "/tempaudio/CraftTheWorld_noKalimba.tmp");
        }

        private void entertrevogoggaudiofile_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/tempaudio");
            OpenFileDialog opg3 = new OpenFileDialog();
            opg3.Filter = "OGG File (*.ogg)|*.ogg;|MP3 File (*.mp3)|*.mp3;";
            if (opg3.ShowDialog() != DialogResult.OK) { return; };
            File.Copy(opg3.FileName, Environment.CurrentDirectory + "/tempaudio/CTW_Gameplay_F2.tmp");
            Process.Start("ffmpeg.exe", string.Format(" -i \"{0}\" -vn \"{1}\"", Environment.CurrentDirectory + "/tempaudio/CTW_Gameplay_F2.tmp", Environment.CurrentDirectory + "/tempaudio/CTW_Gameplay_F2.ogg")).WaitForExit();
            //if (opg3.SafeFileName != "CTW_Gameplay_F2.ogg") { MessageBox.Show("Убедитесь в правильном названии файла, он должен называться CTW_Gameplay_F2"); return; }
            opg3.SupportMultiDottedExtensions = false;
            opg3.Multiselect = false;
            opg3.Title = lng.GetLangText("OpenMusicEnem");
            //MessageBox.Show(opg3.FileName);
            opg3_FileName = Environment.CurrentDirectory + "/tempaudio/CTW_Gameplay_F2.ogg";
            textBox5.Text = opg3.FileName;
            File.Delete(Environment.CurrentDirectory + "/tempaudio/CTW_Gameplay_F2.tmp");
        }
        string opg4_FileName = "";
        private void entermenuoggaudiofile_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/tempaudio");
            OpenFileDialog opg4 = new OpenFileDialog();
            opg4.Filter = "OGG File (*.ogg)|*.ogg;|MP3 File (*.mp3)|*.mp3;";
            if (opg4.ShowDialog() != DialogResult.OK) { return; };
            File.Copy(opg4.FileName, Environment.CurrentDirectory + "/tempaudio/Menu_title_CTW_f_ogg.tmp");
            Process.Start("ffmpeg.exe", string.Format(" -i \"{0}\" -vn \"{1}\"", Environment.CurrentDirectory + "/tempaudio/Menu_title_CTW_f_ogg.tmp", Environment.CurrentDirectory + "/tempaudio/Menu_title_CTW_f_ogg.ogg")).WaitForExit();
            //MessageBox.Show(opg4.SafeFileName);
            //if(opg4.SafeFileName != "Menu_title_CTW_f_ogg.ogg") { MessageBox.Show("Убедитесь в правильном названии файла, он должен называться Menu_title_CTW_f_ogg"); return; }
            opg4.SupportMultiDottedExtensions = false;
            opg4.Multiselect = false;
            opg4.Title = lng.GetLangText("OpenMusicMenu");
            opg4_FileName = Environment.CurrentDirectory + "/tempaudio/Menu_title_CTW_f_ogg.ogg";
            textBox6.Text = opg4.FileName;
            File.Delete(Environment.CurrentDirectory + "/tempaudio/Menu_title_CTW_f_ogg.tmp");

            //MessageBox.Show(opg4.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(puttogame))
            {
                if(textBox2.Text != "")
                {
                    using (ZipFile zip = new ZipFile(@puttogame)) // Создаем объект для работы с архивом
                    {
                        zip.UpdateFile(opg_FileName, "sfx/Music"); // Кладем в архив одиночный файл
                        zip.Save(); // Создаем архив     
                    }
                }
                if (textBox3.Text != "")
                {
                    using (ZipFile zip1 = new ZipFile(@puttogame)) // Создаем объект для работы с архивом
                    {
                        zip1.UpdateFile(opg1_FileName, "sfx/Music"); // Кладем в архив одиночный файл
                        zip1.Save(); // Создаем архив     
                    }
                }
                if (textBox4.Text != "")
                {
                    using (ZipFile zip2 = new ZipFile(@puttogame)) // Создаем объект для работы с архивом
                    {
                        zip2.UpdateFile(opg2_FileName, "sfx/Music"); // Кладем в архив одиночный файл
                        zip2.Save(); // Создаем архив     
                    }
                }
                if (textBox5.Text != "")
                {
                    using (ZipFile zip3 = new ZipFile(@puttogame)) // Создаем объект для работы с архивом
                    {
                        zip3.UpdateFile(opg3_FileName, "sfx/Music"); // Кладем в архив одиночный файл
                        zip3.Save(); // Создаем архив     
                    }
                }
                if (textBox6.Text != "")
                {
                    using (ZipFile zip4 = new ZipFile(@puttogame)) // Создаем объект для работы с архивом
                    {
                        zip4.UpdateFile(opg4_FileName, "sfx/Music"); // Кладем в архив одиночный файл
                        zip4.Save(); // Создаем архив     
                    }
                }
            }
        }

        private void уровниГномовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel5);
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }
        string charlvl = "";
        int lvl = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(puttogame))
            {
                if (maskedTextBox34.Text != "")
                {
                    lvl += 1;
                    string tmp = charlvl;
                    tmp += lvl + " " + maskedTextBox34.Text + " 2";

                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/char_levels.txt");
                            using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                            {
                                writer.Write(tmp);
                                MessageBox.Show(tmp);
                            }
                        }
                        zipToOpen.Close();
                    }
                    open();
                }
                else
                {
                    MessageBox.Show(lng.GetLangText("NullParam"));
                }
            }
        }
        
        private void label38_Click(object sender, EventArgs e)
        {
            
        }

        private void монологаШаманаГоблиновToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel6);
        }

        private void имёнГномовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel10);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists(puttogame))
            {
                using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        ZipArchiveEntry readmeEntry = archive.GetEntry("Lang/Russian/data/shaman_dialogs.txt");
                        using (StreamWriter writer = new StreamWriter(readmeEntry.Open(), Encoding.UTF8))
                        {
                            string[] words = richTextBox1.Text.Split(new char[] { '\n' });

                            foreach (string s in words)
                            {
                                writer.WriteLine(s);
                            }
                            //MessageBox.Show(tmp);
                        }
                    }
                    zipToOpen.Close();
                }
            }
        }

        private void быстрыеДействияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel7);
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists(puttogame))
            {
                if (checkBox2.Checked)
                {
                    XmlDocument xml = new XmlDocument();
                    xml.PreserveWhitespace = true;
                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/resource_bind.xml");

                            using (StreamReader read = new StreamReader(readmeEntry.Open()))
                            {
                                xml.LoadXml(read.ReadToEnd().ToString());
                                //Console.Write(read.ReadToEnd().ToString());
                            }
                        }
                        zipToOpen.Close();
                    }
                    var node1 = xml.SelectSingleNode("/root/bind[@res='sulfur']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='sulfur']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='sulfur']");
                    node1.Attributes["usual_cold"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='gunpowder']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='gunpowder']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='gunpowder']");
                    node1.Attributes["usual_cold"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='trunk']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='trunk']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='trunk']");
                    node1.Attributes["usual_cold"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='trigger_mechanism']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='trigger_mechanism']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='trigger_mechanism']");
                    node1.Attributes["usual_cold"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='pistol']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='pistol']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='pistol']");
                    node1.Attributes["usual_cold"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='rifle']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='rifle']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='rifle']");
                    node1.Attributes["usual_cold"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='heavy_rifle']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='heavy_rifle']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='heavy_rifle']");
                    node1.Attributes["usual_cold"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='ammo']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='ammo']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='ammo']");
                    node1.Attributes["usual_cold"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='ammo_steel']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='ammo_steel']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='ammo_steel']");
                    node1.Attributes["usual_cold"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='ammo_fire']");
                    node1.Attributes["usual_desert"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='ammo_fire']");
                    node1.Attributes["usual_medium"].Value = "true";
                    node1 = xml.SelectSingleNode("/root/bind[@res='ammo_fire']");
                    node1.Attributes["usual_cold"].Value = "true";

                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/resource_bind.xml");
                            using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                            {
                                writer.WriteLine(xml.OuterXml);
                               // MessageBox.Show(xml.OuterXml);
                            }
                        }
                        zipToOpen.Close();
                    }
                    
                    string temper = "";
                    if (checkBox3.Checked)
                    {
                        using (FileStream zipToOpen2 = new FileStream(@puttogame, FileMode.Open))
                        {
                            using (ZipArchive archive2 = new ZipArchive(zipToOpen2, ZipArchiveMode.Read))
                            {
                                ZipArchiveEntry readmeEntry2 = archive2.GetEntry("data/default_techtree.csv");

                                using (StreamReader read2 = new StreamReader(readmeEntry2.Open()))
                                {
                                    temper = read2.ReadToEnd();
                                    //Console.Write(read.ReadToEnd().ToString());
                                }
                            }
                            zipToOpen2.Close();
                        }
                        if (temper.Contains("guns_expert,heavy_rifle,sulfur,gunpowder,trunk,trigger_mechanism,pistol,rifle,ammo,ammo_steel,ammo_fire"))
                        {
                            MessageBox.Show(lng.GetLangText("ErrorResipes"), lng.GetLangText("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                         goto stop;
                        
                        }  
                        temper = temper.Substring(0, temper.Length - 2);
                        //Console.WriteLine(temper);                       
                        temper += ">!;guns_expert,heavy_rifle,sulfur,gunpowder,trunk,trigger_mechanism,pistol,rifle,ammo,ammo_steel,ammo_fire!;";
                        //Console.WriteLine(temper);
                        // temper = comboBox1.Text + "," + temper;
                        // MessageBox.Show(temper);
                        //return;
                        using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                        {
                            using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                            {
                                ZipArchiveEntry readmeEntry = archive.GetEntry("data/default_techtree.csv");
                                using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                                {
                                    writer.WriteLine(temper);
                                    //MessageBox.Show(":fd8");                                   
                                }
                            }
                            zipToOpen.Close();
                        }                    

                    }
                stop:;
                }
                if (checkBox4.Checked)
                {
                    XmlDocument xml = new XmlDocument();
                    xml.PreserveWhitespace = true;
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                    using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                        {
                            ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/creatures.xml");

                            using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                            {
                                //string dat = read.ReadToEnd().ToString();                      
                                //Console.Write(dat);
                                //System.Threading.Thread.Sleep(5000);

                                xml.LoadXml(read1.ReadToEnd().ToString());
                                // xml.Load(@"C:\world.xml");
                            }
                        }
                        zipToOpen1.Close();
                    }

                    var node1 = xml.SelectSingleNode("/root/creature[@name='yak']/params");
                    node1.AppendChild(xml.CreateElement("can_catch"));
                    node1.SelectSingleNode("can_catch").Attributes.Append(xml.CreateAttribute("value")).Value = "true";
                    node1.AppendChild(xml.CreateWhitespace("\r\n "));
                    node1.AppendChild(xml.CreateElement("farm_population_ratio"));
                    node1.SelectSingleNode("farm_population_ratio").Attributes.Append(xml.CreateAttribute("value")).Value = "0.1";
                    node1.AppendChild(xml.CreateWhitespace("\r\n "));            
                    node1.AppendChild(xml.CreateElement("farm_resource"));
                    node1.SelectSingleNode("farm_resource").Attributes.Append(xml.CreateAttribute("value")).Value = "sulfur";
                    node1.AppendChild(xml.CreateWhitespace("\r\n "));

                    //throw new System.ArgumentException("Parameter cannot be null", "original");
                    //MessageBox.Show(node1.Attributes.ToString());

                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/creatures.xml");
                            using (StreamWriter writer = new StreamWriter(readmeEntry.Open(), Encoding.UTF8))
                            {
                                writer.WriteLine(xml.OuterXml);
                                // MessageBox.Show(xml.OuterXml);
                            }
                        }
                        zipToOpen.Close();
                    }
                }

                if (checkBox5.Checked)
                {
                    XmlDocument xml = new XmlDocument();
                    xml.PreserveWhitespace = true;
                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/blocks.xml");

                            using (StreamReader read = new StreamReader(readmeEntry.Open()))
                            {
                                xml.LoadXml(read.ReadToEnd().ToString());
                                //Console.Write(read.ReadToEnd().ToString());
                            }
                        }
                        zipToOpen.Close();
                    }
                    string tmp;
                    var node1 = xml.SelectSingleNode("/root/block[@name='dirt_stalactite']");
                    if (node1.Attributes["properties"].Value.Contains("spawn_water=") & node1.Attributes["properties"].Value.Contains("time=20,draw_effect_with_block"))
                    {
                        tmp = "drop_rain,apply_tool1,dirt,can_replace,spawn_water=" + maskedTextBox4.Text + ",time=20,draw_effect_with_block";
                    }
                    else
                    {
                        tmp = node1.Attributes["properties"].Value + ",spawn_water=" + maskedTextBox4.Text + ",time=20,draw_effect_with_block";
                    }
                    node1 = xml.SelectSingleNode("/root/block[@name='dirt_stalactite']");
                    node1.Attributes["properties"].Value = tmp;
                    //Console.Write(xml.OuterXml);

                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/blocks.xml");
                            using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                            {
                                writer.WriteLine(xml.OuterXml);
                                // MessageBox.Show(xml.OuterXml);
                            }
                        }
                        zipToOpen.Close();
                    }
                }

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                checkBox3.Checked = false;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Activate();
            ab.Show();
        }

        private void логотипаЗагрузкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel8);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (File.Exists(puttogame))
            {
                if (textBox9.Text != "")
                {
                    using (ZipFile zip = new ZipFile(@puttogame)) // Создаем объект для работы с архивом
                    {
                        pictureBox2.Image = ScaleImage(pictureBox2.Image, 1920, 1080);
                        pictureBox2.Image.Save(Environment.CurrentDirectory + "/Loading_screen_01.jpg");
                        zip.UpdateFile(Environment.CurrentDirectory + "/Loading_screen_01.jpg", "gfx/ui/extra"); // Кладем в архив одиночный файл
                        zip.Save(); // Создаем архив   
                        File.Delete(Environment.CurrentDirectory + "/Loading_screen_01.jpg");
                    }
                }
                if (textBox10.Text != "")
                {
                    using (ZipFile zip1 = new ZipFile(@puttogame)) // Создаем объект для работы с архивом
                    {
                        pictureBox3.Image = ScaleImage(pictureBox3.Image, 1920, 1080);
                        pictureBox3.Image.Save(Environment.CurrentDirectory + "/Loading_screen_03_2.jpg");
                        zip1.UpdateFile(Environment.CurrentDirectory + "/Loading_screen_03_2.jpg", "gfx/ui/extra"); // Кладем в архив одиночный файл
                        zip1.Save(); // Создаем архив   
                        File.Delete(Environment.CurrentDirectory + "/Loading_screen_03_2.jpg");  
                    }
                }
                
            }
        }
        string setimg1 = "";
        string setimg2 = "";
        private void imgset1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/tempaudio");
            OpenFileDialog opg4 = new OpenFileDialog();
            opg4.Filter = "Изображение (*.jpg)|*.jpg;";
            if (opg4.ShowDialog() != DialogResult.OK) { return; };
            File.Copy(opg4.FileName, Environment.CurrentDirectory + "/tempaudio/Loading_screen_01.jpg");
            //MessageBox.Show(opg4.SafeFileName);
            //if (opg4.SafeFileName != "Loading_screen_01.jpg") { MessageBox.Show("Убедитесь в правильном названии файла, он должен называться Loading_screen_01"); return; }
            opg4.SupportMultiDottedExtensions = false;
            opg4.Multiselect = false;
            opg4.Title = lng.GetLangText("OpenLogo");
            setimg1 = opg4.FileName;
            textBox9.Text = opg4.FileName;
            pictureBox2.ImageLocation = Environment.CurrentDirectory + "/tempaudio/Loading_screen_01.jpg";
        }

        private void imgset2_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Environment.CurrentDirectory + "/tempaudio");
            OpenFileDialog opg4 = new OpenFileDialog();
            opg4.Filter = "Изображение (*.jpg)|*.jpg;";
            if (opg4.ShowDialog() != DialogResult.OK) { return; };
            File.Copy(opg4.FileName, Environment.CurrentDirectory + "/tempaudio/Loading_screen_03_2.jpg");
            //MessageBox.Show(opg4.SafeFileName);
            //if (opg4.SafeFileName != "Loading_screen_03_2.jpg") { MessageBox.Show("Убедитесь в правильном названии файла, он должен называться Loading_screen_03_2"); return; }
            opg4.SupportMultiDottedExtensions = false;
            opg4.Multiselect = false;
            opg4.Title = "Открыть файл лого загрузки";
            setimg2 = opg4.FileName;
            textBox10.Text = opg4.FileName;
            pictureBox3.ImageLocation = Environment.CurrentDirectory + "/tempaudio/Loading_screen_03_2.jpg";       
        }

        static Image ScaleImage(Image source, int width, int height)
        {

            Image dest = new Bitmap(width, height);
            using (Graphics gr = Graphics.FromImage(dest))
            {
                gr.FillRectangle(Brushes.White, 0, 0, width, height);  // Очищаем экран
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                float srcwidth = source.Width;
                float srcheight = source.Height;
                float dstwidth = width;
                float dstheight = height;

                if (srcwidth <= dstwidth && srcheight <= dstheight)  // Исходное изображение меньше целевого
                {
                    int left = (width - source.Width) / 2;
                    int top = (height - source.Height) / 2;
                    gr.DrawImage(source, left, top, source.Width, source.Height);
                }
                else if (srcwidth / srcheight > dstwidth / dstheight)  // Пропорции исходного изображения более широкие
                {
                    float cy = srcheight / srcwidth * dstwidth;
                    float top = ((float)dstheight - cy) / 2.0f;
                    if (top < 1.0f) top = 0;
                    gr.DrawImage(source, 0, top, dstwidth, cy);
                }
                else  // Пропорции исходного изображения более узкие
                {
                    float cx = srcwidth / srcheight * dstheight;
                    float left = ((float)dstwidth - cx) / 2.0f;
                    if (left < 1.0f) left = 0;
                    gr.DrawImage(source, left, 0, cx, dstheight);
                }

                return dest;
            }
        }

        private void предметовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel9);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(1500);
            if (File.Exists(@puttogame))
            {
                XmlDocument xml = new XmlDocument();
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/craft_resources.xml");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                        {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);

                            xml.LoadXml(read1.ReadToEnd().ToString());
                            // xml.Load(@"C:\world.xml");
                        }
                    }
                    zipToOpen1.Close();
                }
              
                
                var node1 = xml.SelectSingleNode("/root/resource[@title='%" + comboBox2.SelectedItem.ToString() + "T']");
                //MessageBox.Show(xml.OuterXml);
                //return;

                if (node1.Attributes["shop_cost"] != null)
                {
                    maskedTextBox21.Text = node1.Attributes["shop_cost"].Value;
                }
                else
                {
                    maskedTextBox21.Text = "";
                }
                if (node1.Attributes["shop_count"] != null)
                {
                    maskedTextBox35.Text = node1.Attributes["shop_count"].Value;
                }
                else
                {
                    maskedTextBox35.Text = "";
                }
                if (node1.Attributes["properties"] != null)
                {
                    if (node1.Attributes["properties"].Value.Contains("no_shop"))
                    {
                        checkBox6.Checked = false;
                    }
                    else
                    {
                        checkBox6.Checked = true;
                    }
                    textBox11.Text = node1.Attributes["properties"].Value;
                    string[] properties = node1.Attributes["properties"].Value.Split(',');
                    foreach (string tmp in properties)
                    {
                       // MessageBox.Show(tmp.Split('=')[0]);
                        // textBox11.Text = parsing(node1.Attributes["properties"].Value, tmp.Split('=')[0]);
                    }
                }
                else
                {
                    textBox11.Text = "";
                }

                //minning добыча
                //halfstuff игридиенты
                //creature инструменты
                //block конструкции, оссвещение
                //furniture окна, иебель
                //food еда, элексиры
                //creature шлемы, ботинки, броня, магия, особые предметы, элексиры
                //furniture кухни

                if (node1.Attributes["application"].Value == "food") //еда
                {
                    maskedTextBox37.Visible = false;
                    maskedTextBox36.Visible = false;
                    maskedTextBox40.Visible = false;
                    label50.Visible = false;
                    label46.Visible = false;
                    label47.Visible = false;

                    maskedTextBox38.Visible = true;
                    maskedTextBox39.Visible = true;
                    label48.Visible = true;
                    label49.Visible = true;

                    label52.Visible = false;
                    textBox12.Visible = false;

                    if (node1.Attributes["properties"].Value.Contains("satiety"))
                    {
                        // MessageBox.Show(node1.Attributes["properties"].Value);

                        string[] properties = node1.Attributes["properties"].Value.Split(',');
                        foreach (string tmp in properties)
                        {

                            for (int i = 0; i < tmp.Split('=').Length; i++)
                            {
                                if (tmp.Split('=')[i] == "satiety")
                                {
                                    //MessageBox.Show(tmp.Split('=')[i] + "=" + /*tmp.Split('=')[i + 1]*/ "a" + ",");
                                    maskedTextBox38.Text = parsing(tmp.Split('=')[i] + "=" + tmp.Split('=')[i + 1], "satiety");

                                }
                            }
                            // textBox11.Text = parsing(node1.Attributes["properties"].Value, tmp.Split('=')[0]);
                        }


                    }
                    else { maskedTextBox37.Text = ""; }
                    if (node1.Attributes["properties"].Value.Contains("healt"))
                    {
                        string[] properties = node1.Attributes["properties"].Value.Split(',');
                        foreach (string tmp in properties)
                        {

                            for (int i = 0; i < tmp.Split('=').Length; i++)
                            {
                                if (tmp.Split('=')[i] == "healt")
                                {
                                    //MessageBox.Show(tmp.Split('=')[i] + "=" + /*tmp.Split('=')[i + 1]*/ "a" + ",");
                                    maskedTextBox39.Text = parsing(tmp.Split('=')[i] + "=" + tmp.Split('=')[i + 1], "healt");

                                }
                            }
                            // textBox11.Text = parsing(node1.Attributes["properties"].Value, tmp.Split('=')[0]);
                        }
                    }
                    else { maskedTextBox36.Text = ""; }

                }

                else if (node1.Attributes["application"].Value == "creature") //gnom
                {
                    if (node1.Attributes["class"] != null)
                    {

                        if (node1.Attributes["class"].Value == "weapon") //oruzie
                        {
                            maskedTextBox37.Visible = true;
                            maskedTextBox36.Visible = true;
                            maskedTextBox40.Visible = false;
                            label50.Visible = false;
                            label46.Visible = true;
                            label47.Visible = true;

                            maskedTextBox38.Visible = false;
                            maskedTextBox39.Visible = false;
                            label48.Visible = false;
                            label49.Visible = false;


                            if (node1.Attributes["properties"].Value.Contains("attack"))
                            {
                                // MessageBox.Show(node1.Attributes["properties"].Value);

                                string[] properties = node1.Attributes["properties"].Value.Split(',');
                                foreach (string tmp in properties)
                                {

                                    for (int i = 0; i < tmp.Split('=').Length; i++)
                                    {
                                        if (tmp.Split('=')[i] == "attack")
                                        {
                                            //MessageBox.Show(tmp.Split('=')[i] + "=" + /*tmp.Split('=')[i + 1]*/ "a" + ",");
                                            maskedTextBox37.Text = parsing(tmp.Split('=')[i] + "=" + tmp.Split('=')[i + 1], "attack");

                                        }
                                    }
                                    // textBox11.Text = parsing(node1.Attributes["properties"].Value, tmp.Split('=')[0]);
                                }


                            }
                            else { maskedTextBox37.Text = ""; }
                            if (node1.Attributes["properties"].Value.Contains("speed"))
                            {
                                string[] properties = node1.Attributes["properties"].Value.Split(',');
                                foreach (string tmp in properties)
                                {

                                    for (int i = 0; i < tmp.Split('=').Length; i++)
                                    {
                                        if (tmp.Split('=')[i] == "speed")
                                        {
                                            //MessageBox.Show(tmp.Split('=')[i] + "=" + /*tmp.Split('=')[i + 1]*/ "a" + ",");
                                            maskedTextBox36.Text = parsing(tmp.Split('=')[i] + "=" + tmp.Split('=')[i + 1], "speed");

                                        }
                                    }
                                    // textBox11.Text = parsing(node1.Attributes["properties"].Value, tmp.Split('=')[0]);
                                }
                            }
                            else { maskedTextBox36.Text = ""; }

                        }

                        if (node1.Attributes["class"].Value == "helmet" || node1.Attributes["class"].Value == "boots" || node1.Attributes["class"].Value == "cloth") //brona
                        {
                            maskedTextBox37.Visible = false;
                            maskedTextBox36.Visible = false;
                            maskedTextBox40.Visible = true;
                            label50.Visible = true;
                            label46.Visible = false;
                            label47.Visible = false;

                            maskedTextBox38.Visible = false;
                            maskedTextBox39.Visible = false;
                            label48.Visible = false;
                            label49.Visible = false;

                            label52.Visible = true;
                            textBox12.Visible = true;


                            if (node1.Attributes["properties"].Value.Contains("slowdown"))
                            {
                               // MessageBox.Show(node1.Attributes["properties"].Value);

                                string[] properties = node1.Attributes["properties"].Value.Split(',');
                                foreach (string tmp in properties)
                                {

                                    for (int i = 0; i < tmp.Split('=').Length; i++)
                                    {
                                        if(tmp.Split('=')[i] == "slowdown")
                                        {
                                           //MessageBox.Show(tmp.Split('=')[i] + "=" + /*tmp.Split('=')[i + 1]*/ "a" + ",");
                                           textBox12.Text = parsing(tmp.Split('=')[i] + "=" + tmp.Split('=')[i + 1], "slowdown");
                                           
                                        }
                                    }                                  
                                    // textBox11.Text = parsing(node1.Attributes["properties"].Value, tmp.Split('=')[0]);
                                }

                                
                            }
                            else { textBox12.Text = ""; }
                            if (node1.Attributes["properties"].Value.Contains("armor"))
                            {
                                string[] properties = node1.Attributes["properties"].Value.Split(',');
                                foreach (string tmp in properties)
                                {

                                    for (int i = 0; i < tmp.Split('=').Length; i++)
                                    {
                                        if (tmp.Split('=')[i] == "armor")
                                        {
                                            //MessageBox.Show(tmp.Split('=')[i] + "=" + /*tmp.Split('=')[i + 1]*/ "a" + ",");
                                            maskedTextBox40.Text = parsing(tmp.Split('=')[i] + "=" + tmp.Split('=')[i + 1], "armor");

                                        }
                                    }
                                    // textBox11.Text = parsing(node1.Attributes["properties"].Value, tmp.Split('=')[0]);
                                }
                            }
                            else { maskedTextBox40.Text = ""; }

                        }
                    }
                }
                else
                {
                    maskedTextBox37.Visible = false;
                    maskedTextBox36.Visible = false;
                    maskedTextBox40.Visible = false;
                    label50.Visible = false;
                    label46.Visible = false;
                    label47.Visible = false;

                    maskedTextBox38.Visible = false;
                    maskedTextBox39.Visible = false;
                    label48.Visible = false;
                    label49.Visible = false;

                    label52.Visible = false;
                    textBox12.Visible = false;
                }

                // maskedTextBox16.Text = ;

                /*
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/satiety");
                maskedTextBox17.Text = node1.Attributes["value"].Value;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/walk_speed");
                maskedTextBox18.Text = node1.Attributes["value"].Value;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/fall_height");
                maskedTextBox19.Text = node1.Attributes["value"].Value;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/capacity");
                maskedTextBox20.Text = node1.Attributes["value"].Value;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/attack");
                textBox7.Text = node1.Attributes["value"].Value;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/water_die_time");
                maskedTextBox22.Text = node1.Attributes["value"].Value;
                node1 = xml.SelectSingleNode("/root/creature[@name='worker']/params/climbs_speed");
                maskedTextBox23.Text = node1.Attributes["value"].Value;
                */
                //Console.WriteLine("Текущее значение ChanceOfBreak: {0}", node.Attributes["value"].Value);
                //Console.Write("Введите новое значение: ");
            }
        }

        private string parsing(string s, string param, char delite = ',')
        {
                var dict = s.Split(delite)
            .Select(part => part.Split('=')
                                .Select(token => token.Trim('"')))
            .ToDictionary(tokens => tokens.First(),
                          tokens => tokens.Skip(1).Single());


            var res = dict[param];
            return res;
        }

        private void maskedTextBox21_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            checkBox6.Checked = true;
        }

        private void maskedTextBox35_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            checkBox6.Checked = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (File.Exists(@puttogame))
            {
                XmlDocument xml = new XmlDocument();
                xml.PreserveWhitespace = true;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/craft_resources.xml");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                        {
                            //string dat = read.ReadToEnd().ToString();                      
                            //Console.Write(dat);
                            //System.Threading.Thread.Sleep(5000);

                            xml.LoadXml(read1.ReadToEnd().ToString());
                            // xml.Load(@"C:\world.xml");
                        }
                    }
                    zipToOpen1.Close();
                }
                //////////////\\\\\\\\\\\\\\\\\\\\\/////////////////////////////////////////////////////////
                /*int cost = Convert.ToInt32(maskedTextBox21.Text);
                int koll = Convert.ToInt32(maskedTextBox35.Text);

                int scor = Convert.ToInt32(maskedTextBox36.Text);
                int atack = Convert.ToInt32(maskedTextBox37.Text);

                int hill = Convert.ToInt32(maskedTextBox38.Text);
                int sit = Convert.ToInt32(maskedTextBox39.Text);

                int zasit = Convert.ToInt32(maskedTextBox40.Text);*/
                ///////////////////////////////////////////////////////////////////////////////////////\\\\\\\



                string temp = "";
                string dopparam = textBox11.Text;

                var node1 = xml.SelectSingleNode("/root/resource[@title='%" + comboBox2.SelectedItem.ToString() + "T']");
                
                //////////////////////////////////////еда
                if (node1.Attributes["application"].Value == "food")
                {
                    if(maskedTextBox38.Text != "")
                    {
                        temp = "satiety=" + maskedTextBox39.Text + ",healt=" + maskedTextBox38.Text + "";
                    }
                    else
                    {
                        temp = "satiety=" + maskedTextBox39.Text;
                    }
                    
                    if (!checkBox6.Checked)
                    {
                        temp += ",no_shop";
                    }
                    //node1 = xml.SelectSingleNode("/root/resource[@name='" + comboBox2.SelectedItem.ToString() + "']");                   
                                                        
                   // MessageBox.Show(node1.OuterXml);
                }
                //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\еда
                else if (node1.Attributes["application"].Value == "creature")
                {
                    if(node1.Attributes["class"].Value == "helmet" || node1.Attributes["class"].Value == "boots" || node1.Attributes["class"].Value == "cloth") {

                        if (textBox12.Text != "")
                        {
                            temp = "slowdown=" + textBox12.Text + ",armor=" + maskedTextBox40.Text + "";
                        }
                        else
                        {
                            temp = "armor=" + maskedTextBox40.Text;
                        }

                        if (!checkBox6.Checked)
                        {
                            temp += ",no_shop";
                        }

                    }

                    else if (node1.Attributes["class"].Value == "weapon")
                    {

                        if (maskedTextBox36.Text != "")
                        {
                            temp = "speed=" + maskedTextBox36.Text + ",attack=" + maskedTextBox37.Text + "";
                        }
                        else
                        {
                            temp = "attack=" + maskedTextBox37.Text;
                        }

                        if (!checkBox6.Checked)
                        {
                            temp += ",no_shop";
                        }

                    }
                    //node1.Attributes["shop_count"].Value = maskedTextBox35.Text;
                    //node1.Attributes["shop_cost"].Value = maskedTextBox21.Text;
                }               

                ////////////Постоянное, конечное///////////////////////////////////////////////
                if (node1.Attributes["properties"] != null)
                {
                    foreach (string tmp in dopparam.Split(','))
                    {
                        if (!temp.Contains(tmp.Split('=')[0]))
                        {
                            if(temp == "")
                            {
                                temp += tmp;
                            }
                            else
                            {
                               temp += "," + tmp;
                            }
                            
                        }
                    }
                    //MessageBox.Show(temp);
                    node1.Attributes["properties"].Value = temp;
                }
                else if (node1.Attributes["properties"] == null & textBox11.Text != "")
                {
                    var node37 = xml.CreateAttribute("properties");
                    node1.Attributes.Append(node37);

                    foreach (string tmp in dopparam.Split(','))
                    {
                        if (!temp.Contains(tmp.Split('=')[0]))
                        {
                            if (temp == "")
                            {
                                temp += tmp;
                            }
                            else
                            {
                                temp += "," + tmp;
                            }

                        }
                    }
                    //MessageBox.Show(temp);
                    node1.Attributes["properties"].Value = temp;
                }

                if (node1.Attributes["shop_cost"] != null)
                {
                    node1.Attributes["shop_cost"].Value = maskedTextBox21.Text;
                }
                else if (node1.Attributes["shop_cost"] == null & maskedTextBox21.Text != "")
                {
                    var node37 = xml.CreateAttribute("shop_cost");
                    node1.Attributes.Append(node37);
                    node1.Attributes["shop_cost"].Value = maskedTextBox21.Text;
                }
                if (node1.Attributes["shop_count"] != null)
                {
                    node1.Attributes["shop_count"].Value = maskedTextBox35.Text;
                }
                else if (node1.Attributes["shop_count"] == null & maskedTextBox35.Text != "")
                {
                    var node37 = xml.CreateAttribute("shop_count");
                    node1.Attributes.Append(node37);
                    node1.Attributes["shop_count"].Value = maskedTextBox35.Text;
                }               

                using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        ZipArchiveEntry readmeEntry = archive.GetEntry("data/craft_resources.xml");
                        using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                        {
                            writer.WriteLine(xml.OuterXml);
                            // MessageBox.Show(xml.OuterXml);
                        }
                    }
                    zipToOpen.Close();
                }

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string notfem = "";
            string fem = "";

            foreach(string tmp in comboBox3.Items){
                if(comboBox3.Text == tmp)
                {
                     if (textBox13.Text != "")
                     {
                        notfem += textBox13.Text + Environment.NewLine;
                    }
                    else
                    {
                        notfem += tmp + Environment.NewLine;
                    }
                }
                else
                {
                  notfem += tmp + Environment.NewLine;
                }
                
            }

            foreach (string tmp in comboBox4.Items)
            {
                if (comboBox4.Text == tmp)
                {
                    if (textBox14.Text != "")
                    {
                        fem += textBox14.Text + Environment.NewLine;
                    }
                    else
                    {
                        fem += tmp + Environment.NewLine;
                    }
                }
                else
                {
                    fem += tmp + Environment.NewLine;
                }
            }

            using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.GetEntry("Lang/Russian/data/names_female.txt");
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open(), Encoding.UTF8))
                    {
                        writer.WriteLine(fem);
                        // MessageBox.Show(xml.OuterXml);
                    }
                }
                zipToOpen.Close();
            }

            using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.GetEntry("Lang/Russian/data/names.txt");
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open(), Encoding.UTF8))
                    {
                        writer.WriteLine(notfem);
                        // MessageBox.Show(xml.OuterXml);
                    }
                }
                zipToOpen.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void дераваТехнологийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel11);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(@puttogame))
            {
                string rrra = "";
                string rrra1 = "";
                string rrra2 = "";
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////\\
                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("Lang/Russian/data/tech_locale.csv");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open(), Encoding.UTF8))
                        {
                            foreach (var item in read1.ReadToEnd().Split('\n'))
                            {
                                rrra += item.Split(';')[0] + ";";
                                rrra1 += item.Split(';')[item.Split(';').Length - 1] + ";";
                                rrra2 += item + "\n";
                            }
                        }
                    }
                    zipToOpen1.Close();
                }

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////\\
                using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry1 = archive1.GetEntry("data/default_techtree.csv");

                        using (StreamReader read1 = new StreamReader(readmeEntry1.Open(), Encoding.UTF8))
                        {
                            string rrr = read1.ReadToEnd().Replace("<", "");
                            for (int i = 0; i < rrr.Split(';').Length; i++)
                            {
                                for (int ia = 0; ia < rrr.Split(';')[i].Split(',').Length; ia++)
                                {

                                        if (rrr.Split(';')[i].Split(',')[ia] == comboBox6.Text)
                                        {

                                        //MessageBox.Show(rrr.Split(';')[i].Split(',')[0] + " // ");
                                        foreach (var item in rrr.Split(';')[i].Split(','))
                                        {
                                            foreach (string itemcmb in comboBox7.Items)
                                            {
                                                if(item == itemcmb)
                                                {
                                                    comboBox7.Text = item;
                                                }
                                            }
                                        }
                                        //comboBox7.Text = rrr.Split(';')[i].Split(',')[0];

                                                    for (int ie = 0; ie < rrra2.Split('\n').Length; ie++)
                                                    {
                                                        if(rrra2.Split('\n')[ie].Split(';')[0] == rrr.Split(';')[i].Split(',')[0])
                                                        {
                                                            comboBox8.Text = rrra2.Split('\n')[ie].Split(';')[rrra2.Split('\n')[ie].Split(';').Length - 1];
                                                        }
                                                    }
                                                    //comboBox8.Text = rrra1.Split(';')[ir].Split(',')[rrra1.Split(';')[i].Split(',').Length - 1];
                                        
                                        
                                        }
                                    
                                    ////
                                    //comboBox6.Items.Add(rrr.Split(';')[i].Split(',')[ia]);
                                }
                            }

                        }
                    }
                    zipToOpen1.Close();
                }
            }
        }

        private void closopen(bool status, Panel[] panel, Panel elsepanel)
        {
            if (status)
            {
                foreach (var tmp in panel)
                {
                    tmp.Visible = true;
                }
                elsepanel.Visible = false;
            }
            else
            {
                foreach (var tmp in panel)
                {
                    tmp.Visible = false;
                }
                elsepanel.Visible = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void уровнейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel12);
        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel13.Visible = !panel13.Visible;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int index = comboBox9.SelectedIndex + 1;
            XmlDocument xml6 = new XmlDocument();
            xml6.PreserveWhitespace = true;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

            using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry readmeEntry1 = archive1.GetEntry(String.Format("Levels/{0}.xml", index.ToString()));

                    using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                    {
                        //string dat = read.ReadToEnd().ToString();                      
                        //Console.Write(dat);
                        //System.Threading.Thread.Sleep(5000);

                        xml6.LoadXml(read1.ReadToEnd().ToString());
                        // xml.Load(@"C:\world.xml");
                    }
                }
                zipToOpen1.Close();
            }

            xml6.SelectSingleNode("root/level/params").SelectSingleNode("difficulty").Attributes["value"].Value = comboBox10.Text;
            xml6.SelectSingleNode("root/level/params").SelectSingleNode("sizeTemplate").Attributes["value"].Value = comboBox11.Text;
            xml6.SelectSingleNode("root/level/params").SelectSingleNode("lanscapeTemplate").Attributes["value"].Value = comboBox12.Text;
            xml6.SelectSingleNode("root/level/params").SelectSingleNode("temperatureTemplate").Attributes["value"].Value = comboBox13.Text;
            xml6.SelectSingleNode("root/level/params").SelectSingleNode("minGraves").Attributes["value"].Value = comboBox14.Text;
            xml6.SelectSingleNode("root/level/params").SelectSingleNode("graveyards").Attributes["value"].Value = comboBox15.Text;
            xml6.SelectSingleNode("root/level/params").SelectSingleNode("monstersWaveTime").Attributes["value"].Value = comboBox16.Text;
            xml6.SelectSingleNode("root/level/params").SelectSingleNode("monstersWaveLevel").Attributes["value"].Value = comboBox17.Text;
            xml6.SelectSingleNode("root/level/params").SelectSingleNode("monstersWavePortalOffset").Attributes["value"].Value = comboBox18.Text;
            xml6.SelectSingleNode("root/level/params").SelectSingleNode("monstersWaveCount").Attributes["value"].Value = comboBox19.Text;
            System.Threading.Thread.Sleep(500);

            using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.GetEntry(String.Format("Levels/{0}.xml", index.ToString()));
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                    {
                        writer.WriteLine(xml6.OuterXml);
                         //MessageBox.Show(xml6.OuterXml);
                    }
                }
                zipToOpen.Close();
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox9.SelectedIndex + 1;

            XmlDocument xml6 = new XmlDocument();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

            using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry readmeEntry1 = archive1.GetEntry(String.Format("Levels/{0}.xml", index.ToString()));

                    using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                    {
                        //string dat = read.ReadToEnd().ToString();                      
                        //Console.Write(dat);
                        //System.Threading.Thread.Sleep(5000);

                        xml6.LoadXml(read1.ReadToEnd().ToString());
                        // xml.Load(@"C:\world.xml");
                    }
                }
                zipToOpen1.Close();
            }

            comboBox10.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("difficulty").Attributes["value"].Value;
            comboBox11.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("sizeTemplate").Attributes["value"].Value;
            comboBox12.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("lanscapeTemplate").Attributes["value"].Value;
            comboBox13.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("temperatureTemplate").Attributes["value"].Value;
            comboBox14.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("minGraves").Attributes["value"].Value;
            comboBox15.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("graveyards").Attributes["value"].Value;
            comboBox16.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("monstersWaveTime").Attributes["value"].Value;
            comboBox17.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("monstersWaveLevel").Attributes["value"].Value;
            comboBox18.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("monstersWavePortalOffset").Attributes["value"].Value;
            comboBox19.Text = xml6.SelectSingleNode("root/level/params").SelectSingleNode("monstersWaveCount").Attributes["value"].Value;

            Label lb1 = new Label();
            Label lb2 = new Label();
            Label lb3 = new Label();
            Label lb4 = new Label();
            Label lb5 = new Label();

            for (int i = 0; i < xml6.SelectSingleNode("root/level/blocks").ChildNodes.Count; i++)
            {
                if (xml6.SelectSingleNode("root/level/blocks").ChildNodes[i].Name == "block")
                {
                    //Label lb1 = new Label();
                    //lb1.Name = i.ToString();
                    
                    lb1.AutoSize = true;
                    lb1.Font = new Font(FontFamily.GenericSerif, 15, FontStyle.Bold, GraphicsUnit.Pixel);
                    lb1.Location = new Point(10);
                    lb1.Text += Environment.NewLine + xml6.SelectSingleNode("root/level/blocks").ChildNodes[i].Attributes["name"].Value;

                    lb2.AutoSize = true;
                    lb2.Font = new Font(FontFamily.GenericSerif, 15, FontStyle.Bold, GraphicsUnit.Pixel);
                    lb2.Location = new Point(lb1.Location.X + 60, lb1.Location.Y);
                    lb2.Text += Environment.NewLine + xml6.SelectSingleNode("root/level/blocks").ChildNodes[i].Attributes["points"].Value;

                    lb3.AutoSize = true;
                    lb3.Font = new Font(FontFamily.GenericSerif, 15, FontStyle.Bold, GraphicsUnit.Pixel);
                    lb3.Location = new Point(lb2.Location.X + 60, lb1.Location.Y);
                    lb3.Text += Environment.NewLine + xml6.SelectSingleNode("root/level/blocks").ChildNodes[i].Attributes["count"].Value;

                    lb4.AutoSize = true;
                    lb4.Font = new Font(FontFamily.GenericSerif, 15, FontStyle.Bold, GraphicsUnit.Pixel);
                    lb4.Location = new Point(lb3.Location.X + 60, lb1.Location.Y);
                    lb4.Text += Environment.NewLine + xml6.SelectSingleNode("root/level/blocks").ChildNodes[i].Attributes["range"].Value;

                    lb5.AutoSize = true;
                    lb5.Font = new Font(FontFamily.GenericSerif, 15, FontStyle.Bold, GraphicsUnit.Pixel);
                    lb5.Location = new Point(lb4.Location.X + 60, lb1.Location.Y);
                    lb5.Text += Environment.NewLine + xml6.SelectSingleNode("root/level/blocks").ChildNodes[i].Attributes["dheight"].Value;
                }
            }

            panel13.Controls.Add(lb1);
            panel13.Controls.Add(lb2);
            panel13.Controls.Add(lb3);
            panel13.Controls.Add(lb4);
            panel13.Controls.Add(lb5);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel14.Visible = !panel14.Visible;
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (FileStream zipToOpen3 = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive3 = new ZipArchive(zipToOpen3, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry readmeEntry3 = archive3.GetEntry("data/char_levels.txt");                   

                    using (StreamReader read4 = new StreamReader(readmeEntry3.Open()))
                    {
                        string id = comboBox20.Text;

                        string temp = read4.ReadToEnd();

                        string[] temp1 = temp.Split('\n');
                        foreach (var item in temp1)
                        {
                            if (item.Split(' ')[0] == id)
                            {
                                maskedTextBox41.Text = item.Split(' ')[1];
                            }                            
                        }

                        //MessageBox.Show(charlvl);
                    }

                }
                zipToOpen3.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string text = "";
            if (File.Exists(puttogame))
            {
                using (FileStream zipToOpen3 = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive3 = new ZipArchive(zipToOpen3, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry readmeEntry3 = archive3.GetEntry("data/char_levels.txt");

                    using (StreamReader read4 = new StreamReader(readmeEntry3.Open()))
                    {
                        string id = comboBox20.Text;

                        string temp = read4.ReadToEnd();

                        string[] temp1 = temp.Split('\n');

                            for (int i = 0; i < temp1.Length; i++)
                            {
                                if (temp1[i].Split(' ')[0] == id)
                                {
                                    text += temp1[i].Split(' ')[0] + " " + maskedTextBox41.Text + " " + temp1[i].Split(' ')[2] + '\n';
                                }
                                else
                                {
                                    text += temp1[i].Split(' ')[0] + " " + temp1[i].Split(' ')[1] + " " + temp1[i].Split(' ')[2] + '\n';
                                }
                            }
                            text = text.Substring(0, text.Length - 1);
                    }

                }
                zipToOpen3.Close();
            }
        
                if (maskedTextBox41.Text != "")
                {
                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/char_levels.txt");
                            using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                            {
                                writer.Write(text);
                                //MessageBox.Show(text);
                            }
                        }
                        zipToOpen.Close();
                    }
                    open();
                }
                else
                {
                    MessageBox.Show(lng.GetLangText("NullParam"));
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string text = "";
            if (File.Exists(puttogame))
            {
                using (FileStream zipToOpen3 = new FileStream(@puttogame, FileMode.Open))
                {
                    using (ZipArchive archive3 = new ZipArchive(zipToOpen3, ZipArchiveMode.Read))
                    {
                        ZipArchiveEntry readmeEntry3 = archive3.GetEntry("data/char_levels.txt");

                        using (StreamReader read4 = new StreamReader(readmeEntry3.Open(), Encoding.UTF8))
                        {
                            string id = comboBox20.Text;

                            string temp = read4.ReadToEnd();

                            string[] temp1 = temp.Split('\n');

                            for (int i = 0; i < temp1.Length; i++)
                            {
                                if (temp1[i].Split(' ')[0] == id)
                                {
                                    //text += temp1[i].Split(' ')[0] + " " + maskedTextBox41.Text + " " + temp1[i].Split(' ')[2] + Environment.NewLine;
                                }
                                else
                                {
                                    text += temp1[i].Split(' ')[0] + " " + temp1[i].Split(' ')[1] + " " + temp1[i].Split(' ')[2] + '\n';
                                }
                            }
                            text = text.Substring(0, text.Length - 1);
                        }

                    }
                    zipToOpen3.Close();
                }

                    using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                        {
                            ZipArchiveEntry readmeEntry = archive.GetEntry("data/char_levels.txt");
                            using (StreamWriter writer = new StreamWriter(readmeEntry.Open(), Encoding.UTF8))
                            {
                                writer.Write(text);
                            // MessageBox.Show(text);
                            }
                        }
                        zipToOpen.Close();
                    }
                    open();
                }
                else
                {
                    MessageBox.Show(lng.GetLangText("NullParam"));
                }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void сохраненийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel15);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DateLinks.xml");

            SaveFileDialog ops = new SaveFileDialog();
            ops.Filter = "File Saves CTW (*.CTWsave)|*.CTWsave;";
            ops.Title = lng.GetLangText("SaveCTWSaves");
            ops.FileName = "saves_" + DateTime.Now.Second + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Day + ".CTWsave";
            if (ops.ShowDialog() != DialogResult.OK) { return; };

            using (ZipFile zip = new ZipFile()) // Создаем объект для работы с архивом
            {
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression; // MAX степень сжатия
                zip.AddDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dekovir\\crafttheworld\\saves\\" + comboBox21.Text); // Кладем в архив папку вместе с содежимым
                zip.Save(ops.FileName);  // Создаем архив  
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenFileDialog opg = new OpenFileDialog();
            opg.Filter = "File Saves CTW (*.CTWsave)|*.CTWsave;";
            if (opg.ShowDialog() != DialogResult.OK) { return; };
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dekovir\\crafttheworld\\saves\\" + comboBox22.Text))
            {
                foreach (var item in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dekovir\\crafttheworld\\saves\\" + comboBox22.Text))
                {
                    File.Delete(item);
                }
                Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dekovir\\crafttheworld\\saves\\" + comboBox22.Text);
            }
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dekovir\\crafttheworld\\saves\\" + comboBox22.Text);
                using (ZipFile zip = ZipFile.Read(opg.FileName))
                {
                    zip.ExtractAll(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\dekovir\\crafttheworld\\saves\\" + comboBox22.Text);
                }
            
            opg.SupportMultiDottedExtensions = false;
            opg.Multiselect = false;
            opg.Title = lng.GetLangText("OpenCTWSaves");
            
        }

        private void скиловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel16);
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xml55 = new XmlDocument();
            xml55.PreserveWhitespace = true;
            using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry readmeEntry1 = archive1.GetEntry("Lang/Russian/data/skills.xml");

                    using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                    {
                        textBox15.Text = "";
                        textBox16.Text = "";
                        //string dat = read.ReadToEnd().ToString();                      
                        //Console.Write(dat);
                        //System.Threading.Thread.Sleep(5000);

                        xml55.LoadXml(read1.ReadToEnd().ToString());
                        //var node1 = xml.SelectSingleNode("/root/resource[@title='%" + comboBox2.SelectedItem.ToString() + "T']");

                        var nade1 = xml55.SelectSingleNode("/root/skills/skill[@name='" + comboBox23.Text + "']");

                        textBox1.Text = nade1.Attributes["title"].Value;
                        string properties = nade1.Attributes["properties"].Value;

                        if(properties.Split(',').Length >= 2)
                        {
                            textBox15.Text = properties.Split(',')[0].Split('=')[1];
                            textBox16.Text = properties.Split(',')[1].Split('=')[1];
                            label83.Visible = true;
                            textBox16.Visible = true;
                        }
                        else
                        {
                            textBox15.Text = properties.Split('=')[1];
                            label83.Visible = false;
                            textBox16.Visible = false;
                        }
                        // xml.Load(@"C:\world.xml");
                    }
                }
                zipToOpen1.Close();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            XmlDocument xml55 = new XmlDocument();
            xml55.PreserveWhitespace = true;
            using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry readmeEntry1 = archive1.GetEntry("Lang/Russian/data/skills.xml");

                    using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                    {
                        //string dat = read.ReadToEnd().ToString();                      
                        //Console.Write(dat);
                        //System.Threading.Thread.Sleep(5000);

                        xml55.LoadXml(read1.ReadToEnd().ToString());
                        //var node1 = xml.SelectSingleNode("/root/resource[@title='%" + comboBox2.SelectedItem.ToString() + "T']");

                        var nade1 = xml55.SelectSingleNode("/root/skills/skill[@name='" + comboBox23.Text + "']");

                        nade1.Attributes["title"].Value = textBox1.Text;
                        string properties = nade1.Attributes["properties"].Value;

                        if (properties.Split(',').Length >= 2)
                        {
                            nade1.Attributes["properties"].Value = properties.Split(',')[0].Split('=')[0] + "=" + textBox15.Text + "," + properties.Split(',')[1].Split('=')[0] + "=" + textBox16.Text;
                        }
                        else
                        {
                            nade1.Attributes["properties"].Value = properties.Split('=')[0] + "=" + textBox15.Text;
                        }
                        // xml.Load(@"C:\world.xml");
                        //MessageBox.Show(nade1.Attributes["properties"].Value);
                    }
                }
                zipToOpen1.Close();
            }

            using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.GetEntry("Lang/Russian/data/skills.xml");
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                    {
                        writer.WriteLine(xml55.OuterXml);
                        // MessageBox.Show(xml.OuterXml);
                    }
                }
                zipToOpen.Close();
            }
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void названияСуществToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closopen(false, pn, panel17);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string tmp = "";
            XmlDocument xml556 = new XmlDocument();
            xml556.PreserveWhitespace = true;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

            using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry readmeEntry1 = archive1.GetEntry("Lang/Russian/data/beastiary_locale.csv");

                    using (StreamReader read1 = new StreamReader(readmeEntry1.Open(), Encoding.UTF8))
                    {
                        string dat = read1.ReadToEnd().ToString().Replace("\r", "");

                        for (int i = 0; i < dat.Split('\n').Length; i++)
                        {
                            if (dat.Split('\n')[i].Split(';')[0] == comboBox24.Text)
                            {
                                tmp += dat.Split('\n')[i].Split(';')[0] + ";" + textBox17.Text + ";" + richTextBox2.Text + Environment.NewLine;
                            }
                            else
                            {
                                if (dat.Split('\n')[i].Split(';').Length > 1)
                                {
                                    tmp += dat.Split('\n')[i].Split(';')[0] + ";" + dat.Split('\n')[i].Split(';')[1] + ";" + dat.Split('\n')[i].Split(';')[2] + Environment.NewLine;
                                }
                            }
                        }
                    }
                }
                zipToOpen1.Close();
            }
            using (FileStream zipToOpen = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.GetEntry("Lang/Russian/data/beastiary_locale.csv");
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open(), Encoding.UTF8))
                    {
                        writer.WriteLine(tmp);
                        // MessageBox.Show(xml.OuterXml);
                    }
                }
                zipToOpen.Close();
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument xml556 = new XmlDocument();
            xml556.PreserveWhitespace = true;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////\\\\\\\\\

            using (FileStream zipToOpen1 = new FileStream(@puttogame, FileMode.Open))
            {
                using (ZipArchive archive1 = new ZipArchive(zipToOpen1, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry readmeEntry1 = archive1.GetEntry("Lang/Russian/data/beastiary_locale.csv");

                    using (StreamReader read1 = new StreamReader(readmeEntry1.Open()))
                    {
                        string dat = read1.ReadToEnd().ToString();

                        for (int i = 0; i < dat.Split('\n').Length; i++)
                        {
                            if(dat.Split('\n')[i].Split(';')[0] == comboBox24.Text)
                            {
                                textBox17.Text = dat.Split('\n')[i].Split(';')[1];
                                richTextBox2.Text = (dat.Split('\n')[i].Split(';')[2]).Replace("\r", "").Replace("\n", "");
                            }
                        }                      
                    }
                }
                zipToOpen1.Close();
            }
        }

        private void запуститьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gamepaths = "";

            for (int i = 0; i < puttogame.Split('\\').Length - 1; i++)
            {
                gamepaths += puttogame.Split('\\')[i] += "\\";
            }
            Process.Start(gamepaths + "\\CraftWorld.exe");
        }

        private void SaveParam(object sender, EventArgs e)
        {
            if((sender as Button).Name == "Bestyary")
            {
                //CTWLoader_Formating.CTWLoader_ArrayParam.ComboboxParsing(comboBox24);
                SortedList<string, string> Par = new SortedList<string, string>();
                Par.Add("Name", comboBox24.Text);
                Par.Add("Name1", textBox17.Text);
                Par.Add("Desc", richTextBox2.Text);
                CTWLoader_Formating.Save(CTWLoader_Formating.DialogSavePath(), CTWLoader_Formating.TypeData.Bestyary, Par);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SortedList<string, string> ttt = CTWLoader_Formating.Read(CTWLoader_Formating.DialogOpenPath());

            if (CTWLoader_Formating.GetType(ttt["Type"]) == CTWLoader_Formating.TypeData.Bestyary)
            {
                comboBox24.Text = ttt["Name"];
                textBox17.Text = ttt["Name1"];
                richTextBox2.Text = ttt["Desc"];
            }
        }
    }
}