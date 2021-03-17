using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Monster: GameElements
    {
        public Monster(int X, int Y)
        {
            x = X;
            y = Y;
            name = 'M';
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
        public void Run()
        {
            Random rnd = new Random();
            int position = rnd.Next(0, 5);
            if (position == 1 && y + 1 > 0 && y + 1 < Width - 1)
            {
                y += 1;
            }
            else if (position == 2 && x - 1 > 0 && x - 1 < Height - 1)
            {
                x -= 1;
            }
            else if (position == 3 && y - 1 > 0 && y - 1 < Width - 1)
            {
                y -= 1;
            }
            else if (position == 4 && x + 1 > 0 && x + 1 < Height - 1)
            {
                x += 1;
            }
        }
    }
}
