using System;
using LinqToExcel;

namespace BirKelimeBirIslem.Dal.Context
{
    public class ConnExcel
    {
        //Veri Tabanı(Excel) bağlantısı yapmaya yarar
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
            //Singelton tasarım desenine göre çalışır
            //eğer conn oluşmuş ise tekrar oluşturmaz
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
