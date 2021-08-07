using System;

namespace Area_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;
            bool CalcAgain = true;

            while (CalcAgain)
            {
            
                Console.WriteLine("What shape would you like to calculate? Enter 'r' for a rectangle, 's' for a square, 't' for a triangle, or any other key for a circle");

                answer = Console.ReadLine();

                if(answer == "r")
                {
                    Console.WriteLine("Enter height of the rectangle");
                    float height = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter width of the rectangle");
                    float width = float.Parse(Console.ReadLine());

                    result = height * width;
                }

                else if(answer == "s")
                {
                    Console.WriteLine("Enter length of the square side");
                    float side = float.Parse(Console.ReadLine());

                    result = side * side;
                }
                else if(answer == "t")
                {
                    Console.WriteLine("Enter base length of the triangle");
                    float length = float.Parse(Console.ReadLine());

                    Console.WriteLine("Enter height of the triangle");
                    float height = float.Parse(Console.ReadLine());

                    result = ((height * length)/2);
                }
                else
                {
                    Console.WriteLine("Enter radius of circle");
                    float radius = float.Parse(Console.ReadLine());

                    result = (float)Math.PI * radius * radius;
                }

                
                Console.WriteLine("The result is " + result);

                Console.WriteLine("Calculate Again? Press (Y/N)");
                string loop = Console.ReadLine();
                if (loop == "Y")
                {
                    CalcAgain = true;
                }
                else if (loop == "N")
                {
                    CalcAgain = false;
                }
            }
            
        }
    }
}
