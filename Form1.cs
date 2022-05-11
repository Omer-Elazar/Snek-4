using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snek
{
    public partial class Form1 : Form
    {
        // TODO: 
        // pause when minimize window
        // check change direcion (witch func works)
        // make save, load, snap btns
        // make unpause
        // disable mouse events if !gaming
        // add instructions
        // try to disable switching btns with arrows
        // try to make CheckWalls accurate
        // Add option to start new save / new round
        public Form1()
        {
            InitializeComponent();
        }

        Snake snake;
        AppleList Apples;
        GoldenApple golden;
        Random rand;

        public int score = 0;
        public int highscore = 0;

        public bool gaming = false;
        public bool goLeft, goRight, goDown, goUp;
        int MouseIndex = -1;
        int GoldenOpacity = 255;

        Color SnakeColor = Color.Green;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Pausebtn_Click(object sender, EventArgs e)
        {
            if (Pausebtn.Text == "Resume")
            {
                Pausebtn.Text = "Pause";
                timer1.Start();
                GoldenTimer.Start();
                Newbtn.Enabled = false;
                Startbtn.Enabled = false;
                timer1.Enabled = true;
                GoldenTimer.Enabled = true;
                Pausebtn.Enabled = true;
                Snapbtn.Enabled = false;
                Loadbtn.Enabled = false;
                Savebtn.Enabled = false;
                Colorbtn.Enabled = false;
            }
            else
            {
                timer1.Stop();
                GoldenTimer.Stop();
                Pausebtn.Text = "Resume";
                Startbtn.Text = "Restart";
                Newbtn.Enabled = true;
                Startbtn.Enabled = true;
                Savebtn.Enabled = true;
                Snapbtn.Enabled = true;
                Loadbtn.Enabled = true;
                timer1.Enabled = false;
                GoldenTimer.Enabled = false;
                Colorbtn.Enabled = true;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }

        private void Snapbtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!gaming)
            {
                return;
            }
            Graphics g = e.Graphics;
            int i;
            for (i = 0; i < snake.snake.Count; i++)
            {
                if (i == snake.snake.Count - 1)
                {
                    snake.snake[i].DrawHead(g, SnakeColor, snake.Dir);
                }
                else
                {
                    snake.snake[i].Draw(g, SnakeColor);
                }
            }
            for (i = 0; i < Apples.Apples.Count; i++)
            {
                Apples[i].Draw(g);
            }
            if (golden.exist)
            {
                golden.Draw(g, GoldenOpacity);
                if (GoldenOpacity >= 3)
                {
                    GoldenOpacity -= 3;
                }
            }
        }

        private void GoldenTimerTick(object sender, EventArgs e)
        {
            if (golden.exist)
            {
                GoldenOpacity = 255;
                golden.exist = false;
                golden.Dispose();
            }
            if (rand.Next(0, 2) == 1)
            {
                golden = new GoldenApple();
                bool isnoton = false;
                int x, y;
                while (!isnoton)
                {
                    golden.X = rand.Next(5, 400);
                    golden.X = golden.X - (golden.X % 10) + 5;
                    golden.Y = rand.Next(5, 350);
                    golden.Y = golden.Y - (golden.Y % 10) + 5;
                    int i;
                    for (i = 0; i < snake.snake.Count; i++)
                    {
                        if (snake.snake[i].IsOn(golden))
                        {
                            golden.X = rand.Next(5, 400);
                            golden.X = golden.X - (golden.X % 10) + 5;
                            golden.Y = rand.Next(5, 350);
                            golden.Y = golden.Y - (golden.Y % 10) + 5;
                            break;
                        }
                    }
                    isnoton = true;
                }
                golden.exist = true;
            }
            pictureBox1.Invalidate();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Scoretxt.BackColor = Color.White;
            snake.CheckWalls();
            if (goLeft)
            {
                snake.Dir = Direction.Left;
            }
            if (goRight)
            {
                snake.Dir = Direction.Right;
            }
            if (goDown)
            {
                snake.Dir = Direction.Down;
            }
            if (goUp)
            {
                snake.Dir = Direction.Up;
            }
            snake.Move();
            snake.CheckWalls();
            if (snake.IsHitTail())
            {
                GameOver();
            }
            if (golden.exist && snake.GetNextPoint().IsOn(golden))//is on golden apple
            {
                score += 5;
                golden.Eat();
                GoldenOpacity = 255;
                Scoretxt.BackColor = Color.Gold;
            }
            else
            {
                int i;
                for (i = 0; i < Apples.Apples.Count; i++)
                {
                    if (snake.snake[snake.snake.Count - 1].IsOn(Apples[i]))//is on apple
                    {
                        snake.grow();
                        Apples[i].Eat();
                        score++;
                        Apples.Apples.RemoveAt(i);
                        if (Apples.Apples.Count == 0)
                        {
                            Apples[0] = new Apple();
                            bool isnoton = false;
                            int x, y;
                            while (!isnoton)
                            {
                                Apples[0].X = rand.Next(5, 400);
                                Apples[0].X = Apples[0].X - (Apples[0].X % 10) + 5;
                                Apples[0].Y = rand.Next(5, 350);
                                Apples[0].Y = Apples[0].Y - (Apples[0].Y % 10) + 5;
                                for (i = 0; i < snake.snake.Count; i++)
                                {
                                    if (snake.snake[i].IsOn(Apples[0]))
                                    {
                                        Apples[0].X = rand.Next(5, 400);
                                        Apples[0].X = Apples[0].X - (Apples[0].X % 10) + 5;
                                        Apples[0].Y = rand.Next(5, 350);
                                        Apples[0].Y = Apples[0].Y - (Apples[0].Y % 10) + 5;
                                        break;
                                    }
                                }
                                isnoton = true;
                            }
                        }
                    }
                }
            }
            Scoretxt.Text = "Score: " + score;
            pictureBox1.Invalidate();
        } 

        private void Loadbtn_Click(object sender, EventArgs e)
        {

        }

        private void GameOver()
        {
            gaming = false;
            timer1.Stop();
            GoldenTimer.Stop();
            Pausebtn.Enabled = false;
            Newbtn.Enabled = true;
            Startbtn.Enabled = true;
            Savebtn.Enabled = true;
            Snapbtn.Enabled = true;
            Loadbtn.Enabled = true;
            Colorbtn.Enabled = true;
            GameOvertxt.Visible = true;
            if (score > highscore)
            {
                highscore = score;
                HighScoretxt.Text = "New!! HighScore: " + highscore.ToString();
                HighScoretxt.BackColor = Color.Yellow;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gaming)
            {
                return;
            }
            MouseIndex = -1;
            int i;
            for (i = 0; i < Apples.Apples.Count; i++)
            {
                if (e.X > Apples[i].X - 5 && e.X < Apples[i].X + 5 && e.Y > Apples[i].Y - 5 && e.Y < Apples[i].Y + 5)
                {
                    MouseIndex = i;
                    if (e.Button == MouseButtons.Right)
                    {
                        Apples.Apples.RemoveAt(i);
                        MouseIndex = -1;
                        pictureBox1.Invalidate();
                        return;
                    }
                }
            }
            if (MouseIndex < 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    bool ison  =false;
                    for (i = 0; i < snake.snake.Count; i++)
                    {
                        if (e.X > snake.snake[i].X - 8 && e.X < snake.snake[i].X + 8 && e.Y > snake.snake[i].Y - 8 && e.Y < snake.snake[i].Y + 8)
                        {
                            ison = true;
                        }
                    }
                    for (i = 0; i < Apples.Apples.Count; i++)
                    {
                        if (e.X > Apples[i].X - 8 && e.X < Apples[i].X + 8 && e.Y > Apples[i].Y - 8 && e.Y < Apples[i].Y + 8)
                        {
                            ison = true;
                        }
                    }
                    if (golden.exist && e.X > golden.X - 8 && e.X < golden.X + 8 && e.Y > golden.Y - 8 && e.Y < golden.Y + 8)
                    {
                        ison = true;
                    }
                    if (!ison)
                    {
                        Apples[Apples.Apples.Count] = new Apple(e.X, e.Y);
                    }
                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseIndex >= 0)
            {
                int i;
                bool ison = false;
                for (i = 0; i < snake.snake.Count; i++)
                {
                    if (e.X > snake.snake[i].X - 8 && e.X < snake.snake[i].X + 8 && e.Y > snake.snake[i].Y - 8 && e.Y < snake.snake[i].Y + 8)
                    {
                        ison = true;
                    }
                }
                for (i = 0; i < Apples.Apples.Count; i++)
                {
                    if (e.X > Apples[i].X - 8 && e.X < Apples[i].X + 8 && e.Y > Apples[i].Y - 8 && e.Y < Apples[i].Y + 8)
                    {
                        ison = true;
                    }
                }
                if (golden.exist && e.X > golden.X - 8 && e.X < golden.X + 8 && e.Y > golden.Y - 8 && e.Y < golden.Y + 8)
                {
                    ison = true;
                }
                if (!ison)
                {
                    Apples[MouseIndex].X = e.X - (e.X % 10) + 5;
                    Apples[MouseIndex].Y = e.Y - (e.Y % 10) + 5;
                }
                pictureBox1.Invalidate();
            }
        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Would you like to save?",
                                     "New game",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Savebtn_Click(sender, e);
            }
            timer1.Start();
            GoldenTimer.Start();
            Newbtn.Enabled = false;
            timer1.Enabled = true;
            GoldenTimer.Enabled = true;
            Pausebtn.Enabled = true;
            Snapbtn.Enabled = false;
            Loadbtn.Enabled = true;
            Savebtn.Enabled = false;
            Colorbtn.Enabled = false;

            snake = new Snake();
            int i;
            for (i = 0; i < 10; i++)
            {
                snake.snake.Add(new BodyPart());
                snake.snake[snake.snake.Count - 1].X -= 5;
            }
            Apples = new AppleList();
            golden = new GoldenApple();
            rand = new Random();

            score = 0;
            highscore = 0;
            Scoretxt.Text = "Score: " + score;
            HighScoretxt.Text = "HighScore: " + highscore;
            HighScoretxt.BackColor = Color.White;
            gaming = false;
            Pausebtn.Text = "Pause";
            Startbtn.Text = "Start";
            GameOvertxt.Visible = false;
            pictureBox1.Invalidate();
        }

        private void Stratbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            GoldenTimer.Start();
            Newbtn.Enabled = false;
            Startbtn.Enabled = false;
            timer1.Enabled = true;
            GoldenTimer.Enabled = true;
            Pausebtn.Enabled = true;
            Snapbtn.Enabled = false;
            Loadbtn.Enabled = false;
            Savebtn.Enabled = false;
            Colorbtn.Enabled = false;

            snake = new Snake();
            int i;
            for (i = 0; i < 10; i++)
            {
                snake.snake.Add(new BodyPart());
                snake.snake[snake.snake.Count - 1].X -= 5;
            }
            Apples = new AppleList();
            golden = new GoldenApple();
            rand = new Random();

            score = 0;
            Scoretxt.Text = "Score: " + score;
            HighScoretxt.Text = "HighScore: " + highscore;
            HighScoretxt.BackColor = Color.White;
            gaming = true;
            Pausebtn.Text = "Pause";
            GameOvertxt.Visible = false;
            pictureBox1.Invalidate();
        }

        private void Colorbtn_Click(object sender, EventArgs e)
        {
            if (!gaming)
            {
                return;
            }
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = false;
            MyDialog.Color = SnakeColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < snake.snake.Count; i++)
                {
                    SnakeColor = MyDialog.Color;
                }
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIndex = -1;
            pictureBox1.Invalidate();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!gaming)
            {
                return false;
            }
            //capture up arrow key
            if (keyData == Keys.Up && snake.Dir != Direction.Down)
            {
                snake.Dir = Direction.Up;
            }
            //capture down arrow key
            if (keyData == Keys.Down && snake.Dir != Direction.Up)
            {
                snake.Dir = Direction.Down;
            }
            //capture left arrow key
            if (keyData == Keys.Left && snake.Dir != Direction.Right)
            {
                snake.Dir = Direction.Left;
            }
            //capture right arrow key
            if (keyData == Keys.Right && snake.Dir != Direction.Left)
            {
                snake.Dir = Direction.Right;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
