using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jogao_N2
{
    public partial class FrmPrincipal : Form
    {
        #region Inicializar
        public FrmPrincipal()
        {
            InitializeComponent();

            if (File.Exists("Configuracoes.txt"))
            {
                try
                {
                    string dificuldadeLida = File.ReadAllText("Configuracoes.txt");
                    lblDificuldade.Text = dificuldadeLida;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro durante a leitura do arquivo texto.");
                }
            }
        }

        public FrmPrincipal(string nome) : this()
        {
            lblNome.Text = nome;
        }
        #endregion

        Random geraAleatorio = new Random();
        public bool colisao = false;
        public bool loop = false;
        public int contBoss = 0;
        public int contChefao = 0;
        public bool ganhou = false;

        #region Pressionar Tecla para mover o Viotti
        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && imgBala.Visible == false)
            {
                imgBala.Left = imgJogador1.Left - 34;
                imgBala.Left = imgBala.Left + imgBala.Width;
                imgBala.Top = imgBala.Top + (imgBala.Height / 2) - (imgBala.Height / 2);
                imgBala.Visible = true;
                timerTiro.Start();
            }
             
            if (e.KeyCode == Keys.Left && imgJogador1.Left > 65 )
                imgJogador1.Left = imgJogador1.Left - 10;
            else if (e.KeyCode == Keys.Right && imgJogador1.Left < 360)
                imgJogador1.Left = imgJogador1.Left + 10;
        }
        #endregion

        #region Dificuldades do Jogo

        #region Facil
        private void Facil()
        {
            if (loop)
            {
                imgNPC1.Visible = true;
                imgNPC1.Location = new Point(62, 90);
                imgNPC2.Visible = true;
                imgNPC2.Location = new Point(112, 90);
                imgNPC3.Visible = true;
                imgNPC3.Location = new Point(162, 90);
                imgNPC4.Visible = true;
                imgNPC4.Location = new Point(212, 90);
                imgNPC5.Visible = true;
                imgNPC5.Location = new Point(262, 90);
                imgNPC6.Visible = true;
                imgNPC6.Location = new Point(312, 90);
                imgNPC7.Visible = true;
                imgNPC7.Location = new Point(362, 90);
                loop = false;
            }

            timerNPC.Interval = 1750;
            imgNPC1.Top += geraAleatorio.Next(40);
            imgNPC2.Top += geraAleatorio.Next(40);
            imgNPC3.Top += geraAleatorio.Next(40);
            imgNPC4.Top += geraAleatorio.Next(40);
            imgNPC5.Top += geraAleatorio.Next(40);
            imgNPC6.Top += geraAleatorio.Next(40);
            imgNPC7.Top += geraAleatorio.Next(40);


        }
        #endregion

        #region Amador
        private void Amador()
        {
            timerNPC.Interval = 1200;
            imgNPC1.Top += geraAleatorio.Next(60);
            imgNPC2.Top += geraAleatorio.Next(60);
            imgNPC3.Top += geraAleatorio.Next(60);
            imgNPC5.Top += geraAleatorio.Next(60);
            imgNPC6.Top += geraAleatorio.Next(60);
            imgNPC7.Top += geraAleatorio.Next(60);
            imgNPCBoss.Top += geraAleatorio.Next(40);

            if (contChefao == 0)
            {
                imgNPCBoss.Visible = true;
                imgNPCBoss.Enabled = true;
                imgNPCBoss.Location = new Point(202, 42);

                imgNPC1.Visible = true;
                imgNPC1.Location = new Point(62, 90);
                imgNPC2.Visible = true;
                imgNPC2.Location = new Point(112, 90);
                imgNPC3.Visible = true;
                imgNPC3.Location = new Point(162, 90);
                //imgNPC4.Visible = true;
                //imgNPC4.Location = new Point(12, 42);
                imgNPC5.Visible = true;
                imgNPC5.Location = new Point(262, 90);
                imgNPC6.Visible = true;
                imgNPC6.Location = new Point(312, 90);
                imgNPC7.Visible = true;
                imgNPC7.Location = new Point(362, 90);

                contChefao++;
            }
        }
        #endregion

        #region Difícil
        private void Dificil()
        {
            timerNPC.Interval = 750;
            imgNPC1.Top += geraAleatorio.Next(80);
            imgNPC2.Top += geraAleatorio.Next(80);
            imgNPC3.Top += geraAleatorio.Next(80);
            imgNPC5.Top += geraAleatorio.Next(80);
            imgNPC6.Top += geraAleatorio.Next(80);
            imgNPC7.Top += geraAleatorio.Next(80);
            imgNPCBoss.Top += geraAleatorio.Next(60);

            if (contChefao == 0)
            {
                imgNPCBoss.Visible = true;
                imgNPCBoss.Enabled = true;
                imgNPCBoss.Location = new Point(202, 42);

                imgNPC1.Visible = true;
                imgNPC1.Location = new Point(62, 90);
                imgNPC2.Visible = true;
                imgNPC2.Location = new Point(112, 90);
                imgNPC3.Visible = true;
                imgNPC3.Location = new Point(162, 90);
                //imgNPC4.Visible = false;
                //imgNPC4.Location = new Point(12, 42);
                imgNPC5.Visible = true;
                imgNPC5.Location = new Point(262, 90);
                imgNPC6.Visible = true;
                imgNPC6.Location = new Point(312, 90);
                imgNPC7.Visible = true;
                imgNPC7.Location = new Point(362, 90);

                contChefao++;
            }
        }
        #endregion
        
        #endregion

        #region Timer Tiro
        private void timerTiro_Tick(object sender, EventArgs e)
        {
            if(int.Parse(lblPontuacao.Text) >= 500)
            {
                ganhou = true;
                timerAlerta.Start();
            }

            imgBala.Top -= 8;

            if (colisao)
            {
                timerTiro.Stop();
                imgBala.Visible = false;
                colisao = false;
                imgBala.Top = 501;
            }

            foreach (Control objeto in this.Controls)
            {
                if (objeto is PictureBox && objeto != imgBala)
                {
                    if (imgBala.Bounds.IntersectsWith(objeto.Bounds))
                    {
                        colisao = true;

                        if (objeto == imgNPCBoss)
                        {
                            contBoss++;
                            lblPontuacao.Text = $"{int.Parse(lblPontuacao.Text.ToString()) + 25}";

                            if (contBoss >= 3)
                            {
                                //imgNPC4.Visible = false;
                                //imgNPC4.Location = new Point(12, 42);
                                imgNPCBoss.Location = new Point(202, 42);
                                imgNPCBoss.Visible = true;
                                objeto.Enabled = true;
                            }
                        }
                        else
                        {
                            lblPontuacao.Text = $"{int.Parse(lblPontuacao.Text.ToString()) + 15}";
                            objeto.Location = new Point(12, 42);

                            
                            if (objeto == imgNPC1)
                                imgNPC1.Location = new Point(62, 90);
                            if (objeto == imgNPC2)
                                imgNPC2.Location = new Point(112, 90);
                            if (objeto == imgNPC3)
                                imgNPC3.Location = new Point(162, 90);
                            if (objeto == imgNPC4)
                                imgNPC4.Location = new Point(212, 90);
                            if (objeto == imgNPC5)
                                imgNPC5.Location = new Point(262, 90);
                            if (objeto == imgNPC6)
                                imgNPC6.Location = new Point(312, 90);
                            if (objeto == imgNPC7)
                                imgNPC7.Location = new Point(362, 90);
                                
                        }
                    }
                }
            }
        }
        #endregion

        #region Timer NPC
        private void timerNPC_Tick(object sender, EventArgs e)
        {
            switch (lblDificuldade.Text)
            {
                case "Facil":
                    Facil();
                    break;
                case "Amador":
                    Amador();
                    break;
                case "Dificil":
                    Dificil();
                    break;
            }
            
            if (imgNPC1.Visible == false && imgNPC2.Visible == false && imgNPC3.Visible == false &&
                imgNPC4.Visible == false && imgNPC5.Visible == false && imgNPC6.Visible == false &&
                imgNPC7.Visible == false)
                loop = true;
                
        }
        #endregion

        #region Timer Perdeu
        private void timerPerdeu_Tick(object sender, EventArgs e)
        {
            foreach (Control objeto in this.Controls)
            {
                if (objeto is PictureBox && objeto != imgColisaoGol &&
                    objeto != imgColisao1 && objeto != imgColisao2)
                {
                    if (imgColisaoGol.Bounds.IntersectsWith(objeto.Bounds))
                    {
                        ganhou = false;
                        timerAlerta.Start();

                        objeto.Visible = false;
                        objeto.Enabled = false;
                    }
                }
            }
        }
        #endregion

        #region Timer Alerta
        private void timerAlerta_Tick(object sender, EventArgs e)
        {
            timerNPC.Stop();
            timerTiro.Stop();
            timerPerdeu.Stop();
            timerAlerta.Stop();

            if (ganhou == false)
            MessageBox.Show("Os jogadores adversários invadiram o seu gol e levaram a vitória para casa" +
               $"\n\nA sua pontuação foi: {lblPontuacao.Text}" +
                "\n\n** Clique em OK para voltar para a tela inicial **", "VOCÊ PERDEU!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (ganhou == true)
                MessageBox.Show("Você conseguiu derrotar boa parte dos jogadores adversários\n\nUm novo desafio te espera!!" +
                   $"\n\nA sua pontuação foi: {lblPontuacao.Text}" +
                    "\n\n** Clique em OK para voltar para a tela inicial **", "PARABÉNS!!", MessageBoxButtons.OK);

            gravaDados();

            FrmInicial inicial = new FrmInicial();
            this.Hide();
            inicial.Show();
            this.Close();
        }
        #endregion

        #region Método para gravar dados
        private void gravaDados()
        {
            string horario = DateTime.Now.ToString("dd/MM/yyyy - hh:mm tt");

            if (File.Exists("Ranking.txt"))
            {
                try
                {
                    File.AppendAllText("Ranking.txt", lblNome.Text + "|" + lblPontuacao.Text + "|" + lblDificuldade.Text + "|" + horario + "\n", Encoding.UTF8);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro durante leitura do arquivo texto.");
                }
            }

            string pontuacao = lblPontuacao.Text.ToString();
            //Parabens p1 = new FrmRanking(potuacao);
            //p1.Show();
        }
        #endregion

        private void imgAjuda_Click(object sender, EventArgs e)
        {
            timerNPC.Stop();
            timerTiro.Stop();
            timerPerdeu.Stop();
            timerAlerta.Stop();

            FrmTutorial tutorial = new FrmTutorial();
            tutorial.ShowDialog();

            timerNPC.Start();
            //timerTiro.Start();
            timerPerdeu.Start();
        }
    }
}