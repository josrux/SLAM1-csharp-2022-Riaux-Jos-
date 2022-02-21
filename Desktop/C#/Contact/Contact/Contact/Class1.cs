using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    class Contact
    {

        #region Attributs
        private string _Lastname;
        private int _Identifier;
        private string _Firstname;
        private int _Phone;
        private string _Email;
        private DateTime _BirthDay;
        private int _ContactedCount;
        #endregion

        #region propriété

        public string LastName
        {
            get { return _Lastname; }
        }

        public int Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; }
        }

        public int Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public DateTime BirthDay
        {
            get { return _BirthDay; }
            set { _BirthDay = value; }
        }

        public int ContactedCount
        {
            get { return _ContactedCount; }
            set { _ContactedCount = value; }
        }






        #endregion

        #region Construteur
        public Contact(string nom)
        {

        }
        #endregion
    }
}
