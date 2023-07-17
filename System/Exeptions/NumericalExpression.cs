using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_work.Exeptions
{
    class NumericalExpression : Exception
    {
        public NumericalExpression()
        {

        }

        public NumericalExpression(string message)
        : base(message)
        {
        }

        public NumericalExpression(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
