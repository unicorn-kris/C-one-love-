using System;

namespace Task_2_1_2
{
    class Rectangle: Square
    {
        private double _side_b;
        protected double _x2;
        public Rectangle() : base ()
        {
            _side_b = 0;
            _x2 = 0;
        }
        public Rectangle(double x1, double y1, double a, double b): base (x1, y1, a)
        {
            _side_b = b;
            _x2 = x1 + b;
        }
        public Rectangle(double x1, double y1, double x2, double y2, double x3): base(x1, y1, x2, y2)
        {
            _side_b = Math.Abs(x3 - x1);
            _x2 = x3;
        }
        public Rectangle(double a, double b): base (a)
        {
            _side_b = b;
            _x2 = b;
        }
        public override double Perimeter()
        {
            double p = _side_b * 2 + (_side_a * 2);
            return p;
        }
        public override double Area()
        {
            double s = _side_b * _side_a;
            return s;
        }
        public override void Output()
        {
            Console.WriteLine($"Left side = {_side_a}; Coordinates: ({_x}, {_y_left_lower}) - ({_x}, {_y_left_upper})");
            Console.WriteLine($"Lower side = {_side_b}; Coordinates: ({_x}, {_y_left_lower}) - ({_x2}, {_y_left_lower})");
            Console.WriteLine($"Perimeter = {Perimeter()}; Area = {Area()}");
        }
    }
}
