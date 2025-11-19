
namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task2");

            Calculator calculator = new Calculator();

            calculator.PrintWelcome();

            int sum = calculator.Add(10, 20);
            Console.WriteLine($"Sum: {sum}");

            int product = calculator.Multiply(10);
            Console.WriteLine($"Product: {product}");


        }
    }
}
