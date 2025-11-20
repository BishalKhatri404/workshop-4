namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task3");

            ParameterDemo demo = new ParameterDemo();


            int value = 5;
            Console.WriteLine($"Yo Original value: {value}");
            int increasedValue = demo.Increase(ref value);
            Console.WriteLine($"Yo increased value: {increasedValue}");


            demo.GetFullName(out string fullName);
            Console.WriteLine("Full Name is : " + fullName);

            int sum = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine(sum);
        }

    }
}