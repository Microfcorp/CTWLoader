using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ionic.Zip;
using System.IO;
using System.Drawing;

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
            /// <summary>
            /// Catalog from TMP Files
            /// </summary>
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

                public string DoWork(bool DoArchived, bool DoRenaming, string filename)
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
                        returns = ThemeFiles.Writer.Write(filename, Directory);
                        System.IO.Directory.Delete(Directory, true);
                        
                    }
                    if (DoArchived & DoRenaming)
                    {
                        returns = ThemeFiles.Writer.ZIPtoTheme(filename);
                    }

                    return returns;
                }
            }
        }

        public class Reader
        {
            static private TMPCatalog tmp = null;
            /// <summary>
            /// Read Zip Archive
            /// </summary>
            /// <param name="Path">Path to ZIP</param>
            /// <param name="Directory">Path to Directory to the arhived</param>
            /// <returns>Path</returns>
            public static TMPCatalog Read(string Path, string Directory)
            {
                using (ZipFile zip = new ZipFile(@Path))
                {
                    System.IO.Directory.CreateDirectory(Directory);
                    zip.ExtractAll(Directory);
                    tmp = new TMPCatalog(Directory);
                }
                return tmp;
            }
            /*/// <summary>
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
            }*/

                /// <summary>
                /// Catalog from TMP Files
                /// </summary>
            public class TMPCatalog
            {
                /// <summary>
                /// Crated
                /// </summary>
                /// <param name="Directory">Path to directory</param>
                internal TMPCatalog(string Directory)
                {
                    this.Directory = Directory;
                    Confi = Theme.Theme.LoadFile(Directory + "\\config.cfg");
                }

                /// <summary>
                /// Main directory as temp files
                /// </summary>
                public string Directory
                {
                    get;
                    internal set;
                }

                /// <summary>
                /// Array as files
                /// </summary>
                private List<String> files = new List<string>();

                /// <summary>
                /// Config files
                /// </summary>
                private Theme.ThemeConfig Confi = null;

                /// <summary>
                /// Read Configuration
                /// </summary>
                public Theme.ThemeConfig Config
                {
                    get
                    {
                        return Confi;
                    }                    
                }

                /// <summary>
                /// Get anamation
                /// </summary>
                public Image Animations
                {
                    get
                    {
                        return Config.Anim.Image;
                    }
                }

                /// <summary>
                /// Get anamation
                /// </summary>
                public string AnimationsPath
                {
                    get
                    {
                        return Config.Anim.Path;
                    }
                }

                /// <summary>
                /// Get backgroung config files
                /// </summary>
                public CTW_loader.Theme.Background[] Backgrounds
                {
                    get
                    {
                        return Config.Backgrounds;
                    }
                }

                /// <summary>
                /// Get backgroung images from config files
                /// </summary>
                public string[] ImagesPathsFormConfig
                {
                    get
                    {
                        return Config.Backgrounds.Select(tmp => tmp.ImagePath).ToArray();
                    }
                }

                /// <summary>
                /// Get backgroung images from config files
                /// </summary>
                public Image[] ImagesFormConfig
                {
                    get
                    {
                        return Config.Backgrounds.Select(tmp => tmp.Image).ToArray();
                    }
                }

                /// <summary>
                /// Get all images in temp directory
                /// </summary>
                public Image[] Images
                {
                    get
                    {
                        return System.IO.Directory.GetFiles(Directory, "*.bmp|*.jpg|*.tif|*.jpeg|*.ico|*.gif").Select(tmp => Image.FromFile(tmp)).ToArray();
                    }
                }

                /// <summary>
                /// All files in temp directory
                /// </summary>
                public string[] Files
                {
                    get
                    {
                        return System.IO.Directory.GetFiles(Directory).ToArray();
                    }
                }
            }
        }
    }
}
