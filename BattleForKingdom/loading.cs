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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 100)
            {
                Opacity += 0.15;
                progressBar1.Increment(4);
            }
            if (progressBar1.Value == 100) {
                
                timer1.Stop();
                Part_1 p1 = new Part_1();
                p1.ShowDialog();
            }
        }
    }
}
