#pragma checksum "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Shared\Type\ParentTypeModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3274867a573fdf1ae1a1ee52fd4e63f7b72f6e7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TaskManagementInterface.Shared.Type
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Shared\Type\ParentTypeModal.razor"
using Syncfusion.Blazor.TreeGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Shared\Type\ParentTypeModal.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Shared\Type\ParentTypeModal.razor"
using TaskManagementInterface.Data;

#line default
#line hidden
#nullable disable
    public partial class ParentTypeModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Shared\Type\ParentTypeModal.razor"
        

    [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }



    [Parameter] public string tableName { get; set; }
    [Parameter] public int uid { get; set; }
    TaskManagementInterface.Services.Types.TypeServices TypeService = new TaskManagementInterface.Services.Types.TypeServices();
    public List<TaskManagementInterface.Data.Models.tbl_TABLE_TYPE> TreeData = new List<TaskManagementInterface.Data.Models.tbl_TABLE_TYPE>();





    protected override async Task OnInitializedAsync()
    {
        TreeData = await TypeService.GetPossibleParents(tableName, uid.ToString());
        StateHasChanged();
    }


    private void SelectParent(TaskManagementInterface.Data.Models.tbl_TABLE_TYPE e)
    {

        string value = e.uid.ToString();
        BlazoredModal.Close(ModalResult.Ok(value));

    }
 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService ModalService { get; set; }
    }
}
#pragma warning restore 1591
