using System.Collections.Generic;

namespace BordroApp.Models
{
    public class Calisan : BaseModel
    {
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<CalisanMaasRelations> Maas { get; set; }
    }
}
