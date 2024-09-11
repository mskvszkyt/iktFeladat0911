using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class StringExtension
    {
        public static bool isValid(this string str)
        {
            bool vege;
            while (str.Length != 0)
            {
                vege = false;
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == '(' && str[i + 1] == ')')
                    {
                        str = str.Substring(0, i) + str.Substring(i + 2);
                        vege = true;
                    }
                }
                if (!vege) return false;

            }
            return true;
        }
    }
}
