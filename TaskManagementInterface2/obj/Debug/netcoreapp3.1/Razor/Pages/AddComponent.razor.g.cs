#pragma checksum "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2becb32df0a6c457254d493abf9bf5e7dd773806"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskManagementInterface.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcomponent/{kategoriModel}")]
    public partial class AddComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddComponent</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                  kategoriModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                                Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    \r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "modal");
                __builder2.AddAttribute(8, "tabindex", "-1");
                __builder2.AddAttribute(9, "style", "display:block");
                __builder2.AddAttribute(10, "role", "dialog");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "modal-dialog");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "modal-content");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "modal-header");
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.AddMarkupContent(21, "<h3 class=\"modal-title\"> Category </h3>\r\n                    \r\n                    ");
                __builder2.OpenElement(22, "button");
                __builder2.AddAttribute(23, "type", "button");
                __builder2.AddAttribute(24, "class", "close");
                __builder2.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                                                  Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.AddMarkupContent(27, "<span aria-hidden=\"true\">X</span>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                \r\n                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "modal-body");
                __builder2.AddMarkupContent(32, "\r\n\r\n                    ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "hidden", "hidden");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "type", "text");
                __builder2.AddAttribute(37, "placeholder", "Element Id ");
                __builder2.AddAttribute(38, "readonly", "readonly");
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                  kategoriModel.uid

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => kategoriModel.uid = __value, kategoriModel.uid));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, " <br>\r\n                    ");
                __builder2.AddMarkupContent(42, "<label class=\"text-black-50\">Nomination:</label>\r\n\r\n                    ");
                __builder2.OpenElement(43, "input");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "type", "text");
                __builder2.AddAttribute(46, "placeholder", "Nomination");
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                  kategoriModel.nomination

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => kategoriModel.nomination = __value, kategoriModel.nomination));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "<br>\r\n                    ");
                __builder2.AddMarkupContent(50, "<label class=\"text-black-50\">Parent:</label>\r\n");
#nullable restore
#line 32 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                     if (TreeData.Count() != 0)
                    {


#line default
#line hidden
#nullable disable
                __builder2.AddContent(51, "                        ");
                __builder2.OpenElement(52, "select");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "style", "border-radius:7px");
                __builder2.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                                                                      kategoriModel.uid_sup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => kategoriModel.uid_sup = __value, kategoriModel.uid_sup));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(57, "\r\n                            ");
                __builder2.OpenElement(58, "option");
                __builder2.AddAttribute(59, "value", "0");
                __builder2.AddContent(60, "-- Parent --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n");
#nullable restore
#line 37 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                             if (TreeData != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                 foreach (var cnt in TreeData)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(62, "                                    ");
                __builder2.OpenElement(63, "option");
                __builder2.AddAttribute(64, "value", 
#nullable restore
#line 41 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                                    cnt.uid

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(65, 
#nullable restore
#line 41 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                                              cnt.nomination

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n");
#nullable restore
#line 42 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(67, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, " <br>\r\n");
#nullable restore
#line 45 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(69, "                    ");
                __builder2.AddMarkupContent(70, "<label class=\"text-black-50\">Description:</label>\r\n                    ");
                __builder2.OpenElement(71, "input");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "type", "text");
                __builder2.AddAttribute(74, "placeholder", "Description");
                __builder2.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                  kategoriModel.description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => kategoriModel.description = __value, kategoriModel.description));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, " <br>\r\n                    ");
                __builder2.AddMarkupContent(78, "<label class=\"text-black-50\">Code:</label>\r\n                    ");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "type", "text");
                __builder2.AddAttribute(82, "placeholder", "Code");
                __builder2.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                  kategoriModel.code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => kategoriModel.code = __value, kategoriModel.code));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "<br>\r\n                    ");
                __builder2.AddMarkupContent(86, "<label class=\"ftext-black-50\">Elcat:</label>\r\n                    ");
                __builder2.OpenElement(87, "input");
                __builder2.AddAttribute(88, "class", "text-black-50");
                __builder2.AddAttribute(89, "type", "checkbox");
                __builder2.AddAttribute(90, "placeholder", "Code");
                __builder2.AddAttribute(91, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
                                  kategoriModel.elcat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => kategoriModel.elcat = __value, kategoriModel.elcat));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "<br>\r\n\r\n                    <br>\r\n                    \r\n                    ");
                __builder2.AddMarkupContent(94, "<button class=\"btn btn-primary\" type=\"submit\">\r\n                        Save\r\n                    </button>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\remio\source\repos\TaskManagement\TaskManagementInterface2\Pages\AddComponent.razor"
       

    [Parameter]
    public TaskManagementInterface.Data.Kategorite kategoriModel { get; set; }
    public List<TaskManagementInterface.Data.Kategorite> TreeData = new List<Data.Kategorite>();

    private void Save()
    {

    }
    private void Cancel()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
