using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_work.Exeptions
{
    class EmailException : Exception
    {
        public EmailException()
        {

        }

        public EmailException(string message)
        : base(message)
        {
        }

        public EmailException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
