using BirKelimeBirIslem.Dal.Context;
using BirKelimeBirIslem.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BirKelimeBirIslem.UI.Win.Classes.Kelime
{
    public class KelimeAyarlari
    {
        #region Properties
        private ConnExcel ConxObject { get; set; }

        Random rnd = new Random();

        KelimeAra ara { get; set; }

        List<Kelime_Anlam> kelimelistesi { get; set; }

        public List<string> Harfler { get; set; }

        #endregion

        #region Constructor

        public KelimeAyarlari(string _path)
        {
            string pathToExcelFile = _path;
            this.ConxObject = new ConnExcel(pathToExcelFile);
            this.kelimelistesi = new List<Kelime_Anlam>();
            kelimelistesi = Sorgu1();
        }
        #endregion

        #region Functions        
        public List<Kelime_Anlam> Sorgu1()
        {
            var list = from a in ConxObject.UrlConnexion.Worksheet<Kelime_Anlam>("Kelime_Anlam2")
                       select a;
            return list.ToList();
        }

        public KelimeAra Basla()
        {           
            this.ara = new KelimeAra(kelimelistesi,Harfler);            
            return this.ara;
        }

        public void Harf()
        {
            if (Harfler != null) Harfler.Clear();
            this.Harfler = HarflerOlustur();
        }

        private List<string> HarflerOlustur()
        {
            List<string> karakter = new List<string>() { "A", "B", "C","Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

            List<string> harfler = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                harfler.Add(karakter[rnd.Next(1, karakter.Count)]);
            }
            return harfler;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ara);
            return sb.ToString();
        } 
        #endregion
    }
}
