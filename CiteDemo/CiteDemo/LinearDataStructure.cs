using System;
using System.Collections.Generic;

namespace CiteDemo {
    class LinearDataStructure {
        static void Man() {
            // Dictionary - Key - Value
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(112, "Sunday");
            dictionary.Add(23, "Monday");
            string next = dictionary[112];
            Console.WriteLine(next);

            Dictionary<string, bool> stringBoolDictionary = new Dictionary<string, bool>();
            stringBoolDictionary.Add("isTall", true);
            stringBoolDictionary.Add("isShort", false);
            bool next1 = stringBoolDictionary["isTall"];
            Console.WriteLine(next1);

            Console.ReadLine();
        }

        static void QueueDemo() {
            // Enqueue to add an item
            Queue<string> daysOfTheWeek = new Queue<string>();
            daysOfTheWeek.Enqueue("Sunday");
            daysOfTheWeek.Enqueue("Monday");
            daysOfTheWeek.Enqueue("Tuesday");
            daysOfTheWeek.Enqueue("Wednesday");
            daysOfTheWeek.Enqueue("Thursday");
            daysOfTheWeek.Enqueue("Friday");
            daysOfTheWeek.Enqueue("Saturday");

            // Dequeue to read the item in front of the queue
            string next = daysOfTheWeek.Dequeue();
            Console.WriteLine(next);

            for (int i = 0; i < 6; i++) {
                Console.WriteLine(daysOfTheWeek.Dequeue());
            }
        }

        static void StackDemo() {
            // Push adds an item at the top of the stack
            Stack<string> daysOfTheWeek = new Stack<string>();
            daysOfTheWeek.Push("Saturday");
            daysOfTheWeek.Push("Friday");
            daysOfTheWeek.Push("Thursday");
            daysOfTheWeek.Push("Wednesday");
            daysOfTheWeek.Push("Tuesday");
            daysOfTheWeek.Push("Monday");
            daysOfTheWeek.Push("Sunday");

            // Pop reads the item at the top of stack
            string next = daysOfTheWeek.Pop();
            Console.WriteLine(next);
            string next1 = daysOfTheWeek.Pop();
            Console.WriteLine(next1);
        }

        static void HashSetDemo() {
            // Hashset
            HashSet<int> hashInt = new HashSet<int>();
            hashInt.Add(1);
            hashInt.Add(1);
            hashInt.Add(1);
            hashInt.Add(3);
            hashInt.Add(4);
            hashInt.Add(3);
            hashInt.Add(4);
            hashInt.Add(5);
            hashInt.Add(7);
            hashInt.Add(4);
            foreach (int item in hashInt) {
                Console.WriteLine(item);
            }
        }

        static void ListDemo() {
            // Add and Read Items from the list
            int[] intArray = new int[] { 12, 123, 123, 123, 123 };
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(23);
            intList.Add(34);
            intList.AddRange(intArray);

            Console.WriteLine(intList.Count);
            Console.WriteLine(intList[4]);

            foreach (int number in intList) {
                Console.WriteLine(number);
            }
            // Remove an item
            intList.Remove(34);
            intList.Remove(23);
            // Remove an index
            intList.RemoveAt(0);
            intList.RemoveAt(3);
            // Check 
            bool result = intList.Contains(123);
            Console.WriteLine(result);

            Console.WriteLine("===================================");
            for (int i = 0; i < intList.Count; i++) {
                Console.WriteLine(intList[i]);
            }
        }
    }
}
