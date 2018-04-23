@Code
    ViewData("Title") = "Index"

    Dim settings As ChartControlSettings = New ChartControlSettings With {
        .Name = "chart",
        .Width = 640,
        .Height = 360,
        .PaletteName = "Office 2013"
    }

    settings.SeriesDataMember = "Year"
    settings.SeriesTemplate.ArgumentDataMember = "Region"
    settings.SeriesTemplate.ValueDataMembers.AddRange("GSP1")

    Dim view As SideBySideBarSeriesView = New SideBySideBarSeriesView()
    view.FillStyle.FillMode = FillMode.Solid

    settings.SeriesTemplate.View = view

    settings.Titles.Add(New ChartTitle With {.Text = "US regions gross state product"})

    Dim diagram As XYDiagram = TryCast(settings.Diagram, XYDiagram)
    If (diagram IsNot Nothing) Then
        diagram.AxisY.Title.Text = "Millions of USD"
        diagram.AxisY.Title.Visibility = DefaultBoolean.True
    End If

    Html.DevExpress().Chart(settings).Bind(Model).GetHtml()
End Code