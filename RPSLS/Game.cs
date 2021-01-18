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
              
            
        //constructor
        public Game()
        {
            
        }

        //member methods

        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            DisplayRules();
            ChooseTypeOfGame();
            playerOne.CreateGestureList();
            playerTwo.CreateGestureList();
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                
                playerOne.ChooseGesture();
                Console.WriteLine(playerOne.name + " chooses " + playerOne.gestureChoice);
                
                playerTwo.ChooseGesture();
                Console.WriteLine(playerTwo.name + " chooses " + playerTwo.gestureChoice);
                
                CompareGestures();
                Console.WriteLine(playerOne.name +" has " + playerOne.score);
                Console.WriteLine(playerTwo.name +" has " + playerTwo.score);
                

            }
            DisplayWinner();
            Console.ReadLine();
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
        public void DisplayWinner()
        {
            if(playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + " wins!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " wins!");
            }
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
                    playerOne.SetName();
                    playerTwo = new Computer();
                    playerTwo.SetName();
                    

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
            if (playerOne.gestureChoice == playerTwo.gestureChoice)
            {
                Console.WriteLine("Tie"); ;
            }
            else if (playerOne.gestureChoice == playerOne.gestureList[0] && (playerTwo.gestureChoice == playerTwo.gestureList[2] || playerTwo.gestureChoice == playerTwo.gestureList[3]))
            {
                playerOne.AddPoint();
            }
            else if (playerOne.gestureChoice == playerOne.gestureList[1] && (playerTwo.gestureChoice == playerTwo.gestureList[0] || playerTwo.gestureChoice == playerTwo.gestureList[4]))
            {
                playerOne.AddPoint();
            }
            else if (playerOne.gestureChoice == playerOne.gestureList[2] && (playerTwo.gestureChoice == playerTwo.gestureList[1] || playerTwo.gestureChoice == playerTwo.gestureList[3]))
            {
                playerOne.AddPoint();
            }
            else if (playerOne.gestureChoice == playerOne.gestureList[3] && (playerTwo.gestureChoice == playerTwo.gestureList[1] || playerTwo.gestureChoice == playerTwo.gestureList[4]))
            {
                playerOne.AddPoint();
            }
            else if (playerOne.gestureChoice == playerOne.gestureList[4] && (playerTwo.gestureChoice == playerTwo.gestureList[0] || playerTwo.gestureChoice == playerTwo.gestureList[2]))
            {
                playerOne.AddPoint();
            }
            else
            {
                playerTwo.AddPoint();
            }
        }            
    }
}
