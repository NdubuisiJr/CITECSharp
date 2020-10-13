using System;
namespace CiteDemo {
    class Variables {
        static void ain() {
            // Declearing a method
            string name;

            int score = 100;
            int Age = score;
            
            int age = 34;

            const double pi=3.142;
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            // Boolean - True or False
            const bool isTall = true;
            bool isShort = false;

            Console.WriteLine(isTall);
            Console.WriteLine(isShort);

            char charValue = 'f';

            string myName = "Jon snow";

            Console.WriteLine(charValue);
            Console.WriteLine(myName);

            object objectValue;
            objectValue = charValue;
            objectValue = myName;
            objectValue = isShort;
            objectValue = age;

            DateTime Current = new DateTime();//DateTime.Now;// Instantiating
            Console.WriteLine(Current);

            age = 23;
            Console.WriteLine("This is my age");
            Console.WriteLine(Age);
            Console.WriteLine("This is the value of Pi");
            Console.WriteLine(pi);

            Console.ReadLine();
        }
    }
}
