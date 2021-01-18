using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables
        public Player playerOne;
        public Player playerTwo;
        public List<string> gestureList;
        int playerOneScore;
        int playerTwoScore;
             

        //constructor
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }

        //member methods

        public void RunGame()
        {
            
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            DisplayRules();
            ChooseTypeOfGame();
            playerOne.CreateGestureList();
            while (playerOneScore < 2 && playerTwoScore < 2)
            {
                
                playerOne.ChooseGesture();
                Console.WriteLine(playerOne.name + " chooses " + playerOne.gestureChoice);
                Console.ReadLine();
                playerTwo.ChooseGesture();
                CompareGestures();

            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("In this game " +
                "\nRock crushes Scissors, " +
                "\nScissors cuts Paper, " +
                "\nPaper covers Rock, " +
                "\nRock crushes Lizard, " +
                "\nLizard poisons Spock, " +
                "\nSpock smashes Scissors, " +
                "\nScissors decapitates Lizard, " +
                "\nLizard eats Paper, " +
                "\nPaper disproves Spock, " +
                "\nand Spock vaporizes Rock!");
        }
        public void ChooseTypeOfGame()
        {
            Console.WriteLine("Would you like to play a single player game against the computer or a two player game against your friend?");
            
            while (playerOne == null)
            {
                Console.WriteLine("Press 1 for Single Player or 2 for Two Player Game");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Single player chosen");
                    playerOne = new Human();
                    playerTwo = new Computer();
                    playerOne.SetName();
                    

                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Two Player Game chosen");
                    playerOne = new Human();
                    playerOne.SetName();
                    playerTwo = new Human();
                    playerTwo.SetName();
                    
                }
            }
        }
        

        
        
        public void CompareGestures()
        {





        }

    }
}
