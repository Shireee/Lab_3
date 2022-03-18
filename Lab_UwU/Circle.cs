using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Circle: Figure
    {
        public double r { get; set; }
        public override double GetArea()
        {
            return r * r * Math.PI;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + r / 2), (int)(Position.Y + r / 2));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, (float)r * 2, (float)r * 2);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }

}
