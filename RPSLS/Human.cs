using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables
        

        //constructor

        public Human()
        {
            
            
        }

        //member methods



        public override void ChooseGesture()
        {
            PrintGestureList();
            string userGestureChoice = Console.ReadLine();
            
           
            switch(userGestureChoice)
            {
                case "0":
                    gestureChoice = gestureList[0];
                    break;
                 case "1":
                    gestureChoice = gestureList[1];
                    break;
                   
                case "2":
                    gestureChoice = gestureList[2];
                    break;
                 case "3":
                    gestureChoice = gestureList[3];
                    break;
                 case "4":
                    gestureChoice = gestureList[4];
                    break;
                    

                  default:
                    Console.WriteLine("Only enter 0, 1, 2, 3, or 4");
                    ChooseGesture();
                    break;                       
                                         
            }
                    
                      
                       
        }

        public override void SetName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            name = userName;            
        }
        public override void AddPoint()
        {
            score++;
        }

    }
}
