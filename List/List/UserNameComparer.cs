using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class UserComparer : IComparer<User>
    {
        public int Compare(User user1, User user2)
        {
            if (user1 == null || user2 == null)
            {
                return 0;
            }

            return user1.Name.CompareTo(user2.Name);
        }
    }
}
