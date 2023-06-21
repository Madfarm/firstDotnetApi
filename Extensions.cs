using Bookstore.Dtos;
using Bookstore.Models;

namespace Bookstore;

public static class Extensions 
{
    public static BookDto AsDto(this Book book)
    {
        return new BookDto
        {
            Id = book.Id,
            Title = book.Title,
            Price = book.Price
        };
    }
}