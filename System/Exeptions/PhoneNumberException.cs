using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_work.Exeptions
{
    class PhoneNumberException : Exception
    {
        public PhoneNumberException()
        {

        }

        public PhoneNumberException(string message)
        : base(message)
        {
        }

        public PhoneNumberException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
