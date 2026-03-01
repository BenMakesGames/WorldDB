# World DB

A reference web app for countries, characters, and species. Built with ASP.NET Core Razor Pages. All data is stored in memory — no database required.

## Prerequisites

You need the **.NET 10 SDK** (not just the runtime).

### Windows

Download the SDK installer from https://dotnet.microsoft.com/download/dotnet/10.0 and run it.

### macOS

```
brew install dotnet-sdk
```

Or download the installer from the link above.

### Linux (Ubuntu/Debian)

```
sudo apt update
sudo apt install dotnet-sdk-10.0
```

For other distros, see https://learn.microsoft.com/dotnet/core/install/linux

### Verify installation

```
dotnet --version
```

You should see `10.0.x` or later.

## Running the app

```
cd WorldDb
dotnet run
```

The first run will restore NuGet packages automatically. Once you see output like:

```
Now listening on: https://localhost:5001
```

open that URL in your browser. The exact port may vary — check the terminal output.

## Project structure

```
WorldDb/
├── Models/          # Data classes (Country, Character, Species)
├── Services/        # In-memory data stores
├── Pages/           # Razor Pages (UI)
│   ├── Countries/   # List and detail pages for countries
│   ├── Characters/  # List and detail pages for characters
│   └── Species/     # List and detail pages for species
├── wwwroot/         # Static files (CSS, JS)
└── Program.cs       # App entry point and service registration
```
