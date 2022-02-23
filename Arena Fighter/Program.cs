using UnboundKey;
using System;
using System.Collections.Generic;
using UnboundKey.Tools;

namespace Arena_Fighter
{
    class Program
    {
        // TODO!
        //[X]while the player is alive
        //[X]create an opponent for them to fight
        //[X]each round roll a 6 sided die and see who gets the highest roll
        //[X]the one with the highest roll attacks
        //[X]after each battle, if the player is alive ask if they want to retire, or continue
        //[X]If they retire break the battle loop,
        //[X]tally upp all the opponens beaten
        //[X]if they die or choose to retire
        //[X]Show score of how many opponents they defeated
        //[X]prompt them to restart again
            
        //[X]Randomize it's attributes
        //[X]create opponents with random attributes
        //[X]Get player to fight
        //[X]Log the fights
        //[X]Create Classes for the Character Enemy Battle and Round
        public static List<string> battleLog = new List<string>();
        public static int opponentsBeaten;
        static void Main(string[] args)
        {
            while (true)
            {
                // Resetting values to clear everything propperly on a new round
                Console.Clear();
                battleLog.Clear();
                opponentsBeaten = 0;
                Console.WriteLine("Arena Fighter!");
                //Get player input for character name
                string pcName = Helper.conWriteRead("What is your character name?: ");
                Character player = new Character(pcName);

                while(player.getHealth() > 0)
                {
                    Character opponent = new Character("Opponent");
                    //opponent.displayStats();
                    Battle b = new Battle(player, opponent);
                    //if the player died in the last battle. break out of the loop
                    if(player.getHealth() < 0) break;

                    // Ask the player if they want to continue and do if they answer with the right number.
                    string conInput = Helper.conWriteRead("Opponent beaten, do you want to (0)Continue or (1)Retire:");
                    if(Helper.ParseInt(conInput) == 1)
                    {
                        break;
                    }else if (Helper.ParseInt(conInput) == 0)
                    {
                        continue;
                    }
                }
            
                Helper.writeSeparator();
                foreach (var item in battleLog)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Opponents Beaten: " + opponentsBeaten);

                string conQuitInput = Helper.conWriteRead("You were defeated, do you want to play again? Y/N:");
                if (conQuitInput.ToLower() == "y" || conQuitInput.ToLower() == "yes")
                {
                    continue;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
