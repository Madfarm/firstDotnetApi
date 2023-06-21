using Microsoft.AspNetCore.Mvc;
using Bookstore.Repositores;
using Bookstore.Models;
using Bookstore.Dtos;

namespace Bookstore.Controllers;

//The route attribute can explicity declare the url path as a string or use [controller] to pull the url path from the file name
[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly IBooksRepository repository;

    public BooksController(IBooksRepository repository)
    {
        this.repository = repository;
    }

    //  /Books GET
    [HttpGet]
    public IEnumerable<BookDto> GetBooks()
    {
        var books = repository.GetBooks().Select(book => book.AsDto());
        return books;
    }


    // /Books/{id} GET
    [HttpGet("{id}")]
    public ActionResult<BookDto> GetBook(Guid id)
    {
        var book = repository.GetBook(id);

        if (book is null)
        {
            return NotFound();
        }

        return book.AsDto();
    }
    
}