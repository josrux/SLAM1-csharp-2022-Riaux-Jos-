using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Left Operand : ");
            string a = Console.ReadLine();
            int LO = Int32.Parse(a);



            Console.WriteLine("Right Operand : ");
            string b = Console.ReadLine();
            int RO = Int32.Parse(b);

            Console.WriteLine(LO + RO);
            Console.WriteLine(LO - RO);
            Console.WriteLine(LO / RO);
            Console.WriteLine(LO % RO);
            

            Console.ReadKey();

        }
    }
}
