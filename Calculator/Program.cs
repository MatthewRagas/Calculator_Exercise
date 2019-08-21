using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        int sum;
                

        static void Main(string[] args)
        {
            string quitCom = "";
            string action = "";
            bool quit = true;
            while ( quit == true)
            {

                Console.WriteLine("if you wish to quit press x.");
            }

            
        }

        int Addition(ref int firstNum , ref int secondNum)
        {
            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());
            sum = firstNum + secondNum;
            return sum;
        }

        int Subtraction (ref int firstNum, ref int secondNum)
        {
            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());

            sum = firstNum - secondNum;
            return sum;
        }

        int Division( ref int firstNum, ref int secondNum)
        {
            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());

            sum = firstNum / secondNum;
            return sum;
        }
       
        int Multiplication(ref int firstNum, ref int secondNum)
        {
            firstNum = Convert.ToInt32(Console.ReadLine());
            secondNum = Convert.ToInt32(Console.ReadLine());

            sum = firstNum * secondNum;
            return sum;
        }

        bool Quit(string quitCom)
        {
            if (quitCom == "")
            {
                return false;
            }    

            return true;
        }
    }
}
