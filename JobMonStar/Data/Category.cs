using System.ComponentModel.DataAnnotations;

namespace JobMonStar.Data
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(250)]
        public string? CategoryName { get; set; }
        public ICollection<Job> Jobs { get; set; } = new HashSet<Job>();
    }
}
