namespace Carousel.Components;

public sealed class CarouselSlide
{
    public required string ImageUrl { get; init; }
    public required string AltText { get; init; }
    public string? Title { get; init; }
    public string? Description { get; init; }
}
