using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9Final
{
    public delegate void GoSortArr();

    public class PrintArr
    {
        public void PrintArrToConsol(string[] aArray, int fSort)
        {
            SortStrArr sortArr = new SortStrArr();
            sortArr.SortArr(fSort, ref aArray);

            foreach (var toPrint in aArray)
            {
                Console.WriteLine(toPrint);
            }
        }
    }
}
