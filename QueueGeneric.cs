using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class QueueGeneric
    {
        public static void exm()
        {
            Queue<int> q=new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(20);

            foreach(var i in q)
            {
                Console.WriteLine(i);
            }
        }
    }
}
