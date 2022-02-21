using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            Point B = new Point();

            B.x = 3;
            B.y = 5;
            A.x = 7;
            A.y = 10;

           double d4 = A.AddValues(10,30);
            double d = A.distanceTo(B);
            double d2 = B.distanceTo(A);
            Console.WriteLine(d4);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
