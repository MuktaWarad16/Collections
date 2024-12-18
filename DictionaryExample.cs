using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class DictionaryExample
    {
        public static void DictExm()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "mukta");
            dict.Add(2, "anni");
            dict.Add(3, "bindu");

           
            foreach (KeyValuePair<int,string> kv in dict)
            {
                Console.WriteLine(kv);
            }
        }
    }
}
