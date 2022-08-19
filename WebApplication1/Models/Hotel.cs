using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Hotel
    {
        
        
        public int Id { get; set; }


        [RegularExpression(@"^[a-zA-Zа-яА-Я\s]*$",ErrorMessage ="Впишите имя только из букв")]
        [Required]
       
        public string Name { get; set; }
       
        public int Room { get; set; }
    }
}
