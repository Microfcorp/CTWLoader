using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTW_loader.Perioding
{
    class Period
    {
        public static int Value
        {
            get
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey helloKey = currentUserKey.OpenSubKey("CTWLoader");
                if (helloKey != null & helloKey.GetValue("CurMax") != null)
                {
                    string login = helloKey.GetValue("CurMax").ToString();
                    helloKey.Close();

                    return Convert.ToInt32(login);
                }
                return 10;
            }
        }
        public static DateTime Time
        {
            get
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                RegistryKey helloKey = currentUserKey.OpenSubKey("CTWLoader");
                if (helloKey != null & helloKey.GetValue("Dat") != null)
                {
                    string login = helloKey.GetValue("Dat").ToString();
                    helloKey.Close();

                    return DateTime.Parse(login);
                }
                return DateTime.Now;
            }
        }
        public static int SetValue(int value)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.CreateSubKey("CTWLoader");
            helloKey.SetValue("CurMax", value);
            helloKey.SetValue("Dat", DateTime.Now);
            helloKey.Close();

            return value;
        }
    }
}
