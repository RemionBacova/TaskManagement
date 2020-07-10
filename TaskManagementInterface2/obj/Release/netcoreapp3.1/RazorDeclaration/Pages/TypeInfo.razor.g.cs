#pragma checksum "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\TypeInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "092443f4371517fbbd0f24ccf78da556bf573e94"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TaskManagementInterface.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using TaskManagementInterface.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\TypeInfo.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\TypeInfo.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\TypeInfo.razor"
using Syncfusion.Blazor.TreeGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\TypeInfo.razor"
using TaskManagementInterface.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/typeinfo")]
    public partial class TypeInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 226 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\TypeInfo.razor"
      

    private List<Kategorite> kategori = new List<Kategorite>();
    private List<MailItem> MyElement = new List<MailItem>();
    private List<MailItem> MyTipElement = new List<MailItem>();
    private List<MailItem> MyTypeInfoElement = new List<MailItem>();
    private List<Tipe> tipet = new List<Tipe>();
    private List<TestBlazor.Data.TypeInfo> typeInfos = new List<TestBlazor.Data.TypeInfo>();
    private Tipe tipi = new Tipe();
    private TestBlazor.Data.TypeInfo typeInf = new TestBlazor.Data.TypeInfo();
    private TestBlazor.Data.TypeInfo newTypeInfo = new TestBlazor.Data.TypeInfo();
    SfTreeView<MailItem> tree;
    SfContextMenu menu;
    private bool CreateTypeInfo = false;
    private bool ShfaqButon = false;
    private bool Message = false;
    private string selectedKategoriId;
    private string selectedTypeId;
    private string selectedTypeInfoId;
    private string selectedtable;
    private  List<tbl_TABLE_Model> Entities = new List<tbl_TABLE_Model>();


    //Mbushja e dropdownlistes me element
    protected override async Task OnInitializedAsync()
    {
        Entities = await http.GetJsonAsync<List<tbl_TABLE_Model>>("http://192.168.1.118/GetAll_Entities");
    }

    //Zgjedhja e nje entiteti
    private void EntitieClicked(Microsoft.AspNetCore.Components.ChangeEventArgs e)
    {
        string value = e.Value.ToString();
        selectedtable = value;
        this.GetCategory(value);
        MyElement.Clear();
        MyTipElement.Clear();
        MyTypeInfoElement.Clear();
        CreateTypeInfo = false;
        ShfaqButon = false;
        Message = false;
        tipi.uid = 0;
        typeInf.uid = 0;
        StateHasChanged();

    }

    //Mbushja e treeView kategori me te dhena
    private async Task GetCategory(string entitetiZgjedhur)
    {
        kategori = null;

        string url = "http://192.168.1.118/api/tbl_" + entitetiZgjedhur + "_CATEGORY";
        kategori = await http.GetJsonAsync<List<Kategorite>>(url);
        foreach (var element in kategori)
        {
            MailItem item = new MailItem();
            if (element.uid_sup > 0)
            {
                item.ParentId = element.uid_sup.ToString();
            }
            foreach (var child in kategori)
            {
                if (child.uid_sup == element.uid)
                {
                    item.HasSubFolders = true;
                }
            }

            item.Id = element.uid.ToString();
            item.ElementName = element.nomination;

            MyElement.Add(item);


        }
        StateHasChanged();

    }

    //Klikimi i nje elementi ne peme per kategorite
    private  async void nodeClicked(NodeClickEventArgs args)
    {
        string eventString = JsonConvert.SerializeObject(args.Event);
        Dictionary<string, dynamic> eventParameters = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(eventString);
        if ((eventParameters["which"]).ToString() == "3")
        {
            this.selectedKategoriId = (await args.Node.GetAttribute("data-uid")).ToString();
            StateHasChanged();
        }
    }

    private  List<MenuItem> MenuItems = new List<MenuItem>{
        new MenuItem { Text = "View Types" },
    };

    //Menuja ne klikim te kategorise
    private  void MenuSelect(MenuEventArgs args)
    {
        string selectedText;
        selectedText = args.Item.Text;

        if (selectedText == "View Types")
        {
            ShfaqButon = false;
            Message = false;
            this.FillDataToTipe();
        }

    }

    //Mbushja e tipeve me te dhena
    private async Task FillDataToTipe()
    {
        MyTipElement.Clear();
        CreateTypeInfo = false;
        tipi.uid = 0;
        string url = "http://192.168.1.118/api/tbl_" + selectedtable + "/GetTyperByCategory?category_uid=" + selectedKategoriId;
        tipet = await http.GetJsonAsync<List<Tipe>>(url);
        foreach (var element in tipet)
        {
            MailItem item = new MailItem();
            if (element.uid_sup > 0)
            {
                item.ParentId = element.uid_sup.ToString();
            }
            foreach (var child in tipet)
            {
                if (child.uid_sup == element.uid)
                {
                    item.HasSubFolders = true;
                }
            }

            item.Id = element.uid.ToString();
            item.ElementName = element.nomination;

            MyTipElement.Add(item);


        }
        StateHasChanged();

    }

    //Klikimi i nje elementi te pemes Per tipet
    private async void nodeTipClicked(NodeClickEventArgs args)
    {
        string eventString = JsonConvert.SerializeObject(args.Event);
        Dictionary<string, dynamic> eventParameters = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(eventString);
        if ((eventParameters["which"]).ToString() == "3")
        {
            this.selectedTypeId = (await args.Node.GetAttribute("data-uid")).ToString();
            StateHasChanged();
        }
    }

    //Menuja qe shfaqet ne klikim te nje tipi
    private  void MenuSelectForTipe(MenuEventArgs args)
    {
        string selectedText;
        selectedText = args.Item.Text;

        if (selectedText == "View Types Info")
        {
            ShfaqButon = true;
            Message = false;
            this.FillDataToTypeInfo();
        }

    }

    //Menuja qe shfaqet ne klikim te nje tipi info
    private void MenuSelectForTypeInfo(MenuEventArgs args)
    {
        string selectedText;
        selectedText = args.Item.Text;
        if (selectedText == "Edit")
        {
            this.EditTypeInfo();
            Message = false;

        }
        else if (selectedText == "Delete")
        {
            this.DeleteTypeInfo();
            Message = false;

        }
        else if (selectedText == "Add")
        {

            this.AddTypeInfo();
            Message = false;

        }
    }

    private void NewTypeInfo()
    {
        newTypeInfo.uid_sup = -1;

        this.AddTypeInfo();

    }
    //Shtimi i nje rekordi te ri type info
    private async Task AddTypeInfo()
    {
        newTypeInfo.uid_sup = Convert.ToInt32(selectedTypeInfoId);
        CreateTypeInfo = true;
        typeInf.uid = 0;
    }

    //per tu permirsuar selecti i id
    private async Task SaveNewTypeInfo(EditContext context)
    {
        TestBlazor.Data.TypeInfo model = (TestBlazor.Data.TypeInfo)context.Model;

        string parameters = "?type_uid=" + selectedTypeId + "&description=" + model.description + "&description1=" + model.description1 + "&description2=" + model.description2
            + "&mandatory=" + model.mandatory;

        string urltosend = " http://192.168.1.118/api/tbl_" + selectedtable + "_TYPE_INFO/" + model.uid_sup + "/" + model.nomination + "/" + model.property + parameters;

        await http.PostJsonAsync(urltosend, "");

        newTypeInfo.uid_sup = -1;
        Message = true;
        CreateTypeInfo = false;
        MyTypeInfoElement.Clear();
        StateHasChanged();
        await this.FillDataToTypeInfo();

    }

    //Editimi i nje rekordi
    private async Task EditTypeInfo()
    {

        CreateTypeInfo = false;
        string url = "http://192.168.1.118/api/tbl_" + selectedtable + "_TYPE_INFO/" + selectedTypeInfoId;
        List<TestBlazor.Data.TypeInfo> permanent = await http.GetJsonAsync<List<TestBlazor.Data.TypeInfo>>(url);
        typeInf = permanent.FirstOrDefault();
        StateHasChanged();
    }

    //editimi 
    private async Task SaveEditedTypeInfo(EditContext context)
    {
        TestBlazor.Data.TypeInfo model = (TestBlazor.Data.TypeInfo)context.Model;

        string parameters = "?description=" + model.description + "&description1=" + model.description1 + "&description2=" + model.description2 + "&mandatory=" + model.mandatory + "&queue=" + model.queue + "&file=" + model.file + "&user_uid=1";





        string url = " http://192.168.1.118/api/tbl_" + selectedtable + "_TYPE_INFO/" + model.uid +"/" + model.uid_sup + "/" + selectedTypeId + "/" + model.nomination+ "/"+ model.property  + parameters;

        await http.PutJsonAsync(url, "");

        Message = true;

        typeInf.uid =0;

        MyTypeInfoElement.Clear();

        newTypeInfo.uid_sup = -1;

        StateHasChanged();

        await this.FillDataToTypeInfo();

    }

    //Fshirja e nje tipi info
    private  async Task DeleteTypeInfo()
    {

        string url = "http://192.168.1.118/api/tbl_" + selectedtable + "_TYPE_INFO/" + selectedTypeInfoId;
        await http.DeleteAsync(url);
        Message = true;
        MyTypeInfoElement.Clear();
        StateHasChanged();
        await this.FillDataToTypeInfo();

    }


    private async Task FillDataToTypeInfo()
    {

        MyTypeInfoElement.Clear();
        CreateTypeInfo = false;
        typeInf.uid = 0;

        string url = "http://192.168.1.118/api/tbl_" + selectedtable + "_TYPE_INFO/GetByType?TYPE_UID=" + selectedTypeId;
        typeInfos = await http.GetJsonAsync<List<TestBlazor.Data.TypeInfo>>(url);
        foreach (var element in typeInfos)
        {
            MailItem item = new MailItem();
            if (element.uid_sup > 0)
            {
                item.ParentId = element.uid_sup.ToString();
            }
            foreach (var child in typeInfos)
            {
                if (child.uid_sup == element.uid)
                {
                    item.HasSubFolders = true;
                }
            }

            item.Id = element.uid.ToString();
            item.ElementName = element.nomination;

            MyTypeInfoElement.Add(item);


        }
        StateHasChanged();

    }


    //Klikimi i nje elementi te pemes Per tipet info
    private async void nodeTypeInfoClicked(NodeClickEventArgs args)
    {
        string eventString = JsonConvert.SerializeObject(args.Event);
        Dictionary<string, dynamic> eventParameters = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(eventString);
        if ((eventParameters["which"]).ToString() == "3")
        {
            this.selectedTypeInfoId = (await args.Node.GetAttribute("data-uid")).ToString();
            StateHasChanged();
        }
    }

    // Menuja Listat
    private List<MenuItem> MenuItemsForType = new List<MenuItem>{
        new MenuItem { Text = "View Types Info" }
    };

    // Menuja Listat per type info
    private List<MenuItem> MenuItemsForTypeInfo = new List<MenuItem>{
        new MenuItem { Text="Add" },
        new MenuItem { Text = "Edit" },
        new MenuItem { Text="Delete" }
    };

   



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
