using System;

namespace CiteDemo {
    class TypeConversion {
        static void ain() {
            // Type conversion

            
            string number = "100";
            // Parse
            int intNumber = int.Parse(number);
            double doubleNumber = double.Parse(number);
            float floatNumber = float.Parse(number);

            // TryParse
            bool result;
            bool willConvert = bool.TryParse(number, out result);

            string num = "123.232";
            float convertedNum;
            float intNum = float.TryParse(num, out convertedNum) ? convertedNum : 0;

            // Round off
            double result1 = Math.Round(intNum,2);

            Console.WriteLine(intNumber);
            Console.WriteLine(result);
            Console.WriteLine(intNum);

            Console.WriteLine(result1);
            double result2;

            // Expression
            result2 = 23 + 3 + (intNum * result1); // Arithmetic expression
            bool result3 = !(true || false) && 3 > 4; // Logical expression

            // Area of rectangle 
            double height = 23.3;
            double width = 10.2;
            double area = width * height; // Expression to determine the area of a rectangle

            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(area);
            Console.WriteLine(width * height);

            Console.ReadLine();
        }
    }
}
