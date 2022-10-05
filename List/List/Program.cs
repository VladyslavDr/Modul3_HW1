using System;
using System.Collections.Generic;

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list1 = new MyList<int>(2, 6, 5, 9, 5);
            list1.Show();

            list1.Remove(5);
            list1.Remove(5);
            list1.Show();
            Console.WriteLine($"size: {list1.GetSize}");
        }
    }
}
