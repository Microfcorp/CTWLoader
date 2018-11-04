using Ionic.Zip;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTW_loader
{
    class CTWLoader_Formating
    {
        public enum TypeData
        {
            Null=0,
            Bestyary=1,
            Craft=2,
            Skils=3,
        }
        public static string DialogOpenPath()
        {
            OpenFileDialog opg = new OpenFileDialog();
            opg.SupportMultiDottedExtensions = false;
            opg.Multiselect = false;
            opg.Title = "Открыть файл CTW сохранения";

            opg.Filter = "Файл данных CTWLoader (*.CTWLoader)|*.CTWLoader;";
            if (opg.ShowDialog() != DialogResult.OK) { return ""; };
            return opg.FileName;
        }

        public static string DialogSavePath()
        {
            SaveFileDialog opg = new SaveFileDialog();
            opg.SupportMultiDottedExtensions = false;
            opg.Title = "Сохранить файл CTW сохранения";

            opg.Filter = "Файл данных CTWLoader (*.CTWLoader)|*.CTWLoader;";
            if (opg.ShowDialog() != DialogResult.OK) { return ""; };
            return opg.FileName;
        }

        public static SortedList<string,string> Read(string path)
        {
            string ty = File.ReadAllText(path).Replace("\r", "");
            SortedList<string, string> tmp = new SortedList<string, string>();
            tmp.Add("Type", ty.Split(';')[0]);
            foreach (var item in ty.Split(';')[1].Split('\n'))
            {
                if(item.Split('=')[0] != "")
                 tmp.Add(item.Split('=')[0], item.Split('=')[1]);
            }
            
            return tmp;
        }
        public static void Save(string path, TypeData typedata, SortedList<string,string> data)
        {
            string tmp = typedata.ToString() + ";";
            foreach (var item in data)
            {
                tmp += item.Key + "=" + item.Value + "\n";
            }
            File.WriteAllText(path, tmp);
        }
        public static TypeData GetType(string ReadData)
        {
            TypeData tmp = new TypeData();
            switch (ReadData.Split(';')[0])
            {
                case "Bestyary":
                    tmp = TypeData.Bestyary;
                break;
                case "Craft":
                    tmp = TypeData.Craft;
                break;
                case "Skils":
                    tmp = TypeData.Skils;
                    break;
                default:
                    tmp = TypeData.Null;
                    break;

            }
            return tmp;
        }
        public static string GetData(string ReadData, string name)
        {
            string tmp = "";
            foreach (var item in ReadData.Split(';'))
            {
                if(item.Split('=')[0] == name)
                {
                    tmp = item.Split('=')[1];
                }
            }
            return tmp;
        }
        public class CTWLoader_ArrayParam
        {
            public SortedList<string, string> Param
            {
                get;
                internal set;
            }
            public CTWLoader_ArrayParam()
            {
                Param = new SortedList<string, string>();
            }

            public static CTWLoader_ArrayParam ComboboxParsing(ComboBox ComboBox)
            {
                CTWLoader_ArrayParam tmp = new CTWLoader_ArrayParam();               

                for (int i = 0; i < ComboBox.Items.Count; i++)
                {
                    tmp.Param.Add("Param" + i.ToString(), ComboBox.Items[i].ToString());
                }

                return tmp;
            }
        }       
    }
    public class CTWLoader_Array
    {
        private string Name = "";
        private SortedList<string, string> sr = new SortedList<string, string>();

        public string GetName
        {
            get { return Name; }
        }

        public string SetParams(string name, string value)
        {
            sr.Add(name, value);
            return sr[name];
        }

        public string GetParams(string name)
        {
            return sr[name];
        }

        public CTWLoader_Array(string Name)
        {
            this.Name = Name;
        }
        public CTWLoader_Array(string Name, string[] array)
        {
            this.Name = Name;
            for (int i = 0; i < array.Length; i++)
            {
                sr.Add(i.ToString(), array[i]);
            }
        }
        public CTWLoader_Array(string Name, SortedList<string, string> array)
        {
            this.Name = Name;
            for (int i = 0; i < array.Count; i++)
            {
                sr.Add(array.Keys[i], array.Values[i]);
            }
        }

        public CTWLoader_Array(string Name, string text, char separator, char separator1)
        {
            this.Name = Name;
            foreach (var item in text.Split(separator))
            {
                if(item.Split(separator1).Length > 1)
                    sr.Add(item.Split(separator1)[0], item.Split(separator1)[1]);
            }
        }

        public string ToString(char separator, char separator1)
        {
            string tmp = "";
            foreach (var item in sr)
            {
                tmp += item.Key + separator1.ToString() + item.Value + separator.ToString();
            }
            return tmp;
        }
    }
}
