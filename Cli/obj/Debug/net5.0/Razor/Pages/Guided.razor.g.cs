#pragma checksum "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6238189f774edfa343947e533ac35f740e6f3b6dedd37e3397a08f8a5e2d567e"
// <auto-generated/>
#pragma warning disable 1591
namespace Microsoft.CST.AttackSurfaceAnalyzer.Cli.Pages
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
#line 1 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
using Microsoft.CST.OAT.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Objects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Collectors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/guided")]
    public partial class Guided : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Guided Mode</h4>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid bg-custom my-1 pb-1");
#nullable restore
#line 12 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
     switch (pageState)
    {
        case PageState.Options:

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "run-box bg-custom");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-inline");
            __builder.AddMarkupContent(7, "<label class=\"mr-2\" for=\"RunId\">Run ID:</label>\r\n                    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control mr-2");
            __builder.AddAttribute(11, "id", "RunId");
            __builder.AddAttribute(12, "placeholder", "Enter Run ID");
            __builder.AddAttribute(13, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
                                                                                                              RunIdInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => RunIdInput = __value, RunIdInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-check mr-2");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "checkbox");
            __builder.AddAttribute(20, "class", "form-check-input");
            __builder.AddAttribute(21, "id", "UseTimestampCheckbox");
            __builder.AddAttribute(22, "checked", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
                                                                                                         UseTimestamp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UseTimestamp = __value, UseTimestamp));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.AddMarkupContent(25, "<label class=\"form-check-label\" for=\"UseTimestampCheckbox\">Use Timestamp</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddAttribute(29, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
                                                              BeginGuided

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Start Guided Scan");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.AddMarkupContent(32, @"<ul class=""nav nav-tabs mb-3"" id=""options-tabs"" role=""tablist""><li class=""nav-item""><a class=""nav-link active"" id=""collectors-tab"" data-toggle=""tab"" href=""#collectors"" role=""tab"" aria-controls=""collectors"" aria-selected=""true"">Collectors</a></li>
                <li class=""nav-item""><a class=""nav-link"" id=""monitor-tab"" data-toggle=""tab"" href=""#monitor"" role=""tab"" aria-controls=""monitor"" aria-selected=""false"">Monitor</a></li>
                <li class=""nav-item""><a class=""nav-link"" id=""analyze-tab"" data-toggle=""tab"" href=""#analyze"" role=""tab"" aria-controls=""analyze"" aria-selected=""false"">Analyze</a></li></ul>
            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "tab-content");
            __builder.AddAttribute(35, "id", "options-tabs-content");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "tab-pane fade show active");
            __builder.AddAttribute(38, "id", "collectors");
            __builder.AddAttribute(39, "role", "tabpanel");
            __builder.AddAttribute(40, "aria-labelledby", "collectors-tab");
            __builder.OpenComponent<global::Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.CollectorOptionsRazor>(41);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "tab-pane fade");
            __builder.AddAttribute(45, "id", "monitor");
            __builder.AddAttribute(46, "role", "tabpanel");
            __builder.AddAttribute(47, "aria-labelledby", "monitor-tab");
            __builder.OpenComponent<global::Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.MonitorOptionsRazor>(48);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "tab-pane fade");
            __builder.AddAttribute(52, "id", "analyze");
            __builder.AddAttribute(53, "role", "tabpanel");
            __builder.AddAttribute(54, "aria-labelledby", "analyze-tab");
            __builder.OpenComponent<global::Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.AnalyzeOptionsRazor>(55);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"

            break;
        case PageState.Scanning:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States.Scanning>(56);
            __builder.CloseComponent();
