using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {

        public static void ListExample(IGenericList<int> listOfIntegers)
        {
            listOfIntegers.Add(1); // [1]
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            // listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4]
            listOfIntegers.Remove(3); // [3 ,4]
            Console.WriteLine(listOfIntegers.Count); // 2
            Console.WriteLine(listOfIntegers.Remove(100)); // false
            listOfIntegers.Clear(); // []
            Console.WriteLine(listOfIntegers.Count); // 0
        }

        static void Main()
        {
            ListExample(new GenericList<int>(5));

            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add(" Hello ");
            stringList.Add(" World ");
            stringList.Add("!");
          
            // foreach
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }
            // foreach without the syntax sugar
            IEnumerator<string> enumerator = stringList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string value = (string)enumerator.Current;
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
