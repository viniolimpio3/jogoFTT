using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogao_N2
{
    public partial class FrmPenalte : Form
    {
        public FrmPenalte()
        {
            InitializeComponent();
        }

        public Random posicao = new Random();
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int pos = posicao.Next(0, 3);
            int y = goleiro.Location.Y;
            if (pos == 0)
            {
                goleiro.Location = new Point(270,y);
            }
            else if (pos == 1)
            {
                goleiro.Location = new Point(300, y);
            }
            else
            {
                goleiro.Location = new Point(330, y);
            }
        }
    }
}
