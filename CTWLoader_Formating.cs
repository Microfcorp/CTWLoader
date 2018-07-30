using Ionic.Zip;
using System;
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

        public static string Read(string path)
        {
            return File.ReadAllText(path).Replace("/n","").Replace("/r", "");
        }
        public static void Save(string path, TypeData typedata, SortedList<string,string> data)
        {
            string tmp = typedata.ToString() + ";" + Environment.NewLine;
            foreach (var item in data)
            {
                tmp += item.Key + "=" + item.Value;
            }
        }
        public static TypeData GetType(string ReadData)
        {
            TypeData tmp = new TypeData();
            switch (ReadData.Split(';')[0])
            {
                case "Bestyary":
                    tmp = TypeData.Bestyary;
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
    }
}
