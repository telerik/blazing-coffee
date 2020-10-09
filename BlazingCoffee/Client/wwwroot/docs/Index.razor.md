# Demos you'll find here include:

This application showcases many Blazor and Telerik UI for Blazor features.

## Application Features

Application wide features included in the project are outlined below.

### Telerik UI for Blazor

Telerik UI for Blazor is used frequently throughout the application. Including TileLayout, Grid, ToolTip, Chart, Window and many more.

See each component's .md file by clicking the ? icon for details.

### Authentication

- Authentication is provided by [ASP.NET Core Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-3.1&tabs=visual-studio)
- The app requires an authenticated user to view all pages except for the index page
- You may be asked to "migrate" the data base when the application runs for the first time

### Globalization and Localization with ITelerikStringLocalizer

Each component resolves the ITelerikStringLocalizer interface. This is an interface that makes Localization available throughout the app.

- ITelerikStringLocalizer comes from the Telerik.Blazor.Services namespace
- The custom implementation of ITelerikStringLocalizer, BlazingCoffee.Shared.Localization.TelerikLocalizer resolves app wide localization values, and Telerik UI component localization values.
- Where ITelerikStringLocalizer is used the instance is named `L` or `@L` followed by the localizaton key, ex: `@L["Key_for_localized_string_value"]`
- Localization resources are found in BlazingCoffee.Shared/Resources

### Theme

- The application will automatically choose a theme based on your system preferences of light or dark.
- The theme can be changed manually by clicking the gear icon from the top toolbar
- Themes are set using JavaScript interop found in wwwroot/js/themeChooser.js
- To modify the theme visit ThemeBuilder.telerik.com and apply the .scss/_variables produced by themebuilder to Themes/_variables.scss.

### Telerik Drawer

- A TelerikDrawer component powers the left navigation https://demos.telerik.com/blazor-ui/drawer/overview
- For this application a template is used to achieve section headings
- A custom DrawerNavLink component is used to ensure the correct item is always highlighted when visiting a page
- Inside the drawer a user photo is supplied by Gravitar, see: LoginDisplay.razor for code samples

## Index Page Features

## Telerik Tool Tip

## Tile Layout

https://demos.telerik.com/blazor-ui/tilelayout/overview