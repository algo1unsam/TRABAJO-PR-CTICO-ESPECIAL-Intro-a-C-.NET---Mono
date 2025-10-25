using System;
using System.Drawing;

namespace Figuras
{
    public class Figura
    {
        public virtual void Dibujar(Pen pen, Graphics graphics, int x, int y)
        {

        }
    }

    public class Rectangulo : Figura
    {
        protected int alto;
        protected int ancho;

        // Constructor
        public Rectangulo(int ancho, int alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public override void Dibujar(Pen pen, Graphics graphics, int x, int y)
        {
            Point[] points = new Point[4]
            {
                new Point(x, y),
                new Point(x + ancho, y),
                new Point(x + ancho, y + alto),
                new Point(x, y + alto)
            };

            graphics.DrawPolygon(pen, points);
        }
    }

    public class Cuadrado : Rectangulo
    {
        public Cuadrado(int lado) : base(lado, lado)
        {
        }
    }

    public class Circulo : Figura
    {
        private int radio;

        public Circulo(int radio)
        {
            this.radio = radio;
        }

        public override void Dibujar(Pen pen, Graphics graphics, int x, int y)
        {
            graphics.DrawEllipse(pen, x, y, radio, radio);
        }
    }

    public class TrianguloIsosceles : Figura
    {
        private int baseTriangulo;
        private int altura;

        public TrianguloIsosceles(int baseTriangulo, int altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override void Dibujar(Pen pen, Graphics graphics, int x, int y)
        {
            Point[] points = new Point[3]
            {
                new Point(x + baseTriangulo / 2, y),               
                new Point(x, y + altura),                          
                new Point(x + baseTriangulo, y + altura)           
            };

            graphics.DrawPolygon(pen, points);
        }
    }

    public class TrianguloEquilatero : Figura
    {
        private int lado;

        public TrianguloEquilatero(int lado)
        {
            this.lado = lado;
        }

        public override void Dibujar(Pen pen, Graphics graphics, int x, int y)
        {
            int altura = (int)(Math.Sqrt(3) / 2 * lado);

            Point[] points = new Point[3]
            {
                new Point(x + lado / 2, y),         
                new Point(x, y + altura),              
                new Point(x + lado, y + altura)         
            };

            graphics.DrawPolygon(pen, points);
        }
    }
}
