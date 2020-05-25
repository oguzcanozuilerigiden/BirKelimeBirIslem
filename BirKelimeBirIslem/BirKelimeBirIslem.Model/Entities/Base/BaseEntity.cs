namespace BirKelimeBirIslem.Model.Entities.Base
{
    public class BaseEntity
    {
        //kelime ve anlam property lerinin temelini oluşturur
        //Her db de anlam olmayabilir. Ortak alanlar tanımlanmıştır.
        public int Kelime_ID { get; set; }

        public string Kelime { get; set; }
    }
}
