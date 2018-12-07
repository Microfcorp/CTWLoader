using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace CTW_loader.GameFile
{
    public class Helpers
    {
        public static bool IsGameFile(string path, string file)
        {
            if (File.Exists(path) & ZipFile.IsZipFile(path)) return true;
            else
            {
                path = path.Substring(0, path.Length - 8);
                if (File.Exists(path + "\\" + file)) return true;
            }
            return false;
        }
        public static bool IsGameFile(string path)
        {
            if (File.Exists(path) & ZipFile.IsZipFile(path)) return true;
            return false;
        }
        public static string GetPathDirectory(string path)
        {
            string tmp = "", tmp1 = "";
            string[] arr = path.Split('\\'), arr1 = new string[] { };

            foreach (var item in arr)
            {
                tmp1 += item + "/";
            }
            arr1 = tmp1.Split('/');

            for (int i = 0; i < arr1.Length - 2; i++)
            {
                tmp += arr1[i] + "/";
            }
            return tmp;
        }
    }   
}
