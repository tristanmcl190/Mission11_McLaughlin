using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission11_McLaughlin.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Mission11_McLaughlin.Controllers
{
    public class HomeController : Controller
    {
        private BookContext _bookContext;

        public HomeController(BookContext temp) //Constructor
        {
            _bookContext = temp;
        }

        //public IActionResult Index()
        //{
        //    var passBooks = _bookContext.Books.ToList(); // Convert InternalDbSet<Movie> to List<Movie>
        //    return View(passBooks);
        //}

        public IActionResult Index(int page = 1)
        {
            int pageSize = 10;
            var totalBooks = _bookContext.Books.Count();
            var passBooks = _bookContext.Books
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();
            ViewBag.Page = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalBooks / pageSize);
            return View(passBooks);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
