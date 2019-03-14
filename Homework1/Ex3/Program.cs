using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNum;
            int secondNum;
            int swap;

            Console.WriteLine("Enter your first number here:");

            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number here:");

            secondNum = int.Parse(Console.ReadLine());


            swap = firstNum;
            firstNum = secondNum;
            secondNum = swap;

            Console.WriteLine("After swapping:" + " " + firstNum + " " + secondNum);

            Console.ReadLine();

        }
    }
}
