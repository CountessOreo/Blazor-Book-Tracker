@page "/"
@namespace BookTracker.Pages
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@using Microsoft.AspNetCore.Components.Web
@using Microsoft.AspNetCore.Components.WebAssembly.Server
@using BookTracker

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <base href="~/" />

    <!-- Bootstrap and Syncfusion CSS -->
    <link rel="stylesheet" href="bootstrap/bootstrap.min.css" />
    <link rel="stylesheet" href="_content/Syncfusion.Blazor.Themes/bootstrap5.css" />

    <!-- Your app styles -->
    <link rel="stylesheet" href="app.css" />
    <link rel="stylesheet" href="BookTracker.styles.css" />
    <link rel="icon" type="image/png" href="favicon.png" />

    <script>
        window.toggleBodyClass = function (themeClass) {
            document.body.classList.remove("light-mode", "dark-mode");
document.body.classList.add(themeClass);
        };
    </ script >

    < component type = "typeof(HeadOutlet)" render - mode = "ServerPrerendered" />
</ head >
< body >
    < component type = "typeof(App)" render - mode = "ServerPrerendered" />

    < !--Blazor + Syncfusion scripts-- >
    < script src = "_framework/blazor.server.js" ></ script >
    < script src = "_content/Syncfusion.Blazor.Core/scripts/sf-blazor.min.js" ></ script >
</ body >
</ html >
