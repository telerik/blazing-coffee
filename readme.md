# Blazing Coffee Roasters

This is a demo showing how a full-stack .NET application can be built with ASP.NET Core, Blazor Wasm, and Telerik UI for Blazor.

## Requirements

- .NET Core 3.2 or higher
- Telerik UI for Blazor (Trial or Commercial)
- npm (node package manager, for sass themes)

## Running the Application

- from /BlazingCoffee/Client run `npm install`
- run the application and create an account. You should be prompted to `Apply Migrations`. This will create a database for logging into the application.
- Note: The first run make take some time as the database is seeded with sample data.

## Telerik UI for Blazor Trial

If you are using a trial version of Telerik UI for Blazor.

- In BlazingCoffee.Client add `.Trial` to the package path.

```
    <PackageReference Include="Telerik.UI.for.Blazor.Trial" Version="2.13.0" />
```

- In BlazingCoffee.Client/wwwroot, add `.Trial` to the script path.

```
    <script src="_content/telerik.ui.for.blazor/js/telerik-blazor.js"></script>
```

- In BlazingCoffee.Server, add .Trial to all Telerik.* package paths.

```
    <PackageReference Include="Telerik.Documents.Core.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Fixed.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Flow.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Flow.FormatProviders.Pdf.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Spreadsheet.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Spreadsheet.FormatProviders.OpenXml.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Spreadsheet.FormatProviders.Pdf.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.SpreadsheetStreaming.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Zip.Trial" Version="2020.1.109" />
```