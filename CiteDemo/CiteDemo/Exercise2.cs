using System;

namespace CiteDemo {
    class Exercise2 {
        static void ain() {
            // Solve here
            //1. Even - Odd
            int number = 233;
            string message = number % 2 == 0 ? "even" : "odd";
            Console.WriteLine(message);

            //2. Perimeter and Area
            double length = 12.123;
            double width = 123.123;

            double perimeter = 2 * (length + width);
            double area = length * width;

            Console.WriteLine("Perimeter = " + perimeter);
            Console.WriteLine("Area = " + area);

            // 3. Moon - Earth Gravity
            const double gravity = 9.79;
            const double percent = 0.17;
            double mass = 220;
            double weight = percent * gravity * mass; 
            Console.WriteLine("The weight of the man is "+ weight);

            // 4. Area of a trapezoid
            double a = 23;
            double b = 23.2;
            double h = 21;
            double areaOfTrapezoid = ((a + b) / 2) * h;
            Console.WriteLine("The area of the trapezoid is " + areaOfTrapezoid);

            // 5. Point Within a circle
            double x = 3.3;
            double y = 4.4;
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine(result);
            string messageResult = result > 5 ? "outside the circle" : "within the circle";
            Console.WriteLine(messageResult);

            Console.ReadLine();
        }
    }
}
