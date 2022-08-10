using AuthorApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelService.Model;

namespace AuthorApi.Controllers
{
    [Route("api/Author")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        public AuthorController(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }

        [Authorize]
        [HttpPost("AddBook")]
        public IActionResult AddBook(Books books) 
        {
            try
            {
                var result = _bookService.AddBook(books);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        [HttpPost("AddAuthor")]
        public IActionResult AddAuthor(Author author)
        {
            try
            {
                var result = _authorService.AddAuthor(author);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
