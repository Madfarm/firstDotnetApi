using Microsoft.AspNetCore.Mvc;
using Bookstore.Repositores;
using Bookstore.Models;

namespace Bookstore.Controllers;

[ApiController]
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

    }
}