Imports System.Collections.ObjectModel

Public Class GdpProvider
    Dim mFilepath As String

    Sub New(filepath As String)
        mFilepath = filepath
    End Sub

    Function GetGdps() As IEnumerable(Of Gdp)
        Dim gdps = New Collection(Of Gdp)
        Dim document = XDocument.Load(mFilepath)
        Dim root As XElement = document.Element("G7GDPs")
        For Each elementGdp As XElement In root.Elements("GDP")
            gdps.Add(New Gdp(
                    country:=elementGdp.Element("Country").Value,
                    year:=Convert.ToInt32(elementGdp.Element("Year").Value),
                    product:=Convert.ToDouble(elementGdp.Element("Product").Value)))
        Next
        Return gdps
    End Function
End Class
