using System;

namespace CiteDemo {
    class Exercise5 {
        static void Main() {
            // Enter input as string
            Console.WriteLine("Enter a");
            string aInput = Console.ReadLine();

            Console.WriteLine("Enter b");
            string bInput = Console.ReadLine();

            Console.WriteLine("Enter c");
            string cInput = Console.ReadLine();

            // Convert to doubles
            double a = double.Parse(aInput);
            double b = double.Parse(bInput);
            double c = double.Parse(cInput);

            // calculate D
            double d = Math.Pow(b, 2) - (4 * a * c);

            if (d > 0) {
                // real roots
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Root1 = {0} and Root2 = {1}", x1, x2);
            }
            else if (d == 0) {
                // real equal roots
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The equal root is {0}", x1);
            }
            else {
                // imaginary
                Console.WriteLine("No real root");
            }

            Console.ReadLine();
        }
    }
}
