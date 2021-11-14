using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogao_N2 {
    public partial class FrmMinigMataPalmeiras : Form {


        private string nomeJogador;
        private int interval = 2000;
        private Item[] itens;
        private int qtdAtualItens = 0;
        private const int QTD_MAX_ITENS = 10;

        struct Item {
            public PictureBox pic;
            public bool status;
        }

        public FrmMinigMataPalmeiras(string nome) {
            InitializeComponent();
            this.nomeJogador = nome;

            this.setPlayerName();
        }

        private void setPlayerName() {
            lbJogador.Text = lbJogador.Text + $" {this.nomeJogador}";
        }

        private void btnStartGame_Click(object sender, EventArgs e) {
            this.startGame();
        }

        /// <summary>
        /// Ação para inicialização do MiniGame
        /// </summary>
        private void startGame() {

            //remove os Itens do Menu inicial
            this.exibeOuRemoveMenu(false);

            this.clearItens();

            timerSpawnPalmeiras.Start();
        }

        /// <summary>
        /// Exibe ou não elementos do menus inical em tela
        /// </summary>
        /// <param name="visible"></param>
        private void exibeOuRemoveMenu(bool visible = true) {

            //Itens que aparecem no Momento do Menu
            lb_game_title.Visible = visible;
            lb_how_to_play.Visible = visible;
            lb_rule_1.Visible = visible;
            lb_rule_2.Visible = visible;
            btnStartGame.Visible = visible;
            pbLogoPalmeiras.Visible = visible;

            //Itens que aparecem no Momento do Jogo (por isso o not! rs)
            visible = !visible;
            btnStop.Visible = visible;
            lbQtdItens.Visible = visible;
                        
        }

        private void btnStop_Click(object sender, EventArgs e) {
            
            this.exibeOuRemoveMenu();

            timerSpawnPalmeiras.Stop();
        }

        private void timerSpawnPalmeiras_Tick(object sender, EventArgs e) {
            timerSpawnPalmeiras.Interval = this.interval;

            if(this.qtdAtualItens >= QTD_MAX_ITENS) {
                this.gameOver();
                return;
            }

            Item item = new Item();
            Random rand = new Random();

            //Atributos da pic box
            PictureBox pic = new PictureBox();

            pic.Height = 50;
            pic.Width = 50;
            pic.BackgroundImage = pbLogoPalmeiras.BackgroundImage;
            pic.BackgroundImageLayout = pbLogoPalmeiras.BackgroundImageLayout;
            pic.BackColor = Color.Transparent;

            int x = rand.Next(30, this.ClientSize.Width - pic.Width);
            int y = rand.Next(30, this.ClientSize.Height - pic.Height);

            pic.Location = new Point(x, y);

            pic.Click += Palmeiras_Click;

            item.pic = pic;

            this.insereItem(item);
            this.Controls.Add(pic); //Adicionando A picture em tela
        }

        private void Palmeiras_Click(object sender, EventArgs e) {
            PictureBox pic_clicada = sender as PictureBox;

            this.removeItem(pic_clicada); //Remove do vetor de Item[]

            this.Controls.Remove(pic_clicada);
        }

        /// <summary>
        /// Insere o Item no vetor de itens - no índice correto
        /// </summary>
        /// <param name="item"></param>
        private void insereItem(Item item) {
            for(int i = 0; i < itens.Length; i++) {
                if(itens[i].pic == null) {
                    itens[i] = item;
                    this.qtdAtualItens += 1;

                    lbQtdItens.Text = $"Quantidade de Palmeiras: {this.qtdAtualItens}";

                    break;
                }
            }
        }

        /// <summary>
        /// Remove do Vetor de Itens, e o reorganiza!
        /// </summary>
        /// <param name="pic"></param>
        private void removeItem(PictureBox pic) {


            int indexRemoved = 0;
            //Achando qual é o item para ser removido e colocando como null
            for(int i = 0; i < itens.Length; i++) {

                //se for null
                if (pic == null || itens[i].pic == null)
                    break;


                //se for o item.. terá o mesmo name
                if(pic.Name == itens[i].pic.Name) {
                    itens[i].pic = null;
                    indexRemoved = i;
                    this.qtdAtualItens -= 1;
                    lbQtdItens.Text = $"Quantidade de Palmeiras: {this.qtdAtualItens}";
                    break;
                }
            }

            //Construindo os novos itens

            if (indexRemoved == 0)
                return;

            int c = 0;
            while(c < itens.Length) {

                int next = c + 1;
                int prev = c - 1;

                if (c < indexRemoved) {
                    c++;
                    continue;
                }
                
                //Se foi o último item, já fez todas alterações necessárias no vetor
                if(next == itens.Length)
                    break;

                //Reorganizando o vetor
                itens[c] = itens[next];
            }
        }


        private void clearItens() {

            itens = new Item[QTD_MAX_ITENS];
            for(int i=0; i < itens.Length; i++) {
                if(itens[i].pic != null) {
                    this.Controls.Remove(itens[i].pic);
                }
                
                itens[i].pic = null;
            }
            this.qtdAtualItens = 0;
        }

        private void gameOver() {

            timerSpawnPalmeiras.Stop();
            MessageBox.Show("Perdeu :/");

            this.clearItens();
            this.exibeOuRemoveMenu();
        }
    }
}
