using System;

namespace CiteDemo {
    class ConditionalIF {
        static void Min() {
            // If-statement
            string name = "Jon Snow";
            if (name.Length < 10) {
                Console.WriteLine("This block was executed");
                Console.WriteLine(name);
            }


            // If-Else statement
            if (2 < 3) {
                // scope
                if (3 < 4) {
                    Console.WriteLine("three is less than four");//1
                }
                Console.WriteLine("two is greater than three");//2
            }
            else {
                Console.WriteLine("two is not greater than three");//3
            }

            // Sequence of If-ElseIf-Else statement
            int value = 3;
            if (value == 1) {
                Console.WriteLine("One");
            }
            else if (value == 2) {
                Console.WriteLine("Two");
            }
            else if (value == 3) {
                Console.WriteLine("Three");
            }
            else if (value == 4) {
                Console.WriteLine("Four");
            }
            else {
                Console.WriteLine("I don't know");
            }

            int variable=4;

            switch (variable) {
                case 1: {
                        Console.WriteLine("It is one");
                        break;
                    }
                case 2: {
                        Console.WriteLine("It is two");
                        break;
                    }
                case 3: {
                        Console.WriteLine("It is three");
                        break;
                    }
                case 4: {
                        Console.WriteLine("It is four");
                        break;
                    }
                default: {
                        Console.WriteLine("No case matched");
                        break;
                    }
            }


            Console.WriteLine("The program has ended");//4
            Console.ReadLine();
        }
    }
}
