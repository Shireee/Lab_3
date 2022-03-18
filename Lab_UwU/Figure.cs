using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public System.Drawing.Point Position { get; set; }
        public System.Drawing.Color Color { get; set; }

        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }
        public int x4 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }
        public int y3 { get; set; }
        public int y4 { get; set; }

        public abstract double GetArea();
        public abstract System.Drawing.Point GetCenter();
       public abstract void Draw(System.Drawing.Graphics gr);


    }
}

