# Carousel component docs

## Install

```bash
dotnet add package Carousel
```

## Basic usage

```razor
@using Carousel.Components

<Carousel Items="Slides" AutoPlay="true" AutoPlayIntervalMs="4000" AriaLabel="Gallery" />

@code {
    private static readonly IReadOnlyList<CarouselSlide> Slides =
    [
        new() { ImageUrl = "...", AltText = "...", Title = "Slide 1" },
        new() { ImageUrl = "...", AltText = "...", Title = "Slide 2" }
    ];
}
```

## Features

- Touch/swipe gestures (mobile)
- Autoplay with configurable interval
- Lazy slide rendering and lazy image loading
- Keyboard navigation with ArrowLeft/ArrowRight
- ARIA roles and labels for accessibility
