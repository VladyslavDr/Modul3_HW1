using System;
using System.Collections.Generic;

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var user1 = new User("a");
            var user2 = new User("AA");
            var user3 = new User("b");
            var user4 = new User("y");
            var user5 = new User("B");

            var list1 = new MyList<User>(user1, user1, user5, user3, user4, user5, user2);

            foreach (var item in list1)
            {
                if (item == null)
                {
                    continue;
                }

                Console.Write($"{item.Name} ");
            }

            Console.WriteLine();
            list1.Remove(user1);
            list1.RemoveAt(1);
            list1.Add(user4, user5, user4);
            list1.Sort();

            foreach (var item in list1)
            {
                if (item == null)
                {
                    continue;
                }

                Console.Write($"{item.Name} ");
            }

            Console.WriteLine();

            Console.WriteLine($"size: {list1.GetSize}");
        }
    }
}
