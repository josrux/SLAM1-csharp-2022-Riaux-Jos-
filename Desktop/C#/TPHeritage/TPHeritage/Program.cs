using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Clarinette CLARINETTE = new Clarinette();
            FlûteTraversière flute = new FlûteTraversière();
            Guitares GUITARES = new Guitares();
            Hautbois HAUTBOIS = new Hautbois();
            Pianos PIANOS = new Pianos();
            InstrumentsAVent aVent = new InstrumentsAVent();
            InstrumentsACordes aCordes = new InstrumentsACordes();

            CLARINETTE.achat = 15;
            CLARINETTE.anchesimple = 2;
            CLARINETTE.Name = "clarinette";
            CLARINETTE.vente = 45;

            flute.achat = 3;
            flute.biseau = 5;
            flute.Name = "flute";
            flute.vente = 25;

            GUITARES.achat = 10;
            GUITARES.amplicateur = true;
            GUITARES.Name = "Guitare";
            GUITARES.vente = 30;

            HAUTBOIS.achat = 21;
            HAUTBOIS.anchedouble = 3;
            HAUTBOIS.Name = "Hautbois";
            HAUTBOIS.vente = 45;

            PIANOS.Name = "pianos";
            PIANOS.nombdetouche = 80;
            PIANOS.numerique = false;
            PIANOS.silencieux = true;
            PIANOS.vente = 301;

            aVent.achat = 12;
            aVent.Name = "vent";
            aVent.vente = 16;

            aCordes.achat = 17;
            aCordes.largeur = 1.32f;
            aCordes.longueur = 4.1f;
            aCordes.Name = "Corde";
            aCordes.vente = 150;

            List<INSTRUMENTS> intruments = new List<INSTRUMENTS>();

            intruments.Add(CLARINETTE);
            intruments.Add(flute);
            intruments.Add(GUITARES);
            intruments.Add(HAUTBOIS);
            intruments.Add(PIANOS);
            intruments.Add(aVent);
            intruments.Add(aCordes);

            foreach (INSTRUMENTS iNSTRUMENTS in intruments)
            {
                Console.Write("{0} \n ", iNSTRUMENTS.Name) ;
                Console.Write("{0} \n ", iNSTRUMENTS.vente);
                Console.Write("{0} \n\n\n ", iNSTRUMENTS.achat);

            }
            Console.Read();
        }
    }
} 
