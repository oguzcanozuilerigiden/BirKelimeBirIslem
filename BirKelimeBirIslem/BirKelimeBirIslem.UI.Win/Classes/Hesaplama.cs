using System;
using System.Collections.Generic;
using System.Text;

namespace BirKelimeBirIslem.UI.Win.Classes
{
    public enum Islem
    {
        Topla = 1,
        Cikar = 2,
        Carp = 3,
        Bol = 4
    }

    public class Hesaplama
    {
        private  List<object> Elemanlar { get; set; }

        public int Sayi { get; set; }

        public Hesaplama()
        {
            Elemanlar = new List<object>();
        }

        public void IslenenEkle(int islenen)
        {
            this.Elemanlar.Add(islenen);
        }

        public void OperatorEkle(Islem op)
        {
            this.Elemanlar.Add(op);
        }

        public Hesaplama Copy()
        {
            Hesaplama hesap = new Hesaplama();
            foreach (var eleman in Elemanlar)
                hesap.Elemanlar.Add(eleman);
            return hesap;
        }

        public void HesaplamaElemanlariniKopyala(Hesaplama ordan)
        {
            if (ordan != null)
                this.Elemanlar.AddRange(ordan.Elemanlar);
        }

        public int Degerlendir()
        {
            int sayi = (int)Elemanlar[0];
            for (int i = 1; i < Elemanlar.Count; i += 2)
            {
                Islem isl = (Islem)Elemanlar[i];
                sayi = isl.Islet(sayi, (int)Elemanlar[i + 1]);
            }
            return sayi;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            Sayi = (int)Elemanlar[0];
            for (int i = 1; i < Elemanlar.Count; i += 2)
            {
                Islem isl = (Islem)Elemanlar[i];
                int say2 = (int)Elemanlar[i + 1];
                builder.AppendLine(string.Format("{0} {1} {2} = {3}", Sayi, isl.AsString(), say2, isl.Islet(Sayi, say2)));
                Sayi = isl.Islet(Sayi, say2);
            }
            return builder.ToString();
        }
    }

    public static class OperatorExt
    {
        public static int Islet(this Islem isl, int say1, int say2)
        {
            switch (isl)
            {
                case Islem.Topla:
                    return say1 + say2;
                case Islem.Cikar:
                    return say1 - say2;
                case Islem.Carp:
                    return say1 * say2;
                case Islem.Bol:
                    return say1 / say2;
                default:
                    throw new ArgumentException();
            }
        }

        public static string AsString(this Islem isl)
        {
            switch (isl)
            {
                case Islem.Topla:
                    return "+";
                case Islem.Cikar:
                    return "-";
                case Islem.Carp:
                    return "*";
                case Islem.Bol:
                    return "/";
                default:
                    throw new ArgumentException();
            }
        }
    }
}
