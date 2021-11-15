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
        bool ganhou = false;
        int contador = 0;
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
        int n = 0;

        public FlappyBall()
        {
            
            InitializeComponent();
            pbBolaRolando.Parent = pbDudu;
            txtComoJogar.Parent = pbDudu;
            txtFechar.Parent = pbDudu;
            txtInstrucao.Parent = pbDudu;
            lbPontuacao.Parent = pbLineBack;
            pbBall.Visible = false;
            pbDefender.Visible = false;
            pbDefender4.Visible = false;
            pbDefender3.Visible = false;
        }

        private void tmPontuacao_Tick(object sender, EventArgs e)
        {
            lbPontuacao.Text = $"Pontuação: {n}";
            pbBall.Top += TickTimer;
            pbDefender4.Left -= velocidade4;
            pbDefender3.Left -= velocidade3;
            pbDefender.Left -= velocidade0;

            if (pbDefender4.Left <  -50 && n < 100)
            {
                pbDefender4.Left = defender3.Next(650, 660);
                velocidade2 = velocidade.Next(6, 10);
            }

            if (pbDefender3.Left < -50 && n < 100)
            {
                pbDefender3.Left = defender2.Next(600, 700);
                pbDefender3.Top = defender2.Next(110, 170);
                velocidade3 = velocidade.Next(6, 10);
            }
            if (pbDefender.Left < -50 && n < 100)
            {
                pbDefender.Left = defender.Next(700, 800);
                velocidade0 = velocidade.Next(8, 12);
            }
            if (n >= 100)
            {
                pbGOL.Left -= velocidade2;
                tmLose.Enabled = true;
            }
             n++;
        }

        private void FlappyBall_KeyDown(object sender, KeyEventArgs e)
        {
             if(e.KeyCode == Keys.Enter)
            {
                pbBall.Visible = true;
                pbDefender.Visible = true;
                pbDefender4.Visible = true;
                pbDefender3.Visible = true;
                pbDudu.Visible = false;
                tmPontuacao.Enabled = true;
                pbBolaRolando.Visible = false;
                txtComoJogar.Visible = false;
                txtFechar.Visible = false;
                txtInstrucao.Visible = false;
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

       

        private void tmCarregamento_Tick(object sender, EventArgs e)
        {

            if (pbBolaRolando.Bounds.IntersectsWith(pbBound.Bounds))
            {
                pbBolaRolando.Image = pbBall.Image;
                tmCarregamento.Stop();
               
            }
            else
                pbBolaRolando.Left += velocidade2;


        }


        private void tmColisao_Tick(object sender, EventArgs e)
        {
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

                Lose();
            }

            if(pbBall.Bounds.IntersectsWith(pbGOL.Bounds))
            {
                ganhou = true;
                pbWIN.Visible = true;
                txtWIN.Visible = true;
                tmLose.Stop();
                pbBall.Visible = false;
                pbGOL.Visible = false;
               
            }

        }

        private void Lose()
        {
            if (ganhou == false) 
            {
                tmPontuacao.Enabled = false;
                pbLose.Visible = true;
                colisao = false;
                pbBall.Visible = false;
                pbDefender.Visible = false;
                pbDefender4.Visible = false;
                pbDefender3.Visible = false;
                pbCry.Visible = true;
                pbGOL.Visible = false;
            }
         
        }

        private void tmLose_Tick(object sender, EventArgs e)
        {
            contador++;
            
            if ( contador >= 10 && ganhou == false)
            {
                Lose();
            }
          
        }
    }
}
