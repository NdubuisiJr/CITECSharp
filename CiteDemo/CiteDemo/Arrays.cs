using System;

namespace CiteDemo {
    class Arrays {
        static void ain() {
            // One dimensional - []
            //int[] intArray;
            int[] intArray = new int[6];

            bool[] logics = new bool[] { true, false, true, false };

            // multi - dimension
            double[,] twoDDouble = new double[5, 6];
            int[,,] threeDInt = new int[2, 6, 7];

            // Adding a value to an array
            string[] DaysOfTheWeek = new string[7];
            DaysOfTheWeek[0] = "Sunday";
            DaysOfTheWeek[1] = "Monday";
            DaysOfTheWeek[2] = "Tuesday";
            DaysOfTheWeek[3] = "Wednesday";
            DaysOfTheWeek[4] = "Thursday";
            DaysOfTheWeek[5] = "Friday";
            DaysOfTheWeek[6] = "Saturday";

            Console.WriteLine(DaysOfTheWeek[4]);

            foreach (string day in DaysOfTheWeek) {
                Console.WriteLine(day);
            }

            Console.WriteLine("======================================");

            int counter = 0;
            while (counter < DaysOfTheWeek.Length) {
                Console.WriteLine(DaysOfTheWeek[counter]);
                counter++;
            }

            // Add to 2D and Read from 2d
            int[,] int2D = new int[3, 4];
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.Write("int2D[{0},{1}]=",i,j);
                    string input = Console.ReadLine();
                    int2D[i, j] = int.Parse(input);
                }
            }

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.WriteLine("At i = {0} and j = {1} we have {2}", i, j, int2D[i, j]);
                }
            }


            Console.ReadLine();
        }
    }
}
