Imports System.Web.Mvc

Namespace Controllers
    Public Class ChartController
        Inherits Controller

        ' GET: Chart
        Function Index() As ActionResult
            Using dbContent = New GspDbContext()
                Return View(dbContent.GSPs.ToList())
            End Using
        End Function
    End Class
End Namespace