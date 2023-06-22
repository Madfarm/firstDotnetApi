

using System.ComponentModel.DataAnnotations;

namespace Bookstore.Dtos;

public record UpdateBookDto
{
    [Required]
    [Range(1, 10000)]
    public double Price { get; init; }
    [Required]
    public string Title { get; init; }
}