using System;

namespace Task_2_1_2
{
    class Circle
    {
        protected double _x0;
        protected double _y0;
        protected double _radius;
        
        public Circle(double r)
        {
            _x0 = _y0 = 0;
            _radius = r;
        }
        public Circle()
        {
            _x0 = _y0 = 0;
            _radius = 0;
        }
        public Circle(double x, double y, double r)
        {
            _x0 = x;
            _y0 = y;
            _radius = r;
        }
        public virtual double Perimeter()
        {
            double p = 2 * Math.PI * _radius;
            return p;
        }
        public virtual double Area()
        {
            double s = Math.PI *_radius * _radius;
            return s;
        }
        public virtual void Output()
        {
            Console.WriteLine("Circle");
            Console.WriteLine($"Center coordinates: ({_x0}, {_y0}); Radius = {_radius}");
            Console.WriteLine($"Perimeter = {Perimeter():f2}; Area = {Area():f2}");
        }
    }
}
