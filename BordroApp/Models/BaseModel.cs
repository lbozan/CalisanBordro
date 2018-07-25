using System.ComponentModel.DataAnnotations;

namespace BordroApp.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
