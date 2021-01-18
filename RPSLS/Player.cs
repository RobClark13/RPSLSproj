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
        public string gestureChoice;
        public List<string> gestureList;


        //constructor
        public Player()
        {
            name = "";
            gestureChoice = "test";
        }

        //member methods
        public void CreateGestureList()
        {
            gestureList = new List<string>();
            gestureList.Add("Rock");
            gestureList.Add("Paper");
            gestureList.Add("Scissors");
            gestureList.Add("Lizard");
            gestureList.Add("Spock");
        }

        public void PrintGestureList()
        {
            for (int i = 0; i < gestureList.Count; i++)
            {
                Console.WriteLine(name + " Press " + i + " for " + gestureList[i]);

            }

        }
        public abstract void ChooseGesture();
        public abstract void SetName();
       
        

    }
}
