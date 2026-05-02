using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Domain.DB
{
    internal class AccountManagementDbContext : DbContext
    {
        public AccountManagementDbContext(DbContextOptions<AccountManagementDbContext> options)
        {

        }

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
