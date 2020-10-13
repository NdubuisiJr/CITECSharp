using System;

namespace CiteDemo {
    class Operators {
        static void ain() {
            // Arithmetics operators
            int firstValue = 12;
            int secondValue = 24;
            int addResult = (firstValue + secondValue);
            Console.WriteLine(addResult);

            int intValue = 13;
            intValue = intValue + 1;//Hard way
            ++intValue;
            intValue++;

            intValue = intValue - 1;//Hard way
            --intValue;
            intValue--;

            int result = firstValue % secondValue;

            // Logical operators
            bool firstLogic = true;
            bool secondLogic = false;
            // short circuit
            Console.WriteLine(firstLogic && secondLogic);
            Console.WriteLine(firstLogic || secondLogic);

            //Full circuit
            Console.WriteLine(firstLogic & secondLogic);
            Console.WriteLine(firstLogic | secondLogic);


            
            Console.WriteLine(!firstLogic);
            Console.WriteLine(firstLogic ^ secondLogic);

            bool result1 = 2 < 3;

            Console.WriteLine(result1);

            object value = "name";
            string name = (string)value;

            int stringValue = sizeof(int);
            Console.WriteLine(stringValue);

            string message = 4 > 3 ? "Four is greater" : "two is not";
            Console.WriteLine(message);

            string person = "Jon snow";

            //person = null;

            string message1 = person ?? "Hello world";

            Console.WriteLine(message1);

            Console.ReadLine();
        }
    }
}
