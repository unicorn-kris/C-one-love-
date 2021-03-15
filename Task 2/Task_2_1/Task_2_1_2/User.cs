using System;
using System.Collections.Generic;

namespace Task_2_1_2
{
    class User
    {
        private string _name;
        private List<Circle> _circle;
        private List<Ring> _ring;
        private List<Square> _square;
        private List<Rectangle> _rectangle;
        private List<Triangle> _triangle;
        public User(string name)
        {
            _name = name;
            _circle = new List<Circle>();
            _ring = new List<Ring>();
            _square = new List<Square>();
            _rectangle = new List<Rectangle>();
            _triangle = new List<Triangle>();
        }
        public Circle AddCircle
        {
            set
            {
                _circle.Add(value);
            }
        }
        public List<Circle> OutCircle
        {
            get
            {
                return _circle;
            }
        }
        public Ring AddRing
        {
            set
            {
                _ring.Add(value);
            }
        }
        public List<Ring> OutRing
        {
            get
            {
                return _ring;
            }
        }
        public Square AddSquare
        {
            set
            {
                _square.Add(value);
            }
        }
        public List<Square> OutSquare
        {
            get
            {
                return _square;
            }
        }
        public Rectangle AddRectangle
        {
            set
            {
                _rectangle.Add(value);
            }
        }
        public List<Rectangle> OutRectangle
        {
            get
            {
                return _rectangle;
            }
        }
        public Triangle AddTriangle
        {
            set
            {
                _triangle.Add(value);
            }
        }
        public List<Triangle> OutTriangle
        {
            get
            {
                return _triangle;
            }
        }
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
    }
}
