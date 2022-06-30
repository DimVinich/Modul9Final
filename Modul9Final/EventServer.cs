using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9Final
{
    public class EventServer
    {
        public delegate void ArrRedyToSort(ref string[] aArr, int fSort);
        public event ArrRedyToSort arrToSort;

        public void eventServer(ref string[] aArr, int fSort)
        {
            arrToSort(ref aArr, fSort);
        }
    }
}
