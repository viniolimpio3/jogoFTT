
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
            this.goleiro = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.goleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // goleiro
            // 
            this.goleiro.BackColor = System.Drawing.Color.Transparent;
            this.goleiro.Image = ((System.Drawing.Image)(resources.GetObject("goleiro.Image")));
            this.goleiro.Location = new System.Drawing.Point(300, 186);
            this.goleiro.Name = "goleiro";
            this.goleiro.Size = new System.Drawing.Size(216, 270);
            this.goleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goleiro.TabIndex = 1;
            this.goleiro.TabStop = false;
            this.goleiro.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPenalte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.goleiro);
            this.DoubleBuffered = true;
            this.Name = "FrmPenalte";
            this.Text = "FrmPenalte";
            ((System.ComponentModel.ISupportInitialize)(this.goleiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox goleiro;
        private System.Windows.Forms.Timer timer1;
    }
}