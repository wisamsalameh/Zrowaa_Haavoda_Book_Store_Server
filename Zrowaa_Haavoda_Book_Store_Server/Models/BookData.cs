using System.ComponentModel.DataAnnotations;

namespace Zrowaa_Haavoda_Book_Store_Server.Models
{
    public class BookData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }

}
