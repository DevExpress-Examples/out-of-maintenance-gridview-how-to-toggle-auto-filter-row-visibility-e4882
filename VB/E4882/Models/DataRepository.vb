Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq

Namespace E4882.Models
    Public Class DataEntry
        Private privateID As Integer
        Public Property ID() As Integer
            Get
                Return privateID
            End Get
            Set(ByVal value As Integer)
                privateID = value
            End Set
        End Property
        Private privateText As String
        Public Property Text() As String
            Get
                Return privateText
            End Get
            Set(ByVal value As String)
                privateText = value
            End Set
        End Property
    End Class
    Public NotInheritable Class DataRepository
        Private Sub New()
        End Sub
        Public Shared Function GetData() As IEnumerable
            Return Enumerable.Range(0, 100).Select(Function(i) New DataEntry With {.ID = i, .Text = "Text " & i})
        End Function
    End Class
End Namespace