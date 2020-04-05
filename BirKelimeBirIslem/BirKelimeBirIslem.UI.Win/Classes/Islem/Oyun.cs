using System;
using System.Collections.Generic;
using System.Text;

namespace BirKelimeBirIslem.UI.Win.Classes
{
    class Oyun
    {
        #region Properties
        Random rnd { get; set; }

        public int IkiBasamakli { get; set; }

        public List<int> TekBasamakli { get; private set; }

        public int HedefSayi { get; set; }

        Oyuncu Oyuncu { get; set; }
        #endregion Properties

        #region Constructor
        public Oyun()
        {
            rnd = new Random();
            if (TekBasamakli != null) TekBasamakli.Clear();
            IkiBasamakli = IkiBasamakliOlustur();
            TekBasamakli = TekBasamakliOlustur();
            HedefSayi = HedefSayiOlustur();
        }

        #endregion        

        #region Functions
        public Oyuncu Basla()
        {
            this.Oyuncu = new Oyuncu(HedefSayi, TekBasamakli, IkiBasamakli);
            return Oyuncu;
        }
        #endregion

        #region SayılarıOlustur

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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Oyuncu);
            return sb.ToString();
        }
        #endregion ToString
    }
}
