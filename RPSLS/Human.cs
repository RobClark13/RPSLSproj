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
            name = "";
        }

        //member methods
        
        
        
        public override void ChooseGesture()
        {

        }

        public override void SetName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            userName = name;

            
        }
    }
}
