using System;
using System.Collections.Generic;
using System.Text;

namespace BirKelimeBirIslem.UI.Win.Classes
{
    public class OyunAyarlari
    {
        #region Properties

        Random rnd { get; set; }

        public int IkiBasamakli { get; set; }

        public List<int> TekBasamakli { get; private set; }

        public int HedefSayi { get; set; }

        Cozum Cozum { get; set; }
        #endregion Properties

        #region Constructor
        public OyunAyarlari()
        {
            //İşlem oyunu için gerekli veriler constructor metodunda dolduruluyor
            rnd = new Random();
            if (TekBasamakli != null) TekBasamakli.Clear();
            IkiBasamakli = IkiBasamakliOlustur();
            TekBasamakli = TekBasamakliOlustur();
            HedefSayi = HedefSayiOlustur();
        }

        #endregion        

        #region Functions
        public Cozum Basla()
        {
            //Çözüm class ı initialize edilerek arama işlemi tetikleniyor
            this.Cozum = new Cozum(HedefSayi, TekBasamakli, IkiBasamakli);
            return Cozum;
        }
        #endregion

        #region SayılarıOlustur
        // Random olarak sayılar oluşturuluyor
        private int IkiBasamakliOlustur()
        {
            List<int> sayilar = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            return sayilar[rnd.Next(0, sayilar.Count)];
        }

        private List<int> TekBasamakliOlustur()
        {
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                sayilar.Add(rnd.Next(1, 9));
            }
            return sayilar;
        }

        private int HedefSayiOlustur()
        {
            return rnd.Next(100, 1000);
        }

        #endregion PlayGame

        #region ToString

        //sonuç verisi string ezilerek geriye return ediliyor
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Cozum);
            return sb.ToString();
        }
        #endregion ToString
    }
}
