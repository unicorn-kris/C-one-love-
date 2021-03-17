using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Gamer: GameElements
    {
        private int _Speed;
        private bool _fast;
       
        public Gamer(int X, int Y)
        {
            x = X;
            y = Y;
            _Speed = 1;
            name = 'G';
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public bool Fast
        {
            get
            {
                return _fast;
            }
            set
            {
                _fast = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public char Name
        {
            get
            {
                return name;
            }
        }
        public int Speed
        {
            get
            {
                return _Speed;
            }
            set
            {
                _Speed = value;
            }
        }
        public void ClearSpeed()
        { 

                _Speed = 1;
            
        }

        public void Go (char WASD)
        {
            if (Char.ToLower(WASD) == 'w' && Y >= 0 && Y <= Height)
            {
                y -= Speed;
            }
            else if (Char.ToLower(WASD) == 'a' && X >= 0 && X <= Width)
            {
                x -= Speed;
            }
            else if (Char.ToLower(WASD) == 's' && X >= 0 && X <= Width)
            {
                y += Speed;
            }
            else if (Char.ToLower(WASD) == 'd' && X >= 0 && X <= Width)
            {
                x += Speed;
            }
            else
                Console.WriteLine("Для перемещения используй одну из кнопок WASD");
        }

    }
}
