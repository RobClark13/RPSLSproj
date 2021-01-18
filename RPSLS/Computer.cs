using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //member variables
        Random computerGestureNumber2;
        //constructor

        //member methods
        public override void ChooseGesture()
        {
            computerGestureNumber2 = new Random();
            int computerGestureNumber = computerGestureNumber2.Next(0, 4);
            switch (computerGestureNumber)
            {
                case 0:
                    gestureChoice = gestureList[0];
                    break;
                case 1:
                    gestureChoice = gestureList[1];
                    break;

                case 2:
                    gestureChoice = gestureList[2];
                    break;
                case 3:
                    gestureChoice = gestureList[3];
                    break;
                case 4:
                    gestureChoice = gestureList[4];
                    break;


                default:
                    
                    break;

            }


        }
        public override void SetName()
        {
            name = "Computer";
        }
        public override void AddPoint()
        {
            score++;
        }




    }
}
