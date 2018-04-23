<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Html.DevExpress().GetStyleSheets(
                New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
                New StyleSheet With {.ExtensionSuite = ExtensionSuite.Chart},
                New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView})
</head>
<body>
    @RenderBody()

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Html.DevExpress().GetScripts(
                    New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
                    New Script With {.ExtensionSuite = ExtensionSuite.Chart},
                    New Script With {.ExtensionSuite = ExtensionSuite.GridView})
    @RenderSection("scripts", required:=False)
</body>
</html>
