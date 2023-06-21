using Bookstore.Models;

namespace Bookstore.Repositores;

public interface IBooksRepository
{
    Book GetBook(Guid id);
    IEnumerable<Book> GetBooks();
    void CreateBook(Book book);
}