//using System;
//using System.Collections.Generic;

//namespace Collections
//{
//    internal class Program
//    {
//        static void Main(string[] args)
        //{
            //StackExm.stackexmp();
            // DictionaryExample dct = new DictionaryExample();
            //QueueExm.exm();
            //ArrayListExample.ArrayListExm();
            //ListExample.ListExamp();
            //QueueNonGeneric.add();
            // StackNonGeneric.stackexmp();
            //DictionaryExample.DictExm();
            //HashTableExm.add();
            //SortedListNonGeneric.add();

            //Console.WriteLine("enter the number");
            //int[] num = {10,20,30};

            using System;
            using System.Collections.Generic;

class Program
        {
            static void Main()
            {
                // List of integers
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.WriteLine("Numbers divisible by 2:");

                // Iterate through the list and check divisibility
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine(number);
                    }
                }
            }
        }

    }
}
}
