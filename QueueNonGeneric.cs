using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class QueueNonGeneric
    {
        public static void add()
        {
            Queue qq= new Queue();
            qq.Enqueue(1);
            qq.Enqueue("hi");

            foreach(var ele in qq)
            {
                Console.WriteLine( ele);
            }
        }
    }
}
