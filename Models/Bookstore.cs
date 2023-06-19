using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models;


public record Book
{
    public Guid Id { get; init; }
    public double Price { get; init; }
    [Required]
    public string Title { get; init; } = null!;
    public DateTimeOffset DateCreated { get; init; }
}