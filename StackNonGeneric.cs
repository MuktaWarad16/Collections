using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class StackNonGeneric
    {
        public static void stackexmp()
        {
            Stack stk= new Stack();
            stk.Push(0);
            stk.Push("hi");
            stk.Push(2.9);

            foreach (var item in stk)
            {
                Console.WriteLine(item);

            }

        }
    }
}
