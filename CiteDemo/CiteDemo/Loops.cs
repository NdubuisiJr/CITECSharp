using System;
using System.Threading;

namespace CiteDemo {
    class Loops {
        static void ain() {
            // While Loop - print 1 - 1000
            //WhileLoop();

            // For Loop - print 1 - 1000
            //Console.WriteLine("Enter the count you want");
            //string number = Console.ReadLine();
            //int num = int.Parse(number);
            //ForLoop(num);

            // Do - While Loop 1 - 1000;
            //DoWhileLoop();

            //string greeting = "Hello World from this side of the planet";
            //string[] words = greeting.Split(new string[] { " " }, StringSplitOptions.None);
            //foreach(string word in words) {
            //    Console.Beep();
            //    Console.WriteLine(word);
            //    Thread.Sleep(1000);
            //}
            //int count = 1;
            //while (true) {
            //    Console.WriteLine(count);
            //    if (count == 10) {
            //        break;
            //    }
            //    count++;
            //}

            //for (int i = 0; i < 10; i++) {
            //    for (int j = 0; j < 5; j++) {
            //        Console.WriteLine("i={0} and j={1}", i, j);
            //    }
            //}
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(7));
            Console.WriteLine(12 / 2332);
            Console.ReadLine();
        }

        static int Factorial(int number) {
            int result=1; 
            while (number>1) {
                result *= number;
                number--;
            }
            return result;
        }

        static void DoWhileLoop() {
            int counter = 1;
            do {
                Console.Beep();
                Console.WriteLine(counter);
                Thread.Sleep(1000);
                counter++;
            } while (counter <= 10);
        }

        static void ForLoop(int number) {
            for (int counter = 1; counter <= number; counter++) {
                Console.Beep();
                Console.WriteLine(counter);
                Thread.Sleep(1000);
            }
        }

        static void WhileLoop() {
            int counter = 1;
            while (counter <= 10) {
                counter++;
                if (counter == 2 || counter == 8) {
                    continue;
                }
                Console.Beep();
                Console.WriteLine(counter);
                
                Thread.Sleep(1000);
            }
        }
    }
}
