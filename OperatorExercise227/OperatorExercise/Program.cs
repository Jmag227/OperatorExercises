using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Div();
            var result = Math();
            Console.WriteLine(result);
        }

        public static void Div()
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine("if a = 2, and b = 4...");

            Console.WriteLine($"Then 17/4 is 4 remainder {remainder}");

        }

        public static double AreaOfACircle(double r)
        {
            double pi = 3.14;
            double answer = pi * r * r;
            return answer;        

        }

        public static double Math()
        {
            Console.WriteLine("Pick a radius of a circle.");
            var r = double.Parse(Console.ReadLine());
            return AreaOfACircle(r);

             
        }
    
    
    }




}
