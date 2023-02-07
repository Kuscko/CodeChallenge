using CodeChallenge.Core.Models.DataLayer.SeedData;
using CodeChallenge.Core.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Core.Models.DataLayer
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed initial data
            modelBuilder.ApplyConfiguration(new SeedContacts());
            modelBuilder.ApplyConfiguration(new SeedAddresses());
        }
    }
}
