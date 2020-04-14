using System;
using LinqToExcel;

namespace BirKelimeBirIslem.Dal.Context
{
    public class ConnExcel
    {
        #region Sorulacak
        //SOR
        //private ExcelQueryFactory _urlConnexion;
        // public ExcelQueryFactory UrlConnexion { get; private set; }
        //{
        //    get
        //    {
        //        return _urlConnexion;
        //    }
        //} 
        #endregion

        #region Properties

        private static ConnExcel connexcel;

        public ExcelQueryFactory url { get; private set; }

        static object _lockobject = new object(); 
        #endregion

        #region Constructor
        private ConnExcel()
        {

        }
        #endregion

        #region Functions
        public static ConnExcel Conn()
        {
            lock (_lockobject)
            {
                if (connexcel == null) connexcel = new ConnExcel();
            }
            return connexcel;
        }

        public void Yol(string path)
        {            
            if(url==null)url = new ExcelQueryFactory(path);
            else url.FileName = path;
        }
        #endregion
    }
}
