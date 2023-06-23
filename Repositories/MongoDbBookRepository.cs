using Bookstore.Models;

namespace Bookstore.Repositores;

public class MongoDbBookRepository : IBooksRepository
{
    public MongoDbBookRepository()
    {
        
    }
    public void CreateBook(Book book)
    {
        throw new NotImplementedException();
    }

    public void DeleteBook(Guid id)
    {
        throw new NotImplementedException();
    }

    public Book GetBook(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Book> GetBooks()
    {
        throw new NotImplementedException();
    }

    public void UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }
}