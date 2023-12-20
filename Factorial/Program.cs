namespace FactorialProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Factorial of 5 = {Factorial.Calculate(5)}");
            Console.WriteLine($"Factorial of 15 = {Factorial.Calculate(15)}");
            Console.WriteLine($"Factorial of 25 = {Factorial.Calculate(25)}");
        }
    }
}