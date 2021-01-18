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
        Random computerChoiceNumber;
        //constructor

        //member methods
        public override void ChooseGesture()
        {
            string gestureChoice = Console.ReadLine();
           
            
        }
        public override void SetName()
        {
            name = "Computer";
        }




    }
}
