using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Rhomb : Figure
    {
        public double a { get; set; }
        public double b { get; set; }

        public override double GetArea()
        {
            return 0.5 * a * b;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X * 0.9), (int)(Position.Y * 1.2));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawLine(new Pen(Color), x1, y1, x2, y2);
            gr.DrawLine(new Pen(Color), x2, y2, x3, y3);
            gr.DrawLine(new Pen(Color), x3, y3, x4, y4);
            gr.DrawLine(new Pen(Color), x4, y4, x1, y1);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
