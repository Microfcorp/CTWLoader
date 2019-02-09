using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ionic.Zip;
using System.IO;

namespace CTW_loader.GameFile
{
    public class ThemeFiles
    {
        public class Writer
        {
            static private TMPCatalog tmp = null;
            /// <summary>
            /// Generating Zip Archive
            /// </summary>
            /// <param name="Path">Path to ZIP</param>
            /// <param name="Directory">Path to Directory to the arhived</param>
            /// <returns>Path</returns>
            public static string Write(string Path, string Directory)
            {
                using (ZipFile zip = new ZipFile(@Path))
                {
                    zip.AddDirectory(Directory);
                    zip.Save();
                }
                return Path;
            }
            /// <summary>
            /// Renaming Zip to Ctwtheme
            /// </summary>
            /// <param name="Path">Path to archive</param>
            /// <returns>New Path</returns>
            public static string ZIPtoTheme(string Path)
            {
                File.Move(Path, Path.Split('.')[Path.Split('.').Length - 2] + ".ctwtheme");
                return Path.Split('.')[Path.Split('.').Length - 2] + ".ctwtheme";
            }

            public static TMPCatalog Create(string Directory)
            {
                tmp = new TMPCatalog(Directory);
                return tmp;
            }

            public static TMPCatalog AddFiles(params string[] files)
            {
                tmp.files.AddRange(files);
                return tmp;
            }

            public static TMPCatalog AddConfig(string Config)
            { 
                tmp.Config = Config;
                return tmp;
            }

            public class TMPCatalog
            {
                internal TMPCatalog(string Directory) { this.Directory = Directory; }

                public string Directory
                {
                    get;
                    internal set;
                }
               
                internal List<String> files = new List<string>();

                public string Config
                {
                    get;
                    internal set;
                }

                public string[] Files
                {
                    get
                    {
                        return files.ToArray();
                    }
                }

                public string DoWork(bool DoArchived, bool DoRenaming)
                {
                    System.IO.Directory.CreateDirectory(Directory);
                    string returns = Directory;

                    foreach (var item in Files)
                    {
                        File.Copy(item, Directory + "\\"+ (new FileInfo(item)).Name, true);
                    }

                    File.WriteAllText(Directory + "\\config.cfg", Config);

                    if (DoArchived)
                    {
                        returns = ThemeFiles.Writer.Write(Environment.CurrentDirectory + "\\File.zip", Directory);
                        System.IO.Directory.Delete(Directory, true);
                        
                    }
                    if (DoArchived & DoRenaming)
                    {
                        returns = ThemeFiles.Writer.ZIPtoTheme(Environment.CurrentDirectory + "\\File.zip");
                    }

                    return returns;
                }
            }
        }
    }
}
