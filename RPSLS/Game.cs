using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables
        public Player playerOne;
        public Player playerTwo;


        //constructor
        public Game()
        {
            
        }

        //member methods

        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("In this game \nRock crushes Scissors, \nScissors cuts Paper, \nPaper covers Rock, \nRock crushes Lizard, \nLizard poisons Spock, \nSpock smashes Scissors, \nScissors decapitates Lizard, \nLizard eats Paper, \nPaper disproves Spock, \nand Spock vaporizes Rock!");
            Console.WriteLine("Would you like to play a single player game against the computer or a  two player game against your friend?");
            Console.WriteLine("Press 1 for Single Player or 2 for Two Player Game");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("Single player chosen");
                Console.ReadLine();

            }
            else if (userInput == "2")
            {
                Console.WriteLine("Two Player Game chosen");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Press 1 for Single Player or 2 for Two Player Game");
                Console.ReadLine();
            }




        }

    }
}
