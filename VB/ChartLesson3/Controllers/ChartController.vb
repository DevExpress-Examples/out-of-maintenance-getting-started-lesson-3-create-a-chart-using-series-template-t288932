Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace ChartLesson3.Controllers
    Public Class ChartController
        Inherits Controller

        Public Function Index() As ActionResult
            Using dbContext = New Models.GspDbContext()
                Return View(dbContext.GSPs.ToList())
            End Using
        End Function
    End Class
End Namespace
