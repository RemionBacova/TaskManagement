#pragma checksum "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Administration\CategoryAdministration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7112c65b1544b300f0d37458d1ee383768cffeb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TaskManagementInterface.Pages.Administration
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Administration\CategoryAdministration.razor"
using Syncfusion.Blazor.TreeGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Administration\CategoryAdministration.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Administration\CategoryAdministration.razor"
using TaskManagementInterface.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Administration\CategoryAdministration.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Administration\CategoryAdministration.razor"
using TaskManagementInterface.Shared.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Administration\CategoryAdministration.razor"
using TaskManagementInterface.Services.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Administration\CategoryAdministration.razor"
using TaskManagementInterface.Services.Entitet;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CategoryAdministration")]
    public partial class CategoryAdministration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Administration\CategoryAdministration.razor"
      


    public List<TaskManagementInterface.Data.tbl_TABLE_CATEGORY> TreeData = new List<tbl_TABLE_CATEGORY>();
    private List<TaskManagementInterface.Data.tbl_TABLE_Model> Entities = new List<Data.tbl_TABLE_Model>();

    private string SelectedTable;
    bool deleteConfirmation = false;
    bool _addOrEdit = false;
    string _tablename = "";
    CategoryServices categoryServices = new CategoryServices();
    EntitetService entitetService = new EntitetService();

    string _returnMessage = "";


    protected override async Task OnInitializedAsync()
    {
        Entities = await entitetService.SelectEntities();
    }
    private async Task EntitieClicked(Microsoft.AspNetCore.Components.ChangeEventArgs e)
    {
        string value = e.Value.ToString();
        _tablename = "tbl_" + value + "_Category";
        if (value != "-1")
        {
            await FillDataIntoTable();
        }

    }
    private async Task FillDataIntoTable()
    {
        TreeData =await  categoryServices.SelectAllActiveRec(_tablename);
        StateHasChanged();

    }

    async Task ShowModalAdd()
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(AddOrEdit.addOrEdit), true);
        parameters.Add(nameof(AddOrEdit.tableName), _tablename);
        parameters.Add(nameof(AddOrEdit.uid), 0);
        var messageForm = Modal.Show<AddOrEdit>("Add Category", parameters);// tittle parameters
        var result = await messageForm.Result;
        if (!result.Cancelled)
            _returnMessage = result.Data?.ToString() ?? string.Empty;

        await FillDataIntoTable();
    }


    async Task ShowModalEdit(tbl_TABLE_CATEGORY parameter)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(AddOrEdit.addOrEdit), false);
        parameters.Add(nameof(AddOrEdit.tableName), _tablename);
        parameters.Add(nameof(AddOrEdit.uid), parameter.uid);
        var messageForm = Modal.Show<AddOrEdit>("Edit Category", parameters);// tittle parameters
        var result = await messageForm.Result;
        if (!result.Cancelled)
            _returnMessage = result.Data?.ToString() ?? string.Empty;

        await FillDataIntoTable();
    }


    async Task ShowModalDelete(tbl_TABLE_CATEGORY parameter)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(Delete.tableName), _tablename);
        parameters.Add(nameof(Delete.uid), parameter.uid);
        var messageForm = Modal.Show<Delete>("Delete Category", parameters);// tittle parameters
        var result = await messageForm.Result;
        if (!result.Cancelled)
            _returnMessage = result.Data?.ToString() ?? string.Empty;


        await FillDataIntoTable();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
