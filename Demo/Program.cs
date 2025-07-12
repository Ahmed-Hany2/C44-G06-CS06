namespace Demo
{
    internal class Program
    {
        #region Functions (prototype)
        public static void PrintShape1()
        {
            Console.WriteLine("$_");
        }
        public static void PrintShape2(string shape ,int count =10) 
        { 
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(shape);
            }
        }
        #endregion

        #region video 2 ( function prameters (passing by value) )
        public static void Swap(int a, int b)
        {
            Console.WriteLine($"Before Swapping [Inside]: a = {a}, b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After Swapping [Inside]: a = {a}, b = {b}");
        }
        #endregion

        #region video 3 ( function prameters (passing by reference) )
        public static void Swap2(ref int a, ref int b)
        {
            Console.WriteLine($"Before Swapping [Inside]: a = {a}, b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After Swapping [Inside]: a = {a}, b = {b}");
        }
        #endregion

        static void Main(string[] args)
        {

            #region Functions (prototype)
            PrintShape1();
            PrintShape2(count: 20, shape: "%^");
            #endregion

            #region video 2 ( function prameters (passing by value) )
            int x = 10, y = 20;
            Console.WriteLine($"Before Swapping [Outside]: x = {x}, y = {y}");
            Swap(x, y);
            Console.WriteLine($"After Swapping [Outside]: x = {x}, y = {y}");
            #endregion

            #region video 3 ( function prameters (passing by reference) )
            Console.WriteLine($"Before Swapping [Outside]: x = {x}, y = {y}");
            Swap2(ref x, ref y);
            Console.WriteLine($"After Swapping [Outside]: x = {x}, y = {y}");
            #endregion

        }
    }
}
