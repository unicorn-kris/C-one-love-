using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Bonus : GameElements
    {
        public Bonus(int X, int Y)
        {
            x = X;
            y = Y;
            name = 'B';
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
        public void NewPlace()
        {
            Random rnd = new Random();
            x = rnd.Next(1, Height-2);
            y = rnd.Next(1, Width - 2);
        }
    }
}
