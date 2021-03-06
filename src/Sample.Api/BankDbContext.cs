﻿using Bard.Sample.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Bard.Sample.Api
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options)
            : base(options)
        {
        }

        public DbSet<Transfer> Transfers { get; set; } = null!;
        public DbSet<BankAccount> BankAccounts { get; set; } = null!;
    }
}