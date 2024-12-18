using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class HashTableExm
    {
        public static void add()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "hi");
            ht.Add(2, "hey");

            foreach(DictionaryEntry kv in ht)
            {
                Console.WriteLine( kv.Key +" "+kv.Value);
            }
        }
    }
}
