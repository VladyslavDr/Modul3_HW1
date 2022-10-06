using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public interface IMyList<Type>
    {
        public void Add(params Type[] values);
        public void AddRange(List<Type> values);
        public void RemoveAt(int index);
        public bool Remove(Type value);
        public void Sort(IComparer<Type> comparer);
    }
}
