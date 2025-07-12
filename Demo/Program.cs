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

        static void Main(string[] args)
        {

            #region Functions (prototype)
            PrintShape1();
            PrintShape2(count: 20, shape: "%^");
            #endregion

        }
    }
}
