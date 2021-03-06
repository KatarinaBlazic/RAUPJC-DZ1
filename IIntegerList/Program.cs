﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        public static void ListExample(IIntegerList listOfIntegers)
        {
            listOfIntegers.Add(1); // [1]
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            listOfIntegers.Remove(5); // [2 ,3 ,4]
            Console.WriteLine ( listOfIntegers.Count ); // 3
            Console.WriteLine ( listOfIntegers.Remove (100) ); // false
            listOfIntegers.Clear (); // []
            Console.WriteLine ( listOfIntegers.Count ); // 0
        }

    static void Main()
        {
            ListExample(new IntegerList(5));
            Console.ReadLine();
        }
    }

}
