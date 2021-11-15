
namespace Jogao_N2
{
    partial class FrmPenalti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPenalti));
            this.imgGoleiro = new System.Windows.Forms.PictureBox();
            this.imgJogador = new System.Windows.Forms.PictureBox();
            this.imgBola = new System.Windows.Forms.PictureBox();
            this.timerGoleiro = new System.Windows.Forms.Timer(this.components);
            this.timerBola = new System.Windows.Forms.Timer(this.components);
            this.timerMovimento = new System.Windows.Forms.Timer(this.components);
            this.timerBolaEsq = new System.Windows.Forms.Timer(this.components);
            this.timerBolaDir = new System.Windows.Forms.Timer(this.components);
            this.MENSAGEM = new System.Windows.Forms.Label();
            this.timerTexto = new System.Windows.Forms.Timer(this.components);
            this.timerTentativa = new System.Windows.Forms.Timer(this.components);
            this.timerGol = new System.Windows.Forms.Timer(this.components);
            this.contGol = new System.Windows.Forms.Label();
            this.parabens = new System.Windows.Forms.Label();
            this.perdeu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgGoleiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBola)).BeginInit();
            this.SuspendLayout();
            // 
            // imgGoleiro
            // 
            this.imgGoleiro.BackColor = System.Drawing.Color.Transparent;
            this.imgGoleiro.Image = ((System.Drawing.Image)(resources.GetObject("imgGoleiro.Image")));
            this.imgGoleiro.Location = new System.Drawing.Point(217, 122);
            this.imgGoleiro.Name = "imgGoleiro";
            this.imgGoleiro.Size = new System.Drawing.Size(180, 216);
            this.imgGoleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGoleiro.TabIndex = 0;
            this.imgGoleiro.TabStop = false;
            // 
            // imgJogador
            // 
            this.imgJogador.BackColor = System.Drawing.Color.Transparent;
            this.imgJogador.Image = ((System.Drawing.Image)(resources.GetObject("imgJogador.Image")));
            this.imgJogador.Location = new System.Drawing.Point(12, 449);
            this.imgJogador.Name = "imgJogador";
            this.imgJogador.Size = new System.Drawing.Size(323, 251);
            this.imgJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgJogador.TabIndex = 1;
            this.imgJogador.TabStop = false;
            // 
            // imgBola
            // 
            this.imgBola.BackColor = System.Drawing.Color.Transparent;
            this.imgBola.Image = global::Jogao_N2.Properties.Resources.bolasemfundo_removebg_preview;
            this.imgBola.Location = new System.Drawing.Point(262, 613);
            this.imgBola.Name = "imgBola";
            this.imgBola.Size = new System.Drawing.Size(73, 71);
            this.imgBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBola.TabIndex = 2;
            this.imgBola.TabStop = false;
            // 
            // timerGoleiro
            // 
            this.timerGoleiro.Enabled = true;
            this.timerGoleiro.Tick += new System.EventHandler(this.timerGoleiro_Tick);
            // 
            // timerBola
            // 
            this.timerBola.Interval = 1;
            this.timerBola.Tick += new System.EventHandler(this.timerBola_Tick);
            // 
            // timerMovimento
            // 
            this.timerMovimento.Interval = 1;
            this.timerMovimento.Tick += new System.EventHandler(this.timerMovimento_Tick);
            // 
            // timerBolaEsq
            // 
            this.timerBolaEsq.Interval = 1;
            this.timerBolaEsq.Tick += new System.EventHandler(this.timerBolaEsq_Tick);
            // 
            // timerBolaDir
            // 
            this.timerBolaDir.Interval = 1;
            this.timerBolaDir.Tick += new System.EventHandler(this.timerBolaDir_Tick);
            // 
            // MENSAGEM
            // 
            this.MENSAGEM.BackColor = System.Drawing.Color.Transparent;
            this.MENSAGEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MENSAGEM.Font = new System.Drawing.Font("Abduction2002", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENSAGEM.ForeColor = System.Drawing.Color.Red;
            this.MENSAGEM.Location = new System.Drawing.Point(0, 0);
            this.MENSAGEM.Name = "MENSAGEM";
            this.MENSAGEM.Size = new System.Drawing.Size(606, 739);
            this.MENSAGEM.TabIndex = 3;
            this.MENSAGEM.Text = "DUDU";
            this.MENSAGEM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MENSAGEM.Click += new System.EventHandler(this.MENSAGEM_Click);
            // 
            // timerTexto
            // 
            this.timerTexto.Interval = 3500;
            this.timerTexto.Tick += new System.EventHandler(this.timerTexto_Tick);
            // 
            // timerTentativa
            // 
            this.timerTentativa.Interval = 2000;
            this.timerTentativa.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerGol
            // 
            this.timerGol.Interval = 3000;
            this.timerGol.Tick += new System.EventHandler(this.timerGol_Tick);
            // 
            // contGol
            // 
            this.contGol.AutoSize = true;
            this.contGol.BackColor = System.Drawing.Color.Transparent;
            this.contGol.Font = new System.Drawing.Font("Abduction2002", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contGol.ForeColor = System.Drawing.Color.Red;
            this.contGol.Location = new System.Drawing.Point(12, 19);
            this.contGol.Name = "contGol";
            this.contGol.Size = new System.Drawing.Size(133, 32);
            this.contGol.TabIndex = 4;
            this.contGol.Text = "GOLS: 0";
            this.contGol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contGol.Click += new System.EventHandler(this.label1_Click);
            // 
            // parabens
            // 
            this.parabens.AutoSize = true;
            this.parabens.BackColor = System.Drawing.Color.Transparent;
            this.parabens.Font = new System.Drawing.Font("Abduction2002", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parabens.ForeColor = System.Drawing.Color.Red;
            this.parabens.Location = new System.Drawing.Point(6, 405);
            this.parabens.Name = "parabens";
            this.parabens.Size = new System.Drawing.Size(593, 32);
            this.parabens.TabIndex = 5;
            this.parabens.Text = "PARABÉNS! VOCÊ GANHOU 500 PONTOS!";
            this.parabens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.parabens.Visible = false;
            // 
            // perdeu
            // 
            this.perdeu.AutoSize = true;
            this.perdeu.BackColor = System.Drawing.Color.Transparent;
            this.perdeu.Font = new System.Drawing.Font("Abduction2002", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perdeu.ForeColor = System.Drawing.Color.Red;
            this.perdeu.Location = new System.Drawing.Point(108, 405);
            this.perdeu.Name = "perdeu";
            this.perdeu.Size = new System.Drawing.Size(385, 32);
            this.perdeu.TabIndex = 6;
            this.perdeu.Text = "VOCÊ PERDEU. 0 PONTOS";
            this.perdeu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.perdeu.Visible = false;
            this.perdeu.Click += new System.EventHandler(this.perdeu_Click);
            // 
            // FrmPenalti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(606, 739);
            this.Controls.Add(this.perdeu);
            this.Controls.Add(this.parabens);
            this.Controls.Add(this.contGol);
            this.Controls.Add(this.imgBola);
            this.Controls.Add(this.imgGoleiro);
            this.Controls.Add(this.imgJogador);
            this.Controls.Add(this.MENSAGEM);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPenalti";
            this.Text = "Penalti";
            this.Load += new System.EventHandler(this.FrmPenalte_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPenalte_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgGoleiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgGoleiro;
        private System.Windows.Forms.PictureBox imgJogador;
        private System.Windows.Forms.PictureBox imgBola;
        private System.Windows.Forms.Timer timerGoleiro;
        private System.Windows.Forms.Timer timerBola;
        private System.Windows.Forms.Timer timerMovimento;
        private System.Windows.Forms.Timer timerBolaEsq;
        private System.Windows.Forms.Timer timerBolaDir;
        private System.Windows.Forms.Label MENSAGEM;
        private System.Windows.Forms.Timer timerTexto;
        private System.Windows.Forms.Timer timerTentativa;
        private System.Windows.Forms.Timer timerGol;
        private System.Windows.Forms.Label contGol;
        private System.Windows.Forms.Label parabens;
        private System.Windows.Forms.Label perdeu;
    }
}