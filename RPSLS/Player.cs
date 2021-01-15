using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public string name;

        //constructor
        public Player()
        {
            name = "";
        }

        //member methods
        public abstract void ChooseGesture();
        public abstract void SetName();
       
        

    }
}
