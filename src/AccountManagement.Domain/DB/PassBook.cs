using AccountManagement.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountManagement.Domain.DB
{
    public class PassBook
    {
        [Key]
        public Guid Id { get; set; }

        public string Particular { get; set; }

        public TransactionType Type { get; set; }

        public decimal Amount { get; set; }

        public Guid AccountId { get; set; }

        public Guid UserId { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("AccountId")]
        public Account Accounts { get; set; }

        [ForeignKey("UserId")]
        public UserDetail UserDetails { get; set; }
    }
}
