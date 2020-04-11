using BirKelimeBirIslem.Dal.Context;
using BirKelimeBirIslem.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirKelimeBirIslem.UI.Win.Classes.Kelime
{
    public class KelimeYukle
    {
        private ConnExcel ConxObject { get; set; }

        //protected List<string> kelime { get; private set; }

        //protected List<string> anlam { get; private set; }
       // Kelime_Anlam deneme { get; set; }

        public KelimeYukle()
        {

        }
        public KelimeYukle(string _patch)
        {
            
        }

        public Kelime_Anlam Sorgu1()
        {
            var query = from a in ConxObject.UrlConnexion.Worksheet<Kelime_Anlam>("Kelime_Anlam")
                        select a;
            return (Kelime_Anlam)query;
                         //new
                         //{
                         //    a.Kelime,
                         //    a.Anlam
                         //};
            //if (query == null || query.ToList().Count == 0) return;
            //kelime = new List<string>();
            //anlam = new List<string>();
            //foreach (var item in query)
            //{
            //    kelime.Add(item.Kelime);
            //    anlam.Add(item.Anlam);
            //}

        }
    }
}
