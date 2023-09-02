using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidirectional_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List l = new List(2);
            l.add(3);
            l.add(4);
            l.add(5);
            l.add(6);
            l.remove();
            l.add(7);

            l.display();
        }

    }
}
