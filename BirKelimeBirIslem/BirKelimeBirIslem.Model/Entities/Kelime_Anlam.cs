using BirKelimeBirIslem.Model.Entities.Base;

namespace BirKelimeBirIslem.Model.Entities
{
    public class Kelime_Anlam:BaseEntity
    {       
        //Veritabanında anlam da var ise bu class impelemte edilir.
        public string Anlam { get; set; }
    }
}
