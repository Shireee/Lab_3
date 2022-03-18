using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Decagon : Figure
    {
        public double a { get; set; }
        public int x5 { get; set; }
        public int y5 { get; set; }
        public int x6 { get; set; }
        public int y6 { get; set; }
        public int x7 { get; set; }
        public int y7 { get; set; }
        public int x8 { get; set; }
        public int y8 { get; set; }
        public int x9 { get; set; }
        public int y9 { get; set; }
        public int x10 { get; set; }
        public int y10{ get; set; }
        public override double GetArea()
        {
            return 2.5 * a * a * Math.Sqrt(5 + 2 * Math.Sqrt(5));
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
            gr.DrawLine(new Pen(Color), x6, y6, x7, y7);
            gr.DrawLine(new Pen(Color), x7, y7, x8, y8);
            gr.DrawLine(new Pen(Color), x8, y8, x9, y9);
            gr.DrawLine(new Pen(Color), x9, y9, x10, y10);
            gr.DrawLine(new Pen(Color), x10, y10, x1, y1);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
