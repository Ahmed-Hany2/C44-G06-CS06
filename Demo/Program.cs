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

        #region video 5 ( reference-type (passing by reference) )
        public static int SumArray2(ref int[] array)
        {
            Console.WriteLine("Before HashCode [Inside]: " + array.GetHashCode());
            array = [50, 60 , 70, 80];
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

        #region video 6 (passing by out)
        public static void SumMulti(int x, int y, out int sum, out int multi)
        {
            sum = x + y;
            multi = x * y;
        }
        #endregion

        #region video 7 (passing by params)
        public static int SumArray3(params int[] array)
        {
            Console.WriteLine("Before HashCode [Inside]: " + array.GetHashCode());
            array[0] = 100;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
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

            #region video 5 ( reference-type (passing by reference) )
            int[] numbers2 = [1, 3, 5, 7, 9];
            Console.WriteLine("Before HashCode [outside]: " + numbers2.GetHashCode());
            int result2 = SumArray2(ref numbers2);
            Console.WriteLine("Result: " + result2);
            Console.WriteLine("After HashCode [outside]: " + numbers2.GetHashCode());
            Console.WriteLine($"Item [outside] {numbers2[0]}");

            #endregion

            #region video 6 (passing by out)
            int X = 10, Y = 20, sum, multi;
            SumMulti(X, Y, out sum, out multi);
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"Multi: {multi}");
            #endregion

            #region video 7 (passing by params)
            int sum3 = SumArray3(10, 20, 30, 40, 50);
            Console.WriteLine(sum3);
            #endregion

            #region video 8 (Boxing & unboxing)
            int z = 10;
            object obj = z;

            // ======================================
            //obj = new Person();
            z = (int)obj;
            Console.WriteLine(z);

            #endregion

            #region video 9 (Nullable value-type)
            int? W = 10;
            int? F = 9; 
            int A;
            // int A = W;  (error)
            if (W.HasValue)
                A = W.Value;
            else
                A = 0;
            Console.WriteLine(A);

            A = W.HasValue ? W.Value : 0;

            A = W ?? F ?? 0;

            Console.WriteLine(A);

            #endregion

            #region video 10 (Nullable reference-type)
            string? name = null;
            Console.WriteLine(name);
            #endregion
        }
    }
}
