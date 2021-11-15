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

        public string nomeJogador;

        public FrmPrincipal()
        {

            InitializeComponent();
        }

        public FrmPrincipal(string nome) : this()
        {
            this.nomeJogador = nome;
            lblNome.Text = nome;
        }
        #endregion

        public bool colisao = false;

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

            if (e.KeyCode == Keys.Left && imgJogador1.Left > 0)
                imgJogador1.Left = imgJogador1.Left - 10;
            else if (e.KeyCode == Keys.Right)
                imgJogador1.Left = imgJogador1.Left + 10;
        }

        #region Timer Tiro
        private void timerTiro_Tick(object sender, EventArgs e)
        {
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
                        colisao = true;
                }
            }
        }

        #endregion

        public List<PictureBox> items = new List<PictureBox>();

        private void timerNPC_Tick(object sender, EventArgs e)
        {
            int posicaoX = 56;

            for (int i = 0; i < 8; i++)
            {
                SpawnPictureBox(posicaoX);

                posicaoX += 10;
            }

            foreach (PictureBox dados in items)
            {
                int altura;
                altura = dados.Location.Y;
                altura += 10;
                dados.Location = new Point(dados.Location.X, altura);
            }

            imgNPC1.Top -= 8;
        }


        private void SpawnPictureBox(int posicaoX)
        {
            //Random geraAleatorio = new Random();
            PictureBox newPic = new PictureBox();

            newPic = imgNPC1;
            newPic.Visible = true;
            //newPic.ImageLocation = imgNPC1.ImageLocation;
            newPic.Location = new Point(posicaoX, 98);

            items.Add(newPic);
            this.Controls.Add(newPic);
        }

        public void setMinigame(string game) {
            switch (game) {
                case "flappy":
                    this.Hide();
                    FlappyBall f = new FlappyBall(this.nomeJogador);
                    f.Show();
                    break;
                case "palmeiras":
                    this.Hide();
                    FrmMinigMataPalmeiras p = new FrmMinigMataPalmeiras(this.nomeJogador);
                    timerNPC.Stop();
                    p.Show();
                    break;
                case "penalti":
                    //Chamar a tela de Pênalti aqui!
                    MessageBox.Show("ADICIONAR TELA FORM Pênalti"); //REMOVER!
                    break;
                default:
                    MessageBox.Show("Minigame passado inválido - no método minigame()");
                    break;
            }
        }

        private void btnMinigamePalmeiras_Click(object sender, EventArgs e) {
            this.setMinigame("palmeiras");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPenalte Penalte = new FrmPenalte();
            Penalte.Show();
        }
    }
}
