
namespace Jogao_N2
{
    partial class FrmPenalte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPenalte));
            this.imgGoleiro = new System.Windows.Forms.PictureBox();
            this.imgJogador = new System.Windows.Forms.PictureBox();
            this.imgBola = new System.Windows.Forms.PictureBox();
            this.timerGoleiro = new System.Windows.Forms.Timer(this.components);
            this.timerBola = new System.Windows.Forms.Timer(this.components);
            this.timerMovimento = new System.Windows.Forms.Timer(this.components);
            this.timerBolaEsq = new System.Windows.Forms.Timer(this.components);
            this.timerBolaDir = new System.Windows.Forms.Timer(this.components);
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
            // FrmPenalte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(606, 739);
            this.Controls.Add(this.imgBola);
            this.Controls.Add(this.imgGoleiro);
            this.Controls.Add(this.imgJogador);
            this.DoubleBuffered = true;
            this.Name = "FrmPenalte";
            this.Text = "FrmPenalte";
            this.Load += new System.EventHandler(this.FrmPenalte_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPenalte_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgGoleiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBola)).EndInit();
            this.ResumeLayout(false);

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
    }
}