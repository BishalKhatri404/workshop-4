namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Student s1 = new Student();
            Student s2 = new Student(); 

            s1.student_id = 23;
            s1.student_name = "Sudan";
            s1.student_age = 16;

            s2.student_id = 24;
            s2.student_name = "Aship";
            s2.student_age = 17;

            Console.WriteLine($"Student 1 details:\n{s1.student_id}\n{s1.student_name}\n{s1.student_age}");
            Console.WriteLine($"Student 2 details:\n{s2.student_id}\n{s2.student_name}\n{s2.student_age}");

        }
    }
}
