using System;
using System.Collections.Generic;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>();
            cars.Add("Audi");
            cars.Add("Audi");
            cars.Add("Audi");
            cars.Add("Audi");
            Console.WriteLine(cars.Count);

            MyList<string> cars2 = new MyList<string>();
            cars2.Add("Mercedes");
            cars2.Add("Mercedes");
            cars2.Add("Mercedes");
            cars2.Add("Mercedes");
            cars2.Add("Mercedes");
            Console.WriteLine(cars2.Count);
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}
