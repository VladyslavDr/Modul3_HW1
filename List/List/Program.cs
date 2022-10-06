using System;
using System.Collections.Generic;

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var users = GetUsers();

            foreach (var user in users)
            {
                Console.Write($"{user.Name} ");
            }

            Console.WriteLine($"\ncount: {users.Count}");
        }

        public static IReadOnlyCollection<User> GetUsers()
        {
            var user1 = new User("Tom");
            var user2 = new User("Alice");
            var user3 = new User("Li");
            var user4 = new User("Boris");
            var user5 = new User("Bob");

            var users = new MyList<User>(user1, user2, user3, user4);
            users.Add(user5, user5, user1);

            users.Sort(new UserNameComparer());
            return users;
        }
    }
}
