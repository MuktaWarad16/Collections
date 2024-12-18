using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class StackGeneric
    {
        public static void stackexmp()
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(0);
            stk.Push(1);
            stk.Push(2);

            foreach (var item in stk)
            {
                Console.WriteLine(item);

            }
           
        }
    }
}
