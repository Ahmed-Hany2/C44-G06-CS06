using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        #region Question (1)
        public static void IncrementValue(int value)
        {
            value++;
        }
        public static void IncrementReference(ref int value)
        {
            value++;
        }
        #endregion

        #region Question (2)
        public static void ModifyStringVal(string str)
        {
            str = "Ali"; 
        }
        public static void ModifyStringRef(ref string str)
        {
            str = "Sayed";
        }
        #endregion
        static void Main(string[] args)
        {
            #region Question (1)
            //1 - Explain the difference between passing(Value type parameters)
            //by value and by reference then write a suitable c# example.
            // (Answer) => => => =>
            // Passing by value means that a copy of the value is passed to the method, can't modify the original value.
            // Passing by reference means that a reference to the original variable is passed, allowing the method to modify the original value.
            int num1 = 10;
            int num2 = 20;
            IncrementValue(num1);
            IncrementReference(ref num2);
            Console.WriteLine($"After Increment(Passing by value): {num1}");
            Console.WriteLine($"After Increment(Passing by reference): {num2}");
            #endregion

            #region Question (2)
            //2 - Explain the difference between passing(Reference type
            //parameters) by value and by reference then write a suitable c#
            //example.

            // (Answer) => => => =>
            // Passing a reference type by value means that a copy of the reference is passed, allowing the method to modify the original object but not the reference itself.
            // Passing a reference type by reference means that the method can modify both the object and the reference itself.
            string name1 = "Ahmed";
            string name2 = "Omar";
            ModifyStringVal(name1);
            ModifyStringRef(ref name2);
            Console.WriteLine($"Ahmed After ModifyString(Passing by value): {name1}");
            Console.WriteLine($"Omar After ModifyString(Passing by reference): {name2}");

            #endregion

            #region Question (3)
            //3 - Write a c# Function that accept 4 parameters from user and
            //return result of summation and subtracting of two numbers
            int x=10, y=20, sumResult, subResult;
            static void Calculate(int a, int b, out int sum, out int sub)
            {
                sum = a + b;
                sub = a - b;
            }
            Calculate(x, y, out sumResult, out subResult);
            Console.WriteLine($"Sum of {x} and {y} is: {sumResult}");
            Console.WriteLine($"Subtraction of {x} and {y} is: {subResult}");
            #endregion

            #region Question (4)
            //4 - Write a program in C# Sharp to create a function to calculate the sum of the
            //individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7
            int SumOfDigits(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10; 
                    number /= 10;       
                }
                return sum;
            }
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine() ?? "0");
            int sumOfDigits = SumOfDigits(number);
            Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigits}");
            #endregion

            #region Question (5)
            //5 - Create a function named "IsPrime", which receives an integer number
            //and retuns true if it is prime, or false if it is not:
            static bool IsPrime(int num)
            {
                if (num <= 1) return false;
                int i = num-1;
                int sum = 0;
                while(i > 1)
                {
                    if(num % i == 0)
                        sum++;
                    i--;
                }
                return sum == 0;

            }
            Console.Write("Enter a number to check if it's prime: ");
            int primeNumber = int.Parse(Console.ReadLine() ?? "0");
            bool isPrime = IsPrime(primeNumber);
            if (isPrime)
            {
                Console.WriteLine($"{primeNumber} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{primeNumber} is not a prime number.");
            }
            #endregion

            #region Question (6)
            //6 - Create a function named MinMaxArray, to return the minimum and
            //maximum values stored in an array, using reference parameters
            static void MinMaxArray(int[] array ,out int min, out int max)
            {
                min = array[0];
                max = array[0];
                for ( int i=0; i<array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
            }
            int [] numbers = { 3, 5, 1, 8, 2 };
            int minValue, maxValue;
            MinMaxArray(numbers, out minValue, out maxValue);
            Console.WriteLine($"Minimum value in the array: {minValue}");
            Console.WriteLine($"Maximum value in the array: {maxValue}");
            #endregion

            #region Question (7)
            //7 - Create function to calculate the factorial of the number specified as parameter
            static int Factorial(int num)
            {
                int sum = 1;
                if (num < 0)
                {
                    return -1; 
                }
                else if (num == 0 || num == 1)
                    return 1;
                else
                {
                    for (int i = 1; i <= num; i++)
                        sum *= i;  
                    return sum;
                }
            }
            Console.Write("Enter a number to calculate its factorial: ");
            int factorialNumber = int.Parse(Console.ReadLine() ?? "0");
            int factorialResult = Factorial(factorialNumber);
            if (factorialResult == -1)
                Console.WriteLine("Factorial is not defined for negative numbers.");
            else
                Console.WriteLine($"The factorial of {factorialNumber} is: {factorialResult}");
            #endregion
        }
    }
}
