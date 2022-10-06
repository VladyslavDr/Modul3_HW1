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

            Console.WriteLine($"count: {users.Count}");
        }

        public static IReadOnlyCollection<User> GetUsers()
        {
            var user1 = new User("Tom");
            var user2 = new User("Alice");
            var user3 = new User("Li");
            var user4 = new User("Boris");
            var user5 = new User("Bob");

            var users = new MyList<User>(user1, user2, user3, user5);

            users.Remove(user5);
            users.Remove(user1);

            users.Add(user3, user3, user3);

            return users;
        }
    }
}
