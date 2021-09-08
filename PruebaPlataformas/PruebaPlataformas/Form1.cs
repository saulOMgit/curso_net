using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPlataformas
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, isGameOver;
        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;

        int horizontalSpeed = 5;
        int verticalSpeed = 3;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            player.Top += jumpSpeed;

            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            if (jumping==true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    //Evento que nos permite volver al saltar volviendo a estar en contacto con una plataforma
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;

                            if((string)x.Name=="horizontalPlatform" && goLeft==false || (string)x.Name == "horizontalPlatform" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }

                        }

                        x.BringToFront();
                    }
                    //eventos al recolectar monedar
                    if ((string)x.Tag == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }
                    //evento al chocar con enemigos
                    if ((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gametimer.Stop();
                            isGameOver = true;
                            txtScore.Text = "Score: " + score + Environment.NewLine + "Yor were killed in your journey!!";
                        }
                    }
                }
            }

            //Movimiento de las plataformas
            horizontalPlatform.Left -= horizontalSpeed;

            if(horizontalPlatform.Left<0|| horizontalPlatform.Left + horizontalPlatform.Width > this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            verticalPlatform.Top += verticalSpeed;

            if (verticalPlatform.Top < 223 || verticalPlatform.Top > 573)
            {
                verticalSpeed = -verticalSpeed;
            }

            //Movimiento de los enemigos
            enemy1.Left -= enemyOneSpeed;

            if (enemy1.Left < pictureBox5.Left || enemy1.Left+enemy1.Width>pictureBox5.Left+pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            enemy2.Left -= enemyTwoSpeed;

            if (enemy2.Left < pictureBox2.Left || enemy2.Left + enemy2.Width > pictureBox2.Left + pictureBox2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }

            //Game Over si nos caemos al vacio
            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gametimer.Stop();
                isGameOver = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "Sa matao Paco!";
            }

            //Evento de Victoria (LLegar al final)
                //Tienes que conseguir 26 monedas para ganar
            if(player.Bounds.IntersectsWith(door.Bounds)&& score == 26)
            {
                gametimer.Stop();
                isGameOver = true;
                txtScore.Text = "Score: " + score + Environment.NewLine + "Ganaste bro!";
            }
            else
            {
                txtScore.Text = "Score: " + score + Environment.NewLine + "Faltante Moneducas, Rapaz";

            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jumping == true)
            {
                jumping = false;
            }
            if(e.KeyCode==Keys.Enter&& isGameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;

            txtScore.Text = "Score: " + score;

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            //reset the position of player, platform and enemies
            player.Left = 29;
            player.Top = 639;

            enemy1.Left=448; 
            enemy2.Left = 339;

            horizontalPlatform.Left = 275;
            verticalPlatform.Top = 573;

            gametimer.Start();
        }
    }
}
