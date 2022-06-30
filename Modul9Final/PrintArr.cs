using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9Final
{
    public delegate void GoSortArr();

    public static class PrintArr
    {
        public static void PrintArrToConsol(string[] aArray)
        {

            foreach (var toPrint in aArray)
            {
                Console.WriteLine(toPrint);
            }
        }
    }
}
