using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class MyList<Type> : IMyList<Type>, IReadOnlyCollection<Type>
    {
        private const int _initialSize = 4;
        private int _size = _initialSize;
        private int _index = 0;
        private int _count = 0;
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

        public int Count => _count;

        public int Size => _size;

        public void Sort()
        {
        }

        public IEnumerator<Type> GetEnumerator()
        {
            return GetGenericEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetGenericEnumerator();
        }

        public bool Remove(Type value)
        {
            var index = GetItemIndex(value);

            if (index == -1)
            {
                return false;
            }

            RemoveAt(index);

            return true;
        }

        public void RemoveAt(int index)
        {
            for (var i = 0; i < _array.Length; i++)
            {
                if (_array[i] != null && _array[i].Equals(_array[index]))
                {
                    _array[i] = default(Type);

                    if (_count > 0)
                    {
                        _count--;
                    }
                }
            }
        }

        public void AddRange(Type[] values)
        {
            Add(values);
        }

        public void AddRange(List<Type> values)
        {
            AddRange(values.ToArray());
        }

        public void Add(params Type[] values)
        {
            if (values.Length > _size - _index)
            {
                _size *= 2;

                var backupArray = new Type[_array.Length];
                Array.Copy(_array, backupArray, _array.Length);

                _array = new Type[_size];

                Array.Copy(backupArray, _array, backupArray.Length);
            }

            foreach (var value in values)
            {
                _array[_index++] = value;
                _count++;
            }
        }

        private int GetItemIndex(Type value)
        {
            var index = 0;

            foreach (var v in _array)
            {
                if (v == null)
                {
                    continue;
                }

                if (v.Equals(value))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        private IEnumerator<Type> GetGenericEnumerator()
        {
            foreach (var item in _array)
            {
                if (item != null && !item.Equals(default(Type)))
                {
                    yield return item;
                }
            }
        }
    }
}
