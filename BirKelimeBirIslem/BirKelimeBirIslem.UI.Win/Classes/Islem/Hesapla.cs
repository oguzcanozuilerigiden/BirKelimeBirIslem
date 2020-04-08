using System;
using System.Collections.Generic;
using System.Text;
using static BirKelimeBirIslem.UI.Win.Classes.Islem.Enums.Enum;

namespace BirKelimeBirIslem.UI.Win.Classes
{
    class Hesapla
    {
        #region Properties
        private List<int> SiradakiSayi { get; set; }

        private List<Islem_Isaret> Operatorler { get; set; }

        public int DegerHesapla
        {
            get
            {
                int deger = SiradakiSayi[0];
                for (int i = 1; i < SiradakiSayi.Count; i++)
                {
                    switch (Operatorler[i - 1])
                    {
                        case Islem_Isaret.Ekle:
                            deger += SiradakiSayi[i];
                            break;
                        case Islem_Isaret.Cikar:
                            deger -= SiradakiSayi[i];
                            break;
                        case Islem_Isaret.Carp:
                            deger *= SiradakiSayi[i];
                            break;
                        case Islem_Isaret.Bol:
                            deger /= SiradakiSayi[i];
                            break;
                    }
                }
                return deger;
            }
        }
        #endregion Properties

        #region Constructors
        public Hesapla(int _siradaki_sayi)
        {
            this.SiradakiSayi = new List<int>() { _siradaki_sayi };
            this.Operatorler = new List<Islem_Isaret>();
        }

        public Hesapla(Hesapla _denklembaslangici, Islem_Isaret _islem, int _siradakisayi)
        {
            this.SiradakiSayi = new List<int>((int[])_denklembaslangici.SiradakiSayi.ToArray().Clone());
            this.SiradakiSayi.Add(_siradakisayi);
            this.Operatorler = new List<Islem_Isaret>((Islem_Isaret[])_denklembaslangici.Operatorler.ToArray().Clone());
            this.Operatorler.Add(_islem);
        }
        #endregion Constructors

        #region ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int siradaki = SiradakiSayi[0];
            int _siradakideger = -1;
            for (int i = 1; i < SiradakiSayi.Count; i++)
            {
                string satir = YeniIslemSatiriOlustur(siradaki, i, ref _siradakideger);
                sb.Append(satir);
                sb.Append(Environment.NewLine);
                siradaki = _siradakideger;
            }
            return sb.ToString();
        }

        private string YeniIslemSatiriOlustur(int _simdikisayi, int _kartsirasi, ref int _siradakideger)
        {
            int siradaki_sayi = SiradakiSayi[_kartsirasi];
            Islem_Isaret islem = (Islem_Isaret)Operatorler[_kartsirasi - 1];
            string islemsembol = IslemSembolEkle(islem);
            _siradakideger = YeniDegerHesapla(_simdikisayi, siradaki_sayi, islem);
            return string.Format("{0} {1} {2} = {3}", _simdikisayi, islemsembol, siradaki_sayi, _siradakideger);
        }

        private string IslemSembolEkle(Islem_Isaret Operator)
        {
            switch (Operator)
            {
                case Islem_Isaret.Ekle:
                    return "+";
                case Islem_Isaret.Cikar:
                    return "-";
                case Islem_Isaret.Carp:
                    return "*";
                case Islem_Isaret.Bol:
                    return "/";
                default:
                    return null;
            }
        }

        private int YeniDegerHesapla(int _sayi1, int _sayi2, Islem_Isaret _islem)
        {
            switch (_islem)
            {
                case Islem_Isaret.Ekle:
                    return _sayi1 + _sayi2;
                case Islem_Isaret.Cikar:
                    return _sayi1 - _sayi2;
                case Islem_Isaret.Carp:
                    return _sayi1 * _sayi2;
                case Islem_Isaret.Bol:
                    return _sayi1 / _sayi2;
                default:
                    return -1;
            }
        }       
        #endregion ToString
    }

}
