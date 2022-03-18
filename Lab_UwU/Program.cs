using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public class Program
    {
        public static Figure[] figures =
{
            new Rectangle()
            {
                Name = "Rectangle 1",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 50,
                Height = 50
            },
            new Rectangle()
            {
                Name = "Rectangle 2",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(60, 100),
                Width = 100,
                Height = 100
            },
            new Rectangle(){
                Name = "Rectangle 3",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(200, 200),
                Width = 100,
                Height = 50
            },
            new Circle()
            {
                Name = "Circle",
                Color = System.Drawing.Color.Pink,
                Position = new System.Drawing.Point(50,250),
                r = 40
            },
            new Triangle()
            {
                Name = "Triangle",
                Color = System.Drawing.Color.Pink,
                Position = new System.Drawing.Point(500,100),
                x1 = 500,y1 = 200,x2 = 700,y2 =200, x3 = 540, y3 = 100
            },
            new Trapeze()
            {
                Name = "Trapeze",
                Color= System.Drawing.Color.Pink,
                Position = new System.Drawing.Point(425, 240),
                x1 = 350,y1 = 300, x2 = 550,y2 = 300, x3 = 425,y3 = 210, x4 = 500, y4 = 210
            },
            new Rhomb()
            {
                Name = "Rhomb",
                Color = System.Drawing.Color.Violet,
                Position = new System.Drawing.Point(500, 400),
                x1 = 500, y1 = 400, x2 = 400, y2 = 500, x3 = 500, y3 = 599, x4 = 600, y4 = 500
            },
            new Parallelogram()
            {
                Name = "Parallelogram",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(300, 500),
                x1 = 100,y1 = 500, x2 = 300,y2 = 500, x3 = 200,y3 = 400, x4 = 400, y4 = 400

            },
            new Pentagon()
            {
                Name = "Pentagon",
                Color = System.Drawing.Color.Red,
                Position = new System.Drawing.Point(200, 55),
                x1 = 200, y1 = 100, x2 = 250,y2 = 100,x3 = 300,y3 = 50,x4 = 250,y4 =0,x5 = 200,y5 = 0, x6 = 150, y6 = 50
            },
            new Decagon()
            { Name = "Dexagon",
                Color= System.Drawing.Color.Red,
                Position = new System.Drawing.Point(300, 460),
                x1 = 300, y1= 600, x2 = 400, y2 = 600,
                x3 = 500, y3 = 550, x4 = 550, y4 = 450,
                x5 = 500, y5 = 350, x6 = 400, y6 = 300,
                x7 = 300, y7 = 300, x8 = 200, y8 = 350,
                x9 = 150, y9 = 450, x10 = 200, y10 = 550
            }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Lab N3 - Polymorphism");
            Console.WriteLine("Bagdeev Vladimir");

            Figure f = new Rectangle()
            {
                Name = "Rectangle",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 50,
                Height = 50
            };

            Console.WriteLine("Figure:" + f.Name);
            Console.WriteLine("Figure {0}:", f.GetArea());
            Console.WriteLine("Color" + f.Color);
            Console.WriteLine("Figure position:" + f.Position);
            Console.WriteLine("Figure centre:" + f.GetCenter());

            Form frm = new Form()
            {
                Text = "Lab N3 - Polymorphism",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen

            };

            frm.Paint += Frm_Paint;
            Application.Run(frm);
        }
        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure h in figures)
            {
                h.Draw(e.Graphics);
            }
        }

    }
}
