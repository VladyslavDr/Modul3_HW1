using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class UserIdComparer : IComparer<User>
    {
        public int Compare(User user1, User user2)
        {
            if (user1 == null || user2 == null)
            {
                return 0;
            }

            return user1.Id.CompareTo(user2.Id);
        }
    }
}
