using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARCANOID
{
    class Falls
    {
        int countFall;
        public int CountFall
        {
            get { return countFall; }
            set { countFall = value; }
        }
        int LorP;
        public int lORp
        {
            get { return LorP; }
            set { LorP = value; }
        }

        public Falls(){
            countFall = 0;
            LorP = 0;
        }

        public void fall(int l, int t, List<PictureBox> fallen, Control.ControlCollection Controls)
        {
            Random rand = new Random();

            int n = rand.Next(0, 3);
            LorP = rand.Next(0, 2);

            if (n == 2)
            {
                PictureBox f = new PictureBox();
                f.Height = 30;
                f.Width = 30;
                f.Left = l + 45;
                f.Top = t;
                if (LorP == 1) { f.Image = Image.FromFile("life.png"); }
                else { f.Image = Image.FromFile("point2.png"); }

                f.Tag = "F";
                fallen.Add(f);
                /*this.*/Controls.Add(fallen[countFall]);

                countFall++;
            }
        }
    }
}
