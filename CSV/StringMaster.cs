using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTW_loader.CSV
{
    class StringMaster
    {
        public static string[] NotIntArray(string[] text, params int[] noting)
        {
           List<string> tmp = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if(!FindArray(noting, i))
                {
                    tmp.Add(text[i]);
                }
            }
            return tmp.ToArray();
        }
        public static bool FindArray(string[] array, string path)
        {
            bool tmp = false;
            foreach (var item in array)
            {
                if(item == path)
                {
                    tmp = true;
                }
            }
            return tmp;
        }
        public static bool FindArray(int[] array, int path)
        {
            bool tmp = false;
            foreach (var item in array)
            {
                if (item == path)
                {
                    tmp = true;
                }
            }
            return tmp;
        }
    }
}
