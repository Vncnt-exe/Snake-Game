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
        private bool startLabelVisible = true;
        private List<Point> leftSnake = new List<Point>();
        private List<Point> rightSnake = new List<Point>();
        private const int TileSize = 40;
        private bool leftSnakeActive = true;
        public startForm()
        {
            InitializeComponent();
            InitializeSnakes();

            this.Paint += StartForm_Paint;
        }
        private void InitializeSnakes()
        {
            // Khoi tao 2 con ran
            leftSnake.Clear();
            rightSnake.Clear();

            // Con ran ben trai di tu tren xuong
            int leftX = (this.ClientSize.Width * 2 / 10) / TileSize;
            for (int i = 0; i < 5; i++)
            {
                leftSnake.Add(new Point(leftX, -5 + i));
            }

            // Con ran ben phai di tu duoi len
            int rightX = (this.ClientSize.Width * 8 / 10) / TileSize;
            for (int i = 0; i < 5; i++)
            {
                rightSnake.Add(new Point(rightX, (this.ClientSize.Height / TileSize) + 5 - i));
            }

            leftSnakeActive = true;
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

        private void startBlinkingTimer_Tick(object sender, EventArgs e)
        {
            startLabelVisible = !startLabelVisible;
            pressStartLabel.Visible = startLabelVisible;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            MoveSnakes();
            this.Invalidate();
        }

        private void MoveSnakes()
        {
            if (leftSnakeActive)
            {
                // Di chuyen con ran trai
                MoveSnakeDown(leftSnake);

                // Kiem tra con ran co di ra khoi man hinh chua
                Point lastSegment = leftSnake[leftSnake.Count - 1];
                if (lastSegment.Y > this.ClientSize.Height / TileSize)
                {
                    // Chuyen sang con ran ben phai
                    leftSnakeActive = false;

                    // Reset vi tri con ran trai ve tren cung
                    int leftX = (this.ClientSize.Width * 2 / 10) / TileSize;
                    for (int i = 0; i < leftSnake.Count; i++)
                    {
                        leftSnake[i] = new Point(leftX, -5 + i);
                    }
                }
            }
            else
            {
                // Di chuyen con ran phai
                MoveSnakeUp(rightSnake);

                // Kiem tra con ran co di ra khoi man hinh chua
                Point lastSegment = rightSnake[rightSnake.Count - 1];
                if (lastSegment.Y < 0)
                {
                    // Chuyen sang con ran trai lai
                    leftSnakeActive = true;

                    // Reset vi tri con ran phai ve duoi cung
                    int rightX = (this.ClientSize.Width * 8 / 10) / TileSize;
                    for (int i = 0; i < rightSnake.Count; i++)
                    {
                        rightSnake[i] = new Point(rightX, (this.ClientSize.Height / TileSize) + 5 - i);
                    }
                }
            }
        }

        private void MoveSnakeDown(List<Point> snake)
        {
            // Di chuyen ca con ran
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i] = snake[i - 1];
            }

            // Dau con ran di chuyen xuong
            Point head = snake[0];
            snake[0] = new Point(head.X, head.Y + 1);
        }

        private void MoveSnakeUp(List<Point> snake)
        {
            // Di chuyen ca con ran
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i] = snake[i - 1];
            }

            // Dau con ran di chuyen xuong
            Point head = snake[0];
            snake[0] = new Point(head.X, head.Y - 1);
        }
        private void StartForm_Paint(object sender, PaintEventArgs e)
        {
            DrawSnakes(e.Graphics);
        }

        private void DrawSnakes(Graphics g)
        {
            // Chi ve con ran dang di chuyen
            if (leftSnakeActive)
            {
                DrawSnake(g, leftSnake);
            }
            else
            {
                DrawSnake(g, rightSnake);
            }
        }

        private void DrawSnake(Graphics g, List<Point> snake)
        {
            for (int i = 0; i < snake.Count; i++)
            {
                if (snake[i].Y >= 0 && snake[i].Y < this.ClientSize.Height / TileSize)
                {
                    Brush brush = (i == 0) ? Brushes.CornflowerBlue : Brushes.Blue;

                    Rectangle segment = new Rectangle(
                        snake[i].X * TileSize,
                        snake[i].Y * TileSize,
                        TileSize,
                        TileSize);

                    g.FillRectangle(brush, segment);
                    g.DrawRectangle(Pens.DarkBlue, segment);
                }
            }
        }
        private void startForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            animationTimer?.Stop();
            animationTimer?.Dispose();
        }

    }
}
