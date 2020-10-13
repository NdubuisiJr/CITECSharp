using System;

namespace CiteDemo {
    class Exercise3 {
        static void ain() {
            // read three values and print their sum
            // inputed as strings
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            string thirdValue = Console.ReadLine();
            // convert to int
            int first = int.Parse(firstValue);
            int second = int.Parse(secondValue);
            int third = int.Parse(thirdValue);
            // get sum and print
            int sum = first + second + third;
            Console.WriteLine("The sum is {0}", sum);

            Console.ReadLine();
        }
    }
}
