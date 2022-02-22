using UnboundKey;
using System;
using System.Collections.Generic;

namespace Arena_Fighter
{
    class Program
    {
        // TODO!
        //[X]while the player is alive
        //[X]create an opponent for them to fight
        //[X]each round roll a 6 sided die and see who gets the highest roll
        //[X]the one with the highest roll attacks
        //after each battle, if the player is alive ask if they want to retire, or continue
        //If they re
        //[]tally upp all the opponens beaten
        //[]if they die or choose to retire
        //[]Show score of how many opponents they defeated and prompt them to start again
        public static List<string> battleLog = new List<string>();
        public static int opponentsBeaten;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Get player input for character name
            string pcName = Helper.conWriteRead("What is your character name?: ");
            Character player = new Character(pcName,500);
            //player.displayStats();

            while(player.getHealth() > 0)
            {
                Character opponent = new Character("Opponent");
                //opponent.displayStats();
                Battle b = new Battle(player, opponent);
            }
            
            //[X]Randomize it's attributes
            //[X]create opponents with random attributes
            //[X]Get player to fight
            //[]Log the fights
            //[X]Create Classes for the Character Enemy Battle and Round
        }
    }
}
