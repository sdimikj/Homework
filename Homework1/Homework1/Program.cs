using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1
    {
        class Program
        {
            static void Main(string[] args)
            {

                // Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.

                int firstNumber;
                int secondNumber;
                string operation;
                int result;

                Console.WriteLine("Enter your first number here:");

                firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second number here:");

                secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your operation here:");

                operation = Console.ReadLine();

                if (operation == "+")
                {

                    result = firstNumber + secondNumber;
                    Console.WriteLine(result);

                }

                else if (operation == "-")
                {

                    result = firstNumber - secondNumber;
                    Console.WriteLine(result);
                }

                else if (operation == "*")
                {

                    result = firstNumber * secondNumber;
                    Console.WriteLine(result);
                }

                else if (operation == "/")
                {

                    result = firstNumber / secondNumber;
                    Console.WriteLine(result);
                }

                Console.ReadLine();




            }

        }
    }



