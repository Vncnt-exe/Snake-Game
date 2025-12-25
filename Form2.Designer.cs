namespace Snake_Game
{
    partial class startForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pressStartLabel = new System.Windows.Forms.Label();
            this.startBlinkingTimer = new System.Windows.Forms.Timer(this.components);
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(360, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "SNAKE GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pressStartLabel
            // 
            this.pressStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressStartLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pressStartLabel.Location = new System.Drawing.Point(337, 474);
            this.pressStartLabel.Name = "pressStartLabel";
            this.pressStartLabel.Size = new System.Drawing.Size(730, 130);
            this.pressStartLabel.TabIndex = 1;
            this.pressStartLabel.Text = "Press \'Space\' to start!";
            this.pressStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBlinkingTimer
            // 
            this.startBlinkingTimer.Enabled = true;
            this.startBlinkingTimer.Interval = 500;
            this.startBlinkingTimer.Tick += new System.EventHandler(this.startBlinkingTimer_Tick);
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 120;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1384, 882);
            this.Controls.Add(this.pressStartLabel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.startForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pressStartLabel;
        private System.Windows.Forms.Timer startBlinkingTimer;
        private System.Windows.Forms.Timer animationTimer;
    }
}