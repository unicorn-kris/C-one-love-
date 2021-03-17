using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    abstract class GameElements
    {
        protected int Width = 50;
        protected int Height = 20;
        protected int x;
        protected int y;
        protected char name;
        public int X { get; }
        public int Y { get; }
        public char Name { get; }
    }
}
