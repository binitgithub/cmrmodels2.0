using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using cmrmodels2._0.Models;
using Microsoft.EntityFrameworkCore;

namespace cmrmodels2._0.Data
{
    public class CrmDbContext : DbContext
    {
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Apptask> Tasks { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Email> Emails { get; set; }

        public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options) { }


    }
}
