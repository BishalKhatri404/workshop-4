using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Player
    {
        public string playerName;
        public int level;
        public string health;

        public Player()
        {
            Console.WriteLine("Default constructor has been called!");
        }

        public Player(string name, int level, string health)
        {
            this.playerName = name;
            this.level = level;
            this.health = health;
        }


    }
}