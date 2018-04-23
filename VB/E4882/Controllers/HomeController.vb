Imports Microsoft.VisualBasic
Imports System
Imports System.Web.Mvc
Imports E4882.Models

Namespace E4882.Controllers
    Public Class HomeController
        Inherits Controller
        Public Function Index() As ActionResult
            ViewData("AutoFilterRowVisible") = True
            Return View(DataRepository.GetData())
        End Function
        Public Function GridViewPartial(ByVal visible As Boolean) As ActionResult
            Return GridViewCorePartial(visible)
        End Function
        Public Function GridViewCustomActionPartial(ByVal visible As Boolean) As ActionResult
            Return GridViewCorePartial(visible)
        End Function
        Private Function GridViewCorePartial(ByVal visible As Boolean) As ActionResult
            ViewData("AutoFilterRowVisible") = visible
            Return PartialView("GridViewPartial", DataRepository.GetData())
        End Function
    End Class
End Namespace