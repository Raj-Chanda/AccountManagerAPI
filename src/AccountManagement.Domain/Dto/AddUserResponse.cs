using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Domain.Dto
{
    public class AddUserResponse
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit { get; set; }
        public decimal Balance { get; set; }
    }
}
