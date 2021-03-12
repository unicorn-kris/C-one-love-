using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_1
{
    class Kris_String
    {
        private char[] _array_string;
        private int _length;
        public Kris_String()
        {
            _length = 0;
            _array_string = new char[0];
        }
        public Kris_String (params char [] array) 
        {
            _length = array.Length;
            _array_string = new char[_length];
            for (int i=0; i< _length; ++i)
            {
                _array_string[i] = array[i];
            }
        }
        public Kris_String(int length, char symbol)
        {
            _length = length;
            _array_string = new char[_length];
            for (int i = 0; i < _length; ++i)
            {
                _array_string[i] = symbol;
            }
        }
        public Kris_String(string str)
        {
            _length = str.Length;
            _array_string = new char[_length];
            for (int i = 0; i < _length; ++i)
            {
                _array_string[i] = str[i];
            }
        }
        public Kris_String(int length)
        {
            _length = length;
            _array_string = new char[_length];
        }
        public bool Compare(Kris_String b)
        {
            Kris_String a = new Kris_String(this._array_string);
            if (a == b)
            {
                for (int i = 0; i < _length;)
                {
                    if (this[i] != b[i])
                        return false;
                    else
                        ++i;
                }
                return true;
            }
            else
                return false;
        }
        public int Find(char symbol) //last index of symbol
        {
            int num = -1;
            for (int i = 0; i < _length; ++i)
                if (this[i] == symbol)
                    num = i;
            return num;
        }
        public int Find_First(char symbol)
        {
            int num = -1;
            bool find = false;
            for (int i = 0; i < _length; ++i)
                if (this[i] == symbol && !find)
                {
                    num = i;
                    find = true;
                }
            return num;
        }
        public Kris_String Concatenation (Kris_String b)
        {
            Kris_String new_str = new Kris_String(this._length + b._length);
            for (int i = 0; i < this._length; ++i)
                new_str[i] = this[i];
            for (int i = this._length; i < new_str._length; ++i)
                new_str[i] = b[i - this._length];
            return new_str;
        }
        

        public void Output()
        {
            for (int i = 0; i < _length; ++i)
                Console.Write(_array_string[i]);
            Console.WriteLine();
        }
        public char this[int index]
        {
            get
            {
                return _array_string[index];
            }
            set
            {
                _array_string[index] = value;
            }
        }
        public static bool operator == (Kris_String a, Kris_String b)
        {
            if (a._length == b._length)
                return true;
            else return false;
        }
        public static bool operator != (Kris_String a, Kris_String b)
        {
            if (a._length == b._length)
                return false;
            else return true;
        }
        public static Kris_String operator + (Kris_String a, Kris_String b) 
        {
            Kris_String new_str = new Kris_String(a._length + b._length);
            for (int i = 0; i < a._length; ++i)
                new_str[i] = a[i];
            for (int i = a._length; i < new_str._length; ++i)
                new_str[i] = b[i - a._length];
            return new_str;
        }
        public static Kris_String operator + (Kris_String a, char[] array)
        {
            Kris_String new_str = new Kris_String(a._length + array.Length);
            for (int i = 0; i < a._length; ++i)
                new_str[i] = a[i];
            for (int i = a._length; i < new_str._length; ++i)
                new_str[i] = array[i - a._length];
            return new_str;
        }
        public static Kris_String operator + (Kris_String a, string str)
        {
            Kris_String new_str = new Kris_String(a._length + str.Length);
            for (int i = 0; i < a._length; ++i)
                new_str[i] = a[i];
            for (int i = a._length; i < new_str._length; ++i)
                new_str[i] = str[i - a._length];
            return new_str;
        }
        public static Kris_String operator + (Kris_String a, char symbol)
        {
            Kris_String new_str = new Kris_String(a._length + 1);
            for (int i = 0; i < a._length; ++i)
                new_str[i] = a[i];
            new_str[a._length] = symbol;
            return new_str;
        }

        public static implicit operator string(Kris_String a)
        {
            string result = "";
            for (int i = 0; i < a._length; ++i)
                result += a[i];
            return result;
        }
        public static explicit operator Kris_String(string a)
        {
            Kris_String result = new Kris_String(a.Length);
            for (int i = 0; i < a.Length; ++i)
                result[i] = a[i];
            return result;
        }
    }
}
