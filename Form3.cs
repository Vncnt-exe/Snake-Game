using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class gameOverForm : Form
    {
        public gameOverForm(int highscore)
        {
            InitializeComponent();

            lblScore.Text = $"High score: {highscore}";
        }

        private void gameOverForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                ReturnToMainMenu();
            }
        }
        private void ReturnToMainMenu()
        {
            startForm mainMenu = new startForm();
            mainMenu.Show();

            this.Hide();
        }

        private void gameOverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
