using CodeChallenge.Core.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.Core.Models.DataLayer.SeedData
{
    internal class SeedContacts : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> entity) 
        {
            entity.HasData(
                new Contact { ContactId = 1, FirstName="Michelle", LastName="Alexander", AddressId = 1010 },
                new Contact { ContactId = 2, FirstName="Stephen E.", LastName="Ambrose", AddressId = 3241 },
                new Contact { ContactId = 3, FirstName="Seth", LastName="Grahame-Smith", AddressId = 3241 }
            );
        }
    }
}
