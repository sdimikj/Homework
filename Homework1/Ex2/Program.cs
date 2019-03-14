using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            int firstNum;
            int secondNum;
            int thirdNum;
            int fourthNum;
            int result;

            Console.WriteLine("Enter your first number here:");

            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number here:");

            secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your third number here:");

            thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your fourth number here:");

            fourthNum = int.Parse(Console.ReadLine());



            result = (firstNum + secondNum + thirdNum + fourthNum) / 4;

            Console.WriteLine("The result is:" + result);

            Console.ReadLine();


        }
    }
}
