using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMonStar.Data
{
    public class Job
    {
        [Key]
        [Required]
        public int JobId { get; set; }
        [MaxLength(250)]
        public string? JobName { get; set; }
        [MaxLength(1000)]
        public string? JobContent { get; set; }
        public DateTime JobDate { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

    }
}
