using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPBibliothèque
{
    internal class Bibliothèque
    {
        #region Attributs
        private string _Title;
        private string _Content;
        private int _PageCount;
        private int _ReadCount;
        private DateTime _Time;
        private DateTime _nombreTime;

        #endregion





        #region Constructors

        public Bibliothèque(string Titlename, string Contentname, int PageCountname, DateTime _TimeCountname)
        {
            _Title = Titlename;
            _Content = Contentname;
            _PageCount = PageCountname;
            _Time = _TimeCountname;
        }

        #region Propriétés

        public DateTime Time
        {
            get { return _Time; }
        }

        

        public string Title
        {
            get { return _Title; }
        }

        public string Content
        {
            get { return _Content; }
        }

        public int Pagecount
        {
            get { return _PageCount; }
        }
        #endregion

       

       

        #region Méthodes

        public string Lire()
        {
            _ReadCount++;
            _nombreTime = DateTime.Now;
            return _Content;
        }

        public int Count()
        {
            return _ReadCount;
        }
        #endregion



    }
}