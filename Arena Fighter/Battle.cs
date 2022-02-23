using System;
using System.Collections.Generic;
using System.Text;
using UnboundKey.Tools;

namespace Arena_Fighter
{
    class Battle
    {
        public List<String> battleLog = new List<string>();
        public Character player;
        public Character opponentChar;
        public Battle(Character player, Character opponent)
        {
            this.player = player;
            opponentChar = opponent;
            
            while (player.getHealth() > 0)
            { 
                log(player.getName() + " " + player.getStats(),Program.battleLog);
                log(opponent.getName() + " " + opponent.getStats(), Program.battleLog);
                Round r = new Round(this);
                if (opponentChar.getHealth() <= 0)
                {
                    Program.opponentsBeaten++;
                    break;
                }
            }

        }
        public void log(string logMessage)
        {
            battleLog.Add(logMessage);
            Console.WriteLine(logMessage);
        }
        public void log(string logMessage, List<string> battleLogList)
        {
            battleLogList.Add(logMessage);
            Console.WriteLine(logMessage);
        }
    }
}
