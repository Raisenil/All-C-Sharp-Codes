using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_7
{
    interface BasicCalculatorInterface
    {
        int sum(int x, int y);
        int sub(int x, int y);
        int multiplication(int x, int y);
        int division(int x, int y);
    }
    class BasicCalc : BasicCalculatorInterface
    {
        int result;
        public int sum(int number1, int number2)
        {
            Console.WriteLine("Sum : " + number1 + " With : " + number2);
            result = number1 + number2;
            return result;
        }
        public int sub(int number1, int number2)
        {
            Console.WriteLine("Sub : " + number1 + " By : " + number2);
            result = number1 - number2;
            return result;
        }
        public int multiplication(int number1, int number2)
        {
            Console.WriteLine("Mul : " + number1 + " With : " + number2);
            result = number1 * number2;
            return result;
        }
        public int division(int number1, int number2)
        {
            Console.WriteLine("Div : " + number1 + " & Divvisor : " + number2);
            result = number1 / number2;
            return result;
        }
        public void printStates()
        {
            Console.WriteLine("Result : " + result);
        }
    }
}
