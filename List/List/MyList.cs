using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class MyList<Type> : IMyListTemplate<Type>
    {
        private int _initialSize = 4;
        private int _index = 0;
        private Type[] _array;

        public MyList()
        {
            _array = new Type[_initialSize];
        }

        public MyList(params Type[] values)
            : this()
        {
            Add(values);
        }

        public int GetSize => _array.Length;

        public bool Remove(Type value)
        {
            var index = GetItemIndex(value);

            if (index.Item1 == false)
            {
                return false;
            }

            RemoveAt(index.Item2);
            return true;
        }

        public bool RemoveAt(int index)
        {
            if (index > _index)
            {
                return false;
            }

            Type[] backupArray = _array;
            _array = new Type[_initialSize];

            for (var i = 0; i < _array.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }

                _array[i] = backupArray[i];
            }

            return true;
        }

        public void AddRange(Type[] values)
        {
            Add(values);
        }

        public void AddRange(List<Type> values)
        {
            if (values.Count > _array.Length - _index)
            {
                var index = 0;
                _initialSize *= 2;

                Type[] backupArray = _array;
                _array = new Type[_initialSize];

                foreach (var value in backupArray)
                {
                    _array[index++] = value;
                }
            }

            foreach (var value in values)
            {
                _array[_index++] = value;
            }
        }

        public void Add(params Type[] values)
        {
            if (values.Length > _array.Length - _index)
            {
                var index = 0;
                _initialSize *= 2;

                Type[] backupArray = _array;
                _array = new Type[_initialSize];

                foreach (var value in backupArray)
                {
                    _array[index++] = value;
                }
            }

            foreach (var value in values)
            {
                _array[_index++] = value;
            }
        }

        public void Show()
        {
            foreach (var value in _array)
            {
                Console.Write($"{value} ");
            }

            Console.WriteLine();
        }

        private (bool, int) GetItemIndex(Type value)
        {
            var index = 0;

            foreach (var v in _array)
            {
                if (v.Equals(value))
                {
                    return (true, index);
                }

                index++;
            }

            return (false, -1);
        }
    }
}
