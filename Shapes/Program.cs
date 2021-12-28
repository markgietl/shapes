using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            string tryAgain = null;
            do {
                
                Console.WriteLine("1. Create Circle");
                Console.WriteLine("2. Create Square"); 
                string answer = Console.ReadLine();
                Circle myCircle = null;
                Square mySquare = null;
                
                switch (answer)
                {
                    case "1":
                        {
                            myCircle = new Circle(10);
                            Console.WriteLine("Circle");
                            break;
                        }
                    case "2":
                        {
                            mySquare = new Square(10,10);    
                            Console.WriteLine("Square");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Incorrect input.");
                            break;
                        }
                }
                if (myCircle != null)
                {
                    Console.WriteLine($"The area of the circle is {myCircle.Area()} ");
                }
                if (mySquare != null)
                {
                    Console.WriteLine($"The area of the square is {mySquare.Area()} ");
                }
                Console.WriteLine("Press Y to try again.");
                tryAgain = (string)Console.ReadLine();
            } while (tryAgain == "Y" || tryAgain == "y");
        }
    }
}
