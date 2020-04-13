using BirKelimeBirIslem.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirKelimeBirIslem.UI.Win.Classes.Kelime
{
    public class KelimeAra
    {
        #region Properties
        private List<int> harfmiktar { get; set; }

        public int puan;

        private int max { get; set; }

        internal List<Kelime_Anlam> bulunankelimeler { get; private set; }
        #endregion

        #region Constructor
        public KelimeAra(List<Kelime_Anlam> _liste, List<string> _harfler)
        {
            int adet = 0;
            int sira = -1;
            max = 0;

            harfmiktar = new List<int>();
            bulunankelimeler = new List<Kelime_Anlam>();
            List<Kelime_Anlam> aramasonuc= new List<Kelime_Anlam>();

            foreach (var item in _liste)
            {
                string kelime = item.Kelime.ToUpper().Trim().ToString();
                adet = 0;
                foreach (var item2 in _harfler)
                {
                    if (kelime.Count() == 0) break;
                    sira = kelime.IndexOf(item2);
                    if (sira != -1)
                    {
                        adet++;
                        kelime = kelime.Remove(sira, 1);
                        sira = -1;
                    }
                }
                if (kelime.Count() == 0)
                {
                    if (adet > max) max = adet;
                    harfmiktar.Add(adet);
                    aramasonuc.Add(new Kelime_Anlam { Kelime_ID = item.Kelime_ID, Kelime = item.Kelime, Anlam = item.Anlam });
                }
            }
            VerileriIsle(aramasonuc);
        }
        #endregion

        #region Functions
        private void VerileriIsle(List<Kelime_Anlam> _liste)
        {
            foreach (var item in _liste.Select((value, i) => new { i, value }))
            {
                if (harfmiktar[item.i] == max)
                {
                    bulunankelimeler.Add(new Kelime_Anlam { Kelime_ID = item.value.Kelime_ID, Kelime = item.value.Kelime, Anlam = item.value.Anlam });
                }
            }
        } 
        #endregion

        #region ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in bulunankelimeler)
            {
                sb.AppendLine(item.Kelime + " --> " + item.Anlam);
            }
            string ifade;
            switch (max)
            {                
                case 9:
                    puan = 15;
                    ifade = "Alınan Puan: 15" + Environment.NewLine +"( "+ max + " Harf Eşleşti.)";
                    break;
                case 8:
                    puan = 11;
                    ifade = "Alınan Puan: 11" + Environment.NewLine + "( " + max + " Harf Eşleşti.)";
                    break;
                case 7:
                    puan = 9;
                    ifade = "Alınan Puan: 9" + Environment.NewLine + "( " + max + " Harf Eşleşti.)";
                    break;
                case 6:
                    puan = 7;
                    ifade = "Alınan Puan: 7" + Environment.NewLine + "( " + max + " Harf Eşleşti.)";
                    break;
                case 5:
                    puan = 5;
                    ifade = "Alınan Puan: 5" + Environment.NewLine + "( " + max + " Harf Eşleşti.)";
                    break;
                case 4:
                    puan = 4;
                    ifade = "Alınan Puan: 4" + Environment.NewLine + "( " + max + " Harf Eşleşti.)";
                    break;
                case 3:
                    puan = 3;
                    ifade = "Alınan Puan: 3" + Environment.NewLine + "( " + max + " Harf Eşleşti.)";
                    break;
                case 2:
                    puan = 1;
                    ifade = "Alınan Puan: 1" + Environment.NewLine + "( " + max + " Harf Eşleşti.)";
                    break;
                default:
                    puan = 0;
                    ifade = "Alınan Puan: 0" + Environment.NewLine + "( " + max + " Harf Eşleşti.)";
                    break;
            }
            sb.Append(ifade);
            return sb.ToString();
        } 
        #endregion
    }
}