using System;
using System.Collections.Generic;

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list1 = new MyList<int>(2, 5, 8, 4);
            list1.Add(3);
            list1.Show();

            var arr = new int[] { 2, 3, 6, 7 };

            list1.AddRange(arr);
            list1.Show();

            Console.WriteLine($"size: {list1.GetSize}");
        }
    }
}
