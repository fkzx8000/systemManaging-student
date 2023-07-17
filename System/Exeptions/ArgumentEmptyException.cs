using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_work.Exeptions
{
    class ArgumentEmptyException : Exception
    {
        public ArgumentEmptyException()
        {

        }

        public ArgumentEmptyException(string message)
        : base(message)
        {
        }

        public ArgumentEmptyException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
