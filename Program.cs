using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x[0]);
                int y = Convert.ToInt32(tokens_x[1]);
                int z = Convert.ToInt32(tokens_x[2]);

                if (Math.Abs(x - z) > Math.Abs(y - z)) Console.WriteLine("Cat B");
                else if (Math.Abs(x - z) < Math.Abs(y - z)) Console.WriteLine("Cat A");
                else Console.WriteLine("Mouse C");
            }
        }
    }
}