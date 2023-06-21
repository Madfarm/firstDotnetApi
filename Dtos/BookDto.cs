public record BookDto
{
    public Guid Id { get; init; }
    public double Price { get; init; }
    public string Title { get; init; } = null!;
    public DateTimeOffset DateCreated { get; init; }
}