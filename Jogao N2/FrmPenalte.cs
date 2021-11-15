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
        public int posBolaY;
        public int posBolaX;
        public int posGoleiroX;
        public int tamanBolaX;
        public int tamanBolaY;
        public Random gerador = new Random();
        public int aleatorio = 0;
        public int cont = 0;
        public int tentativa = 1;
        public bool permissao = true;
        public bool gol = false;

        public FrmPenalte()
        {
            InitializeComponent();
        }

        private bool Gol()
        {
            if(imgBola.Bounds.IntersectsWith(imgGoleiro.Bounds))
            {
                imgBola.Parent = imgGoleiro;
                imgBola.Location = new Point(6, 50);
                MessageBox.Show("PERDEEEEEEEEEEEEU");
                return false;
            }
            else
            {
                MessageBox.Show("GOOOOOOOOOOOOOL \n +200 PONTOS");
                this.Close();
                return true;
            }
        }
        private void DiminuiBola()
        {
            if(cont == 3)
            {
                imgBola.Size = new Size(imgBola.Width - 1, imgBola.Height - 1);
                cont = 0;
            }
        }

        private void Tentativa()
        {
            if(tentativa <= 3 && !gol)
            {
                imgBola.Size = new Size(tamanBolaX, tamanBolaY);
                imgBola.Parent = this;
                imgBola.Location = new Point(posBolaX, posBolaY);
                imgBola.BringToFront();
                imgGoleiro.Location = new Point(posGoleiroX, imgGoleiro.Location.Y);
                MessageBox.Show($"{tentativa}ª Tentativa! Restam {4 - tentativa}.");
                timerGoleiro.Start();
                permissao = true;
            }
            if(tentativa > 3)
            {
                MessageBox.Show("Acabaram as tentativas. Mais sorte na próxima.");
                this.Close();
            }
        }

        private void timerGoleiro_Tick(object sender, EventArgs e)
        {
            aleatorio = gerador.Next(0, 4);
            //label1.Text = aleatorio.ToString();
            timerMovimento.Start();
        }

        private void timerMovimento_Tick(object sender, EventArgs e)
        {
            int velocidade = 15;
            int x = imgGoleiro.Location.X;
            int pontocentro = 217;
            int pontoesq = 67;
            int pontdir = 357;
            if(x > pontoesq && x < pontdir)
            {
                if(aleatorio <= 1)
                {
                    if (x < pontocentro)
                    {
                        imgGoleiro.Left += velocidade;
                    }
                    else if(x > pontocentro)
                    {
                        imgGoleiro.Left -= velocidade;
                    }
                }
                else if(aleatorio == 2)
                {
                    if( x > pontoesq)
                    {
                        imgGoleiro.Left -= velocidade;
                    }
                }
                else if(aleatorio == 3)
                {
                    if(x < pontdir)
                    {
                        imgGoleiro.Left += velocidade;
                    }
                }
            }
            else if(x <= pontoesq)
            {
                if(aleatorio < 2)
                {
                    if(x < pontocentro)
                    {
                        imgGoleiro.Left += velocidade;
                    }
                }
            }
            else
            {
                if (aleatorio < 2)
                {
                    if (x > pontocentro)
                    {
                        imgGoleiro.Left -= velocidade;
                    }
                }
            }
        }

        private void FrmPenalte_KeyDown(object sender, KeyEventArgs e)
        {
            if (permissao)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    timerBola.Start();
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    timerBolaEsq.Start();
                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    timerBolaDir.Start();
                }
            }

        }

        private void timerBola_Tick(object sender, EventArgs e)
        {
            int y = imgBola.Location.Y;
            int velocidade = 15;
            if(y > 133)
            {
                imgBola.Top -= velocidade;
                cont++;
                DiminuiBola();
            }
            else
            {
                timerMovimento.Stop();
                timerGoleiro.Stop();
                timerBola.Stop();
                gol = Gol();
                permissao = false;
                tentativa++;
                Tentativa();
            }
        }

        private void timerBolaEsq_Tick(object sender, EventArgs e)
        {
            int y = imgBola.Location.Y;
            int x = imgBola.Location.X;
            int velocidadey = 15;
            int velocidadex = 4;
            if (y > 133 && x > 70)
            {
                imgBola.Top -= velocidadey;
                imgBola.Left -= velocidadex;
                cont++;
                DiminuiBola();
            }
            else
            {
                timerMovimento.Stop();
                timerGoleiro.Stop();
                timerBolaEsq.Stop();
                gol = Gol();
                permissao = false;
                tentativa++;
                Tentativa();
            }
        }

        private void timerBolaDir_Tick(object sender, EventArgs e)
        {
            int y = imgBola.Location.Y;
            int x = imgBola.Location.X;
            int velocidadey = 15;
            int velocidadex = 5;
            if (y > 133 && x < 455)
            {
                imgBola.Top -= velocidadey;
                imgBola.Left += velocidadex;
                cont++;
                DiminuiBola();
            }
            else
            {
                timerMovimento.Stop();
                timerGoleiro.Stop();
                timerBolaDir.Stop();
                gol = Gol();
                permissao = false;
                tentativa++;
                Tentativa();
            }
        }

        private void FrmPenalte_Load(object sender, EventArgs e)
        {
            posBolaY = imgBola.Location.Y;
            posBolaX = imgBola.Location.X;
            posGoleiroX = imgGoleiro.Location.X;
            tamanBolaX = imgBola.Width;
            tamanBolaY = imgBola.Height;
            Tentativa();
        }
    }
}
