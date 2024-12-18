using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class SortedListGeneric
    {
        public static void add()
        {
            SortedList<int, string> st = new SortedList<int, string>();
            st.Add(10, "blue");
            st.Add(5, "berries");

            foreach (KeyValuePair<int,string> d in st)
            {
                Console.WriteLine(d);
            }
        }
    }
}
