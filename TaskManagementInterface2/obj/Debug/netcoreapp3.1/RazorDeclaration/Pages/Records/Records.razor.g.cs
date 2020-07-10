#pragma checksum "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a643fbad4ef6f2f0ed0b87571c52ceb3a94a9b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TaskManagementInterface.Pages.Records
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
using Syncfusion.Blazor.TreeGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
using TaskManagementInterface.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Records\Records.razor"
      

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
