using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BirKelimeBirIslem.UI.Win.Classes.Hesaplama;

namespace BirKelimeBirIslem.UI.Win.Classes
{
    class SayiOyun
    {
        Random random = new Random();
        public int IkiBasamakli { get; set; }

        public List<int> BirBasamaklilar { get; private set; }

        public int HedefSayi { get; set; }

        private Islem[] islemler = new Islem[] { Islem.Topla, Islem.Cikar, Islem.Carp, Islem.Bol };

        public SayiOyun()
        {
            Yukle();
        }

        public SayiOyun(int hedefSayi, int ikiBasamakli, List<int> birBasamaklilar)
        {
            this.BirBasamaklilar = birBasamaklilar;
            this.IkiBasamakli = ikiBasamakli;
            this.HedefSayi = hedefSayi;
        }

        private List<int> BirBasamakliSayiGetir()
        {
            List<int> gecerliSayilar = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };//Tek olacak
            List<int> birBasamaklilar = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int r = random.Next(0, gecerliSayilar.Count);
                birBasamaklilar.Add(gecerliSayilar[r]);
                gecerliSayilar.RemoveAt(r);
            }
            return birBasamaklilar;
        }

        private void Yukle()
        {
            this.BirBasamaklilar = BirBasamakliSayiGetir();
            this.IkiBasamakli = random.Next(1, 9) * 10;
            this.HedefSayi = random.Next(100, 999);
        }

        public Hesaplama EnYakinIfade()
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(IkiBasamakli);
            sayilar.AddRange(BirBasamaklilar);

            Hesaplama yakinIfade = null;
            double enYakin = double.MaxValue;
            foreach (var eleman in EnYakinIfadeRecursive(sayilar, null))
            {
                double val = eleman.Degerlendir();
                if (Math.Abs(HedefSayi - val) <= enYakin)
                {
                    enYakin = Math.Abs(HedefSayi - val);
                    yakinIfade = eleman.Copy();
                    if (val == (double)HedefSayi)
                        break;
                }
            }
            return yakinIfade;
        }

        private IEnumerable<Hesaplama> EnYakinIfadeRecursive(IList<int> sayilar, Hesaplama onceki)//List denenecek
        {
            List<Hesaplama> Hesaplama = new List<Hesaplama>();

            foreach (int sayi in sayilar)
            {
                List<int> kopya = ListeyiTekElemansizKopyala(sayilar, sayi);
                foreach (Islem oper in islemler)
                {
                    Hesaplama simdiki = new Hesaplama();
                    simdiki.HesaplamaElemanlariniKopyala(onceki);
                    simdiki.IslenenEkle(sayi);
                    Hesaplama.Add(simdiki);
                    if (kopya.Count == 0)
                        break;
                    Hesaplama hesabinKopyasi = simdiki.Copy();
                    hesabinKopyasi.OperatorEkle(oper);
                    foreach (var eleman in EnYakinIfadeRecursive(kopya, hesabinKopyasi))
                        yield return eleman;
                }
            }
            foreach (var eleman in Hesaplama)
                yield return eleman;
        }

        private List<int> ListeyiTekElemansizKopyala(IEnumerable<int> sayilar, int eleman)
        {
            var sayilariKopyala = sayilar.ToList();
            sayilariKopyala.Remove(eleman);
            return sayilariKopyala;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("İki basamaklı sayı: " + IkiBasamakli.ToString());
            builder.Append("Tek basamaklı sayılar: ");
            foreach (var item in BirBasamaklilar)
                builder.Append(item.ToString() + " ");
            builder.AppendLine();
            builder.Append("Hedef sayı: " + HedefSayi.ToString());
            builder.AppendLine();
            return builder.ToString();
        }
    }
}
