#pragma checksum "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\TypeInfo\ChooseCategoryModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e20562377e23976b297f009751747505355cba"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TaskManagementInterface.Shared.TypeInfo
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\TypeInfo\ChooseCategoryModal.razor"
using Syncfusion.Blazor.TreeGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\TypeInfo\ChooseCategoryModal.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\TypeInfo\ChooseCategoryModal.razor"
using TaskManagementInterface.Data;

#line default
#line hidden
#nullable disable
    public partial class ChooseCategoryModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\TypeInfo\ChooseCategoryModal.razor"
        

    [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }



    [Parameter] public string tableName { get; set; }
    TaskManagementInterface.Services.Types.TypeServices typeService = new Services.Types.TypeServices();
    public List<tbl_TABLE_CATEGORY> TreeData = new List<tbl_TABLE_CATEGORY>();





    protected override async Task OnInitializedAsync()
    {
        TreeData = await typeService.SelectAllActiveRec(tableName);
        StateHasChanged();
    }


    private void SelectParent(tbl_TABLE_CATEGORY e)
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
