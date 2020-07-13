#pragma checksum "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Category\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5774d30f095b0d15b7a7db99b73d7cbe75221a53"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskManagementInterface.Shared.Category
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
#line 2 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Category\Delete.razor"
using TaskManagementInterface.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Category\Delete.razor"
using TaskManagementInterface.Services.Categories;

#line default
#line hidden
#nullable disable
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n\r\n    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Category\Delete.razor"
                      SubmitForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddContent(5, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Category\Delete.razor"
                      Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "btn btn-secondary");
            __builder.AddContent(10, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Category\Delete.razor"
        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }
    CategoryServices CategoryServices = new CategoryServices();
    private tbl_TABLE_CATEGORY kategoriModel = new tbl_TABLE_CATEGORY();

    [Parameter] public string tableName { get; set; }
    [Parameter] public int uid { get; set; }
    private string returnValue = "";



    void SubmitForm() => DeleteCategory();
    void Cancel() => BlazoredModal.Cancel();
    private async Task DeleteCategory()
    {
        Error errorModel = new Error();

        errorModel = await CategoryServices.DeleteCategory(uid.ToString(), tableName);
        var parametersError = new ModalParameters();

        parametersError.Add(nameof(ErrorDatabaseMessage.ErrorName), errorModel.ERRORNAME);
        parametersError.Add(nameof(ErrorDatabaseMessage.Id), errorModel.UID);
        var messageForm = Modal.Show<ErrorDatabaseMessage>("Message", parametersError);


        BlazoredModal.Close(ModalResult.Ok(returnValue));
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
