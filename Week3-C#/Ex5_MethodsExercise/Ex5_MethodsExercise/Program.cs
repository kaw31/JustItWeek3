using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 0;
            char sign = ' ';
            double result = 0;
             

            Console.WriteLine("Create your method");
            Console.WriteLine("Please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your math sign (+ , - , * , /)");
            sign = Convert.ToChar(Console.ReadLine());

            switch(sign)
            {
                case '+':
                    result = Add(num1, num2);
                    Console.WriteLine("Addition is " + result);
                    break;
                case '-':
                    result = Subtract(num1, num2);
                    Console.WriteLine("Subtraction is " + result);
                    break;
                case '*':
                    result = Multiply(num1, num2);
                    Console.WriteLine("Multiplication is " + result);
                    break;
                case '/':
                    result = Divide(num1, num2);
                    Console.WriteLine("Division is " + result);
                    break;
            }

        }

        static double Add(double number1, double number2)
        {
            double answer = 0;

            answer = number1 + number2;

            return answer;
        }

        static double Subtract(double number1, double number2)
        {
            double answer = 0;

            answer = number1 - number2;

            return answer;
        }

        static double Multiply(double number1, double number2)
        {
            double answer = 0;

            answer = number1 * number2;

            return answer;
        }

        static double Divide(double number1, double number2)
        {
            double answer = 0;

            answer = number1 / number2;

            return answer;
        }
    }
}
