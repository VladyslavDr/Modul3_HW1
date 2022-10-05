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
    }
}
