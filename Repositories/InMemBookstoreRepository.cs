using Bookstore.Models;



namespace Bookstore.Repositores;



public class InMemBookstoreRepository : IBooksRepository
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

    public void CreateBook(Book book)
    {
        books.Add(book);
    }

    public void UpdateBook(Book book)
    {
        int index = books.FindIndex(item => item.Id == book.Id);
        books[index] = book;
    }

    public void DeleteBook(Guid id)
    {
        int index = books.FindIndex(item => item.Id == id);
        books.RemoveAt(index);
    }
}