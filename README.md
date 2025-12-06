# DogsInfo

A .NET 8 Blazor WebAssembly standalone application that provides informational pages about dogs.

## Overview

DogsInfo is a client-side web application built with Blazor WebAssembly. It provides two main informational pages:

### Dog Breeds (`/breeds`)
- Browse a list of popular dog breeds with details including:
  - Origin
  - Size category (Small, Medium, Large)
  - Temperament
  - Image
- Search breeds by name
- Filter breeds by size category

### Dog Diseases (`/diseases`)
- Learn about common dog diseases with:
  - Description
  - Symptoms
  - Suggested actions
- Color-coded severity badges (Low, Moderate, High)
- Expandable accordion sections for each disease

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

### Build the application

```bash
cd DogsInfo
dotnet build
```

### Run the application

```bash
cd DogsInfo
dotnet run
```

The application will be available at `http://localhost:5000` (or the port specified in the console output).

### Run with hot reload (development)

```bash
cd DogsInfo
dotnet watch run
```

This enables hot reload for faster development - changes to the code will automatically refresh the browser.

## Project Structure

```
DogsInfo/
├── Models/
│   ├── Breed.cs          # Dog breed data model
│   └── Disease.cs        # Dog disease data model
├── Pages/
│   ├── Home.razor        # Home page
│   ├── Breeds.razor      # Dog breeds listing with filtering
│   └── Diseases.razor    # Dog diseases with accordion
├── Shared/
│   └── SeverityBadge.razor  # Reusable severity badge component
├── Layout/
│   ├── MainLayout.razor  # Main layout template
│   └── NavMenu.razor     # Navigation menu
└── wwwroot/
    ├── index.html        # HTML entry point with Bootstrap CDN
    └── css/
        ├── app.css       # Application base styles
        └── site.css      # Custom styles for DogsInfo
```

## Data

All data is stored in-memory within the Razor components. The data can be easily modified by editing the breed and disease lists in their respective page components.

## Technologies

- .NET 8
- Blazor WebAssembly (standalone)
- Bootstrap 5.3 (via CDN)
- C#
