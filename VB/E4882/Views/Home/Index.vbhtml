<script type="text/javascript">
    function OnBeginCallback(s, e) {
        e.customArgs["visible"] = cbToggle.GetChecked();
    }
    function OnCheckedChanged(s, e) {
        gv.PerformCallback();
    }
</script>

@Html.DevExpress().CheckBox( _
    Sub(settings)
            settings.Name = "cbToggle"
            settings.Text = "Toggle AutoFilterRow"
            settings.Checked = Convert.ToBoolean(ViewData("AutoFilterRowVisible"))
            settings.Properties.ClientSideEvents.CheckedChanged = "OnCheckedChanged"
    End Sub).GetHtml()

@Html.Action("GridViewPartial", New With {.visible = ViewData("AutoFilterRowVisible")})