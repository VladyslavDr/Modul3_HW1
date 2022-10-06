using System;
using System.Collections.Generic;

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user1 = new User("Tom");
            var user2 = new User("Alice");
            var user3 = new User("Li");
            var user4 = new User("Boris");
            var user5 = new User("Bob");

            var users = new MyList<User>(user1, user2, user3, user5);
            Show(users);

            users.Remove(user5);
            users.Remove(user1);
            Show(users);

            users.Add(user3, user3, user3);
            Show(users);
        }

        public static void Show(MyList<User> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item.Name} ");
            }

            Console.WriteLine();
            Console.WriteLine($"count: {list.Count}");
            Console.WriteLine($"size: {list.Size}");
        }
    }
}
