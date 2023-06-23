using Bookstore.Models;
using MongoDB.Driver;

namespace Bookstore.Repositores;

public class MongoDbBookRepository : IBooksRepository
{
    private const string databaseName = "BookstoreTest";
    private const string collectionName = "Books";
    private readonly IMongoCollection<Book> booksCollection;
    public MongoDbBookRepository(IMongoClient mongoClient)
    {
        IMongoDatabase database = mongoClient.GetDatabase(databaseName);
        booksCollection = database.GetCollection<Book>(collectionName);
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