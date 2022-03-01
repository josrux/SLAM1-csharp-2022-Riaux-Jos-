using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBibliothèque
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliothèque biblio = new Bibliothèque("jojo","voiture de course",200, now DateTime (1976, 01, 30));
            Console.WriteLine(biblio.Lire());
            Console.WriteLine(biblio.Count());
            Console.ReadKey();

           

        }
    }
}
