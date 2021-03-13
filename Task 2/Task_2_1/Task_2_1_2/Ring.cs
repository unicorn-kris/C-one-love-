using System;

namespace Task_2_1_2
{
    class Ring: Circle
    {
        private double _radius_small;
        public Ring(int x, int y, double r1, double r2): base(x, y, r1)
        {
            _radius_small = r2;
        }
        public Ring(double r1, double r2): base(r1)
        {
            _radius_small = r2;
        }
        public Ring(): base()
        {
            _radius_small = 0;
        }
        public override double Perimeter()
        {
            double p = 2 * Math.PI * (_radius + _radius_small);
            return p;
        }
        public override double Area()
        {
            double s = Math.PI * (_radius * _radius - _radius_small * _radius_small);
            return s;
        }
        public virtual void Output()
        {
            Console.WriteLine($"Center coordinates: ({_x0}, {_y0}); Outer radius = {_radius}; Inner radius = {_radius_small}");
            Console.WriteLine($"Perimeter = {Perimeter()}; Area = {Area()}");
        }
    }
}
