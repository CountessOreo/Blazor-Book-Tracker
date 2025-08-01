﻿using BookTracker.BookServices;
using BookTracker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookTracker.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBookAsync() => Ok(await bookService.GetBooksAsync());

        [HttpPost]
        public async Task<ActionResult<(bool, string)>> ManageBookAsync(Book book)
        {
            if(book == null) return BadRequest(false);

            var result = await bookService.ManageBookAsync(book);

            if(result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<(bool, string)>> DeleteBookAsync(int id)
        {
            var result = await bookService.DeleteBookAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
    }
}
