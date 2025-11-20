namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task4");


            Player player1 = new Player();
            player1.playerName = "Dai ho dai";
            player1.level = 0;
            player1.health = "Thikai chha!";


            Player player2 = new Player("Abhishek Sharma", 100, "Good");


            Console.WriteLine($"Player 1: Name = {player1.playerName}, Level = {player1.level}, Health = {player1.health}");
            Console.WriteLine();
            Console.WriteLine($"Player 2: Name = {player2.playerName}, Level = {player2.level}, Health = {player2.health}");


        }
    }
}