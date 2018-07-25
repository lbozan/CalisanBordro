namespace BordroApp.Models
{
    public class MaasTipi : BaseModel
    {
        // Sabit Maaş, Günlük, Mesai
        public string Tip { get; set; }
        public decimal Ucret { get; set; }
    }
}
