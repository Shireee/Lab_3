using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2
{
    public  class Triangle : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        private double p { get; set; }
      
        public override double GetArea()
        {
            p = (a + b + c)/2;
            return  Math.Sqrt((p*(p - a)*(p - b)*(p - c)));
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X*1.1), (int)(Position.Y*1.5));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawLine(new Pen(Color), x1,y1,x2,y2);
            gr.DrawLine(new Pen(Color), x1, y1, x3, y3);
            gr.DrawLine(new Pen(Color), x2, y2, x3, y3);

            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
