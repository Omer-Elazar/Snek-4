﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snek
{
    public class BodyPart : Circle
    {

        public BodyPart()
        {
            X = 300 - (pictureBox1.Width / 2 % 10) + 5;
            Y = 200 - (pictureBox1.Height / 2 % 10) + 5;
        }

        public BodyPart(int x, int y, int rad)
        {
            X = x;
            Y = y;
            radius = rad;
        }

        public void move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    X -= 5;
                    break;
                case Direction.Right:
                    X += 5;
                    break;
                case Direction.Up:
                    Y -= 5;
                    break;
                case Direction.Down:
                    Y += 5;
                    break;
            }
        }

        public void Draw(Graphics g, Color color)
        {
            SolidBrush br = new SolidBrush(color);
            Pen pen = new Pen(ControlPaint.Dark(color, 20) , 2);
            g.FillEllipse(br, X - radius, Y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(pen, X - radius, Y - radius, 2 * radius, 2 * radius);
        }

        public void DrawHead(Graphics g, Color color, Direction Dir)
        {
            SolidBrush br = new SolidBrush(color);
            SolidBrush br2 = new SolidBrush(Color.Black);
            Pen pen = new Pen(ControlPaint.Dark(color, 50), 2);
            g.FillEllipse(br, X - radius, Y - radius, (Dir == Direction.Right || Dir == Direction.Left ? 4 : 2) * radius, (Dir == Direction.Right || Dir == Direction.Left ? 2 : 4) * radius);
            g.DrawEllipse(pen, X - radius, Y - radius, (Dir == Direction.Right || Dir == Direction.Left ? 4 : 2) * radius, (Dir == Direction.Right || Dir == Direction.Left ? 2 : 4) * radius);
            //g.FillEllipse(br2, X, Y, (Dir == Direction.Right || Dir == Direction.Left ? 1 : 1) * radius, (Dir == Direction.Right || Dir == Direction.Left ? 1 : 1) * radius);
            //g.FillEllipse(br2, X - 5, Y - 5, (Dir == Direction.Right || Dir == Direction.Left ? 1 : 1) * radius, (Dir == Direction.Right || Dir == Direction.Left ? 1 : 1) * radius);
        }
    }
}
