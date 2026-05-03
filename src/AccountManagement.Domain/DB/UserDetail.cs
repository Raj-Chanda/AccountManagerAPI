using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Domain.DB
{
    public class UserDetail
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string UserName { get; set; }

        [MinLength(5)]
        [MaxLength(25)]
        public string Password { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string LastName { get; set; }

        public bool IsActive { get; set; } = false;
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public ICollection<Account> Accounts { get; set; }
        public ICollection<PassBook> PassBooks { get; set; }
    }
}
