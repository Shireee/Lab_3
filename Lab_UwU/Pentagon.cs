using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Pentagon : Figure
    {
        public double h { get; set; }
        public double b { get; set; }
        public int x5 { get; set; }
        public int y5 { get; set; }
        public int x6 { get; set; }
        public int y6 { get; set; }
        public override double GetArea()
        {
            return h * b * 0.5 * 5;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawLine(new Pen(Color), x1, y1, x2, y2);
            gr.DrawLine(new Pen(Color), x2, y2, x3, y3);
            gr.DrawLine(new Pen(Color), x3, y3, x4, y4);
            gr.DrawLine(new Pen(Color), x4, y4, x5, y5);
            gr.DrawLine(new Pen(Color), x5, y5, x6, y6);
            gr.DrawLine(new Pen(Color), x6, y6, x1, y1);

            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}