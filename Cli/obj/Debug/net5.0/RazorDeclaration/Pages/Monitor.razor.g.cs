// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Microsoft.CST.AttackSurfaceAnalyzer.Cli.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.OAT.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.OAT.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Objects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Collectors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/monitor")]
    public partial class Monitor : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Monitor.razor"
       
    enum PageState
    {
        Options,
        Monitoring,
        MonitorFlushing,
        Finished,
        Error
    }

    bool UseTimestamp = true;
    string RunIdInput = "";

    PageState pageState = PageState.Options;

    System.Threading.Timer timer;

    async void BeginMonitor()
    {
        appData.RunId = UseTimestamp ? DateTime.Now.ToString() : RunIdInput;
        timer = new System.Threading.Timer((_) => InvokeAsync(() => StateHasChanged()), null, 0, 100);
        appData.MonitorOptions.RunId = appData.MonitorRunId;

        pageState = PageState.Monitoring;
        this.StateHasChanged();

        if (await Task.Factory.StartNew(() => AttackSurfaceAnalyzerClient.RunGuiMonitorCommand(appData.MonitorOptions)) != Microsoft.CST.AttackSurfaceAnalyzer.Types.ASA_ERROR.NONE)
        {
            pageState = PageState.Error;
        }

        this.StateHasChanged();
    }

    void FinishMonitor()
    {
        pageState = PageState.MonitorFlushing;
        this.StateHasChanged();
        AttackSurfaceAnalyzerClient.StopMonitors();
        pageState = PageState.Finished;
        this.StateHasChanged();
    }

    void GoToOptions()
    {
        pageState = PageState.Options;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.CST.AttackSurfaceAnalyzer.Cli.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
