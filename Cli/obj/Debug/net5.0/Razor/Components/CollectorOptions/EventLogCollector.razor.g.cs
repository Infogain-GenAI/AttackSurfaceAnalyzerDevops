#pragma checksum "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Components\CollectorOptions\EventLogCollector.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a2f92d2b50c88767f75887dcd1f8bcd037ded2f963758e0585bc1e76ad9ce35c"
// <auto-generated/>
#pragma warning disable 1591
namespace Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.CollectorOptions
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.CST.OAT.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.CST.OAT.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Objects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Collectors;

#line default
#line hidden
#nullable disable
    public partial class EventLogCollector : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-check");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "class", "form-check-input");
            __builder.AddAttribute(8, "id", "enableEventLogCollectionCheckbox");
            __builder.AddAttribute(9, "checked", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Components\CollectorOptions\EventLogCollector.razor"
                                                                                                         appData.CollectOptions.EnableEventLogCollector

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => appData.CollectOptions.EnableEventLogCollector = __value, appData.CollectOptions.EnableEventLogCollector));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<label class=\"form-check-label\" for=\"enableEventLogCollectionCheckbox\">Enable EventLog Collector</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-check");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "checkbox");
            __builder.AddAttribute(20, "class", "form-check-input");
            __builder.AddAttribute(21, "id", "enableVerboseEventLogCollectionCheckbox");
            __builder.AddAttribute(22, "checked", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Components\CollectorOptions\EventLogCollector.razor"
                                                                                                                appData.CollectOptions.GatherVerboseLogs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => appData.CollectOptions.GatherVerboseLogs = __value, appData.CollectOptions.GatherVerboseLogs));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<label class=\"form-check-label\" for=\"enableVerboseEventLogCollectionCheckbox\">Enable Verbose Event Log Collector</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.CST.AttackSurfaceAnalyzer.Cli.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
