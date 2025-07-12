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

        #region video 4 ( reference-type (passing by value) )
        public static int SumArray(int[] array)
        {
            Console.WriteLine("Before HashCode [Inside]: " + array.GetHashCode());
            array[0] = 100;
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            
            Console.WriteLine("After HashCode [Inside]: " + array.GetHashCode());
            Console.WriteLine($"Item [Inside] {array[0]}");
            return sum;
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

            #region video 4 ( reference-type (passing by value) )
            int[] numbers = [5, 7, 8];
            Console.WriteLine("Before HashCode [outside]: " + numbers.GetHashCode()); 
            int result = SumArray(numbers);
            Console.WriteLine("Result: " + result);
            Console.WriteLine("After HashCode [outside]: " + numbers.GetHashCode());
            Console.WriteLine($"Item [outside] {numbers[0]}");
            #endregion
        }
    }
}
