using System;
using System.Collections.Generic;
using System.Text;
using static BirKelimeBirIslem.UI.Win.Classes.Islem.Enums.Enum;

namespace BirKelimeBirIslem.UI.Win.Classes
{
    class Cozum
    {
        #region Properties
        public List<int> TumSayilar { get; private set; }

        public int Hedef2 { get; private set; }

        private Hesapla Hesapla { get; set; }

        private int enYakin = int.MaxValue;

        #endregion Properties

        #region Constructor
        public Cozum(int _hedef, List<int> _tekbasamakli, int _ikibasamakli)
        {
            TumSayilar = new List<int>();

            this.Hedef2 = _hedef;
            this.TumSayilar.Add(_ikibasamakli);
            this.TumSayilar.AddRange(_tekbasamakli);
            Coz();
        }
        #endregion Constructor

        #region CozunArama
        public void Coz()
        {
            for (int i = 0; i < TumSayilar.Count; i++)
            {
                Hesapla _denklem = new Hesapla(TumSayilar[i]);
                List<int> arttikliste = KisaListeOlustur(TumSayilar, i);
                if (CozumAra(_denklem, arttikliste))
                    break;
            }
        }

        private List<int> KisaListeOlustur(List<int> _eskiliste, int _sirano)
        {
            List<int> yeniliste = new List<int>();
            for (int i = 0; i < _eskiliste.Count; i++)
                if (i != _sirano)
                    yeniliste.Add(_eskiliste[i]);
            return yeniliste;
        }

        private bool CozumAra(Hesapla _denklembaslangici, List<int> _artikliste)
        {
            for (int i = 0; i < _artikliste.Count; i++)
            {
                foreach (Islem_Isaret islem in Enum.GetValues(typeof(Islem_Isaret)))
                {
                    List<int> yeniartikliste = KisaListeOlustur(_artikliste, i);
                    int siradakisayi = _artikliste[i];
                    if (CozumeKartiEkle(siradakisayi, islem, _denklembaslangici, yeniartikliste))
                        return true;
                }
            }
            return false;
        }

        private bool CozumeKartiEkle(int _siradakisayi, Islem_Isaret _islem, Hesapla _denklembaslangici, List<int> _artikliste)
        {
            Hesapla denklem = new Hesapla(_denklembaslangici, _islem, _siradakisayi);

            if (Math.Abs(Hedef2 - denklem.DegerHesapla) <= enYakin)
            {
                enYakin = Math.Abs(Hedef2 - denklem.DegerHesapla);
                this.Hesapla = denklem;
                if (denklem.DegerHesapla == Hedef2) return true;
            }

            if (_artikliste.Count == 0)
            {
                return false;
            }

            return CozumAra(denklem, _artikliste);
        }
        #endregion Solve

        #region ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Hesapla.ToString());

            int fark = Math.Abs(this.Hesapla.DegerHesapla - Hedef2);
            string puan;
            switch (fark)
            {
                case 0:
                    puan = "Alınan Puan: 10" + Environment.NewLine + "(Tam Sonuç)";
                    break;
                case 1:
                    puan = "Alınan Puan: 9" + Environment.NewLine + "(Bir Yaklaşık Sonuç)";
                    break;
                case 2:
                    puan = "Alınan Puan: 8" + Environment.NewLine + "(İki Yaklaşık Sonuç)";
                    break;
                case 3:
                    puan = "Alınan Puan: 7" + Environment.NewLine + "(Üç Yaklaşık Sonuç)";
                    break;
                case 4:
                    puan = "Alınan Puan: 6" + Environment.NewLine + "(Dört Yaklaşık Sonuç)";
                    break;
                case 5:
                    puan = "Alınan Puan: 5" + Environment.NewLine + "(Beş Yaklaşık Sonuç)";
                    break;
                case 6:
                    puan = "Alınan Puan: 4" + Environment.NewLine + "(Altı Yaklaşık Sonuç)";
                    break;
                case 7:
                    puan = "Alınan Puan: 3" + Environment.NewLine + "(Yedi Yaklaşık Sonuç)";
                    break;
                case 8:
                    puan = "Alınan Puan: 2" + Environment.NewLine + "(Sekiz Yaklaşık Sonuç)";
                    break;
                case 9:
                    puan = "Alınan Puan: 1" + Environment.NewLine + "(Dokuz Yaklaşık Sonuç)";
                    break;
                default:
                    puan = "Puan Alamadınız!" + Environment.NewLine + "Çözüm Bulunamadı";
                    break;
            }
            sb.Append(Environment.NewLine + puan);

            return sb.ToString();
        }
        #endregion ToString
    }
}
