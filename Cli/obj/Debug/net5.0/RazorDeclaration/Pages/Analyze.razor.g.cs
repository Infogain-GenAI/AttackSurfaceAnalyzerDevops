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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/analyze")]
    public partial class Analyze : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Analyze.razor"
      
    enum PageState
    {
        Options,
        Analyzing,
        Finished,
        Error
    }

    List<string> Runs = AttackSurfaceAnalyzerClient.DatabaseManager?.GetRuns() ?? new List<string>();

    int RunIdInput {
        get
        {
            return Runs.IndexOf(appData.ExportCollectCommandOptions.FirstRunId ?? string.Empty);
        }
        set
        {
            if (value >= 0)
            {
                appData.ExportCollectCommandOptions.FirstRunId = Runs[value];
            }
            else
            {
                appData.ExportCollectCommandOptions.FirstRunId = string.Empty;
            }
        }
    }
    int RunIdInput2
    {
        get
        {
            return Runs.IndexOf(appData.ExportCollectCommandOptions.SecondRunId ?? string.Empty);
        }
        set
        {
            if (value >= 0)
            {
                appData.ExportCollectCommandOptions.SecondRunId = Runs[value];
            }
            else
            {
                appData.ExportCollectCommandOptions.SecondRunId = string.Empty;
            }
        }
    }

    PageState pageState = PageState.Options;

    void GoToOptions()
    {
        pageState = PageState.Options;
    }

    async void BeginAnalyze()
    {
        await AnalyzeIt();
        pageState = PageState.Finished;
    }
    System.Threading.Timer? timer;

    async Task<ASA_ERROR> AnalyzeIt()
    {
        timer = new System.Threading.Timer((_) => InvokeAsync(() => StateHasChanged()), null, 0, 100);
        var firstRunId = RunIdInput != -1 ? Runs[RunIdInput] : string.Empty;
        var secondRunId = RunIdInput2 != -1 ? Runs[RunIdInput2] : string.Empty;

        appData.ExportCollectCommandOptions.FirstRunId = string.IsNullOrEmpty(secondRunId) ? secondRunId : firstRunId;
        appData.ExportCollectCommandOptions.SecondRunId = string.IsNullOrEmpty(secondRunId) ? firstRunId : secondRunId;
        pageState = PageState.Analyzing;

        await Task.Factory.StartNew(() =>
        {
            var CompareOneOptions = appData.CompareCommandOptions;
            CompareOneOptions.FirstRunId = appData.ExportCollectCommandOptions.FirstRunId;
            CompareOneOptions.SecondRunId = appData.ExportCollectCommandOptions.SecondRunId;
            var results = AttackSurfaceAnalyzerClient.CompareRuns(CompareOneOptions);
            AttackSurfaceAnalyzerClient.InsertCompareResults(results, CompareOneOptions.FirstRunId, CompareOneOptions.SecondRunId, appData.CompareCommandOptions.AnalysesFile?.GetHash() ?? string.Empty);
        });

        return ASA_ERROR.NONE;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.CST.AttackSurfaceAnalyzer.Cli.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
