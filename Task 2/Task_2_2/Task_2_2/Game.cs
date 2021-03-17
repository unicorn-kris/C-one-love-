using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Game : GameElements
    {
        private Gamer _gamer;
        private List<Barrier> _barriers = new List<Barrier>();
        private List<Monster> _monsters = new List<Monster>();
        private List<Bonus> _bonuses = new List<Bonus>();
        private char [,] GameRectangle;
        private bool EndGame = false;

        public Game()// первые позиции барьеров, бонусов, геймера и монстров
        {
            GameRectangle = new char[Height, Width];
            x = 1;
            y = 1;
            _gamer = new Gamer(1,1);
            Random rnd = new Random();
            int xGame = 0;
            int yGame = 0;
            int count = rnd.Next(0, Width); //число игровых элементов - барьеров
            for (int i = 0; i < count; ++i)
            {
                xGame = rnd.Next(1, Height - 2);
                yGame = rnd.Next(1, Width - 2);
                Barrier newB = new Barrier(xGame, yGame);
                _barriers.Add(newB);
            }
            for (int i = 0; i < Height; ++i)
            { 
                _barriers.Add(new Barrier(i, 0));
                _barriers.Add(new Barrier(i, Width-1));
            }
            for (int i = 0; i < Width; ++i)
            {
                _barriers.Add(new Barrier(0, i));
                _barriers.Add(new Barrier(Height-1, i));
            }

            count = rnd.Next(0, Width); //число игровых элементов - бонусов
            for (int i = 0; i < count; ++i)
            {
                xGame = rnd.Next(1, Height - 2);
                yGame = rnd.Next(1, Width - 2);
                Bonus newB = new Bonus(xGame, yGame);
                _bonuses.Add(newB);
            }

            count = rnd.Next(0, Width); //число игровых элементов - монстров
            for (int i = 0; i < count; ++i)
            {
                xGame = rnd.Next(2, Height - 2);
                yGame = rnd.Next(2, Width - 2);
                Monster newB = new Monster(xGame, yGame);
                _monsters.Add(newB);
            }

        }
        public void GoGamer(char Way)
        {
            _gamer.Go(Way);
            if (_gamer.X > Width - 2)
            {
                _gamer.X = Width - 2;
            }
            if (_gamer.X < 1)
            {
                _gamer.X = 1;
            }
            if (_gamer.Y < 1)
            {
                _gamer.Y = 1;
            }
            if (_gamer.Y > Height - 2)
            {
                _gamer.Y = Height - 2;
            }

            for (int i=0; i<_bonuses.Count; ++i) //если попал на бонус - увеличить скорость
            {
                if (_bonuses[i].Y == _gamer.X && _bonuses[i].X == _gamer.Y)
                {
                    _gamer.Speed++;
                    _gamer.Fast = true;
                    _bonuses[i].NewPlace();
                }
            }
            
            for (int i = 0; i < _barriers.Count; ++i) //если наткнулся на препятствие - сбросить геймера в начало
            {
                if (_barriers[i].Y == _gamer.X && _barriers[i].X == _gamer.Y)
                {
                    Console.WriteLine("Препятствие!");
                    _gamer.X = 1;
                    _gamer.Y = 1;
                }
            }
            if (_gamer.X == Width-2 && _gamer.Y == Height - 2)
            {
                Console.WriteLine("Вы победили!");
                EndGame = true;
            }
           
        }
        public void GoMonster()
        {
            for (int i = 0; i < _monsters.Count; ++i)
            {
                _monsters[i].Run();
            }
            for (int i = 0; i < _monsters.Count; ++i) //если монстр напал, сбросить игру
            {
                if (_monsters[i].Y == _gamer.X && _monsters[i].X == _gamer.Y)
                {
                    Console.WriteLine("Напал монстр! Вы проиграли!");
                    EndGame = true;
                }
            }

        }
        public bool End
        {
            get
            {
                return EndGame;
            }
        }
        public void Out()
        {
            foreach (Barrier b in _barriers)
            {
                GameRectangle[b.X, b.Y] = b.Name;
            }
            foreach (Bonus b in _bonuses)
            {
                GameRectangle[b.X, b.Y] = b.Name;
            }
            foreach (Monster b in _monsters)
            {
                GameRectangle[b.X, b.Y] = b.Name;
            }

            GameRectangle[_gamer.Y, _gamer.X] = _gamer.Name;
            _gamer.Fast = false;

            for (int i=0; i<Height; ++i)
            {
                for (int j = 0; j < Width; ++j)
                    Console.Write(GameRectangle[i, j]);
                Console.WriteLine();
            }
            for (int i = 0; i < Height; ++i)
            {
                for (int j = 0; j < Width; ++j)
                    GameRectangle[i, j] = '\0';
            }
        }
    }
}
