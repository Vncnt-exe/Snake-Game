namespace Snake_Game
{
    partial class gameForm
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.PictureBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelGame)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 150;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(631, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(207, 48);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelGame.ErrorImage = null;
            this.panelGame.InitialImage = null;
            this.panelGame.Location = new System.Drawing.Point(125, 121);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1122, 761);
            this.panelGame.TabIndex = 2;
            this.panelGame.TabStop = false;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // lblHighScore
            // 
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(578, 57);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(313, 53);
            this.lblHighScore.TabIndex = 3;
            this.lblHighScore.Text = "Highscore: 0";
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 882);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.lblScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "gameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gameForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox panelGame;
        private System.Windows.Forms.Label lblHighScore;
    }
}

