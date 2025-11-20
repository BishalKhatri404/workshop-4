namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task6");

            Console.Write("Enter marks: ");
            string inputMarks = Console.ReadLine();

            Console.Write("Enter total: ");
            string inputTotal = Console.ReadLine();

            int marks;
            int total;

            bool isMarksValid = int.TryParse(inputMarks, out marks);
            bool isTotalValid = int.TryParse(inputTotal, out total);

            if (!isMarksValid || !isTotalValid)
            {
                Console.WriteLine("Invalid input, Please enter Integer!");
                return;
            }

            double percentage = (double)marks / total * 100;

            Console.WriteLine("Percentage is " + percentage);
            Console.ReadLine();
        }
    }
}