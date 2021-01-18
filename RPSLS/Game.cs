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

                CompareGesturesExpanded();
                Console.WriteLine(playerOne.name + " has " + playerOne.score);
                Console.WriteLine(playerTwo.name + " has " + playerTwo.score);
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
                "\nand Spock vaporizes Rock!"+
                "\nBest of Three");
        }
        public void DisplayWinner()
        {
            if (playerOne.score == 2)
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

        //Initial Compare Gestures Method
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
        public void CompareGesturesExpanded()
        {
            if (playerOne.gestureChoice == playerTwo.gestureChoice)
            {
                Console.WriteLine("Round is a tie");
            }
            //either chooses rock
            else if (playerOne.gestureChoice == playerOne.gestureList[0] || playerTwo.gestureChoice == playerTwo.gestureList[0])
            {
                //Either chooses paper
                if (playerOne.gestureChoice == playerOne.gestureList[1] || playerTwo.gestureChoice == playerTwo.gestureList[1])
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Paper covers Rock");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    if (playerOne.gestureChoice == playerOne.gestureList[1])
                    {
                        playerOne.AddPoint();
                    }
                    else
                    {
                        playerTwo.AddPoint();
                    }
                }
                //Either choose Scissors
                else if (playerOne.gestureChoice == playerOne.gestureList[2] || playerTwo.gestureChoice == playerTwo.gestureList[2])
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Rock crushes Scissors");
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (playerOne.gestureChoice == playerOne.gestureList[2])
                    {
                        playerTwo.AddPoint();
                    }
                    else
                    {
                        playerOne.AddPoint();
                    }
                }
                //Either chooses Lizard
                else if (playerOne.gestureChoice == playerOne.gestureList[3] || playerTwo.gestureChoice == playerTwo.gestureList[3])
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Rock crushes Lizard");
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (playerOne.gestureChoice == playerOne.gestureList[3])
                    {
                        playerTwo.AddPoint();
                    }
                    else
                    {
                        playerOne.AddPoint();
                    }
                }
                //Either chooses Spock
                else 
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Spock vaporizes Rock");
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (playerOne.gestureChoice == playerOne.gestureList[4])
                    {
                        playerOne.AddPoint();
                    }
                    else
                    {
                        playerTwo.AddPoint();
                    }
                }
            }
            //Either chooses Paper
            else if (playerOne.gestureChoice == playerOne.gestureList[1] || playerTwo.gestureChoice == playerTwo.gestureList[1])
            {
                //Either chooses Scissors
                if (playerOne.gestureChoice == playerOne.gestureList[2] || playerTwo.gestureChoice == playerTwo.gestureList[2])
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Scissors cuts Paper");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    if (playerOne.gestureChoice == playerOne.gestureList[2])
                    {
                        playerOne.AddPoint();
                    }
                    else
                    {
                        playerTwo.AddPoint();
                    }
                }
                //Either chooses Lizard
                else if (playerOne.gestureChoice == playerOne.gestureList[3] || playerTwo.gestureChoice == playerTwo.gestureList[3])
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Lizard eats Paper");
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (playerOne.gestureChoice == playerOne.gestureList[3])
                    {
                        playerOne.AddPoint();
                    }
                    else
                    {
                        playerTwo.AddPoint();
                    }
                }
                //Either chooses Spock 
                else 
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Paper disproves Spock");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    if (playerOne.gestureChoice == playerOne.gestureList[4])
                    {
                        playerOne.AddPoint();
                    }
                    else
                    {
                        playerTwo.AddPoint();
                    }
                }
            }
            //Either chooses Scissors
            else if (playerOne.gestureChoice == playerOne.gestureList[2] || playerTwo.gestureChoice == playerTwo.gestureList[2])
            {
                //either chooses lizard
                if (playerOne.gestureChoice == playerOne.gestureList[3] || playerTwo.gestureChoice == playerTwo.gestureList[3])
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Scissors decapitates Lizard");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    if (playerOne.gestureChoice == playerOne.gestureList[3])
                    {
                        playerTwo.AddPoint();
                    }
                    else
                    {
                        playerOne.AddPoint();
                    }
                }
                //either chooses Spock
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Spock smashes Scissors");
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (playerOne.gestureChoice == playerOne.gestureList[4])
                    {
                        playerOne.AddPoint();
                    }
                    else
                    {
                        playerTwo.AddPoint();
                    }
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Lizard poisons Spock");
                Console.BackgroundColor = ConsoleColor.Black;
                if (playerOne.gestureChoice == playerOne.gestureList[4])
                {
                    playerTwo.AddPoint();
                }
                else
                {
                    playerOne.AddPoint();
                }
            }
        }
    }
}

