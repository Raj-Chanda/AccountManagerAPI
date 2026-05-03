using AccountManagement.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Domain.DB
{
    internal class AccountManagementDbContext : DbContext
    {
        public AccountManagementDbContext(DbContextOptions<AccountManagementDbContext> options) : base(options) { }

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<PassBook> PassBooks { get; set; }
    }
}
