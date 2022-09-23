using System.ComponentModel.DataAnnotations;

namespace MyProjectAp.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DisplayOrder { get; set; }

        public DateTime DateTime { get; set; }= DateTime.Now;
    }
}
