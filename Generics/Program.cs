using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> citysPlaque = new MyDictionary<string,int>();
            citysPlaque.Add("Malatya",44);
            citysPlaque.Add("İstanbul",34);
            citysPlaque.Add("Ankara", 06);

            Console.WriteLine(citysPlaque.Count);

        }
    }
    class MyDictionary<DKey,DValue>
    {
        DKey[] _array;
        DKey[] _tempArray;

        DValue[] _value;
        DValue[] _tempValue;

        public MyDictionary()
        {
            _array = new DKey[0];
            _value = new DValue[0];
        }
        public void Add(DKey key,DValue value)
        {
            _tempArray = _array;
            _tempValue = _value;

            _array = new DKey[_array.Length + 1];
            _value = new DValue[_value.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = key;
            
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _value[_value.Length - 1] = value;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }

}
