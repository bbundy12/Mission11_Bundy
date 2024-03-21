using Microsoft.AspNetCore.Mvc;
using Mission11_Bundy.Models;
using Mission11_Bundy.Models.ViewModel;
using System.Diagnostics;

namespace Mission11_Bundy.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository _repo;
        public HomeController(IBookstoreRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var books = new BookListViewModel
            {
                Books = _repo.Books
                    .OrderBy(p => p.BookId)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),
                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(books);
        }
    }
}
