using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class User
    {
        private readonly int _id;

        public User(string name)
        {
            _id = new Random().Next();
            Name = name;
        }

        public int Id => _id;
        public string Name { get; set; }
    }
}
