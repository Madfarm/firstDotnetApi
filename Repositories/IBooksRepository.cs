using Bookstore.Models;

namespace Bookstore.Repositores;

public interface IInMemBookstoreRepository
{
    Book GetBook(Guid id);
    IEnumerable<Book> GetBooks();
}