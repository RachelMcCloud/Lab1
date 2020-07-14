using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            string goAgain;
            do
            {
                Console.Write("Please enter width (in feet): ");
                string width = Console.ReadLine();
                Console.Write("Please enter length (in feet): ");
                string length = Console.ReadLine();
                double perimeter = (2 * double.Parse(width)) + (2 * double.Parse(length));
                double area = double.Parse(width) * double.Parse(length);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("\no");
                Console.WriteLine("Would you like to continue? yes or no");
                goAgain = Console.ReadLine().ToLower();
                Console.WriteLine("\no");
            } while (goAgain == "yes");
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
        
   
