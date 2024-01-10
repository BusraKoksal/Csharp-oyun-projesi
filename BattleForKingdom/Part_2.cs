using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleForKingdom
{
    public partial class Part_2 : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        bool hcrown = false;

        int jumpSpeed = 10;
        int force = 8;

        int Lift1Speed = 5;
        int Lift2Speed = 3;
        int Lift3Speed = 5;
        int enemy1Speed=5;
        int enemy2Speed=3;
        

        public Part_2()
        {
            InitializeComponent();
            Game_end.Hide();
            Menu_Win.Hide();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping)
            {
                jumping = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player2.Top += jumpSpeed;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (goleft)
            {
                player2.Left -= 5;
                player2.Image = Properties.Resources.knight_run2;
            }

            if (goright)
            {
                player2.Left += 5;
                player2.Image = Properties.Resources.knight_run1;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player2.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player2.Top = x.Top - player2.Height;
                    }
                }
                if ((string)x.Tag == "enemy")
                {
                    if (player2.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        Game_end.Show();
                    }
                }

                if (player2.Bounds.IntersectsWith(crown.Bounds))
                {
                    crown.Visible = false;
                    hcrown = true;
                    throne.Image = Properties.Resources.open_door;
                }


                if (player2.Bounds.IntersectsWith(throne.Bounds) && hcrown == true)
                {

                    
                    timer1.Stop();
                   
                    Menu_Win.Show();
                   


                }

                if ((string)x.Tag == "spike")
                {
                    if (player2.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        Game_end.Show();
                    }
                }
            }
            Lift1.Left -= Lift1Speed;
            if (Lift1.Left < 0 || Lift1.Left > 320)
            {
                Lift1Speed = -Lift1Speed;
            }
            Lift2.Top += Lift2Speed;
            if (Lift2.Top < 180 || Lift2.Top > 300)
            {
                Lift2Speed = -Lift2Speed;
            }
            Lift3.Left -= Lift3Speed;
            if (Lift3.Left < 0 || Lift3.Left > 554)
            {
                Lift3Speed = -Lift3Speed;
            }
            enemy1.Left -= enemy1Speed;
            if (enemy1.Left < pictureBox1.Left || enemy1.Left + enemy1.Width > pictureBox1.Left + pictureBox1.Width)
            {
                enemy1Speed = -enemy1Speed;
            }
            enemy2.Left -= enemy2Speed;
            if (enemy2.Left < pictureBox4.Left || enemy2.Left + enemy2.Width > pictureBox4.Left + pictureBox4.Width)
            {
                enemy2Speed = -enemy2Speed;
            }
            if (player2.Top+player2.Height>this.ClientSize.Height)
            {
                timer1.Stop();
                Game_end.Show();
            }

        }

        private void lbl_restart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Game_end.Hide();
            player2.Location = new Point(12, 23) ;
           
        }

        private void lbl_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label_quit_Click(object sender, EventArgs e)
        {
            
            thanks ty = new thanks();
            ty.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
    }
}
            
    

