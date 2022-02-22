using Atempt2;
using System;

namespace Arena_Fighter
{
    class Program
    {
        // TODO!
        //[X]while the player is alive
        //[X]create an opponent for them to fight
        //[X]each round roll a 6 sided die and see who gets the highest roll
        //[X]the one with the highest roll attacks
        //[]tally upp all the opponens beaten
        //[]if they die or choose to retire
        //[]Show score of how many opponents they defeated and prompt them to start again


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Get player input for character name
            string pcName = Helper.conWriteRead("What is your character name?: ");
            Character player = new Character(pcName);
            player.displayStats();
            while(player.getHealth() > 0)
            {
                
                Character opponent = new Character("Opponent");
                opponent.displayStats();
                Battle b = new Battle(player, opponent);
                
            }
            
            //[]Randomize it's attributes
            //[]create opponents with random attributes
            //[]Get player to fight
            //[]Log the fights
            //[]Create Classes for the Character Enemy Battle and Round
        }
    }
}
