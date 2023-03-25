using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_lab02.Tools.Exceptions
{
    class WrongEmail : Exception
    {

        public WrongEmail()
        {
        }

        public WrongEmail(string email)
            : base(String.Format("Invalid Email Address: {0}", email))
        {
        }
    }
}
