namespace C_Sharp_Daily
{

    internal class Program
    {
        public static int Factorial(int num)
        {
            int Fact = 1;
            for(int i = 1; i <= num; i++) 
            {
                Fact = Fact * i;
            }
            return Fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int Number=int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of a Number is\t{Factorial(Number)}");
        }
    }
}
