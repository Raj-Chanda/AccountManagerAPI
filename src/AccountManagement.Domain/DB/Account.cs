using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Domain.DB
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Id")]
        public Guid UserId { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
