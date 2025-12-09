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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void startForm_Load(object sender, EventArgs e)
        {

        }

        private void startForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gameForm newGameForm = new gameForm();
                
                newGameForm.Show();
                this.Hide();
            }
        }

        private void startForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
