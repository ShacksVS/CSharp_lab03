using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lab02.Tools.Exceptions
{
    class BadName : Exception
    {
        public BadName()
        {
        }

        public BadName(string name)
            : base(String.Format("Invalid name"))
        {
        }

    }
 }
