namespace Bookstore;

public record CreateBookDto
{
    public double Price { get; init; }
    public string Title { get; init; }
}