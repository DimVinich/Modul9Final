using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9Final
{
    public class MyException : Exception
    {
        public MyException(string aMessage) : base(aMessage) { }
        public MyException() : base() { }
    }
}
