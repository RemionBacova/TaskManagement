#pragma checksum "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89c1e19059994d918467c8bbb8b5c551f8b33ad4"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskManagementInterface.Shared.Type
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
#line 3 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
using TaskManagementInterface.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
using TaskManagementInterface.Services.Types;

#line default
#line hidden
#nullable disable
    public partial class AddOrEditType : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal-body");
            __builder.AddAttribute(2, "style", "width:650px");
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n\r\n\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-inline");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group col-md-12");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddMarkupContent(10, "<label class=\"col-md-5 \" style=\"justify-content: left\">Parent Name:</label>\r\n                ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "form-control col-md-6");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 17 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                                                                        ParentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "form-control col-md-1");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                                                                ButtonParent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n        <br>\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-inline");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group col-md-12");
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.AddMarkupContent(29, "<label class=\"col-md-5 \" style=\"justify-content: left\">Nomination:</label>\r\n                ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "class", "form-control  col-md-6");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                              TypeModel.nomination

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeModel.nomination = __value, TypeModel.nomination));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n        <br>\r\n        <br>\r\n\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-inline");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group col-md-12");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<label class=\"col-md-5\" style=\"justify-content: left\">Code:</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "class", "form-control col-md-6");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                              TypeModel.code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeModel.code = __value, TypeModel.code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n\r\n        <br>\r\n        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-inline");
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group col-md-12");
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.AddMarkupContent(59, "<label class=\"col-md-5 \" style=\"justify-content: left\">Code actual:</label>\r\n                ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "class", "form-control  col-md-6");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                              TypeModel.codeactual

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeModel.codeactual = __value, TypeModel.codeactual));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-inline");
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group col-md-12");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.AddMarkupContent(74, "<label class=\"col-md-5 \" style=\"justify-content: left\">codebegin:</label>\r\n                ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "class", "form-control  col-md-6");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                              TypeModel.codebegin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeModel.codebegin = __value, TypeModel.codebegin));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-inline");
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group col-md-12");
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.AddMarkupContent(89, "<label class=\"col-md-5 \" style=\"justify-content: left\">Code end:</label>\r\n                ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "class", "form-control  col-md-6");
            __builder.AddAttribute(92, "type", "text");
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                              TypeModel.codeend

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeModel.codeend = __value, TypeModel.codeend));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n        <br>\r\n        ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "form-inline");
            __builder.AddMarkupContent(100, "\r\n            ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "form-group col-md-12");
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.AddMarkupContent(104, "<label class=\"col-md-5 \" style=\"justify-content:left\">Description:</label>\r\n                ");
            __builder.OpenElement(105, "input");
            __builder.AddAttribute(106, "class", "form-control  col-md-6");
            __builder.AddAttribute(107, "type", "text");
            __builder.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                              TypeModel.description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeModel.description = __value, TypeModel.description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\r\n        <br>\r\n\r\n        ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "form-inline");
            __builder.AddMarkupContent(115, "\r\n            ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "form-group col-md-12");
            __builder.AddMarkupContent(118, "\r\n                ");
            __builder.AddMarkupContent(119, "<label class=\"col-md-5 \" style=\"justify-content: left\">Contains Elements:</label>\r\n                ");
            __builder.OpenElement(120, "input");
            __builder.AddAttribute(121, "style", "justify-content: left");
            __builder.AddAttribute(122, "type", "checkbox");
            __builder.AddAttribute(123, "class", "col-md-6");
            __builder.AddAttribute(124, "placeholder", "Elcat");
            __builder.AddAttribute(125, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                              TypeModel.elcat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(126, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeModel.elcat = __value, TypeModel.elcat));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n\r\n        <br>\r\n\r\n\r\n\r\n\r\n\r\n\r\n        ");
            __builder.OpenElement(130, "button");
            __builder.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                          SubmitForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "class", "btn btn-primary");
            __builder.AddContent(133, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.OpenElement(135, "button");
            __builder.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                          Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "class", "btn btn-secondary");
            __builder.AddContent(138, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\Administration\Documents\GitHub\TaskManagement\TaskManagementInterface2\Shared\Type\AddOrEditType.razor"
                   
                [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

                private tbl_TABLE_TYPE TypeModel = new tbl_TABLE_TYPE();
                TypeServices typeServices = new TypeServices();
                [Parameter] public bool addOrEdit { get; set; }
                [Parameter] public string tableName { get; set; }
                [Parameter] public int uid { get; set; }
                [Parameter] public string uid_sup { get; set; }
                [Parameter] public string CategoryUID { get; set; }

                private string returnValue = "";
                public string ParentName = "";
                public string ParentID = "";

                protected async void OnLoad()
                {


                    if (!addOrEdit)
                    {

                        TypeModel = await typeServices.SelectRecById(tableName, uid.ToString());

                        if (TypeModel.uid_sup != null)
                        {
                            ParentID = TypeModel.uid_sup.ToString();
                            ParentName = (await typeServices.SelectRecById(tableName, TypeModel.uid_sup.ToString())).nomination;

                        }
                        else
                        {
                            ParentID = "";
                            ParentName = "";
                        }


                    }
                    StateHasChanged();
                }

                protected override void OnInitialized() => OnLoad();

                void SubmitForm() => Save();
                void Cancel() => BlazoredModal.Cancel();

                protected async Task Save()
                {

                    TaskManagementInterface.Data.Error errorModel = new TaskManagementInterface.Data.Error();
                    string parameters;
                    if (ParentID == "")
                    {

                        parameters = "?description=" + TypeModel.description + "&codeend=" + TypeModel.codeend+ "&codebegin=" + TypeModel.codebegin+ "&codeend=" + TypeModel.codeend;
                    }
                    else
                    {
                        parameters = "?uid_sup=" + ParentID + "&description=" + TypeModel.description + "&codeend="+TypeModel.codeend+ "&codebegin=" + TypeModel.codebegin + "&codeactual" + TypeModel.codeactual;
                    }

                    if (!addOrEdit)
                    {

                        errorModel =  await typeServices.Update(TypeModel, tableName, parameters);
                        var parametersError = new ModalParameters();

                        parametersError.Add(nameof(ErrorDatabaseMessage.ErrorName), errorModel.ERRORNAME);
                        parametersError.Add(nameof(ErrorDatabaseMessage.Id), errorModel.UID);
                        var messageForm = Modal.Show<ErrorDatabaseMessage>("Message", parametersError);

                    }
                    else
                    {
                        errorModel=  await typeServices.Add(TypeModel, tableName,CategoryUID, parameters);
                        var parametersError = new ModalParameters();
                        parametersError.Add(nameof(ErrorDatabaseMessage.ErrorName), errorModel.ERRORNAME);
                        parametersError.Add(nameof(ErrorDatabaseMessage.Id), errorModel.UID);
                        var messageForm = Modal.Show<ErrorDatabaseMessage>("Message", parametersError);



                        var result = await messageForm.Result;


                    }
                    StateHasChanged();
                    BlazoredModal.Close(ModalResult.Ok(returnValue));
                }

                async Task ButtonParent()
                {
                    var parameters2 = new ModalParameters();

                    parameters2.Add(nameof(ParentTypeModal.tableName), tableName);
                    parameters2.Add(nameof(ParentTypeModal.uid), uid);
                    var messageForm = Modal.Show<ParentTypeModal>("Select Parent", parameters2);



                    var result = await messageForm.Result;
                    /// do mar result dhe do e vej tek text box

                    if (result.Data is null)
                    {
                        ParentID = "";
                    }
                    else
                    {
                        ParentID = result.Data.ToString();
                    }


                    if (ParentID != "")
                    {

                        ParentName = (await typeServices.SelectRecById(tableName,ParentID)).nomination;

                    }
                    else
                    {
                        ParentName = "";
                    }

                }


                

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
