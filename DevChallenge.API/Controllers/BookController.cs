using DevChallenge.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevChallenge.API.Controllers
{
    [ApiController]
    [Route("v1/obras")]
    public class BookController : ControllerBase
    {
        readonly IBookService _bookService;

        public BookController(IBookService bookService) => _bookService = bookService;

        [HttpGet("")]
        public async Task<IActionResult> Get() => Ok(await _bookService.GetAllBooks());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => Ok(await _bookService.GetBookById(id));
    }
}