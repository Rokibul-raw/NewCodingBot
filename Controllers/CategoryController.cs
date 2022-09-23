using Microsoft.AspNetCore.Mvc;
using MyProjectAp.Data;
using MyProjectAp.Models;

namespace MyProjectAp.Controllers
{
    public class CategoryController : Controller
    {
        public ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Catagory> catagoriese = _context.catagories;
            return View(catagoriese);
        }
    }
}
