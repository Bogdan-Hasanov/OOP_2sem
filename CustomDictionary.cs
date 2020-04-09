using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_2sem
{
    public class CustomDictionary : IEnumerable
    {
        Dictionary<int,Object> _dictionary = new Dictionary<int,Object>();
        public IEnumerator GetEnumerator()
        {
            return  _dictionary.GetEnumerator();
        }

        public Object this[int index]
        {
            get => _dictionary[index];
            set => _dictionary[index] = value;
        }
    }
}