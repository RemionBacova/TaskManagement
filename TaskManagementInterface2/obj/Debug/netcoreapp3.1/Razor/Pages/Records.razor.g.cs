#pragma checksum "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a643fbad4ef6f2f0ed0b87571c52ceb3a94a9b"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskManagementInterface.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
using Syncfusion.Blazor.TreeGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
using TaskManagementInterface.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reports")]
    public partial class Records : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> Reporting</h3>\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n\r\n    .sf-license-warning {\r\n        display: none !important;\r\n    }\r\n\r\n    #wrapper {\r\n        max-width: 300px;\r\n        margin: 0px auto;\r\n        padding-top: 20px\r\n    }\r\n</style>\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container py-3");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-6");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<label for=\"date\">1.Select Machine:</label>\r\n            ");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "class", "custom-select");
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                                      EntitieClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", true);
            __builder.AddContent(18, "-- Select Machine --");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 40 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                 if (machines != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                     foreach (var mach in machines)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                        ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", 
#nullable restore
#line 44 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                        mach.uid

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, 
#nullable restore
#line 44 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                                   mach.machineName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 45 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                     
                }
                else
                {

                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-6");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.AddMarkupContent(33, "<label for=\"date\">2.Pick Data Range:</label>\r\n                ");
            __builder.OpenComponent<Syncfusion.Blazor.Calendars.SfDateRangePicker>(34);
            __builder.AddAttribute(35, "StartDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 57 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                                     StartValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "StartDateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StartValue = __value, StartValue))));
            __builder.AddAttribute(37, "StartDateExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.DateTime?>>>(() => StartValue));
            __builder.AddAttribute(38, "EndDate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 57 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                                                                 EndValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "EndDateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EndValue = __value, EndValue))));
            __builder.AddAttribute(40, "EndDateExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.DateTime?>>>(() => EndValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    <br>\r\n    ");
            __builder.OpenElement(45, "div");
            __builder.AddMarkupContent(46, "\r\n\r\n        ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "btn btn-primary col-md-12");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                                            MachineReporting

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "Get Report");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    <br>\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<MachineReporting2>>(55);
            __builder.AddAttribute(56, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<MachineReporting2>>(
#nullable restore
#line 72 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                                        machreps

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(60, "\r\n\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(61);
                __builder2.AddAttribute(62, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 74 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                        10

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(64);
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(67);
                    __builder3.AddAttribute(68, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                   nameof(MachineReporting2.hoursSpend)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "HeaderText", "Hours Active");
                    __builder3.AddAttribute(70, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 76 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                                                                                             TextAlign.Left

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "Width", "80");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(72, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(73);
                    __builder3.AddAttribute(74, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 77 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
                                   nameof(MachineReporting2.applicationName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "HeaderText", "Application Name");
                    __builder3.AddAttribute(76, "Width", "80");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n\r\n\r\n\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\remio\OneDrive\Desktop\TaskManagementInterface2\Pages\Records.razor"
      

    public class Machines
    {
        public int uid { get; set; }
        public string machineName { get; set; }
    }

    public class MachineReporting2
    {
        public float hoursSpend { get; set; }
        public string applicationName { get; set; }
    }

    public List<Machines> machines = new List<Machines>();
    public List<MachineReporting2> machreps = new List<MachineReporting2>();

    string selectedMachine;



    protected override async Task OnInitializedAsync()
    {
        machines = await http.GetJsonAsync<List<Machines>>("http://192.168.1.109/api/Machines/GetAll_Machines");
    }

    private async Task MachineReporting()
    {
        string machid = selectedMachine;
        string s = "http://192.168.1.109/api/MachinesReporting/GetAll_MachineRecordingByUID?uid=" + machid + "&dateBegin=" + StartValue?.ToString("MM-dd-yyyy") + "&dateEnd=" + EndValue?.ToString("MM-dd-yyyy");
        machreps = await http.GetJsonAsync<List<MachineReporting2>>(s);
    }

    void EntitieClicked(Microsoft.AspNetCore.Components.ChangeEventArgs e)
    {
        string value = e.Value.ToString();
        selectedMachine = value;
        StateHasChanged();

    }

    public DateTime? StartValue { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 01, 01, 01);
    public DateTime? EndValue { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
