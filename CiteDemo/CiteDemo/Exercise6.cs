using System;

namespace CiteDemo {
    class Exercise6 {
        static void Min() {

            int N = 15;
            int K = 4;
            int factN = Factorial(N);
            int factK = Factorial(K);
            int result = factN / factK;

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Factorial(int number) {
            int temp = 1;
            while (number > 1) {
                temp *= number;
                number--;
            }
            return temp;
        }

    }
}
