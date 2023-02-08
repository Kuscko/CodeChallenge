using CodeChallenge.Core.Models.DataLayer;
using CodeChallenge.Core.Models.DataLayer.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CodeChallenge.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactDbContext _context;

        public HomeController(ContactDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.GetContactDetails());
        }
    }
}