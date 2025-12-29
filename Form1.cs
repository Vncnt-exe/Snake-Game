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
    public partial class gameForm : Form
    {
        private List<Point> snake = new List<Point>();
        private Point food;
        private Direction currentDirection = Direction.Right;
        private int score = 0;
        private static int highscore = 0;
        private Random random = new Random();
        private const int TileSize = 20;
        private bool gameRunning = true;
        private Direction nextDirection = Direction.Right;

        private enum Direction { Up, Down, Left, Right }
        public gameForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Con ran co do dai = 3 luc dau
            snake.Clear();
            snake.Add(new Point(5, 10));
            snake.Add(new Point(4, 10));
            snake.Add(new Point(3, 10));

            GenerateFood();

            score = 0;
            lblHighScore.Text = $"High Score: {highscore}";
        }
        // Random vi tri qua tao
        private void GenerateFood()
{
    int maxX = panelGame.Width / TileSize;
    int maxY = panelGame.Height / TileSize;

    List<Point> availablePoints = new List<Point>();

    for (int x = 0; x < maxX; x++)
    {
        for (int y = 0; y < maxY; y++)
        {
            Point p = new Point(x, y);
            if (!snake.Contains(p))
            {
                availablePoints.Add(p);
            }
        }
    }

    if (availablePoints.Count > 0)
    {
        int index = random.Next(availablePoints.Count);
        food = availablePoints[index];
    }
}
        // Chuyen huong di chuyen cua con ran
        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            Direction newDirection = currentDirection;

            switch (e.KeyCode)
            {
                case Keys.Up when currentDirection != Direction.Down:
                    newDirection = Direction.Up;
                    break;
                case Keys.Down when currentDirection != Direction.Up:
                    newDirection = Direction.Down;
                    break;
                case Keys.Left when currentDirection != Direction.Right:
                    newDirection = Direction.Left;
                    break;
                case Keys.Right when currentDirection != Direction.Left:
                    newDirection = Direction.Right;
                    break;
            }

            if (newDirection != currentDirection)
            {
                nextDirection = newDirection;
            }
        }

        // Ve lai con ran lien tuc
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (!gameRunning) return;

            MoveSnake();
            CheckCollision();
            panelGame.Invalidate();
        }
        private void CheckCollision()
        {
            Point head = snake[0];
            int gridWidth = panelGame.Width / TileSize;
            int gridHeight = panelGame.Height / TileSize;

            // Check dung tuong
            if (head.X < 0 || head.X >= gridWidth ||
                head.Y < 0 || head.Y >= gridHeight)
            {
                GameOver();
                return;
            }

            // Check tu dung vao ban than
            for (int i = 1; i < snake.Count; i++)
            {
                if (head == snake[i])
                {
                    GameOver();
                    return;
                }
            }
        }
        // Ket thuc tro choi
        private void GameOver()
        {
            gameTimer.Stop();
            gameTimer.Enabled = false;
            
            if (score > highscore)
            {
                highscore = score;
            }

            gameRunning = false;

            gameOverForm gameOver = new gameOverForm(highscore);
            this.Hide();
            gameOver.Show();
        }

        // Logic di chuyen cua con ran
        private void MoveSnake()
        {
            currentDirection = nextDirection;

            Point head = snake[0];
            Point newHead = head;

            switch (currentDirection)
            {
                case Direction.Up:
                    newHead = new Point(head.X, head.Y - 1);
                    break;

                case Direction.Down:
                    newHead = new Point(head.X, head.Y + 1);
                    break;

                case Direction.Left:
                    newHead = new Point(head.X - 1, head.Y);
                    break;

                case Direction.Right:
                    newHead = new Point(head.X + 1, head.Y);
                    break;
            }

            snake.Insert(0, newHead);

            if (newHead == food)
            {
                score += 10;
                lblScore.Text = $"Score: {score}";
                GenerateFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }

        // Ve con ran va do an
        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < snake.Count; i++)
            {
                Brush snakeBrush = (i == 0) ? Brushes.CornflowerBlue : Brushes.Blue;

                Rectangle segment = new Rectangle(
                    snake[i].X * TileSize,
                    snake[i].Y * TileSize,
                    TileSize,
                    TileSize
                );

                g.FillRectangle(snakeBrush, segment);
                g.DrawRectangle(Pens.DarkBlue, segment);
            }

            Rectangle foodRect = new Rectangle(
                food.X * TileSize,
                food.Y * TileSize,
                TileSize,
                TileSize
            );

            g.FillEllipse(Brushes.Red, foodRect);
        }

        private void gameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
