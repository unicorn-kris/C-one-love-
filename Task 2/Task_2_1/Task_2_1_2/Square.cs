using System;

namespace Task_2_1_2
{
    class Square
    {
        protected double _side_a;
        protected double _x;
        protected double _y_left_lower;
        protected double _y_left_upper;
        public Square()
        {
            _side_a = 0;
            _x = 0;
            _y_left_lower = 0;
            _y_left_upper = 0;
        }
        public Square(double x, double y, double a)
        {
            _side_a = a;
            _x = x;
            _y_left_lower = y;
            _y_left_upper = y + a;
        }
        public Square(double x1, double y1, double x2, double y2)
        {
            _side_a = Math.Abs(y2 - y1);
            _x = x1;
            _y_left_lower = y1;
            _y_left_upper = y2;
        }
        public Square(double a)
        {
            _side_a = a;
            _x = 0;
            _y_left_lower = 0;
            _y_left_upper = a;
        }
        public virtual double Perimeter()
        {
            double p = 4 * _side_a;
            return p;
        }
        public virtual double Area()
        {
            double s = _side_a * _side_a;
            return s;
        }
        public virtual void Output()
        {
            Console.WriteLine($"Left side = {_side_a}; Coordinates: ({_x}, {_y_left_lower}) - ({_x}, {_y_left_upper})");
            Console.WriteLine($"Perimeter = {Perimeter()}; Area = {Area()}");
        }
    }
}
