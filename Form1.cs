using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.Json;
using System.IO;



namespace ARCANOID
{

public partial class Form1 : Form
    {
        Player player = new Player();

        Block block = new Block();
        Ball ball2 = new Ball();
        Falls falls = new Falls();
       
        Game game = new Game();

        Random rand = new Random();

        PictureBox[,] blocks = new PictureBox[5, 9];
        List<PictureBox> fallen = new List<PictureBox>();

public Form1()
        {
            InitializeComponent();
            record1.Text = "Record: " + player.TheBest;
            player.Name = Microsoft.VisualBasic.Interaction.InputBox("Введите имя: ");
            name1.Text = "Name: " + player.Name;
            ball.Left = ClientSize.Width/2+ball.Width/2;
            ball.Top = 300;
            paddle.Left = ClientSize.Width / 2 + paddle.Width / 2;
            paddle.Top = 400;
            block.placeBlocks(blocks,game,player,ball2,score1,lifes1,ball,paddle,ClientSize,gameTimer,this.Controls,record1);
        }

        

        //public void setupGame(/*Player player, Ball ball2*/)
        /*{
            Random rand = new Random();

            game.IsOver = false;
            player.Score = 0;
            player.Lifes = 3;
            player.Speed = 12;

            ball2.Ballx = 5;
            ball2.Bally = 5;

            score1.Text = "Score: " + player.Score;
            lifes1.Text = "Lifes: " + player.Lifes;

            ball.Left = ClientSize.Width / 2 + ball.Width / 2;
            ball.Top = 300;
            paddle.Left = ClientSize.Width / 2 + paddle.Width / 2;
            paddle.Top = 400;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    x.BackColor = randomColor;
                }
            }

            gameTimer.Start();
        }

        public void gameOver()
        {
            game.IsOver = true;
            gameTimer.Stop();
        }*/

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            if (player.Name!="None")
            {

            
            
            if (fallen.Count > 0)
            {
                for (int f = 0; f < fallen.Count; f++)
                {
                    fallen[f].Top += 5;
                }
            }

            ball.Left += ball2.Ballx;
            ball.Top += ball2.Bally;

            score1.Text = "Score: " + player.Score;
            lifes1.Text = "Lifes: " + player.Lifes;

            if (player.GoLeft) { paddle.Left -= player.Speed; }
            if (player.GoRight) { paddle.Left += player.Speed; }

            if (paddle.Left < 1)
            {
                player.GoLeft = false; 
            }
            else if (paddle.Left + paddle.Width > ClientSize.Width)
            {
                player.GoRight = false;
            }

            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                ball2.Ballx = -ball2.Ballx; 
            }

            if (ball.Top < 0 || ball.Bounds.IntersectsWith(paddle.Bounds))
            {
                ball2.Bally = -ball2.Bally; 
            }


            if (ball.Top + ball.Height > ClientSize.Height)
            {
                player.Lifes--;
                ball2.Bally = -ball2.Bally;
                lifes1.Text = "Lifes: " + player.Lifes;
            }

            if (player.Lifes == 0)
            {
                game.gameOver(gameTimer,player);
                MessageBox.Show("You Loose! Press Enter to restart the game");
            }

            if (ball.Bounds.IntersectsWith(paddle.Bounds))
            {
                ball.Top = 380;

                ball2.Bally = rand.Next(5, 12) * -1;

                if (ball2.Ballx < 0)
                {
                    ball2.Ballx = rand.Next(5, 12) * -1;
                }
                else
                {
                    ball2.Ballx = rand.Next(5, 12);
                }

            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        block.Count++;
                        falls.fall(x.Left,x.Top,fallen,this.Controls);
                        ball2.Bally = -ball2.Bally;
                        player.Score++;
                    }
                }
            }

            foreach (Control f in this.Controls)
            {
                if (f is PictureBox && (string)f.Tag == "F")
                {
                    if (paddle.Bounds.IntersectsWith(f.Bounds))
                    {
                        this.Controls.Remove(f);
                        
                        if (falls.lORp == 1)
                        {
                            player.Lifes++;
                            lifes1.Text = "Lifes: " + player.Lifes;
                        }
                        else
                        {
                            player.Score++;
                            score1.Text = "Score: " + player.Score;
                        }
                    }
                }
            }

           

            if (block.Count == 45)
            {
                game.gameOver(gameTimer,player);
                MessageBox.Show("You Win! Press Enter to restart the game");
            }
            }
        }

        //public void fall(int l, int t/*, List<PictureBox> fallen*/)
        /*{
            Random rand = new Random();

            int n = rand.Next(0, 3);
            falls.lORp = rand.Next(0, 2);

            if (n == 2)
            {
                PictureBox f = new PictureBox();
                f.Height = 30;
                f.Width = 30;
                f.Left = l + 45;
                f.Top = t;
                if (falls.lORp == 1) { f.Image = Image.FromFile("D:\\УНИВЕРСИТЕТ НГТУ\\СЕМЕСТР 3\\прога\\ARCANOID\\life.png"); }
                else { f.Image = Image.FromFile("D:\\УНИВЕРСИТЕТ НГТУ\\СЕМЕСТР 3\\прога\\ARCANOID\\point2.png"); }

                f.Tag = "F";
                fallen.Add(f);
                this.Controls.Add(fallen[falls.CountFall]);

                falls.CountFall++;
            }
        }

        public void placeBlocks()
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

                    this.Controls.Add(blocks[i, j]);
                    //block.Count++;

                    left = left + 70;
                }

                top = top + 30;
                left = 15;
            }

            setupGame();
        }

        public void removeBlocks(PictureBox[,] blocks)
        {
            foreach (PictureBox x in blocks)
            {
                this.Controls.Remove(x);

            }
        }*/

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && paddle.Left > 0) { player.GoLeft = true; }
            if (e.KeyCode == Keys.Right && paddle.Left + paddle.Width < ClientSize.Width) {  player.GoRight = true; }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { player.GoLeft = false; }
            if (e.KeyCode == Keys.Right) { player.GoRight = false; }
            if (e.KeyCode == Keys.Enter && game.IsOver == true)
            {
                block.removeBlocks(blocks,this.Controls);
                block.Count = 0;
                block.placeBlocks(blocks, game, player, ball2,score1,lifes1,ball,paddle,ClientSize,gameTimer,this.Controls,record1);
                

            }
        }

    }
}
