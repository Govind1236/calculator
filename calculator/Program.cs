using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            double num1 = 0;
            double result = 0;
            Console.WriteLine("Enter First number: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t+ :Add");
            Console.WriteLine("\t- :Sub");
            Console.WriteLine("\t* :Multiply");
            Console.WriteLine("\t/ :Divide");
            Console.WriteLine("\t% :Modulus");
            Console.Write("Choose Option: ");
            Console.ReadLine();
            switch(Console.ReadLine())
            { 
                case "+":
                    result = num + num1;
                    Console.WriteLine($"Your result: {num} + {num1} = " + result);
                    break;
                case "-":
                    result = num - num1; 
                    Console.WriteLine($"Your result: {num} - {num1} = " + result);
                    break;
                case "*":
                    result = num * num1;
                    Console.WriteLine($"Your result: {num} * {num1} = " + result);
                    break;
                case "/":
                    result = num / num1;
                    Console.WriteLine($"Your result: {num} / {num1} = " + result);
                    break;
                    case "%":
                        result = num % num1;
                    Console.WriteLine($"Your result: {num} % {num1} =" + result);
                    break;

                default:
                    Console.WriteLine("Thats not a correct symbol");
                    break;
            }
            Console.ReadKey();
            }
        }
    }
