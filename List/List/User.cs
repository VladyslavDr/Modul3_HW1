using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class User : IComparable
    {
        private readonly int _id;

        public User(string name)
        {
            _id = new Random().Next();
            Name = name;
        }

        public int Id => _id;
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is User user)
            {
                return Name.CompareTo(user.Name);
            }
            else
            {
                throw new ArgumentException("Некорректное значение параметра");
            }
        }
    }
}
