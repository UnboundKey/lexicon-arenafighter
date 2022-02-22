using System;
using System.Collections.Generic;
using System.Text;

namespace Arena_Fighter
{
    class Round
    {
        public Round(Battle battle)
        {
            
            Random r = new Random();
            int playerRand = r.Next(6);
            int opponentRand = r.Next(6);
            
            if (playerRand > opponentRand)
            {
                battle.player.attack(battle.opponentChar);
            } else
            {
                battle.opponentChar.attack(battle.player);
            }
            battle.log(string.Format("Player Health: {0}, Player Attack Roll: {1}, Opponent Health: {2}, Opponent Attack Roll: {3}",battle.player.getHealth(),playerRand,battle.opponentChar.getHealth(),opponentRand));
        }


    }
}
