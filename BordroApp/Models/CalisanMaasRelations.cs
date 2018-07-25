namespace BordroApp.Models
{
    public class CalisanMaasRelations : BaseModel
    {
        public int CalisanId { get; set; }
        public Calisan Calisan { get; set; }

        public int MaasTipiId { get; set; }
        public MaasTipi MaasTipi { get; set; }

        public int ZamanTipiId { get; set; }
        public ZamanTipi ZamanTipi { get; set; }
    }
}
