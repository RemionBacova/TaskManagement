#pragma checksum "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7257da7e318fb463df34ed12d93aad86cee4213"
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
#line 3 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Login.razor"
using TaskManagementInterface.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-6 card");
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Login.razor"
                          user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Login.razor"
                                                ValidateUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<div>\r\n                <br><br><br><br><br>\r\n            </div>\r\n            ");
                __builder2.AddMarkupContent(11, "<div class=\"text-center\">\r\n                <h5 style=\"font-weight:bold; color:black;\">TASK MANAGEMENT</h5>\r\n            </div>\r\n            ");
                __builder2.AddMarkupContent(12, "<div>\r\n                <br>\r\n            </div>\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-6 row");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "class", "form-control col-12");
                __builder2.AddAttribute(18, "placeholder", "USERNAME");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Login.razor"
                                                          user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Username = __value, user.Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            <br>\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-6 row text-center");
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "password");
                __builder2.AddAttribute(28, "class", "form-control col-12");
                __builder2.AddAttribute(29, "placeholder", "PASSWORD");
                __builder2.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Login.razor"
                                                                          user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            <br>\r\n            ");
                __builder2.AddMarkupContent(34, "<div class=\"col-6 row\">\r\n                <input type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Login\">\r\n                \r\n            </div>\r\n            <br>\r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-6 row");
                __builder2.AddAttribute(37, "style", "text-align:left; font-weight:bold");
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "span");
                __builder2.AddAttribute(40, "class", "col-12");
                __builder2.AddContent(41, 
#nullable restore
#line 41 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Login.razor"
                                          LoginMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Admin\Desktop\Sitel\TaskManagement\TaskManagementInterface2\Pages\Login.razor"
       

    private Users_Model user;
    public string LoginMessage { get; set; }


    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override Task OnInitializedAsync()
    {
        user = new Users_Model();

        return base.OnInitializedAsync();

    }

    private async Task ValidateUser()
    {
        try
        {
            await userService.LoginAsync(user);
            ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsAuthenticated(user.Username);
            NavigationMang.NavigateTo("Index");
            await sessionStorage.SetItemAsync("description", user.Username);
            StateHasChanged();
        }
        catch (Exception e)
        {
            LoginMessage = e.Message;

        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationMang { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
