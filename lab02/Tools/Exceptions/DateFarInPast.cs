using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lab02.Tools.Exceptions
{
    class DateFarInPast : Exception
    {
        public DateFarInPast()
        {
        }

        public DateFarInPast(int age)
            : base(String.Format("Come on, are u really that old: {0}?", age))
        {
        }
    }
}
