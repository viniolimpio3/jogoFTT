namespace Jogao_N2
{
    partial class FlappyBall
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
            this.lbPontuacao = new System.Windows.Forms.Label();
            this.tmPontuacao = new System.Windows.Forms.Timer(this.components);
            this.pbinicio = new System.Windows.Forms.PictureBox();
            this.pbDefender = new System.Windows.Forms.PictureBox();
            this.pbDefender4 = new System.Windows.Forms.PictureBox();
            this.pbLineBack = new System.Windows.Forms.PictureBox();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pbDefender3 = new System.Windows.Forms.PictureBox();
            this.pbLose = new System.Windows.Forms.PictureBox();
            this.pbLineUp = new System.Windows.Forms.PictureBox();
            this.pbDudu = new System.Windows.Forms.PictureBox();
            this.pbBolaRolando = new System.Windows.Forms.PictureBox();
            this.txtComoJogar = new System.Windows.Forms.Label();
            this.txtInstrucao = new System.Windows.Forms.Label();
            this.txtFechar = new System.Windows.Forms.Label();
            this.tmCarregamento = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDudu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBolaRolando)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPontuacao
            // 
            this.lbPontuacao.AutoSize = true;
            this.lbPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lbPontuacao.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontuacao.Location = new System.Drawing.Point(-2, 9);
            this.lbPontuacao.Name = "lbPontuacao";
            this.lbPontuacao.Size = new System.Drawing.Size(87, 13);
            this.lbPontuacao.TabIndex = 5;
            this.lbPontuacao.Text = "Pontuação:";
            this.lbPontuacao.Click += new System.EventHandler(this.lbPontuacao_Click);
            // 
            // tmPontuacao
            // 
            this.tmPontuacao.Interval = 50;
            this.tmPontuacao.Tick += new System.EventHandler(this.tmPontuacao_Tick);
            // 
            // pbinicio
            // 
            this.pbinicio.Image = global::Jogao_N2.Properties.Resources.blogue_aniv_Silva;
            this.pbinicio.Location = new System.Drawing.Point(1, -1);
            this.pbinicio.Name = "pbinicio";
            this.pbinicio.Size = new System.Drawing.Size(10, 10);
            this.pbinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbinicio.TabIndex = 9;
            this.pbinicio.TabStop = false;
            // 
            // pbDefender
            // 
            this.pbDefender.BackColor = System.Drawing.Color.Transparent;
            this.pbDefender.Image = global::Jogao_N2.Properties.Resources.jogador_removebg_preview1;
            this.pbDefender.Location = new System.Drawing.Point(32, 282);
            this.pbDefender.Name = "pbDefender";
            this.pbDefender.Size = new System.Drawing.Size(69, 133);
            this.pbDefender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDefender.TabIndex = 1;
            this.pbDefender.TabStop = false;
            // 
            // pbDefender4
            // 
            this.pbDefender4.BackColor = System.Drawing.Color.Transparent;
            this.pbDefender4.Image = global::Jogao_N2.Properties.Resources.jogador_removebg_preview;
            this.pbDefender4.Location = new System.Drawing.Point(264, 9);
            this.pbDefender4.Name = "pbDefender4";
            this.pbDefender4.Size = new System.Drawing.Size(48, 102);
            this.pbDefender4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDefender4.TabIndex = 7;
            this.pbDefender4.TabStop = false;
            // 
            // pbLineBack
            // 
            this.pbLineBack.Image = global::Jogao_N2.Properties.Resources.image;
            this.pbLineBack.Location = new System.Drawing.Point(1, 432);
            this.pbLineBack.Name = "pbLineBack";
            this.pbLineBack.Size = new System.Drawing.Size(599, 16);
            this.pbLineBack.TabIndex = 3;
            this.pbLineBack.TabStop = false;
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.Transparent;
            this.pbBall.Image = global::Jogao_N2.Properties.Resources.bolasemfundo_removebg_preview;
            this.pbBall.Location = new System.Drawing.Point(21, 190);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(33, 34);
            this.pbBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBall.TabIndex = 2;
            this.pbBall.TabStop = false;
            // 
            // pbDefender3
            // 
            this.pbDefender3.BackColor = System.Drawing.Color.Transparent;
            this.pbDefender3.Image = global::Jogao_N2.Properties.Resources.jogador_removebg_preview1;
            this.pbDefender3.Location = new System.Drawing.Point(518, 135);
            this.pbDefender3.Name = "pbDefender3";
            this.pbDefender3.Size = new System.Drawing.Size(58, 119);
            this.pbDefender3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDefender3.TabIndex = 6;
            this.pbDefender3.TabStop = false;
            // 
            // pbLose
            // 
            this.pbLose.BackColor = System.Drawing.Color.Transparent;
            this.pbLose.Image = global::Jogao_N2.Properties.Resources._200w;
            this.pbLose.Location = new System.Drawing.Point(218, 107);
            this.pbLose.Name = "pbLose";
            this.pbLose.Size = new System.Drawing.Size(191, 147);
            this.pbLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLose.TabIndex = 8;
            this.pbLose.TabStop = false;
            this.pbLose.Visible = false;
            // 
            // pbLineUp
            // 
            this.pbLineUp.Image = global::Jogao_N2.Properties.Resources.image;
            this.pbLineUp.Location = new System.Drawing.Point(1, -1);
            this.pbLineUp.Name = "pbLineUp";
            this.pbLineUp.Size = new System.Drawing.Size(599, 10);
            this.pbLineUp.TabIndex = 10;
            this.pbLineUp.TabStop = false;
            // 
            // pbDudu
            // 
            this.pbDudu.BackColor = System.Drawing.Color.Transparent;
            this.pbDudu.BackgroundImage = global::Jogao_N2.Properties.Resources.gramado_grama_Easy_Resize_com__2_;
            this.pbDudu.Image = global::Jogao_N2.Properties.Resources.dudasv2;
            this.pbDudu.Location = new System.Drawing.Point(1, -1);
            this.pbDudu.Name = "pbDudu";
            this.pbDudu.Size = new System.Drawing.Size(599, 449);
            this.pbDudu.TabIndex = 11;
            this.pbDudu.TabStop = false;
            this.pbDudu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbBolaRolando
            // 
            this.pbBolaRolando.BackColor = System.Drawing.Color.Transparent;
            this.pbBolaRolando.Image = global::Jogao_N2.Properties.Resources.gif_bola_rolando;
            this.pbBolaRolando.Location = new System.Drawing.Point(119, 321);
            this.pbBolaRolando.Name = "pbBolaRolando";
            this.pbBolaRolando.Size = new System.Drawing.Size(53, 51);
            this.pbBolaRolando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBolaRolando.TabIndex = 12;
            this.pbBolaRolando.TabStop = false;
            // 
            // txtComoJogar
            // 
            this.txtComoJogar.AutoSize = true;
            this.txtComoJogar.BackColor = System.Drawing.Color.Transparent;
            this.txtComoJogar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComoJogar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtComoJogar.Location = new System.Drawing.Point(327, 144);
            this.txtComoJogar.Name = "txtComoJogar";
            this.txtComoJogar.Size = new System.Drawing.Size(165, 30);
            this.txtComoJogar.TabIndex = 13;
            this.txtComoJogar.Text = "COMO JOGAR :";
            // 
            // txtInstrucao
            // 
            this.txtInstrucao.AutoSize = true;
            this.txtInstrucao.BackColor = System.Drawing.Color.Transparent;
            this.txtInstrucao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstrucao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInstrucao.Location = new System.Drawing.Point(327, 179);
            this.txtInstrucao.Name = "txtInstrucao";
            this.txtInstrucao.Size = new System.Drawing.Size(235, 75);
            this.txtInstrucao.TabIndex = 14;
            this.txtInstrucao.Text = "FlappyBall\r\n\r\n- Aperte Espaço para subir";
            // 
            // txtFechar
            // 
            this.txtFechar.AutoSize = true;
            this.txtFechar.BackColor = System.Drawing.Color.Transparent;
            this.txtFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFechar.Location = new System.Drawing.Point(189, 394);
            this.txtFechar.Name = "txtFechar";
            this.txtFechar.Size = new System.Drawing.Size(193, 21);
            this.txtFechar.TabIndex = 15;
            this.txtFechar.Text = "Clique enter para iniciar";
            // 
            // tmCarregamento
            // 
            this.tmCarregamento.Enabled = true;
            this.tmCarregamento.Interval = 20;
            this.tmCarregamento.Tick += new System.EventHandler(this.tmCarregamento_Tick);
            // 
            // FlappyBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Jogao_N2.Properties.Resources.gramado_grama_Easy_Resize_com__2_;
            this.ClientSize = new System.Drawing.Size(600, 448);
            this.Controls.Add(this.txtFechar);
            this.Controls.Add(this.txtInstrucao);
            this.Controls.Add(this.txtComoJogar);
            this.Controls.Add(this.pbBolaRolando);
            this.Controls.Add(this.pbDudu);
            this.Controls.Add(this.pbLineUp);
            this.Controls.Add(this.pbLose);
            this.Controls.Add(this.pbinicio);
            this.Controls.Add(this.pbDefender);
            this.Controls.Add(this.lbPontuacao);
            this.Controls.Add(this.pbDefender4);
            this.Controls.Add(this.pbLineBack);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbDefender3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlappyBall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBall";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBall_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyBall_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDudu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBolaRolando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbDefender;
        private System.Windows.Forms.PictureBox pbLineBack;
        private System.Windows.Forms.Label lbPontuacao;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Timer tmPontuacao;
        private System.Windows.Forms.PictureBox pbDefender3;
        private System.Windows.Forms.PictureBox pbDefender4;
        private System.Windows.Forms.PictureBox pbinicio;
        private System.Windows.Forms.PictureBox pbLose;
        private System.Windows.Forms.PictureBox pbLineUp;
        private System.Windows.Forms.PictureBox pbDudu;
        private System.Windows.Forms.PictureBox pbBolaRolando;
        private System.Windows.Forms.Label txtComoJogar;
        private System.Windows.Forms.Label txtInstrucao;
        private System.Windows.Forms.Label txtFechar;
        private System.Windows.Forms.Timer tmCarregamento;
    }
}