using EgeGuneyDaldaban.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EgeGuneyDaldaban.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        BookDBContext _context;

        public HomeController(ILogger<HomeController> logger,BookDBContext context)
        {
            _context = context;
            _logger = logger;

        }

        public IActionResult Index()
        {
            List<Book> BookList = new List<Book>()
            {
                new Book
                {
                    BookId=0002,
                    Name = "The Silence of the Lambs",
                    Author="Thomas Harris",
                    Description = "Dr. Hannibal Lecter is a cannibal...",
                    Category = "Novel",
                    ReleaseDate = "03/05/1991"
                },
                
            };

            string jsonCharcters = JsonSerializer.Serialize(BookList);
            HttpContext.Session.SetString("SessionCharacters", jsonCharcters);
            HttpContext.Session.SetString("CharacterVariable", "Session List");
            var characters = _context.Books.ToList();
            return View(characters);

        }
        public IActionResult Session()
        {
            string jsonCharcters = HttpContext.Session.GetString("SessionCharacters");

            List<Book> CharacterList = null;
            if (jsonCharcters != null)
                CharacterList = JsonSerializer.Deserialize<List<Book>>(jsonCharcters);

            
            if (HttpContext.Session.GetString("CharacterVariable") != null)
                ViewBag.Message = HttpContext.Session.GetString("CharacterVariable");
            else
                ViewBag.Message = "";

            return View(CharacterList);
        }
        [Route("Home/Priv")]
        [Route("Home/Privacy")]
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
