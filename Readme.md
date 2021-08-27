<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550740/14.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4882)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E4882/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E4882/Controllers/HomeController.vb))
* [DataRepository.cs](./CS/E4882/Models/DataRepository.cs) (VB: [DataRepository.vb](./VB/E4882/Models/DataRepository.vb))
* **[GridViewPartial.cshtml](./CS/E4882/Views/Home/GridViewPartial.cshtml)**
* [Index.cshtml](./CS/E4882/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to toggle Auto Filter Row visibility
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4882/)**
<!-- run online end -->


<p>Starting with v2014 vol 1 (v14.1), it is much easier to accomplish this task via the built-in Context Menu -> Filter Row command. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2014/05/12/asp-net-gridview-context-menu-what-39-s-new-in-14-1.aspx">ASP.NET: GridView Context Menu (What's new in 14.1)</a> blog post to learn more about this new feature and the online <a href="http://demos.devexpress.com/aspxgridviewdemos/Columns/ContextMenu.aspx">Context Menu</a> demo to see it in action.<br /><br />This example illustrates how to toggle the Auto Filter Row visibility via a custom MVC GridView callback.</p>
<p>- Initialize the expected Auto Filter Row visibility via the <strong>ViewData</strong> key when a View is loaded for the first time;<br /> - Set the <strong>CheckBox</strong> state according to the ViewData key value;<br /> - Load the <strong>GridView's PartialView</strong> via the <strong>Html.Action</strong> method and pass the ViewData key as a parameter;<br /> - Set the Auto Filter Row visibility according to the <strong>ViewData</strong> key;<br /> - Handle the client-side <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxEditorsScriptsASPxClientCheckBox_CheckedChangedtopic"><u>ASPxClientCheckBox.CheckedChanged</u></a> event;<br /> - Perform a custom GridView callback via the client-side <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_PerformCallbacktopic"><u>ASPxClientGridView.PerformCallback</u></a> method;<br /> - Handle the client-side <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_BeginCallbacktopic"><u>ASPxClientGridView.BeginCallback</u></a> event;<br /> - Pass the CheckBox' checked state as a parameter (<a href="http://documentation.devexpress.com/#AspNet/CustomDocument9941"><u>Passing Values to Controller Action Through Callbacks</u></a>);<br /> - Handle the <strong>GridViewSettings.CustomActionRouteValues.Action</strong> method and retrieve the passed parameter. In general, it is possible to use the <strong>Action method</strong> specified <strong>for all GridView callbacks</strong> (<strong>GridViewSettings.CallbackRouteValues.Action</strong>). The illustrated technique allows handling a custom GridView's callback <strong>within a separate Action method</strong>, whose signature can be different. Usually, custom callbacks are used for changing the GridView's state programmatically in a custom manner (like here - toggling the Auto Filter Row visibility);<br /> - Pass the required Auto Filter Row visibility state via the ViewData key back to the GridView PartialView.</p>

<br/>


