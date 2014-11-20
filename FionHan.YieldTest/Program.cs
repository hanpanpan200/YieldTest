using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FionHan.YieldTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------With Yield-----------");
            WithYield();
            Console.WriteLine("-------------Without Yield--------");
            WithoutYield();
            Console.WriteLine("-------------With Yield 迭代--------");
            foreach (var i in WithYield())
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("-------------Without Yield 迭代--------");
            foreach (var i in WithoutYield())
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
        static IEnumerable<int> WithoutYield()
        {
            IList<int> list = new List<int>();
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(i.ToString());
                if (i > 2)
                {
                    list.Add(i);
                }
            }
            return list;
        }
        static IEnumerable<int> WithYield()
        {
            //只有在Iterator执行MoveNext时，才会真正执行。
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(i.ToString());
                if (i > 2)
                {
                    yield return i;
                }
            }
        }

    }
}
