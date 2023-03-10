using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobMonStar.Data
{
    [Table("Account")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        [Phone]
        public string? Phone { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [MaxLength (250)]
        public string? Address { get; set; }
    }
}
