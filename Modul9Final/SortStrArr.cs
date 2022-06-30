using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9Final
{
    public class SortStrArr
    {
        protected static bool NeedChange(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
        protected static bool NeedChangeDesc(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return true;
            }
            return false;
        }

        public void SortAsc(ref string[] arrstr)
        {
            for (int i = 0; i < arrstr.Length - 1; i++)
            {
                for (int j = 0; j < arrstr.Length - 1; j++)
                {
                    if (NeedChange(arrstr[j], arrstr[j + 1]))

                    {
                        string temp = arrstr[j];
                        arrstr[j] = arrstr[j + 1];
                        arrstr[j + 1] = temp;
                    }
                }
            }
        }


        public void SortDesc(ref string[] arrstr)
        {
            for (int i = 0; i < arrstr.Length - 1; i++)
            {
                for (int j = 0; j < arrstr.Length - 1; j++)
                {
                    if (NeedChangeDesc(arrstr[j], arrstr[j + 1]))

                    {
                        string temp = arrstr[j];
                        arrstr[j] = arrstr[j + 1];
                        arrstr[j + 1] = temp;
                    }
                }
            }
        }

        public void SortArr(ref string[] arrstr, int MetodSort)
        {
            if (MetodSort == 1)
            {
                SortAsc(ref arrstr);
            }
            if (MetodSort == 2)
            {
                SortDesc(ref arrstr);
            }
        }
    }
}
