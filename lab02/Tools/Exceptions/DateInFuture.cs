using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lab02.Tools.Exceptions
{
    class DateInFuture : Exception
    {
        public DateInFuture()
        {
        }

        public DateInFuture(int age)
            : base(String.Format("You aren't even born!"))
        {
        }
    }
}
