using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTW_loader.CSV
{
    class StringMaster
    {
        /// <summary>
        /// Исключение из массива ключей
        /// </summary>
        /// <param name="text">Массив</param>
        /// <param name="noting">Исключение</param>
        /// <returns></returns>
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
        /// <summary>
        /// Оставление в массива ключей
        /// </summary>
        /// <param name="text">Массив</param>
        /// <param name="noting">Не исключение</param>
        /// <returns></returns>
        public static string[] InIntArray(string[] text, params int[] noting)
        {
            List<string> tmp = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (FindArray(noting, i))
                {
                    tmp.Add(text[i]);
                }
            }
            return tmp.ToArray();
        }
        /// <summary>
        /// Поиск в массиве
        /// </summary>
        /// <param name="array"></param>
        /// <param name="path"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Массив в строку с разделителем
        /// </summary>
        /// <param name="Array">Массив</param>
        /// <param name="Sep">Разделитель</param>
        /// <returns>Строка с разделителями</returns>
        public static string ArrayToString(string[] Array, string Sep)
        {
            return String.Join(value: Array, separator: Sep);
        }
    }
}
