using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTW_loader.ComandArgs
{
    public class Parser
    {
        string[] args = null;
        public Parser(string[] args)
        {
            this.args = args;
        }

        public string FindParamsAndArgs(string Params, out bool Finds)
        {
            string ret = null;
            bool bol = false;
            for (int i = 0; i < args.Length; i++)
            {
                if(args[i] == Params)
                {
                    ret = args[i+1];
                    break;
                }
            }
            Finds = bol;
            return ret;
        }
        
        public bool FindParamsAndArgs(string Params, out string Finds)
        {
            string ret = null;
            bool bol = false;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == Params)
                {
                    ret = args[i + 1];
                    break;
                }
            }
            Finds = ret;
            return bol;
        }
        public bool FindParams(string Params)
        {
            bool bol = false;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == Params)
                {
                    bol = true;
                    break;
                }
            }
            return bol;
        }
    }
}
