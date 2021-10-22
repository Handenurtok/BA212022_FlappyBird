
namespace BA212022_FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.pbPipe3 = new System.Windows.Forms.PictureBox();
            this.pbPipe4 = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(24, 17);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 29);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score ";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 80;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // pbPipe3
            // 
            this.pbPipe3.Image = global::BA212022_FlappyBird.Properties.Resources.pipe;
            this.pbPipe3.Location = new System.Drawing.Point(509, 186);
            this.pbPipe3.Name = "pbPipe3";
            this.pbPipe3.Size = new System.Drawing.Size(35, 127);
            this.pbPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe3.TabIndex = 6;
            this.pbPipe3.TabStop = false;
            // 
            // pbPipe4
            // 
            this.pbPipe4.Image = global::BA212022_FlappyBird.Properties.Resources.pipedown;
            this.pbPipe4.Location = new System.Drawing.Point(676, 1);
            this.pbPipe4.Name = "pbPipe4";
            this.pbPipe4.Size = new System.Drawing.Size(35, 137);
            this.pbPipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe4.TabIndex = 5;
            this.pbPipe4.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbGround.Image = global::BA212022_FlappyBird.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(0, 312);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(753, 50);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 3;
            this.pbGround.TabStop = false;
            // 
            // pbPipe1
            // 
            this.pbPipe1.Image = global::BA212022_FlappyBird.Properties.Resources.pipe;
            this.pbPipe1.Location = new System.Drawing.Point(225, 218);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(35, 95);
            this.pbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe1.TabIndex = 2;
            this.pbPipe1.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.Image = global::BA212022_FlappyBird.Properties.Resources.pipedown;
            this.pbPipe2.Location = new System.Drawing.Point(317, 1);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(41, 103);
            this.pbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe2.TabIndex = 1;
            this.pbPipe2.TabStop = false;
            // 
            // pbBird
            // 
            this.pbBird.Image = global::BA212022_FlappyBird.Properties.Resources.birdnew;
            this.pbBird.Location = new System.Drawing.Point(27, 139);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(41, 32);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 362);
            this.Controls.Add(this.pbPipe3);
            this.Controls.Add(this.pbPipe4);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbPipe1);
            this.Controls.Add(this.pbPipe2);
            this.Controls.Add(this.pbBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbPipe4;
        private System.Windows.Forms.PictureBox pbPipe3;
        private System.Windows.Forms.Timer tmrGame;
    }
}

