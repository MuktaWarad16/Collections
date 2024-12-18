using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class SortedListNonGeneric
    {
        public static void add()
        {
            SortedList st= new SortedList();
            st.Add(10, "blue");
            st.Add(5, "berries");

            foreach (DictionaryEntry d in st)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
        }
    }
}
