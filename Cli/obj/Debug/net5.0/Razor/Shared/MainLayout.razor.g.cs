#pragma checksum "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Shared\MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f16fe01268fed6493bb4ec45c85874aadd47035528ec9bbe19a6fa64717d29fe"
// <auto-generated/>
#pragma warning disable 1591
namespace Microsoft.CST.AttackSurfaceAnalyzer.Cli.Shared
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
#nullable restore
#line 2 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Shared\MainLayout.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Utils;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.CST.AttackSurfaceAnalyzer.Cli.Shared.NavMenu>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "main");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content");
#nullable restore
#line 7 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Shared\MainLayout.razor"
__builder.AddContent(6, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.CST.AttackSurfaceAnalyzer.Cli.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
