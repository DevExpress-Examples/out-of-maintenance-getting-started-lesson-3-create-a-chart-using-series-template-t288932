@Code
    ViewBag.Title = "Getting Started Lesson 3"
End Code

@Html.DevExpress().Chart(Sub(settings)
                                  ' Specify the obligatory chart name.
                                  settings.Name = "Chart"
                                  settings.Width = 640
                                  settings.Height = 360
                                  settings.PaletteName = "Office 2013"

                                  ' Configure a template used to generate series.
                                  settings.Series.Template(Sub(t)
                                                               t.SetDataMembers("Year", "Product")
                                                               t.Views().LineSeriesView(Sub(v) v.MarkerVisibility = DefaultBoolean.True)
                                                           End Sub)

                                  ' Add a chart title.
                                  settings.Titles.Add(Sub(t) t.Text = "G7 GDP")

                                  ' Configure the diagram after series because diagram can be changed
                                  ' to be compatible with the series view type.
                                  settings.XYDiagram(Sub(d)
                                                         ' Set the X-axis title text And show it.
                                                         d.AxisX.Title.Visibility = DefaultBoolean.True
                                                         d.AxisX.Title.Text = "Year"

                                                         ' Configure scale options to show only integer value tickmarks.
                                                         d.AxisX.NumericScaleOptions.MeasureUnit = NumericMeasureUnit.Ones
                                                         d.AxisX.NumericScaleOptions.GridOffset = 1

                                                         ' Set the Y-axis title text And show it.
                                                         d.AxisY.Title.Visibility = DefaultBoolean.True
                                                         d.AxisY.Title.Text = "GDP, billions of USD"
                                                     End Sub)

                                  settings.Legends.Default(Sub(l)
                                                               l.AlignmentHorizontal = LegendAlignmentHorizontal.Left
                                                               l.AlignmentVertical = LegendAlignmentVertical.Top
                                                               l.Direction = LegendDirection.LeftToRight
                                                           End Sub)
                              End Sub).Bind(Model, "Country").GetHtml()
