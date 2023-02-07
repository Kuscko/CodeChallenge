using CodeChallenge.Core.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
namespace CodeChallenge.Core.Models.DataLayer.Queries
{
    public static class ContactQueries
    {
        public static List<Contact> GetContactDetails(this ContactDbContext context)
        {
            return context.Contacts.Include(c => c.Address).ToList();
        }
    }
}
