using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunAndMoonServer.Data;
using SunAndMoonServer.Models;

namespace SunAndMoonServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAPIController : ControllerBase
    {
        private readonly DataContext _context;
        public BookAPIController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var books = await _context.Books.ToListAsync();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(long id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book is null)
                return NotFound("The book could not be found");

            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<List<Book>>> CreateBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return Ok(await _context.Books.ToListAsync());
        }

    }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
