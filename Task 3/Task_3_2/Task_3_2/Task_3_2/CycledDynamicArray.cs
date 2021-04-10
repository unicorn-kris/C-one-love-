using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_3_2
{
    class CycledDynamicArray<T>:  IEnumerable, IEnumerable<T>, ICloneable
    {
{
        private T[] _array;

        public CycledDynamicArray()
        {
            T[] newArray = new T[8];
            _array = newArray;
        }
        public CycledDynamicArray(int capacity)
        {
            T[] newArray = new T[capacity];
            _array = newArray;
        }
        public CycledDynamicArray(IEnumerable<T> collection)
        {
            T[] newArray = new T[collection.Count()];
            int i = 0;
            foreach (var element in collection)
            {
                newArray[i] = element;
                ++i;
            }
            _array = newArray;
        }

        public int Length
        {
            get
            {
                int count = 0;
                foreach (T element in _array)
                {
                    if (element != null)
                        ++count;
                }
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return _array.Length;
            }
        }

        public void Add(T newElement)
        {
            int size = _array.Length;
            int count = 0;
            foreach (T element in _array)
            {
                if (element != null)
                    ++count;
            }
            if (count == _array.Length)
            {
                size *= 2;
            }

            T[] newArray = new T[size];
            int i = 0;
            foreach (T element in _array)
            {
                newArray[i] = element;
                ++i;
            }
            newArray[i] = newElement;
            _array = newArray;
        }
        public void AddRange(IEnumerable<T> collection)
        {
            int size = _array.Length;

            int count = 0;
            foreach (T element in _array)
            {
                if (element != null)
                    ++count;
            }
            if (size - count < collection.Count())
            {
                size += collection.Count();
            }

            T[] newArray = new T[size];
            int i = 0;
            foreach (T element in _array)
            {
                newArray[i] = element;
                ++i;
            }
            foreach (T element in collection)
            {
                newArray[i] = element;
                ++i;
            }
            _array = newArray;
        }
        public bool Remove(int deleteElement)
        {
            bool delete = false;
            T[] newArray = _array;
            for (int i = 0; i < newArray.Length; ++i)
            {
                if (i == deleteElement)
                {
                    delete = true;
                    for (int j = i; j < newArray.Length - 1; ++j)
                    {
                        newArray[j] = newArray[j + 1];
                    }
                    break;
                }
            }
            _array = newArray;
            return delete;
        }
        public bool Insert(T insertElement, int place)
        {
            bool insert = true;
            int size = _array.Length;

            T elementInPosition;
            try
            {
                elementInPosition = _array[place];
            }
            catch (ArgumentOutOfRangeException e)
            {
                insert = false;
                Console.WriteLine("ArgumentOutOfRangeException");
            }

            if (insert)
            {
                int count = 0;
                foreach (T element in _array)
                {
                    if (element != null)
                        ++count;
                }
                if (size == count)
                {
                    size *= 2;
                }

                T[] newArray = new T[size];
                int i = 0;
                for (int j = 0; j < _array.Length; ++j)
                {
                    if (j == place)
                    {
                        newArray[i] = insertElement;
                        --j;
                    }
                    else
                    {
                        newArray[i] = _array[j];
                    }
                    ++i;
                }
                _array = newArray;
            }
            return insert;
        }
        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)_array).GetEnumerator();
        }
       
        public T this[int index]
        {
            get
            {
                try
                {
                    T elementInPosition = _array[Math.Abs(index)];
                }
                catch (ArgumentOutOfRangeException e)
                {
                    if (e.Data == null)
                    {
                        if (index < 0)
                            return _array[_array.Length - index];
                        else
                            return _array[index];
                    }
                    else
                    {
                        Console.WriteLine("ArgumentOutOfRangeException");
                        return default(T);
                    }
                }
                return default(T);
            }
            set
            {
                try
                {
                    T elementInPosition = _array[Math.Abs(index)];
                }
                catch (ArgumentOutOfRangeException e)
                {
                    if (e.Data == null)
                    {
                        if (index < 0)
                            _array[_array.Length - index] = value;
                        else
                            _array[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("ArgumentOutOfRangeException");
                    }
                }
            }
        }
        public void ChangeCapacity(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            int i = 0;
            foreach (T element in _array)
            {
                newArray[i] = element;
                ++i;
            }
            _array = newArray;
        }
        public object Clone()
        {
            return _array;
        }
        public T[] ToArray()
        {
            T[] newArray = new T[_array.Length];
            int i = 0;
            foreach (T element in _array)
            {
                if (element != null)
                {
                    newArray[i] = element;
                    ++i;
                }
            }
            return newArray;
        }
    }
}
