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
#line 2 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using System.Reflection.Metadata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Microsoft.CodeAnalysis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Microsoft.CST.OAT.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Microsoft.CST.OAT.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Microsoft.CST.OAT.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
using Microsoft.CST.OAT.Blazor.Components.Inputs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/sandbox")]
    public partial class Sandbox : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "d:\sonarcube_projects\AttackSurfaceAnalyzerDevops\Cli\Pages\Sandbox.razor"
       
    Func<Stream, Task> LoadSandbox;

    void ClearSandbox()
    {
        AppState.TestObjects.Clear();
        SandBoxErrors.Clear();
        ParseErrors.Clear();
        this.StateHasChanged();
    }

    void RefreshPage()
    {
        this.StateHasChanged();
    }

    Type[] TypesList = typeof(AsaRule).Assembly.DefinedTypes.Where(x => typeof(CollectObject).IsAssignableFrom(x)).ToArray();

    void SetLoadSandbox()
    {
        LoadSandbox = async assemblyStream =>
        {
            SandBoxErrors.Clear();

            try
            {
                using var sr = new StreamReader(assemblyStream);
                JObject sandboxState = JObject.Parse(await sr.ReadToEndAsync());

                if (sandboxState["Objects"] is JObject sandBoxObjects)
                {
                    foreach (var objectType in sandBoxObjects.Properties().Select(x => x.Name).ToList())
                    {
                        var types = TypesList;
                        var results = new List<(Type, ConstructorInfo)>();
                        foreach (var typed in types)
                        {
                            var constructor = typed.GetConstructor(Type.EmptyTypes);
                            if (constructor != null)
                            {
                                results.Add((typed, constructor));
                            }
                            else
                            {
                                foreach (var ctor in typed.GetConstructors())
                                {
                                    var ctorFailed = false;
                                    foreach (var param in ctor.GetParameters())
                                    {
                                        if (!Helpers.ConstructedOfLoadedTypes(param.ParameterType, Assemblies))
                                        {
                                            ctorFailed = true;
                                            break;
                                        }
                                    }
                                    if (!ctorFailed)
                                    {
                                        results.Add((typed, ctor));
                                    }
                                }
                            }
                        }
                        var selected = results.Select(x => $"{x.Item1.FullName}");
                        var resultTypes = results.Where(x => $"{x.Item1.Namespace}.{x.Item1.Name}" == objectType);
                        if (resultTypes.Any())
                        {
                            var type = resultTypes.First();
                            if (sandboxState["Objects"]?[objectType] is JArray jArray)
                            {
                                foreach (var objState in jArray)
                                {
                                    var ctor = type.Item2;
                                    var inputs = new List<object?>();
                                    foreach (var param in ctor.GetParameters())
                                    {
                                        if (param.Name is not null)
                                        {
                                            var representation = objState?[param.Name]?.ToObject<string>();
                                            if (representation != null && GetValueFromJObject(param.ParameterType, representation) is { } obj)
                                            {
                                                inputs.Add(obj);
                                            }
                                            else
                                            {
                                                inputs.Add(null);
                                            }
                                        }
                                    }
                                    var empty = ctor.Invoke(inputs.ToArray());
                                    foreach (var prop in Helpers.GetAllNestedFieldsAndPropertiesMemberInfo(type.Item1))
                                    {
                                        var obj = objState;
                                        foreach (var split in prop.Path.Split('.'))
                                        {
                                            obj = obj?[split];
                                        }
                                        var stringRepresentation = obj.ToObject<string>();
                                        if (stringRepresentation is string representation)
                                        {
                                            if (prop.MemInfo is PropertyInfo propInfo)
                                            {
                                                object? value = GetValueFromJObject(propInfo.PropertyType, representation);
                                                Helpers.SetValueByPropertyOrFieldName(empty, prop.Path, value);
                                            }
                                            if (prop.MemInfo is FieldInfo fieldInfo)
                                            {
                                                object? value = GetValueFromJObject(fieldInfo.FieldType, representation);
                                                Helpers.SetValueByPropertyOrFieldName(empty, prop.Path, value);
                                            }
                                        }
                                    }
                                    AppState.TestObjects.Add((CollectObject)empty);
                                }

                            }
                        }
                        else
                        {
                            SandBoxErrors.Add($"Type {objectType} isn't loaded and won't be loaded.");
                        }
                    }
                }
            }
            catch (OperationCanceledException)
            {
                await InvokeAsync(StateHasChanged);
                await Task.Delay(1);
            }
            catch (Exception e)
            {
                var message = e.Message;
                var stackTrace = e.StackTrace;
                var type = e.GetType();
                var name = type.Name;
                type = e.GetType();
                Console.WriteLine($"{name}: {message} ({type}:{stackTrace})");
            }
            RefreshPage();
        };
    }

    List<string> ParseErrors = new List<string>();

    AsaAnalyzer analyzer = new AsaAnalyzer();

    List<string> SandBoxErrors = new List<string>();

    Dictionary<string, object> values = new Dictionary<string, object>();

    int constructorToInvoke
    {
        get
        {
            return _constructorToInvoke;
        }
        set
        {
            _constructorToInvoke = value;
            var constructors = Types.Where(x => x.Key.FullName == typeToInvoke).FirstOrDefault().Value;
            if (constructors.Any())
            {
                ScaffoldedObject = new Scaffold(constructors[value]);
                if (constructors[value].DeclaringType == typeof(CertificateObject))
                {
                    ScaffoldedObject.Parameters["Certificate"] = (new Scaffold(typeof(SerializableCertificate).GetConstructors().Where(x => x.GetParameters().Count() > 1).First()), typeof(SerializableCertificate));
                }
            }
            RefreshState();
        }
    }

    string typeToInvoke
    {
        get
        {
            return _typeToInvoke;
        }
        set
        {
            _typeToInvoke = value;
            var constructors = Types.Where(x => x.Key.FullName == value).FirstOrDefault().Value;
            if (constructors.Any())
            {
                var constructorToUse = constructors[constructorToInvoke];
                ScaffoldedObject = new Scaffold(constructorToUse, Assemblies);
                if (constructors[constructorToInvoke].DeclaringType == typeof(CertificateObject))
                {
                    ScaffoldedObject.Parameters["Certificate"] = (new Scaffold(typeof(SerializableCertificate).GetConstructors().Where(x => x.GetParameters().Count() > 1).First()), typeof(SerializableCertificate));
                }
            }
            RefreshState();
        }
    }

    string _typeToInvoke = string.Empty;

    public bool removeDisabled => AppState.TestObjects.Count == 0;
    public Scaffold ScaffoldedObject;

    int _constructorToInvoke;

    Dictionary<Type, List<ConstructorInfo>> Types { get; set; } = new Dictionary<Type, List<ConstructorInfo>>();

    List<Assembly> Assemblies { get; set; } = new List<Assembly>();

    protected override async Task OnInitializedAsync()
    {
        UpdateTypes();
        SetLoadSandbox();
        var results = analyzer.Analyze(AppState.Rules);
        await base.OnInitializedAsync();
    }

    void UpdateTypes()
    {
        Assemblies.Add(Assembly.Load("AsaLib"));
        Assemblies.Add(Assembly.Load("Microsoft.Win32.Registry"));

        var types = TypesList;
        var results = new Dictionary<Type, List<ConstructorInfo>>();
        foreach (var type in types)
        {
            try
            {
                var allowedConstructors = new List<ConstructorInfo>();
                var constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
                foreach (var constructorItr in constructors)
                {
                    if (Helpers.ConstructedOfLoadedTypes(constructorItr, Assemblies))
                    {
                        allowedConstructors.Add(constructorItr);
                    }
                }
                if (allowedConstructors.Any())
                {
                    results.Add(type, allowedConstructors);
                }
            }
            catch (Exception)
            {
                // Skip this constructor, we can't make it work.
                //Console.WriteLine($"Failed to get constructor:{e.Message}");
            }
        }
        Types = results;
        RefreshState();
    }

    void RefreshState()
    {
        this.StateHasChanged();
    }

    void RemoveLastObject()
    {
        if (AppState.TestObjects.Count > 0)
        {
            AppState.TestObjects.RemoveAt(AppState.TestObjects.Count - 1);
        }
    }

    Dictionary<string, object> Parameters = new Dictionary<string, object>();

    void AddObject()
    {
        try
        {
            if (ScaffoldedObject.Construct() is CollectObject colObj)
            {
                if (colObj is ComObject comObject)
                {
                    comObject.x86_Binary = new FileSystemObject(string.Empty);
                    comObject.x64_Binary = new FileSystemObject(string.Empty);
                }
                AppState.TestObjects.Add(colObj);
            }
        }
        catch (Exception e)
        {
            ParseErrors.Add($"Failed to construct object.  This likely is due to an external assembly reference.  This PWA currently only supports types which are fully defined within the provided assembly. ({e.Message})");
        }
    }

    object? GetValueFromJObject(Type type, string objectState)
    {
        if (type == typeof(int))
        {
            if (int.TryParse(objectState, out int intVal))
            {
                return intVal;
            }
        }
        else if (type == typeof(string))
        {
            return objectState;
        }
        else if (type == typeof(char))
        {
            return objectState[0];
        }
        else if (type == typeof(long))
        {
            if (long.TryParse(objectState, out long longVal))
            {
                return longVal;
            }
        }
        else if (type == typeof(float))
        {
            if (float.TryParse(objectState, out float floatVal))
            {
                return floatVal;
            }
        }
        else if (type == typeof(double))
        {
            if (double.TryParse(objectState, out double doubleVal))
            {
                return doubleVal;
            }
        }
        else if (type == typeof(decimal))
        {
            if (decimal.TryParse(objectState, out decimal decimalVal))
            {
                return decimalVal;
            }
        }
        else if (type == typeof(bool))
        {
            if (bool.TryParse(objectState, out bool boolVal))
            {
                return boolVal;
            }
        }
        else if (type == typeof(uint))
        {
            if (uint.TryParse(objectState, out uint uintVal))
            {
                return uintVal;
            }
        }
        else if (type == typeof(ulong))
        {
            if (ulong.TryParse(objectState, out ulong ulongVal))
            {
                return ulongVal;
            }
        }
        else if (type == typeof(short))
        {
            if (short.TryParse(objectState, out short shortVal))
            {
                return shortVal;
            }
        }
        else if (type == typeof(ushort))
        {
            if (ushort.TryParse(objectState, out ushort ushortVal))
            {
                return ushortVal;
            }
        }
        else if (type == typeof(DateTime))
        {
            if (DateTime.TryParse(objectState, out DateTime dateTimeVal))
            {
                return dateTimeVal;
            }
        }
        else if (type.IsEnum)
        {
            if (Enum.TryParse(type, objectState, out object? result))
            {
                return Convert.ChangeType(result, type);
            }
        }
        return null;
    }

    public async Task SaveSandboxState()
    {
        var objects = new Dictionary<string, List<object>>();
        foreach (var obj in AppState.TestObjects)
        {
            var t = obj.GetType();
            if (t.FullName is not null)
            {
                if (!objects.ContainsKey(t.FullName))
                {
                    objects.Add(t.FullName, new List<object>());
                }
                objects[t.FullName].Add(obj);
            }
        }
        var state = new Cli.SandboxState(objects);
        await JSRuntime.InvokeAsync<object>(
            "FileSaveAs",
            "SandboxState.json",
            "data:text/plain;charset=utf-8,",
            Newtonsoft.Json.JsonConvert.SerializeObject(state)
        );
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.CST.AttackSurfaceAnalyzer.Cli.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
