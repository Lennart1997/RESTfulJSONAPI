// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ClientTodo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/_Imports.razor"
using AdvancedTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/Pages/AddTodo.razor"
using AdvancedTodo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/Pages/AddTodo.razor"
using AdvancedTodo.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddTodo")]
    public partial class AddTodo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/lennartsargezian/Desktop/TodosWebAP-master/ClientTodo/Pages/AddTodo.razor"
       
    private Todo newTodoItem = new Todo();

    private async Task AddNewTodoAsync() {
        await TodosService.AddTodoAsync(newTodoItem);
        NavigationManager.NavigateTo("/Todos");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodosService TodosService { get; set; }
    }
}
#pragma warning restore 1591