#nullable restore
#line 52 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
            break;
        case PageState.Monitoring:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States.Monitoring>(57);
            __builder.AddAttribute(58, "Continue", (object)((global::System.Action)(
#nullable restore
#line 54 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
                                   ContinueGuided

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 55 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
            break;
        case PageState.MonitorFlushing:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States.MonitorFlushing>(59);
            __builder.CloseComponent();
#nullable restore
#line 58 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
            break;
        case PageState.Analyzing:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States.Analyzing>(60);
            __builder.CloseComponent();
#nullable restore
#line 61 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
            break;
        case PageState.Results:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States.Results>(61);
            __builder.AddAttribute(62, "FirstRunId", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 63 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
                                  appData.ExportCollectCommandOptions.FirstRunId

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(63, "SecondRunId", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 63 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
                                                                                                appData.ExportCollectCommandOptions.SecondRunId

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(64, "AnalysesHash", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 63 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
                                                                                                                                                                appData.CompareCommandOptions.AnalysesFile.GetHash()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(65, "MonitorRunId", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 63 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
                                                                                                                                                                                                                                     appData.MonitorOptions.RunId

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 64 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
            break;
        case PageState.Error:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "<p>An Error Occured while collecting.</p>");
#nullable restore
#line 67 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
            break;
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Guided.razor"
      
    enum PageState
    {
        Options,
        Scanning,
        Monitoring,
        MonitorFlushing,
        Analyzing,
        Results,
        Error
    }

    bool UseTimestamp = true;
    string RunIdInput = "";

    PageState pageState = PageState.Options;

    async void BeginGuided()
    {
        appData.RunId = UseTimestamp ? DateTime.Now.ToString() : RunIdInput;
        timer = new System.Threading.Timer((_) => InvokeAsync(() => StateHasChanged()), null, 0, 100);
        appData.CollectOptions.RunId = appData.FirstRunId;
        if (await BeginScan() == ASA_ERROR.NONE)
        {
            appData.MonitorOptions.RunId = appData.MonitorRunId;
            await BeginMonitor();
            AttackSurfaceAnalyzerClient.ClearCollectors();
        }
        else
        {
            pageState = PageState.Error;
        }
    }

    async void ContinueGuided()
    {
        pageState = PageState.MonitorFlushing;
        this.StateHasChanged();
        AttackSurfaceAnalyzerClient.StopMonitors();
        while (AttackSurfaceAnalyzerClient.DatabaseManager.HasElements)
        {
            Thread.Sleep(1);
        }

        appData.CollectOptions.RunId = appData.SecondRunId;
        await BeginScan();

        appData.ExportCollectCommandOptions.SaveToDatabase = true;
        appData.ExportCollectCommandOptions.FirstRunId = appData.FirstRunId;
        appData.ExportCollectCommandOptions.SecondRunId = appData.SecondRunId;
        await BeginAnalyze();
        pageState = PageState.Results;
    }

    System.Threading.Timer timer;

    async Task<ASA_ERROR> BeginScan()
    {
        pageState = PageState.Scanning;
        this.StateHasChanged();
        return await Task.Factory.StartNew(() => AttackSurfaceAnalyzerClient.RunCollectCommand(appData.CollectOptions));
    }

    async Task<ASA_ERROR> BeginMonitor()
    {
        pageState = PageState.Monitoring;
        this.StateHasChanged();
        return await Task.Factory.StartNew(() => AttackSurfaceAnalyzerClient.RunGuiMonitorCommand(appData.MonitorOptions));
    }

    async Task<ASA_ERROR> BeginAnalyze()
    {
        pageState = PageState.Analyzing;

        await Task.Factory.StartNew(() =>
        {
            var CompareOneOptions = appData.CompareCommandOptions;
            CompareOneOptions.FirstRunId = appData.ExportCollectCommandOptions.FirstRunId;
            CompareOneOptions.SecondRunId = appData.ExportCollectCommandOptions.SecondRunId ?? string.Empty;
            var results = AttackSurfaceAnalyzerClient.CompareRuns(CompareOneOptions);
            AttackSurfaceAnalyzerClient.InsertCompareResults(results, appData.ExportCollectCommandOptions.FirstRunId, appData.ExportCollectCommandOptions.SecondRunId ?? string.Empty, appData.CompareCommandOptions.AnalysesFile?.GetHash() ?? "");
        });

        await Task.Factory.StartNew(() =>
        {
            var CompareTwoOptions = appData.CompareCommandOptions;

            CompareTwoOptions.FirstRunId = null;
            CompareTwoOptions.SecondRunId = appData.MonitorRunId;
            var results = AttackSurfaceAnalyzerClient.CompareRuns(CompareTwoOptions);
            AttackSurfaceAnalyzerClient.InsertCompareResults(results, null, appData.MonitorRunId, appData.CompareCommandOptions.AnalysesFile?.GetHash() ?? "");
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
