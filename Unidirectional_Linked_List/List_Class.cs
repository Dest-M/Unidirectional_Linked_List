using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidirectional_Linked_List
{
    internal class List
    {
        int val;
        List next;
        public List(int val)
        {
            this.val = val;
        }
        public void add(int val)
        {
            List tempNext = this;
            while (tempNext.next != null)
            {
                tempNext = tempNext.next;
            }
            if (tempNext.next == null)
            {
                tempNext.next = new List(val);
            }

        }
        public void remove()
        {
            List tempNext = this;
            List prev = tempNext;
            while (tempNext.next != null)
            {
                prev = tempNext;
                if (tempNext.next != null)
                {
                    tempNext = tempNext.next;
                }
            }
            prev.next = null;

        }
        public void display()
        {
            List virnext = this;
            while (virnext != null)
            {
                Console.Write(Convert.ToString(virnext.val) + " ");
                virnext = virnext.next;
            }
        }
    }
}


