using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Square: Figure 
    {
        public double a { get; set; }

        public override double GetArea()
        {
            return a * a;
        }

        public override Point GetCenter()
        {
            return new Point();
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)a, (int)a);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
