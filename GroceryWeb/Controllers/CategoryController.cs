using GroceryWeb.Data;
using GroceryWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult CategoryIndex()
        {
            IEnumerable<Users> objCategoryList = _db.User;
            return View(objCategoryList);
        }
    }
}