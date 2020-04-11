using BirKelimeBirIslem.Model.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirKelimeBirIslem.UI.Win.Classes.Kelime
{
    public class KelimeAra
    {
        private List<int> harfmiktar { get; set; }
        private int max { get; set; }

        internal Kelime_Anlam bulunankelimeler { get; set; }

        public KelimeAra(Kelime_Anlam _liste, List<char> _harfler)
        {
            int adet = 0;
            int sira = -1;
            max = 0;

            harfmiktar = new List<int>();

            foreach (var item in _liste.Kelime)
            {
                string kelime = item.ToString();
                adet = 0;
                foreach (var item2 in _harfler)
                {
                    if (kelime.Count() == 0) break;
                    sira = kelime.IndexOf(item2);
                    if (sira != -1)
                    {
                        adet++;
                        kelime.Remove(sira, 1);
                        sira = -1;
                    }
                }
                if (adet > max) max = adet;
                harfmiktar.Add(adet);
            }
            VerileriIsle(_liste);
        }

        private void VerileriIsle(Kelime_Anlam _liste)
        {
            for (int i = 0; i <= harfmiktar.Count; i++)
            {
                if(harfmiktar[i]==max)
                {
                    bulunankelimeler.Kelime.Append(_liste.Kelime[i]);
                    bulunankelimeler.Anlam.Append(_liste.Anlam[i]);
                }
            }       
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in bulunankelimeler.Anlam)
            {
                sb.Append(item + bulunankelimeler.Anlam[item]);         
            }
          
            return sb.ToString();
        }
    }    
}