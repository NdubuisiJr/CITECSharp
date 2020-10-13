using System;

namespace CiteDemo {
    class InputOut {
        static void qain() {
            Console.Write('\a');
            // Read and ReadKey.
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("Char = {0}, key ={1},modifiers = {2}",
                keyInfo.KeyChar, keyInfo.Key, keyInfo.Modifiers);

            int value = Console.Read();
            Console.WriteLine("The key code is {0}", value);

            
            
            // Conversion and Read
            // Echo - program
            string input = Console.ReadLine();//whatever you read from the console is of type string
            Console.WriteLine(input);

            //Perimeter and Area - With inputs
            Console.WriteLine("Enter length");
            string lenthString = Console.ReadLine();
            Console.WriteLine("Enter Width");
            string widthString = Console.ReadLine();

            double length = double.Parse(lenthString);
            double width = double.Parse(widthString);

            double perimeter = 2 * (length + width);
            double area = length * width;

            Console.WriteLine("Perimeter = " + perimeter);
            Console.WriteLine("Area = " + area);

            Console.WriteLine("Perimeter = {0} and Area = {1}", perimeter,area);

            Console.Write("First"+"\n");
            Console.Write("Second");
            

            Console.ReadLine();
        }
    }
}
