Public Class ChartController
    Inherits System.Web.Mvc.Controller
    Function Index() As ActionResult
        Return View(New GdpProvider(Server.MapPath("~/App_Data/GDPofG7.xml")).GetGdps())
    End Function
End Class