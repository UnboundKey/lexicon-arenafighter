using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_Fighter
{
    class Character
    {
        private string name;
        private int health;
        private int strength;
        //public bool isAlive = true;
        public Character(string name)
        {
            int randMax = 100;
            Random r = new Random();
            this.name = name;
            //randomizing the strength value
            strength = r.Next(randMax);
            health = r.Next(randMax);

        }
        public Character(string name, int strength, int health)
        {
            this.name = name;
            this.strength = strength;
            this.health = health;
        }
        public int getHealth()
        {
            return health;
        }
        public void attack(Character target)
        {

            target.health = target.health - this.strength;
        }
        public void displayStats()
        {
            Console.WriteLine(string.Format("Health: {0},Strength: {1}",health,strength));
        }
    }
}
