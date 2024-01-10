using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BattleForKingdom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SoundPlayer music = new SoundPlayer();
            music.SoundLocation = "C:\\Users\\busra\\Downloads\\oyun müziği.wav";
            music.PlayLooping();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_hover;
        }

        private void btn_back_MouseHover(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.back_hover;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.STARTT;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.BACKK;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            menü.Hide();
            loading ld = new loading();
            ld.ShowDialog();
            Part_1 p1 = new Part_1();
            p1.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_lore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A KNIGHT FOUND HIMSELF IN A SOMEPLACE WITH DANGERS,GUIDE THIS YOUNG MAN IN HIS BATTLE TO GAIN HIS CROWN BACK!!!");
        }
    }
}
