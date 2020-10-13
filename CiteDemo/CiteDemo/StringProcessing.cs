using System;
namespace CiteDemo {
    class StringProcessing {
        static void ain() {
            // upper case to lower case
            string name = "Jon Snow";
            string nameUpper = name.ToUpper();
            string nameLower = name.ToLower();
            Console.WriteLine(nameUpper);
            Console.WriteLine(nameLower);

            // Searching for substring
            string greeting = "Hello World from CITE";
            int index = greeting.IndexOf("l",4);
            Console.WriteLine(index);

            // Extracting a substring
            int startPoint = greeting.IndexOf("CITE");
            string cite = greeting.Substring(startPoint, 4);
            Console.WriteLine(cite);
            Console.WriteLine(cite.ToLower());

            int firstSpace = greeting.IndexOf(" ");
            int secondSpace = greeting.IndexOf(" ", firstSpace + 1);
            int length = secondSpace - firstSpace;
            string secondWord = greeting.Substring(firstSpace + 1, length);
            Console.WriteLine(secondWord);

            // Splitting a string
            string[] words = greeting.Split(new string[] { " " }, StringSplitOptions.None);
            Console.WriteLine(words[0]);
            Console.WriteLine(words[1]);
            Console.WriteLine(words[2]);
            Console.WriteLine(words.Length);

            // Replacing a substring; greeting ="Hello World from CITE"
            string newString = greeting.Replace("CITE", "UNIPORT");
            Console.WriteLine(newString);

            // Triming a string
            string stringToTrim = "  Jon Snow  ";
            string trimmed = stringToTrim.Trim();
            Console.WriteLine(trimmed.Length);

            Console.ReadLine();
        }
    }
}
