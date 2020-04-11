using LinqToExcel;

namespace BirKelimeBirIslem.Dal.Context
{
    public class ConnExcel
    {
        public string _pathExcelFile;
        public ExcelQueryFactory _urlConnexion;

        public ConnExcel(string path)
        {
            this._pathExcelFile = path;
            this._urlConnexion = new ExcelQueryFactory(_pathExcelFile);
        }

        public string PathExcelFile
        {
            get
            {
                return _pathExcelFile;
            }
        }
        public ExcelQueryFactory UrlConnexion
        {
            get
            {
                return _urlConnexion;
            }
        }
    }
}
