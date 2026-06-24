using System.ComponentModel.DataAnnotations;

namespace GSULibrary.Models
{
    public class GSUBook
    {
        [Key]
        public int GSUBookId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        [Required]
        public string ISBN { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int NumberOfCopy { get; set; }
    }
}