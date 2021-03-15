using System;

namespace Task_2_1_2
{
    class Triangle
    {
        private double _side_a;
        private double _side_b;
        private double _side_c;
        public Triangle()
        {
            _side_a = 0;
            _side_b = 0;
            _side_c = 0;
        }
        public Triangle(double a, double b, double c)
        {
            _side_a = a;
            _side_b = b;
            _side_c = c;
        }
        //public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        //{
        //    _side_a = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
        //    _side_b = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
        //    _side_c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
        //}
        public virtual double Perimeter()
        {
            return _side_a + _side_b + _side_c;
        }
        public virtual double Area()
        {
            double p = (_side_a + _side_b + _side_c) / 2;
            return Math.Sqrt(p * (p - _side_a) * (p - _side_b) * (p - _side_c));
        }
        public virtual void Output()
        {
            Console.WriteLine("Triangle");
            Console.WriteLine($"Side 1 = {_side_a}; Side 2 = {_side_b}; Side 3 = {_side_c};");
            Console.WriteLine($"Perimeter = {Perimeter():f2}; Area = {Area():f2}");
        }
    }
}
