namespace Jogao_N2
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.imgNPCBoss = new System.Windows.Forms.PictureBox();
            this.imgNPC1 = new System.Windows.Forms.PictureBox();
            this.timerTiro = new System.Windows.Forms.Timer(this.components);
            this.imgJogador1 = new System.Windows.Forms.PictureBox();
            this.imgColisaoGol = new System.Windows.Forms.PictureBox();
            this.imgColisao1 = new System.Windows.Forms.PictureBox();
            this.imgColisao2 = new System.Windows.Forms.PictureBox();
            this.imgBala = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.timerNPC = new System.Windows.Forms.Timer(this.components);
            this.imgNPC2 = new System.Windows.Forms.PictureBox();
            this.imgNPC3 = new System.Windows.Forms.PictureBox();
            this.imgNPC4 = new System.Windows.Forms.PictureBox();
            this.imgNPC5 = new System.Windows.Forms.PictureBox();
            this.imgNPC6 = new System.Windows.Forms.PictureBox();
            this.imgNPC7 = new System.Windows.Forms.PictureBox();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblIndicador2 = new System.Windows.Forms.Label();
            this.timerPerdeu = new System.Windows.Forms.Timer(this.components);
            this.lblIndicador1 = new System.Windows.Forms.Label();
            this.lblDificuldade = new System.Windows.Forms.Label();
            this.timerAlerta = new System.Windows.Forms.Timer(this.components);
            this.imgAjuda = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPCBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJogador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColisaoGol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColisao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColisao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAjuda)).BeginInit();
            this.SuspendLayout();
            // 
            // imgNPCBoss
            // 
            this.imgNPCBoss.BackColor = System.Drawing.Color.Transparent;
            this.imgNPCBoss.Enabled = false;
            this.imgNPCBoss.Image = ((System.Drawing.Image)(resources.GetObject("imgNPCBoss.Image")));
            this.imgNPCBoss.Location = new System.Drawing.Point(409, 42);
            this.imgNPCBoss.Name = "imgNPCBoss";
            this.imgNPCBoss.Size = new System.Drawing.Size(54, 57);
            this.imgNPCBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNPCBoss.TabIndex = 0;
            this.imgNPCBoss.TabStop = false;
            this.imgNPCBoss.Visible = false;
            // 
            // imgNPC1
            // 
            this.imgNPC1.BackColor = System.Drawing.Color.Transparent;
            this.imgNPC1.Image = ((System.Drawing.Image)(resources.GetObject("imgNPC1.Image")));
            this.imgNPC1.Location = new System.Drawing.Point(62, 90);
            this.imgNPC1.Name = "imgNPC1";
            this.imgNPC1.Size = new System.Drawing.Size(34, 38);
            this.imgNPC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNPC1.TabIndex = 2;
            this.imgNPC1.TabStop = false;
            // 
            // timerTiro
            // 
            this.timerTiro.Interval = 10;
            this.timerTiro.Tick += new System.EventHandler(this.timerTiro_Tick);
            // 
            // imgJogador1
            // 
            this.imgJogador1.BackColor = System.Drawing.Color.Transparent;
            this.imgJogador1.Image = ((System.Drawing.Image)(resources.GetObject("imgJogador1.Image")));
            this.imgJogador1.Location = new System.Drawing.Point(182, 537);
            this.imgJogador1.Name = "imgJogador1";
            this.imgJogador1.Size = new System.Drawing.Size(34, 38);
            this.imgJogador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgJogador1.TabIndex = 6;
            this.imgJogador1.TabStop = false;
            // 
            // imgColisaoGol
            // 
            this.imgColisaoGol.Location = new System.Drawing.Point(56, 581);
            this.imgColisaoGol.Name = "imgColisaoGol";
            this.imgColisaoGol.Size = new System.Drawing.Size(349, 27);
            this.imgColisaoGol.TabIndex = 7;
            this.imgColisaoGol.TabStop = false;
            this.imgColisaoGol.Visible = false;
            // 
            // imgColisao1
            // 
            this.imgColisao1.Location = new System.Drawing.Point(403, 35);
            this.imgColisao1.Name = "imgColisao1";
            this.imgColisao1.Size = new System.Drawing.Size(60, 573);
            this.imgColisao1.TabIndex = 8;
            this.imgColisao1.TabStop = false;
            this.imgColisao1.Visible = false;
            // 
            // imgColisao2
            // 
            this.imgColisao2.Location = new System.Drawing.Point(0, 35);
            this.imgColisao2.Name = "imgColisao2";
            this.imgColisao2.Size = new System.Drawing.Size(58, 573);
            this.imgColisao2.TabIndex = 9;
            this.imgColisao2.TabStop = false;
            this.imgColisao2.Visible = false;
            // 
            // imgBala
            // 
            this.imgBala.BackColor = System.Drawing.Color.Transparent;
            this.imgBala.Image = ((System.Drawing.Image)(resources.GetObject("imgBala.Image")));
            this.imgBala.Location = new System.Drawing.Point(182, 501);
            this.imgBala.Name = "imgBala";
            this.imgBala.Size = new System.Drawing.Size(34, 30);
            this.imgBala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBala.TabIndex = 10;
            this.imgBala.TabStop = false;
            this.imgBala.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(0, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(463, 37);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(64, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(124, 18);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome do Jogador";
            // 
            // timerNPC
            // 
            this.timerNPC.Enabled = true;
            this.timerNPC.Interval = 1000;
            this.timerNPC.Tick += new System.EventHandler(this.timerNPC_Tick);
            // 
            // imgNPC2
            // 
            this.imgNPC2.BackColor = System.Drawing.Color.Transparent;
            this.imgNPC2.Image = ((System.Drawing.Image)(resources.GetObject("imgNPC2.Image")));
            this.imgNPC2.Location = new System.Drawing.Point(112, 90);
            this.imgNPC2.Name = "imgNPC2";
            this.imgNPC2.Size = new System.Drawing.Size(34, 38);
            this.imgNPC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNPC2.TabIndex = 13;
            this.imgNPC2.TabStop = false;
            // 
            // imgNPC3
            // 
            this.imgNPC3.BackColor = System.Drawing.Color.Transparent;
            this.imgNPC3.Image = ((System.Drawing.Image)(resources.GetObject("imgNPC3.Image")));
            this.imgNPC3.Location = new System.Drawing.Point(162, 90);
            this.imgNPC3.Name = "imgNPC3";
            this.imgNPC3.Size = new System.Drawing.Size(34, 38);
            this.imgNPC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNPC3.TabIndex = 14;
            this.imgNPC3.TabStop = false;
            // 
            // imgNPC4
            // 
            this.imgNPC4.BackColor = System.Drawing.Color.Transparent;
            this.imgNPC4.Image = ((System.Drawing.Image)(resources.GetObject("imgNPC4.Image")));
            this.imgNPC4.Location = new System.Drawing.Point(212, 90);
            this.imgNPC4.Name = "imgNPC4";
            this.imgNPC4.Size = new System.Drawing.Size(34, 38);
            this.imgNPC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNPC4.TabIndex = 15;
            this.imgNPC4.TabStop = false;
            this.imgNPC4.Visible = false;
            // 
            // imgNPC5
            // 
            this.imgNPC5.BackColor = System.Drawing.Color.Transparent;
            this.imgNPC5.Image = ((System.Drawing.Image)(resources.GetObject("imgNPC5.Image")));
            this.imgNPC5.Location = new System.Drawing.Point(262, 90);
            this.imgNPC5.Name = "imgNPC5";
            this.imgNPC5.Size = new System.Drawing.Size(34, 38);
            this.imgNPC5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNPC5.TabIndex = 16;
            this.imgNPC5.TabStop = false;
            // 
            // imgNPC6
            // 
            this.imgNPC6.BackColor = System.Drawing.Color.Transparent;
            this.imgNPC6.Image = ((System.Drawing.Image)(resources.GetObject("imgNPC6.Image")));
            this.imgNPC6.Location = new System.Drawing.Point(312, 90);
            this.imgNPC6.Name = "imgNPC6";
            this.imgNPC6.Size = new System.Drawing.Size(34, 38);
            this.imgNPC6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNPC6.TabIndex = 17;
            this.imgNPC6.TabStop = false;
            // 
            // imgNPC7
            // 
            this.imgNPC7.BackColor = System.Drawing.Color.Transparent;
            this.imgNPC7.Image = ((System.Drawing.Image)(resources.GetObject("imgNPC7.Image")));
            this.imgNPC7.Location = new System.Drawing.Point(362, 90);
            this.imgNPC7.Name = "imgNPC7";
            this.imgNPC7.Size = new System.Drawing.Size(34, 38);
            this.imgNPC7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNPC7.TabIndex = 18;
            this.imgNPC7.TabStop = false;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.SystemColors.Control;
            this.lblPontuacao.Location = new System.Drawing.Point(338, 623);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(18, 18);
            this.lblPontuacao.TabIndex = 19;
            this.lblPontuacao.Text = "0";
            // 
            // lblIndicador2
            // 
            this.lblIndicador2.AutoSize = true;
            this.lblIndicador2.Location = new System.Drawing.Point(253, 623);
            this.lblIndicador2.Name = "lblIndicador2";
            this.lblIndicador2.Size = new System.Drawing.Size(87, 18);
            this.lblIndicador2.TabIndex = 20;
            this.lblIndicador2.Text = "Pontuação: ";
            // 
            // timerPerdeu
            // 
            this.timerPerdeu.Enabled = true;
            this.timerPerdeu.Tick += new System.EventHandler(this.timerPerdeu_Tick);
            // 
            // lblIndicador1
            // 
            this.lblIndicador1.AutoSize = true;
            this.lblIndicador1.Location = new System.Drawing.Point(60, 623);
            this.lblIndicador1.Name = "lblIndicador1";
            this.lblIndicador1.Size = new System.Drawing.Size(86, 18);
            this.lblIndicador1.TabIndex = 21;
            this.lblIndicador1.Text = "Dificuldade:";
            // 
            // lblDificuldade
            // 
            this.lblDificuldade.AutoSize = true;
            this.lblDificuldade.BackColor = System.Drawing.SystemColors.Control;
            this.lblDificuldade.Location = new System.Drawing.Point(146, 623);
            this.lblDificuldade.Name = "lblDificuldade";
            this.lblDificuldade.Size = new System.Drawing.Size(38, 18);
            this.lblDificuldade.TabIndex = 22;
            this.lblDificuldade.Text = "Facil";
            // 
            // timerAlerta
            // 
            this.timerAlerta.Tick += new System.EventHandler(this.timerAlerta_Tick);
            // 
            // imgAjuda
            // 
            this.imgAjuda.Image = ((System.Drawing.Image)(resources.GetObject("imgAjuda.Image")));
            this.imgAjuda.Location = new System.Drawing.Point(409, 623);
            this.imgAjuda.Name = "imgAjuda";
            this.imgAjuda.Size = new System.Drawing.Size(35, 33);
            this.imgAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAjuda.TabIndex = 24;
            this.imgAjuda.TabStop = false;
            this.imgAjuda.Click += new System.EventHandler(this.imgAjuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(462, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgAjuda);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblDificuldade);
            this.Controls.Add(this.lblIndicador1);
            this.Controls.Add(this.imgColisaoGol);
            this.Controls.Add(this.imgNPC7);
            this.Controls.Add(this.imgNPC6);
            this.Controls.Add(this.imgNPC5);
            this.Controls.Add(this.imgNPC4);
            this.Controls.Add(this.imgNPC3);
            this.Controls.Add(this.imgNPC2);
            this.Controls.Add(this.imgNPC1);
            this.Controls.Add(this.imgBala);
            this.Controls.Add(this.imgNPCBoss);
            this.Controls.Add(this.lblIndicador2);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.imgJogador1);
            this.Controls.Add(this.imgColisao1);
            this.Controls.Add(this.imgColisao2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soccer Defender";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgNPCBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJogador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColisaoGol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColisao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgColisao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAjuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgNPCBoss;
        private System.Windows.Forms.PictureBox imgNPC1;
        private System.Windows.Forms.Timer timerTiro;
        private System.Windows.Forms.PictureBox imgJogador1;
        private System.Windows.Forms.PictureBox imgColisaoGol;
        private System.Windows.Forms.PictureBox imgColisao1;
        private System.Windows.Forms.PictureBox imgColisao2;
        private System.Windows.Forms.PictureBox imgBala;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Timer timerNPC;
        private System.Windows.Forms.PictureBox imgNPC2;
        private System.Windows.Forms.PictureBox imgNPC3;
        private System.Windows.Forms.PictureBox imgNPC4;
        private System.Windows.Forms.PictureBox imgNPC5;
        private System.Windows.Forms.PictureBox imgNPC6;
        private System.Windows.Forms.PictureBox imgNPC7;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblIndicador2;
        private System.Windows.Forms.Timer timerPerdeu;
        private System.Windows.Forms.Label lblIndicador1;
        private System.Windows.Forms.Label lblDificuldade;
        private System.Windows.Forms.Timer timerAlerta;
        private System.Windows.Forms.PictureBox imgAjuda;
        private System.Windows.Forms.Label label1;
    }
}