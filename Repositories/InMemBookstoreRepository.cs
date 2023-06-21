using Bookstore.Models;



namespace Bookstore.Repositores;



public class InMemBookstoreRepository : IInMemBookstoreRepository
{
    private readonly List<Book> books = new()
    {
        new Book { Id = Guid.NewGuid(), Price = 9.99, Title = "Great Expectations", DateCreated = DateTimeOffset.UtcNow },
        new Book { Id = Guid.NewGuid(), Price = 99.99, Title = "Finch-Collector's Death", DateCreated = DateTimeOffset.UtcNow },
        new Book { Id = Guid.NewGuid(), Price = 5.99, Title = "Auth, the Great Nightmare", DateCreated = DateTimeOffset.UtcNow },
        new Book { Id = Guid.NewGuid(), Price = 150.99, Title = "Job Searching was Hell until I found this trick!", DateCreated = DateTimeOffset.UtcNow }
    };

    public IEnumerable<Book> GetBooks()
    {
        return books;
    }

    public Book GetBook(Guid id)
    {
        return books.Where(book => book.Id == id).SingleOrDefault();
    }

}