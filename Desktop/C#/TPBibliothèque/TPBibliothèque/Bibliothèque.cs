namespace TPBibliothèque
{
    internal class Bibliothèque
    {
        #region Attributs
        private string _Title;
        private string _Content;
        private int _PageCount;
        private int _ReadCount;
        #endregion

        

        

        #region Constructors

        public Bibliothèque(string Titlename, string Contentname, int PageCountname)
        {
            _Title = Titlename;
            _Content = Contentname;
            _PageCount = PageCountname;
        }
        
        #region Propriétés

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

        public Bibliothèque()
        {
        }

        #endregion

        #region Méthodes

        public string Lire()
        {
            _ReadCount++;
            return _Content;
        }

        public int Count()
        {
            return _ReadCount;
        }
        #endregion



    }
}