using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class ListExample
    {
        public static void ListExamp()
        {
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);

            foreach (int element in lst)
            {
                Console.WriteLine(element);
            }

        }

    }
}
