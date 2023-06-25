using System;

namespace Lab
{
    internal abstract class Figure
    {
        public abstract double CalculateArea(); //абстрактный метод вычисления площади для каждой фигуры
    }
    internal class Rectangle : Figure
    {
        private double length; //длина прямоугольника
        private double width; //ширина прямоугольника
        public Rectangle()
        {
            length = 0;
            width = 0;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double Length
        {
            get { return length; } set { length = value; }
        }
        public double Width
        {
            get { return width; } set { width = value; }
        }
        public override string ToString()
        {
            return $"Rectangle\nLength: {length}\nWidth: {width}";
        }
        public override double CalculateArea()
        {
            return length * width;
        }
    }
    internal class Circle : Figure
    {
        private double radius; //радиус круга
        private const double num_pi = 3.14; //число Пи (константа)
        public Circle()
        {
            radius = 0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; } set { radius = value; }
        }
        public override string ToString()
        {
            return $"Circle\nRadius: {radius}";
        }
        public override double CalculateArea()
        {
            return num_pi * radius * radius;
        }
    }
    internal class RightTriangle : Figure
    {
        private double leg_a; //горизонтальный катет треугольника
        private double leg_b; //вертикальный катет треугольника
        public RightTriangle()
        {
            leg_a = 0;
            leg_b = 0;
        }
        public RightTriangle(double leg_a, double leg_b)
        {
            this.leg_a = leg_a;
            this.leg_b = leg_b;
        }
        public double Leg_A
        {
            get { return leg_a; } set { leg_a = value; }
        }
        public double Leg_B
        {
            get { return leg_b; } set { leg_b = value; }
        }
        public override string ToString()
        {
            return $"Right triangle\nHorizontal leg: {leg_a}\nVertical leg: {leg_b}";
        }
        public override double CalculateArea()
        {
            return leg_a * leg_b / 2;
        }
    }
    internal class Trapezoid : Figure
    {
        private double line_a; //верхняя линия трапеции
        private double line_b; //нижняя линия трапеции
        private double height; //высота трапеции
        public Trapezoid()
        {
            line_a = 0;
            line_b = 0;
            height = 0;
        }
        public Trapezoid(double line_a, double line_b, double height)
        {
            this.line_a = line_a;
            this.line_b = line_b;
            this.height = height;
        }
        public double Line_A
        {
            get { return line_a; } set { line_a = value; }
        }
        public double Line_B
        {
            get { return line_b; } set { line_b = value; }
        }
        public double Height
        {
            get { return height; } set { height = value; }
        }
        public override string ToString()
        {
            return $"Trapezoid\nTop line: {line_a}\nBottom line: {line_b}\nHeight: {height}";
        }
        public override double CalculateArea()
        {
            return (line_a + line_b) / 2 * height;
        }
    }
}
