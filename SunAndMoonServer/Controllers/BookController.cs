using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SunAndMoonServer.Models;

namespace SunAndMoonServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
        public class BookAPIController : ControllerBase
        {
            [HttpGet]
            public async Task<IActionResult> GetAllBooks()
            {
                var books = new List<Book>
                {
                    new() {
                        Id = 1,
                        Title = "Heralds of Andross",
                        ChapterCount = 651,
                        Completed = true,
                        Author = "Mark Ruffalo",
                        Description = "A whole lotta flavor text!"
                    }
                };

                return Ok(books);
            }
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
