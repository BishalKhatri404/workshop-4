using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Wrong
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("Invalid input, Please enter integer!");
                return;
            }

            double percentage = marks / total * 100;

            Console.WriteLine("Percentage is " + percentage);
            Console.ReadLine();
        }
    }
}