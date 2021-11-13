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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imgBala = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.timerNPC = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgNPCBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJogador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // imgNPCBoss
            // 
            this.imgNPCBoss.BackColor = System.Drawing.Color.Transparent;
            this.imgNPCBoss.Image = ((System.Drawing.Image)(resources.GetObject("imgNPCBoss.Image")));
            this.imgNPCBoss.Location = new System.Drawing.Point(202, 35);
            this.imgNPCBoss.Name = "imgNPCBoss";
            this.imgNPCBoss.Size = new System.Drawing.Size(54, 57);
            this.imgNPCBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNPCBoss.TabIndex = 0;
            this.imgNPCBoss.TabStop = false;
            // 
            // imgNPC1
            // 
            this.imgNPC1.BackColor = System.Drawing.Color.Transparent;
            this.imgNPC1.Image = ((System.Drawing.Image)(resources.GetObject("imgNPC1.Image")));
            this.imgNPC1.Location = new System.Drawing.Point(56, 98);
            this.imgNPC1.Name = "imgNPC1";
            this.imgNPC1.Size = new System.Drawing.Size(34, 38);
            this.imgNPC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNPC1.TabIndex = 2;
            this.imgNPC1.TabStop = false;
            this.imgNPC1.Visible = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 598);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 10);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(403, 537);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 71);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 537);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 71);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
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
            this.pictureBox4.Size = new System.Drawing.Size(463, 10);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(124, 18);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome do Jogador";
            // 
            // timerNPC
            // 
            this.timerNPC.Enabled = true;
            this.timerNPC.Interval = 2000;
            this.timerNPC.Tick += new System.EventHandler(this.timerNPC_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(462, 676);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.imgBala);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgJogador1);
            this.Controls.Add(this.imgNPC1);
            this.Controls.Add(this.imgNPCBoss);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgNPCBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNPC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJogador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgNPCBoss;
        private System.Windows.Forms.PictureBox imgNPC1;
        private System.Windows.Forms.Timer timerTiro;
        private System.Windows.Forms.PictureBox imgJogador1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox imgBala;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Timer timerNPC;
    }
}