using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST b = new BST();

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                b.Add(rnd.Next(0, 100));
            }

            b.Print();

            int val = rnd.Next(0, 100);
            Console.WriteLine("{0} in tree: {1}", val, b.Search(val));


            Dictionary<int, int> d = new Dictionary<int, int>();


            Console.ReadKey();
        }
    }
}
