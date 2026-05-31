using Bunit;

namespace Carousel.Tests;

public sealed class CarouselComponentTests : TestContext
{
    [Fact]
    public void ClickNext_ChangesActiveSlide()
    {
        var module = JSInterop.SetupModule("./_content/Carousel/carousel.js");
        module.SetupVoid("bindSwipe", _ => true);

        var cut = RenderComponent<global::Carousel.Components.Carousel>(parameters =>
            parameters.Add(x => x.Items, CreateSlides(3))
                .Add(x => x.AutoPlay, false));

        Assert.Contains("1 of 3", cut.Markup);

        cut.Find("button[aria-label='Next slide']").Click();

        Assert.Contains("2 of 3", cut.Markup);
        Assert.Contains("aria-current=\"true\"", cut.Markup);
    }

    [Fact]
    public void LazyRender_OnlyRendersAdjacentSlides_WhenMoreThanThreeSlides()
    {
        var module = JSInterop.SetupModule("./_content/Carousel/carousel.js");
        module.SetupVoid("bindSwipe", _ => true);

        var cut = RenderComponent<global::Carousel.Components.Carousel>(parameters =>
            parameters.Add(x => x.Items, CreateSlides(5))
                .Add(x => x.AutoPlay, false));

        Assert.Equal(3, cut.FindAll("img").Count);
    }

    private static IReadOnlyList<global::Carousel.Components.CarouselSlide> CreateSlides(int count)
    {
        var slides = new List<global::Carousel.Components.CarouselSlide>(count);
        for (var i = 0; i < count; i++)
        {
            slides.Add(new global::Carousel.Components.CarouselSlide
            {
                ImageUrl = $"https://example.com/{i}.jpg",
                AltText = $"slide {i}",
                Title = $"Title {i}",
                Description = $"Description {i}"
            });
        }

        return slides;
    }
}
