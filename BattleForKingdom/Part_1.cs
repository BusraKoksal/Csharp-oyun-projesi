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
    public partial class Part_1 : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        bool hKey = false;

        int jumpSpeed = 10;
        int force = 8;
        
        int Lift1Speed=5;
        int Lift2Speed=3;

        public Part_1()
        {
            InitializeComponent();
            Game_END.Hide();
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
            player.Top += jumpSpeed;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (goleft)
            {
                player.Left -= 5;
                player.Image = Properties.Resources.knight_run2;
            }

            if (goright)
            {
                player.Left += 5;
                player.Image = Properties.Resources.knight_run1;
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
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }

                if (player.Bounds.IntersectsWith(Key.Bounds))
                {
                    Key.Visible = false;
                    hKey = true;
                    door.Image = Properties.Resources.open_door;
                }
                if ((string)x.Tag == "spike")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        Game_END.Show();
                    }
                }


            }
                

            

            if (player.Bounds.IntersectsWith(door.Bounds)&&hKey==true)
            {

               
                timer1.Stop();
                    Part_2 p2 = new Part_2();
                    p2.ShowDialog();
                }
            
            
           



                Lift1.Left -= Lift1Speed;
            if (Lift1.Left < 0 || Lift1.Left >245) 
            {
                Lift1Speed =- Lift1Speed;
            }
            Lift2.Top += Lift2Speed;
            if (Lift2.Top<90 || Lift2.Top>210)
            {
                Lift2Speed =- Lift2Speed;
            }


        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void Part_1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_restart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Game_END.Hide();
            player.Location = new Point(12, 470);
        }

        private void lbl_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
    
