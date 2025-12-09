namespace Snake_Game
{
    partial class gameOverForm
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
            this.lblScore = new System.Windows.Forms.Label();
            this.retryLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Location = new System.Drawing.Point(337, 326);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(749, 177);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "High Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // retryLabel
            // 
            this.retryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.retryLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.retryLabel.Location = new System.Drawing.Point(339, 541);
            this.retryLabel.Name = "retryLabel";
            this.retryLabel.Size = new System.Drawing.Size(744, 123);
            this.retryLabel.TabIndex = 1;
            this.retryLabel.Text = "Press Space to retry!";
            this.retryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameOverLabel.Location = new System.Drawing.Point(176, 131);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(1070, 155);
            this.gameOverLabel.TabIndex = 2;
            this.gameOverLabel.Text = "GAME OVER :(";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1384, 882);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.retryLabel);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "gameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gameOverForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameOverForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label retryLabel;
        private System.Windows.Forms.Label gameOverLabel;
    }
}