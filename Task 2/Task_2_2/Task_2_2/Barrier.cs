using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Barrier: GameElements
    {
        public Barrier(int X, int Y)
        {
            x = X;
            y = Y;
            name = '*';
        }
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public char Name
        {
            get
            {
                return name;
            }
        }
    }
}
