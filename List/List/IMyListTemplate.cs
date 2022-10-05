using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public interface IMyListTemplate<Type>
    {
        public void Add(params Type[] values);
        public void AddRange(List<Type> values);
        public bool RemoveAt(int index);
        public bool Remove(Type value);
    }
}
