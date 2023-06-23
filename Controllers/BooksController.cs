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

    // /Books POST
    [HttpPost]
    public ActionResult<BookDto> CreateBook(CreateBookDto bookDto)
    {
        Book book = new()
        {
            Id = Guid.NewGuid(),
            Title = bookDto.Title,
            Price = bookDto.Price,
            DateCreated = DateTimeOffset.UtcNow
        };

        repository.CreateBook(book);

        return CreatedAtAction(nameof(GetBook), new {id = book.Id}, book.AsDto());
    }

    // /Boks/{id} PUT
    [HttpPut("{id}")]
    public ActionResult UpdateBook(Guid id, UpdateBookDto bookDto)
    {
        var existingBook = repository.GetBook(id);

        if (existingBook is null)
        {
            return NotFound();
        }


        //with is a superpower of C#
        Book updatedBook = existingBook with
        {
            Title = bookDto.Title,
            Price = bookDto.Price
        };

        repository.UpdateBook(updatedBook);

        return NoContent();
    }


    
}