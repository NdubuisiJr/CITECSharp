using System;
namespace CiteDemo {
    class Exercise4 {
        static void sain() {
            Console.WriteLine("Enter words separated by comma (,)");
            string words = Console.ReadLine();
            string[] splitted = words.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(splitted[0]);
            Console.WriteLine(splitted[1]);
            Console.WriteLine(splitted[2]);
            Console.WriteLine(splitted[3]);

            Console.ReadLine();
        }
    }
}
