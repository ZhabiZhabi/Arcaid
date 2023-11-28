using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ARCANOID
{
    class Game
    {
        bool isGameOver;

        public bool IsOver
        {
            get { return isGameOver; }
            set { isGameOver = value; }
        }

        public void setupGame(Player player,Ball ball2, Label score1,Label lifes1,PictureBox ball,PictureBox paddle, Size ClientSize, Timer gameTimer, Control.ControlCollection Controls,Label record1)
        {
            Random rand = new Random();

            isGameOver = false;
            player.Score = 0;
            player.Lifes = 3;
            player.Speed = 12;

            ball2.Ballx = 5;
            ball2.Bally = 5;

            score1.Text = "Score: " + player.Score;
            lifes1.Text = "Lifes: " + player.Lifes;
            record1.Text = "The Best: " + player.TheBest;

            ball.Left = ClientSize.Width / 2 + ball.Width / 2;
            ball.Top = 300;
            paddle.Left = ClientSize.Width / 2 + paddle.Width / 2;
            paddle.Top = 400;

            foreach (Control x in /*this.*/Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    x.BackColor = randomColor;
                }
            }

            gameTimer.Start();
        }

        public void gameOver(Timer gameTimer,Player player)
        {
            isGameOver = true;
            gameTimer.Stop();
            if (player.Score > player.TheBest)
            {
                player.TheBest = player.Score;
            }
        }
    }
}
