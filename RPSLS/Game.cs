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
             

        //constructor
        public Game()
        {
           
        }

        //member methods

        public void RunGame()
        {
            CreateGestureList();
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            DisplayRules();
            ChooseTypeOfGame();
            
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
                    Console.ReadLine();

                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Two Player Game chosen");
                    playerOne = new Human();
                    playerOne.SetName();
                    playerTwo = new Human();
                    playerTwo.SetName();
                    Console.ReadLine();
                }
            }
        }
        public void CreateGestureList()
        {
            gestureList = new List<string>();
            gestureList.Add("Rock");
            gestureList.Add("Paper");
            gestureList.Add("Scissors");
            gestureList.Add("Lizard");
            gestureList.Add("Spock");
        }
        
        public void CompareGestures()
        {

        }

    }
}
