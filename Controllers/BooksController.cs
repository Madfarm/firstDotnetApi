using Microsoft.AspNetCore.Mvc;
using Bookstore.Repositores;
using Bookstore.Models;

namespace Bookstore.Controllers;

[ApiController]

//The route attribute can explicity declare the url path as a string or use [controller] to pull the url path from the file name
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly InMemBookstoreRepository repository;

    public BooksController()
    {
        repository = new InMemBookstoreRepository();
    }

    [HttpGet]
    public IEnumerable<Book> GetBooks()
    {
        var books = repository.GetBooks();
        return books;
    }
}