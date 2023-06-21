using Microsoft.AspNetCore.Mvc;
using Bookstore.Repositores;
using Bookstore.Models;

namespace Bookstore.Controllers;

//The route attribute can explicity declare the url path as a string or use [controller] to pull the url path from the file name
[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly InMemBookstoreRepository repository;

    public BooksController()
    {
        repository = new InMemBookstoreRepository();
    }

    //  /Books GET
    [HttpGet]
    public IEnumerable<Book> GetBooks()
    {
        var books = repository.GetBooks();
        return books;
    }

    // /Books/{id} GET
    [HttpGet("{id}")]
    public Book GetBook(Guid id)
    {
        var book = repository.GetBook(id);
        return book;
    }
    
}