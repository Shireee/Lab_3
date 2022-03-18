using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Trapeze : Figure 
    {
        public double base1 { get; set; }
        public double base2 { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return (base1 + base2)*Height/2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawLine(new Pen(Color), x1, y1, x2, y2);
            gr.DrawLine(new Pen(Color), x3, y3, x4, y4);
            gr.DrawLine(new Pen(Color), x1, y1, x3, y3);
            gr.DrawLine(new Pen(Color), x2, y2, x4, y4);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
