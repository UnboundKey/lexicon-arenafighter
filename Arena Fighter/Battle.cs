using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_Fighter
{
    class Battle
    {
        private List<String> battleLog = new List<string>();
        public Character player;
        public Character opponentChar;
        public Battle(Character player)
        {
            Character opponent = new Character("Opponent");


        }
        public Battle(Character player, Character opponent)
        {
            this.player = player;
            opponentChar = opponent;
            Round r = new Round(this);

        }
        public void log(string logMessage)
        {
            battleLog.Add(logMessage);
            Console.WriteLine(logMessage);
        }
    }
}
