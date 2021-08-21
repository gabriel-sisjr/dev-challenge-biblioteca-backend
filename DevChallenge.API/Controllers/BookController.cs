using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevChallenge.Data.Entities;
using DevChallenge.Service.Services.Interfaces;

namespace DevChallenge.API.Controllers
{
    [ApiController]
    [Route("v1/obras")]
    public class BookController : ControllerBase
    {
        readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var book = _bookService.GetBookById(id);
            return Ok(book);
        }        
    }
}