using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CTW_loader.GameFile
{
    class GameFile
    {
        public enum TypeFile : byte
        {
            NotFound = 0x00,
            MainPak = 0xBC,
            Unzip = 0xFF
        }

        public static TypeFile GetTypeFile(string path)
        {
            if (!Helpers.IsGameFile(path, "data/world.xml")) return TypeFile.NotFound;
            if (Helpers.IsGameFile(path)) return TypeFile.MainPak;
            return TypeFile.Unzip;
        }

        public static string TypeFileToString(TypeFile tp)
        {
            if (tp == TypeFile.Unzip) return "Unzip";
            if (tp == TypeFile.MainPak) return "MainPak";
            return "NotFound";
        }
    }
}
