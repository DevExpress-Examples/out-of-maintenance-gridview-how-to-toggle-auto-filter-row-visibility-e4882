@Functions
    Private Sub SetFilterRowVisibility(ByVal grid As MVCxGridView, ByVal visible As Boolean)
        grid.Settings.ShowFilterRow = visible
    End Sub
End Functions

@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gv"
    
            'built-in callbacks
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
    
            'custom callbacks
            settings.CustomActionRouteValues = New With {.Cotroller = "Home", .Action = "GridViewCustomActionPartial"}
    
            settings.KeyFieldName = "ID"
            settings.Columns.Add("ID")
            settings.Columns.Add("Text")
    
            settings.ClientSideEvents.BeginCallback = "OnBeginCallback"
            
            settings.PreRender = Sub(s, e) SetFilterRowVisibility(TryCast(s, MVCxGridView), Convert.ToBoolean(ViewData("AutoFilterRowVisible")))

            settings.BeforeGetCallbackResult = Sub(s, e) SetFilterRowVisibility(TryCast(s, MVCxGridView), Convert.ToBoolean(ViewData("AutoFilterRowVisible")))
    End Sub).Bind(Model).GetHtml()