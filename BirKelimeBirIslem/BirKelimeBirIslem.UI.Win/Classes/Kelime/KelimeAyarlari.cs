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
       
        Random rnd = new Random();

        KelimeAra ara { get; set; }

        List<Kelime_Anlam> kelimelistesi { get; set; }

        public List<string> Harfler { get; set; }

        #endregion

        #region Constructor

        public KelimeAyarlari(string _path)
        {
            //excel üzerinden gelen datalar değişkene aktarılıyor
            var excel = ConnExcel.Conn();
            excel.Yol(_path);
            this.kelimelistesi = new List<Kelime_Anlam>();
            kelimelistesi = Sorgu1(excel);
        }
        #endregion

        #region Functions        
        public List<Kelime_Anlam> Sorgu1(ConnExcel _excel)
        {
            //excel çalışma sayfayı okunup datalar list e aktarılıyor 
            var list = from a in _excel.url.Worksheet<Kelime_Anlam>("Kelime_Anlam2")
                       select a;
            return list.ToList();
        }

        public KelimeAra Basla()
        {           
            //çözüm için KelimeAra sınıfı initialize eediliyor ve veriler gönderiliyor
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
            //random olarak harf listesi oluşturuluyor
            List<string> karakter = new List<string>() { "A", "B", "C","Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };

            List<string> harfler = new List<string>();
            for (int i = 0; i < 8; i++)
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
