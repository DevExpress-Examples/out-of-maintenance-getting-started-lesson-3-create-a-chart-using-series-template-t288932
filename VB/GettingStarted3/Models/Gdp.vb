Public Class Gdp
    Private mProduct As Double
    Private mYear As Integer
    Private mCountry As String

    Public ReadOnly Property Country() As String
        Get
            Return mCountry
        End Get
    End Property
    Public ReadOnly Property Year() As Integer
        Get
            Return mYear
        End Get
    End Property
    Public ReadOnly Property Product() As Double
        Get
            Return mProduct
        End Get
    End Property

    Public Sub New(country As String, year As Integer, product As Double)
        mCountry = country
        mYear = year
        mProduct = product
    End Sub
End Class