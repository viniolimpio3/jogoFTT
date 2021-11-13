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
    public partial class FlappyBall : Form
    {
        int TickTimer;
        Random velocidade = new Random();
        int velocidade0 = 8;
        int velocidade2 = 3;
        int velocidade3 = 8;
        int velocidade4 = 8;
        bool colisao = false;
        public int inicio = 0;
        Random defender = new Random();
        Random defender2 = new Random();
        Random defender3 = new Random();


        public FlappyBall()
        {
            InitializeComponent();
            pbBolaRolando.Parent = pbDudu;
            txtComoJogar.Parent = pbDudu;
            txtFechar.Parent = pbDudu;
            txtInstrucao.Parent = pbDudu;
        }

        private void tmPontuacao_Tick(object sender, EventArgs e)
        {

            pbBall.Top += TickTimer;
            pbDefender4.Left -= velocidade4;
            pbDefender3.Left -= velocidade3;
            pbDefender.Left -= velocidade0;

            if (pbDefender4.Left < -50)
            {
                pbDefender4.Left = defender3.Next(650, 660);
                velocidade2 = velocidade.Next(6, 10);
            }

            if (pbDefender3.Left < -50)
            {
                pbDefender3.Left = defender2.Next(600, 700);
                pbDefender3.Top = defender2.Next(110, 170);
                velocidade3 = velocidade.Next(6, 10);
            }
            if (pbDefender.Left < -50)
            {
                pbDefender.Left = defender.Next(700, 800);
                velocidade0 = velocidade.Next(8, 12);
            }
            if (pbBall.Bounds.IntersectsWith(pbDefender.Bounds)
               || pbBall.Bounds.IntersectsWith(pbDefender4.Bounds)
               || pbBall.Bounds.IntersectsWith(pbDefender3.Bounds)
               || pbBall.Bounds.IntersectsWith(pbLineBack.Bounds)
               || pbBall.Bounds.IntersectsWith(pbLineUp.Bounds))
            {
                colisao = true;

            }
            if (colisao)
            {
                tmPontuacao.Enabled = false;
                pbLose.Visible = true;
                colisao = false;
                pbBall.Visible = false;
                pbDefender.Visible = false;
                pbDefender4.Visible = false;
                pbDefender3.Visible = false;
            }


        }

        private void FlappyBall_KeyDown(object sender, KeyEventArgs e)
        {
            inicio = 1;
            if (inicio == 1)
            {
                pbinicio.Visible = false;
                tmPontuacao.Enabled = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                TickTimer = -25;
            }
        }

        private void FlappyBall_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                TickTimer = 10;
            }
        }

        private void lbPontuacao_Click(object sender, EventArgs e)
        {

        }

        private void pbinicio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tmCarregamento_Tick(object sender, EventArgs e)
        {
            pbBolaRolando.Left += velocidade2;
        }
    }
}
