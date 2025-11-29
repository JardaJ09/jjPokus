# jjPokus

## DogsInfo - Blazor WebAssembly Application

A simple Blazor WebAssembly application that provides informational pages about dogs, including popular dog breeds and common canine diseases.

### Features

- **Dog Breeds Page** (`/breeds`): Browse a collection of popular dog breeds with information about their origin, size category, and temperament. Includes search and filter functionality.
- **Dog Diseases Page** (`/diseases`): Learn about common dog health issues with descriptions, symptoms, severity ratings, and suggested actions presented in an expandable accordion layout.

### Technology Stack

- .NET 8 Blazor WebAssembly Standalone App
- Bootstrap 5 (via CDN) for styling
- Client-side rendering (no server required)

### Project Structure

```
DogsInfo/
├── Components/
│   └── SeverityBadge.razor      # Reusable badge component for disease severity
├── Layout/
│   ├── MainLayout.razor         # Main application layout
│   └── NavMenu.razor            # Navigation menu component
├── Models/
│   ├── Breed.cs                 # Breed data model
│   └── Disease.cs               # Disease data model
├── Pages/
│   ├── Home.razor               # Home page (/)
│   ├── Breeds.razor             # Dog breeds page (/breeds)
│   └── Diseases.razor           # Dog diseases page (/diseases)
├── wwwroot/
│   ├── css/
│   │   └── site.css             # Custom styles
│   └── index.html               # Main HTML file with Bootstrap CDN
└── Program.cs                   # Application entry point
```

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later

### Build and Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/JardaJ09/jjPokus.git
   cd jjPokus
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Build the application:**
   ```bash
   dotnet build
   ```

4. **Run the application:**
   ```bash
   cd DogsInfo
   dotnet run
   ```
   
   Or use watch mode for development:
   ```bash
   cd DogsInfo
   dotnet watch run
   ```

5. **Access the application:**
   Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

### Pages Overview

#### Home Page (/)
Welcome page with an overview of the application and quick links to the main pages.

#### Dog Breeds (/breeds)
- Displays a grid of dog breed cards with images, origin, size category, and temperament
- **Search**: Filter breeds by name using the search box
- **Size Filter**: Filter breeds by size category (Small/Medium/Large)
- Data is stored in-memory as a list of `Breed` objects

#### Dog Diseases (/diseases)
- Displays common dog diseases in an accordion layout
- Each disease shows severity badge (Low/Moderate/High) with color coding
- Expandable sections reveal description, symptoms, and suggested actions
- Uses the reusable `SeverityBadge` component for severity display
- Data is stored in-memory as a list of `Disease` objects

### Data Models

**Breed:**
- Name, Origin, SizeCategory (Small/Medium/Large), Temperament, ImageUrl

**Disease:**
- Name, Description, Symptoms, SuggestedAction, Severity (Low/Moderate/High)

### Notes

- All data is stored in-memory; no database or persistent storage is used
- Images use placeholder URLs from placedog.net
- The application runs entirely client-side in the browser

