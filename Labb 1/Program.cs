using System;

namespace Labb_1
{

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSettings(23,100);
            bool runProgram = true;
            while (runProgram)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(String.Format("{0," + (Console.WindowWidth - 52) + "}", "Cirkel"));
                Console.WriteLine();
                Circle circle5 = new Circle(5);
                Circle circle6 = new Circle(6);
                Console.WriteLine("Arean på en cirkel med radien 5cm är:                              " + circle5.getArea() + "cm^2");
                Console.WriteLine("Arean på en cirkel med radien 6cm är:                              " + circle6.getArea() + "cm^2");
                Console.WriteLine();
                Console.Write("Vänligen ange radien på en cirkel (cm): ");
                double userRadie = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(userRadie);
                Console.WriteLine();
                Console.WriteLine("Omkretsen på en cirkel med radien " + userRadie + "cm är:                          " + circle.getCircumference() + "cm");
                Console.WriteLine("Arean på en cirkel med radien " + userRadie + "cm är:                              " + circle.getArea() + "cm^2");
                Console.WriteLine("Volymen för en sfär med raiden " + userRadie + "cm är:                             " + circle.getVolume() + "cm^3");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(String.Format("{0," + (Console.WindowWidth - 52) + "}", "Triangel"));
                Console.WriteLine();
                Console.Write("Vänligen ange längden på första katetern (cm): ");
                double userKatet1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vänligen ange längden på den andra katetern (cm): ");
                double userKatet2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vänligen ange djupet på triangeln (cm): ");
                double userDepth = Convert.ToDouble(Console.ReadLine());

                Triangle triangle = new Triangle(userKatet1, userKatet2, userDepth);
                Console.WriteLine();
                Console.WriteLine("Omkretsen på en triangel med kateterna " + userKatet1 + "cm och " + userKatet2 + "cm är:             " + triangle.getCircumference() + "cm");
                Console.WriteLine("Arean på en triangel med kateterna " + userKatet1 + "cm och " + userKatet2 + "cm är:                 " + triangle.getArea() + "cm^2");
                Console.WriteLine("Volymen på en triangel med kateterna " + userKatet1 + "cm " + userKatet2 + "cm och djupet: " + userDepth + " cm är:  " + triangle.getVolume() + "cm^3");
                Console.WriteLine("Tryck enter för att köra programmet igen...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void ConsoleSettings(int height, int width)
        {

            Console.WindowHeight = height;
            Console.WindowWidth = width;
        }

    }


}
