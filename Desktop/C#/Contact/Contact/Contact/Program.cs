using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact1 = new Contact("der");
            Contact contact2 = new Contact("dad");
            Contact contact3 = new Contact("kji");
            Contact contact4 = new Contact("fez");
            Contact contact5 = new Contact("pz");
            Contact contact6 = new Contact("dez");
            Contact contact7 = new Contact("def");

            List<Contact> list = new List<Contact>();

            String choix;
            do
            {
                Console.WriteLine("1 - Création d'un Contact");
                Console.WriteLine("2 - Gestion de la liste des contacts");
                Console.WriteLine("3 - Rechercher un contact");
                Console.WriteLine("4 - Quitter l'application");
                choix = Console.ReadLine();

                Console.Clear();
                switch (choix)
                {
                    case "1":
                        Console.WriteLine("Création d'un Contact");
                        Console.Read();
                        break;
                    case "2":
                        Console.WriteLine("Gestion de la liste des contacts");
                        Console.Read();
                        break;
                    case "3":
                        Console.WriteLine("Rechercher un contact");
                        Console.Read();
                        break;
                    case "4":
                        Console.WriteLine("Quitter l'application");
                        Console.Read();
                        break;
                        //default:
                        //    Console.WriteLine("Choix inexistant");
                        //    Console.Read();
                        //    break;
                }
            } while (choix != "0");
        }
    }
}
