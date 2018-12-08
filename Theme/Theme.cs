using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTW_loader.Theme
{
    class Theme
    {
        private Theme(Color c, string N)
        {
            MainColor = c;
            Name = N;
            Controls = new List<Control>();
        }

        private Color MainColor = Color.Transparent;
        private string Name = "";
        List<Control> Controls = new List<Control>();

        public Color GetMainColor
        {
            get { return MainColor; }
        }
        public string GetName
        {
            get { return Name; }
        }

        public static Theme NewYearTheme()
        {
            Theme tmp = new Theme(Color.Aqua, "NewYear");
            return tmp;
        }
    }
}
