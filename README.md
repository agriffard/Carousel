# Carousel

[![NuGet](https://img.shields.io/nuget/v/Carousel.svg)](https://www.nuget.org/packages/Carousel)

A .NET 10 Blazor component library that provides an accessible image carousel with touch/swipe support, autoplay, lazy slides, keyboard navigation, and ARIA semantics.

## What's included

- `src/Carousel`: reusable Blazor component library
- `samples/Carousel.Sample`: Blazor WebAssembly sample app
- `docs/usage.md`: setup and usage documentation
- GitHub Actions workflows for CI, NuGet publishing, and GitHub Pages deployment

## Install from NuGet

```bash
dotnet add package Carousel
```

## Component usage

```razor
@using Carousel.Components

<Carousel Items="Slides" AutoPlay="true" AutoPlayIntervalMs="4000" AriaLabel="Home hero carousel" />
```

`Items` expects a list of `CarouselSlide` objects with `ImageUrl` and `AltText` (plus optional `Title` and `Description`).

## Local development

```bash
dotnet restore Carousel.slnx
dotnet build Carousel.slnx
dotnet test Carousel.slnx
```

Run the sample app:

```bash
dotnet run --project samples/Carousel.Sample/Carousel.Sample.csproj
```

## Accessibility notes

The component includes:

- `role="region"` and `aria-roledescription="carousel"`
- Slide grouping with `aria-label="x of n"`
- Keyboard support (left/right arrows)
- Explicit control labels for previous/next and slide indicators
