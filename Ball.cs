using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCANOID
{
    class Ball
    {
        int ballx;
        public int Ballx
        {
            get { return ballx; }
            set { ballx = value; }
        }
        int bally;
        public int Bally
        {
            get { return bally; }
            set { bally = value; }
        }
        public Ball()
        {
            ballx=5;
            bally=5;
        }
    }
}
