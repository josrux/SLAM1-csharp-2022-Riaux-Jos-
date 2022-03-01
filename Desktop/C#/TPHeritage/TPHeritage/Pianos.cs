using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHeritage
{
   public class Pianos : INSTRUMENTS
    {
        public bool numerique { get; set; }
        public bool silencieux { get; set; }
        public int nombdetouche { get; set; }
    }
}
