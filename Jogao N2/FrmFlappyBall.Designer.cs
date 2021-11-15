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
            this.tmPontuacao = new System.Windows.Forms.Timer(this.components);
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
            this.pbBound = new System.Windows.Forms.PictureBox();
            this.pbCry = new System.Windows.Forms.PictureBox();
            this.pbGOL = new System.Windows.Forms.PictureBox();
            this.tmColisao = new System.Windows.Forms.Timer(this.components);
            this.tmLose = new System.Windows.Forms.Timer(this.components);
            this.pbWIN = new System.Windows.Forms.PictureBox();
            this.txtWIN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDudu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBolaRolando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGOL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWIN)).BeginInit();
            this.SuspendLayout();
            // 
            // tmPontuacao
            // 
            this.tmPontuacao.Interval = 50;
            this.tmPontuacao.Tick += new System.EventHandler(this.tmPontuacao_Tick);
            // 
            // pbDefender
            // 
            this.pbDefender.BackColor = System.Drawing.Color.Transparent;
            this.pbDefender.Image = global::Jogao_N2.Properties.Resources.jogador_removebg_preview1;
            this.pbDefender.Location = new System.Drawing.Point(519, 293);
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
            this.pbDefender4.Location = new System.Drawing.Point(37, 19);
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
            this.pbLineBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLineBack.TabIndex = 3;
            this.pbLineBack.TabStop = false;
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.Transparent;
            this.pbBall.Image = global::Jogao_N2.Properties.Resources.bolasemfundo_removebg_preview;
            this.pbBall.Location = new System.Drawing.Point(37, 332);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(37, 40);
            this.pbBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBall.TabIndex = 2;
            this.pbBall.TabStop = false;
            // 
            // pbDefender3
            // 
            this.pbDefender3.BackColor = System.Drawing.Color.Transparent;
            this.pbDefender3.Image = global::Jogao_N2.Properties.Resources.jogador_removebg_preview1;
            this.pbDefender3.Location = new System.Drawing.Point(301, 135);
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
            this.pbLose.Location = new System.Drawing.Point(214, 9);
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
            // 
            // pbBolaRolando
            // 
            this.pbBolaRolando.BackColor = System.Drawing.Color.Transparent;
            this.pbBolaRolando.Image = global::Jogao_N2.Properties.Resources.gif_bola_rolando;
            this.pbBolaRolando.Location = new System.Drawing.Point(116, 322);
            this.pbBolaRolando.Name = "pbBolaRolando";
            this.pbBolaRolando.Size = new System.Drawing.Size(54, 50);
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
            this.txtFechar.Location = new System.Drawing.Point(185, 372);
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
            // pbBound
            // 
            this.pbBound.Location = new System.Drawing.Point(590, 309);
            this.pbBound.Name = "pbBound";
            this.pbBound.Size = new System.Drawing.Size(10, 63);
            this.pbBound.TabIndex = 16;
            this.pbBound.TabStop = false;
            this.pbBound.Visible = false;
            // 
            // pbCry
            // 
            this.pbCry.BackColor = System.Drawing.Color.Transparent;
            this.pbCry.Image = global::Jogao_N2.Properties.Resources.crying_89;
            this.pbCry.Location = new System.Drawing.Point(237, 162);
            this.pbCry.Name = "pbCry";
            this.pbCry.Size = new System.Drawing.Size(141, 132);
            this.pbCry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCry.TabIndex = 17;
            this.pbCry.TabStop = false;
            this.pbCry.Visible = false;
            // 
            // pbGOL
            // 
            this.pbGOL.BackColor = System.Drawing.Color.Transparent;
            this.pbGOL.Image = global::Jogao_N2.Properties.Resources.Futebol_Trave_de_Futebol_PNG_COMFUNDO_removebg_preview;
            this.pbGOL.Location = new System.Drawing.Point(809, 74);
            this.pbGOL.Name = "pbGOL";
            this.pbGOL.Size = new System.Drawing.Size(92, 192);
            this.pbGOL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGOL.TabIndex = 18;
            this.pbGOL.TabStop = false;
            // 
            // tmColisao
            // 
            this.tmColisao.Enabled = true;
            this.tmColisao.Interval = 20;
            this.tmColisao.Tick += new System.EventHandler(this.tmColisao_Tick);
            // 
            // tmLose
            // 
            this.tmLose.Interval = 1000;
            this.tmLose.Tick += new System.EventHandler(this.tmLose_Tick);
            // 
            // pbWIN
            // 
            this.pbWIN.BackColor = System.Drawing.Color.Transparent;
            this.pbWIN.Image = global::Jogao_N2.Properties.Resources.Curinthians;
            this.pbWIN.Location = new System.Drawing.Point(91, 29);
            this.pbWIN.Name = "pbWIN";
            this.pbWIN.Size = new System.Drawing.Size(366, 225);
            this.pbWIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWIN.TabIndex = 19;
            this.pbWIN.TabStop = false;
            this.pbWIN.Visible = false;
            // 
            // txtWIN
            // 
            this.txtWIN.AutoSize = true;
            this.txtWIN.BackColor = System.Drawing.Color.Transparent;
            this.txtWIN.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWIN.Location = new System.Drawing.Point(136, 293);
            this.txtWIN.Name = "txtWIN";
            this.txtWIN.Size = new System.Drawing.Size(356, 65);
            this.txtWIN.TabIndex = 20;
            this.txtWIN.Text = "GoOoOoOooL!";
            this.txtWIN.Visible = false;
            // 
            // FlappyBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Jogao_N2.Properties.Resources.gramado_grama_Easy_Resize_com__2_;
            this.ClientSize = new System.Drawing.Size(601, 448);
            this.Controls.Add(this.pbGOL);
            this.Controls.Add(this.txtFechar);
            this.Controls.Add(this.pbBolaRolando);
            this.Controls.Add(this.pbDefender);
            this.Controls.Add(this.pbDefender4);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbDefender3);
            this.Controls.Add(this.pbLineUp);
            this.Controls.Add(this.pbLineBack);
            this.Controls.Add(this.pbDudu);
            this.Controls.Add(this.pbCry);
            this.Controls.Add(this.pbLose);
            this.Controls.Add(this.pbWIN);
            this.Controls.Add(this.txtComoJogar);
            this.Controls.Add(this.txtInstrucao);
            this.Controls.Add(this.pbBound);
            this.Controls.Add(this.txtWIN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlappyBall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBall";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBall_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyBall_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefender3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDudu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBolaRolando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGOL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbDefender;
        private System.Windows.Forms.PictureBox pbLineBack;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Timer tmPontuacao;
        private System.Windows.Forms.PictureBox pbDefender3;
        private System.Windows.Forms.PictureBox pbDefender4;
        private System.Windows.Forms.PictureBox pbLose;
        private System.Windows.Forms.PictureBox pbLineUp;
        private System.Windows.Forms.PictureBox pbDudu;
        private System.Windows.Forms.PictureBox pbBolaRolando;
        private System.Windows.Forms.Label txtComoJogar;
        private System.Windows.Forms.Label txtInstrucao;
        private System.Windows.Forms.Label txtFechar;
        private System.Windows.Forms.Timer tmCarregamento;
        private System.Windows.Forms.PictureBox pbBound;
        private System.Windows.Forms.PictureBox pbCry;
        private System.Windows.Forms.PictureBox pbGOL;
        private System.Windows.Forms.Timer tmColisao;
        private System.Windows.Forms.Timer tmLose;
        private System.Windows.Forms.PictureBox pbWIN;
        private System.Windows.Forms.Label txtWIN;
    }
}