/*
  Author: Ndubuisi Jr chukuigwe
  Aim: To Demo simple built in libraries 
 */
using System;
using CiteDemo.UserDefined;
using System.Collections.Generic;

namespace CiteDemo {

    class Program {
        static void Main() {
            Dog bruno = new Dog("German Shephard");// bruno is an object of the dog class
            bruno.Feed(5);
            bruno.Starve(2);
            List<int> state = bruno.ShowTeeth();

            Console.WriteLine("Bruno's wickedness is {0} and it's hunger level is {1}", state[0], state[1]);

            Dog bingo = new Dog("Bull Dog");
            bingo.Age = 5;
            int ageOfTheDog = bingo.Age;
            //bingo.Color = "Dark-Brown";
            Console.WriteLine(ageOfTheDog);
            Console.WriteLine(bingo.Color);

            Console.WriteLine(bruno.Breed);
            Console.WriteLine(bingo.Breed);
            Console.ReadLine();           
        }
    }
}
