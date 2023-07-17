using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_work.Logic
{
    class Bucket
    {
        private readonly List<UserData> elements = new List<UserData>();

        private void add(UserData element)
        {
            elements.Add(element);
        }

        private List<UserData> getElements()
        {
            return elements;
        }
    }
}
