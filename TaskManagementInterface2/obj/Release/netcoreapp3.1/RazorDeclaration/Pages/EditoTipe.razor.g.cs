#pragma checksum "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\EditoTipe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81ee0738e5e8c1d53b89cb6aeceff43606393ecf"
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
#line 3 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\EditoTipe.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\EditoTipe.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\EditoTipe.razor"
using TaskManagementInterface.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editotipe")]
    public partial class EditoTipe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 212 "C:\Users\User\source\repos\TaskManagement\TaskManagementInterface2\Pages\EditoTipe.razor"
          

        private List<Kategorite> kategori = new List<Kategorite>();
        private List<MailItem> MyElement = new List<MailItem>();
        private List<MailItem> MyTipElement = new List<MailItem>();
        private List<Tipe> tipet = new List<Tipe>();
        private Tipe tipi = new Tipe();
        private Tipe tipiIRI = new Tipe();
        SfTreeView<MailItem> tree;
        SfContextMenu menu;
        private bool KrijoTip = false;
        private bool ShfaqButon = false;
        private bool Message = false;
        private string selectedKategoriId;
        private string selectedTipId;
        private string selectedtable;
        private string SelectedParent;
        private  List<tbl_TABLE_Model> Entities = new List<tbl_TABLE_Model>();
        private List<Tipe> Zgjidhprindin = new List<Tipe>();


        private async Task CheckboxClicked(object checkedValue)
        {
            if ((bool)checkedValue)
            {
                Zgjidhprindin = await http.GetJsonAsync<List<Tipe>>("http://192.168.1.118/api/tbl_" + selectedtable + "/GetTyperByCategory?category_uid=" + selectedKategoriId);
            }
            else
            {
                Zgjidhprindin.Clear();
            }
            StateHasChanged();
        }

        private void PrindiChanged(Microsoft.AspNetCore.Components.ChangeEventArgs e)
        {
            tipi.uid_sup = Convert.ToInt32(e.Value.ToString());
        }
        //Mbushja e dropdownlistes me element
        protected override async Task OnInitializedAsync()
        {
            Entities = await http.GetJsonAsync<List<tbl_TABLE_Model>>("http://192.168.1.118/GetAll_Entities");
        }

        //Zgjedhja e nje entiteti
        void EntitieClicked(Microsoft.AspNetCore.Components.ChangeEventArgs e)
        {
            string value = e.Value.ToString();
            selectedtable = value;
            this.GetCategory(value);
            MyElement.Clear();
            MyTipElement.Clear();
            KrijoTip = false;
            ShfaqButon = false;
            Message = false;
            tipi.uid = 0;
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
        private async void nodeClicked(NodeClickEventArgs args)
        {
            string eventString = JsonConvert.SerializeObject(args.Event);
            Dictionary<string, dynamic> eventParameters = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(eventString);
            if ((eventParameters["which"]).ToString() == "3")
            {
                this.selectedKategoriId = (await args.Node.GetAttribute("data-uid")).ToString();
                StateHasChanged();
            }
        }

        private List<MenuItem> MenuItems = new List<MenuItem>{
        new MenuItem { Text = "Edito Tipet" },

    };

        //Menuja ne klikim te kategorise
        private void MenuSelect(MenuEventArgs args)
        {
            string selectedText;
            selectedText = args.Item.Text;

            if (selectedText == "Edito Tipet")
            {
                ShfaqButon = true;
                Message = false;
                this.FillDataToTipe();
            }

        }

        //Mbushja e tipeve me te dhena
        private async Task FillDataToTipe()
        {
            MyTipElement.Clear();
            Zgjidhprindin.Clear();
            KrijoTip = false;
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
                this.selectedTipId = (await args.Node.GetAttribute("data-uid")).ToString();
                StateHasChanged();
            }
        }

        //Menuja qe shfaqet ne klikim te nje tipi
        private void MenuSelectForTipe(MenuEventArgs args)
        {
            string selectedText;
            selectedText = args.Item.Text;
            if (selectedText == "Edit")
            {
                this.EditType();
                Message = false;

            }
            else if (selectedText == "Remove")
            {
                this.DeleteType();
                Message = false;

            }
            else if (selectedText == "Add")
            {
                tipiIRI.uid_sup = Convert.ToInt32(selectedTipId);
                this.AddType();
                Message = false;

            }
        }


        private void NewType()
        {
            tipiIRI.uid_sup = -1;
            this.AddType();

        }

        //Shtimi i nje rekordi te ri
        private async Task AddType()
        {
            List<Tipe> list = new List<Tipe>();

            KrijoTip = true;
            if (tipiIRI.uid_sup != -1)
            {
                list = await http.GetJsonAsync<List<Tipe>>("http://192.168.1.118/api/tbl_CLIENTS_TYPE/"+selectedTipId);
                SelectedParent = list.FirstOrDefault().nomination;
            }
            else
            {
                SelectedParent = "No Parent";
            }
            tipi.uid = 0;
            StateHasChanged();
        }

        //per tu permirsuar selecti i id
        private async Task SaveNewType(EditContext context)
        {
            Tipe model = (Tipe)context.Model;
            string parameters = "?codeend=" + model.codeend + "&description=" + model.description;

            string urltosend = "http://192.168.1.118/api/tbl_" + selectedtable + "_TYPE/" + model.uid_sup + "/" + model.elcat + "/" + model.code + "/" + model.nomination + parameters;
            await http.PostJsonAsync(urltosend, "");
            List<LastUid> lst = await http.GetJsonAsync<List<LastUid>>("http://192.168.1.118/api/tbl_INTER_TABLE_TABLE/SelectLastUid?tableName=" + selectedtable + "_TYPE");
            LastUid uidTip = lst.FirstOrDefault();
            string urltypkategori = "http://192.168.1.118/api/tbl_INTER_TABLE_TABLE/SPI_INTER_TABLE_TYPE_CATEGORY?tablename=" + selectedtable + "&tabletype_uid=" + uidTip.uid + "&tabletype_cat_uid=" + selectedKategoriId + "&user_uid=1";

            await http.PostJsonAsync(urltypkategori, "");
            tipiIRI.uid_sup = -1;
            Message = true;
            KrijoTip = false;
            MyTipElement.Clear();
            StateHasChanged();
            await this.FillDataToTipe();

        }


        //Editimi i nje rekordi
        private async Task EditType()
        {
            KrijoTip = false;
            string url = "http://192.168.1.118/api/tbl_" + selectedtable + "_TYPE/" + selectedTipId;
            List<Tipe> permanent = await http.GetJsonAsync<List<Tipe>>(url);
            tipi = permanent.FirstOrDefault();
            StateHasChanged();
        }

        //editimi ka ngelur pergjys
        private async Task SaveEditedType(EditContext context)
        {
            Tipe model = (Tipe)context.Model;
            string parameters = "?uid_sup=" + model.uid_sup + "&description=" + model.description;
            string url = "http://192.168.1.118/api/tbl_" + selectedtable + "_TYPE/" + selectedTipId + "/" + model.elcat + "/" + model.code + "/" + model.nomination + parameters;
            await http.PutJsonAsync(url, "");
            Message = true;
            tipi.uid = 0;
            MyTipElement.Clear();
            tipiIRI.uid_sup = -1;
            StateHasChanged();
            await this.FillDataToTipe();

        }

        //Fshirja e nje tipi
        private async Task DeleteType()
        {
            string url = "http://192.168.1.118/api/tbl_" + selectedtable + "_TYPE/" + selectedTipId.ToString();
            await http.DeleteAsync(url);
            Message = true;
            MyTipElement.Clear();
            StateHasChanged();
            await this.FillDataToTipe();

        }

        // Menuja Listat
        private List<MenuItem> MenuItemsForType = new List<MenuItem>{
        new MenuItem { Text = "Edit" },
        new MenuItem { Text = "Remove" },
        new MenuItem { Text = "Add" }
    };



    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
