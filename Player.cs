using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCANOID
{
    class Player
    {
        int theBest;
        public int TheBest
        {
            set { theBest = value; }
            get { return theBest; }
        }
        string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        bool goRight;
        public bool GoRight
        {
            get { return goRight; }
            set { goRight = value; }
        }
        bool goLeft;
        public bool GoLeft
        {
            get { return goLeft; }
            set { goLeft = value; }
        }
        int speed;
        
        public int Speed{ 
            get { return speed; } 
            set { speed = value; } 
        }
        int lifes;
        public int Lifes
        {
            get { return lifes; }
            set { lifes = value; }
        }
        int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public Player(bool r = false, bool l = false,int sp = 10,int lf = 3,int sc = 0,int tb = 0,string n = "None") 
        {
            goRight = r;
            goLeft = l;
            speed = sp;
            lifes = lf;
            score = sc;
            theBest = tb;
            name = n;
        }
    }
}
