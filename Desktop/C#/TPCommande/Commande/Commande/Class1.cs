using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCommande
{
    public class Commande
    {
        #region Attributs
        private int _IdentifiantCommande;
        private DateTime _Date;
        private string _Reference;
        private string _DateLastModification;
        private List<LigneCommande> _LignesCommandes;
        #endregion
        #region Propriétés
        public Commande()
        {
            _LignesCommandes = new List<LigneCommande>();
        }

        public Commande(String reference) : this()
        {
            _Reference = Reference;
        }

        public Commande(String reference, DateTime date) : this(reference)
        {
            _Date = date;
        }
        public int IdentifiantCommande
        {
            get { return _IdentifiantCommande; }
            set { _IdentifiantCommande = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public string Reference
        {
            get { return _Reference; }
            set { _Reference = value; }
        }
        public string DateLastModification
        {
            get { return _DateLastModification; }
            set { _DateLastModification = value; }
        }
        #endregion
        #region Constructeurs
        public Commande(int IdentifiantCommande)
        {
            this._IdentifiantCommande = IdentifiantCommande;
        }
        #endregion
    }
}
