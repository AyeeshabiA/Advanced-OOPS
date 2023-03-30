using System;
using System.Collections.Generic;
using System.Collections;

namespace MetroCardFH
{
    //creating class for custom list
    //type for data type
    //IEnumerable, IEnumerator for foreach 
    public class CustomList<Type> : IEnumerable, IEnumerator
    {
        private int _count;
        private int _size;
        public int Count { get { return _count; } }
        public int Capacity { get { return _size; } }
        private Type[] _array;

        // property for index creation
        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }


        //constructor for custom list
        public CustomList()
        {
            _count = 0;
            _size = 4;
            _array = new Type[_size];
        }

        //constructor for default size of custom list
        public CustomList(int size)
        {
            _count = 0;
            _size = size;
            _array = new Type[_size];
        }

        //method for add data
        public void Add(Type data)
        {
            if (_count == _size)
            {
                GrowSize();    //method for increasing size 

            }
            _array[_count] = data;
            _count++;
        }
        private void GrowSize()
        {
            _size *= 2;
            Type[] temp = new Type[_size];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];

            }
            _array = temp;
        }

        // IEnumerator GetEnumerator for working of foreach
        int location;
        public IEnumerator GetEnumerator()
        {
            location = -1;
            return (IEnumerator)this;

        }
        //move next line of next detail to the list
        public bool MoveNext()
        {
            if (location < _count - 1)
            {
                location++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            location = -1;

        }
        public object Current { get { return _array[location]; } }

    }
}