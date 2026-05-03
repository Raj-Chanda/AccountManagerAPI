using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Domain.Dto
{
    internal class AccountSummaryResponse
    {
        public string UserName { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public decimal Balance { get; set; }
    }
}
