using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_work.Exeptions
{
    class ArgumentAlphaException : Exception
    {
        public ArgumentAlphaException()
        {

        }

        public ArgumentAlphaException(string message)
        : base(message)
        {
        }

        public ArgumentAlphaException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
