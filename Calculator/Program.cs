using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            bool quit = true;
            string stop = "";
            int numThree = 0;
                        

            while(quit == true)
            {

                Console.WriteLine("Please input your equation.\nYour choice of operations are *, /, +, -.");
                int numOne = Convert.ToInt32(Console.ReadLine());
                string operation = Console.ReadLine();
                int numTwo = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();

                if (operation == "+")
                {
                   numThree = Addition(numOne, numTwo);

                }

                else if (operation == "-")
                {
                    numThree = Subtraction(numOne, numTwo);
                }

                else if( operation == "*")
                {
                    numThree = Multiplication(numOne, numTwo);
                }

                else if(operation == "/")
                {
                    numThree = Division(numOne, numTwo);
                }

                //displays sum of equation
                Console.WriteLine(numThree);

                Console.WriteLine("If you wish to exit\nthe application type yes\nif no, type no");
                stop = Console.ReadLine();

                if (stop == "yes" || stop == "Yes")
                {
                    Quit();
                }
                else
                {
                    quit = true;
                }
               

            }

            

            //Addition function;
            int Addition(int lhs, int rhs)
            {
                int sum = lhs + rhs;
                return sum;
            }

            //Subtraction function;
            int Subtraction(int lhs, int rhs)
            {
                int sum = lhs - rhs;
                return sum;
            }

            //Multiplication function;
            int Multiplication(int lhs, int rhs)
            {
                int sum = lhs * rhs;
                return sum;
            }

            //Division functioin;
            int Division(int lhs, int rhs)
            {
                int sum = lhs / rhs;
                return sum;
            }
            
            //Quit program functioin;
            bool Quit()
            {
                quit = false;
                return quit;
            }
        }       

    }
}
