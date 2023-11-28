using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ARCANOID
{
    class Block
    {
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public Block()
        {
            count = 0;
        }
        public void placeBlocks(PictureBox[,] blocks,Game game,Player player,Ball ball2, Label score1, Label lifes1, PictureBox ball, PictureBox paddle, Size ClientSize, Timer gameTimer, Control.ControlCollection Controls,Label record1)
        {
            int top = 15;
            int left = 15;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    blocks[i, j] = new PictureBox();
                    blocks[i, j].Height = 30;
                    blocks[i, j].Width = 70;
                    blocks[i, j].Tag = "blocks";
                    blocks[i, j].BorderStyle = BorderStyle.Fixed3D;

                    blocks[i, j].Left = left;
                    blocks[i, j].Top = top;

                    /*this.*/Controls.Add(blocks[i, j]);
                    //count++;

                    left = left + 70;
                }

                top = top + 30;
                left = 15;
            }

            game.setupGame(player,ball2, score1, lifes1, ball, paddle, ClientSize, gameTimer, Controls,record1);
        }

        public void removeBlocks(PictureBox[,] blocks, Control.ControlCollection Controls)
        {
            foreach (PictureBox x in blocks)
            {
                /*this.*/Controls.Remove(x);
                
            }
        }

    }
}
