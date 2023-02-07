using CodeChallenge.Core.Models.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CodeChallenge.Core.Models.DataLayer.SeedData
{
    internal class SeedAddresses : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> entity)
        {
            entity.HasData(
                new Address { AddressId = 1010, Street = "58469 Fletcher Ave", City = "Tampa", State = "FL", PostalCode = "33467" },
                new Address { AddressId = 3241, Street = "12468 Even Street", City = "Tampa", State = "FL", PostalCode = "33468" }
            );
        }
    }
}
