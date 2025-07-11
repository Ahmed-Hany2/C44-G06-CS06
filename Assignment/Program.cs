using System.ComponentModel;

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
        }
    }
}
