using System.ComponentModel.DataAnnotations;

namespace MyProjectAp.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DisplayOrderName { get; set; }
        public DateTime DateTime { get; set; }= DateTime.Now;
    }
}
