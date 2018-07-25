using System.ComponentModel.DataAnnotations;

namespace BordroApp.Models
{
    public class ZamanTipi : BaseModel
    {
        [Required]
        public int Deger { get; set; }
    }

}
