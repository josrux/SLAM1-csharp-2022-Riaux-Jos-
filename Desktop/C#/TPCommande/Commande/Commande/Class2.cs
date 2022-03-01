using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCommande
{
    public class LigneCommande
    {
        #region Attributs
        private int _IdentifiantProduit;
        private int _Quantite;
        private double _PrixUnitaire;
        private double _PrixTotal;
        private string _LastModifiedDate;
        #endregion
        #region Propriétés
        public int IdentifiantProduit
        {
            get { return _IdentifiantProduit; }
            set { _IdentifiantProduit = value; }
        }
        public int Quantite
        {
            get { return _Quantite; }
            set { _Quantite = value; }
        }
        public double PrixUnitaire
        {
            get { return _PrixUnitaire; }
            set { _PrixUnitaire = value; }
        }
        public double PrixTotal
        {
            get { return _PrixTotal; }
            set { _PrixTotal = value; }
        }
        public string LastModifiedDate
        {
            get { return _LastModifiedDate; }
            set { _LastModifiedDate = value; }
        }
        #endregion
        #region Constructeurs
        public LigneCommande(int IdentifiantProduit)
        {
            this._IdentifiantProduit = IdentifiantProduit;
        }
        #endregion
    }
}
