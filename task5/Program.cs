namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task5");

            Console.Write("Enter a day: ");
            string day = Console.ReadLine().Trim().ToLower();

            DayType dayType;

            if (day == "friday" || day == "saturday")
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine($"It's: {dayType}");


            Book book1 = new Book("Ijoriya", "Subin Bhattrai", 899.00);
            Book book2 = book1 with { title = "Harry Potter", price = 1500.00 };

            Console.WriteLine("\nFirst Book:");
            Console.WriteLine($"Title: {book1.title}, Author: {book1.author}, Price: {book1.price}");



            var (title, author, price) = book2;

            Console.WriteLine("\nSecond Book |Decontructed:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");

            Console.ReadLine();
        }
    }
}