#pragma checksum "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eb1da8e8cfb3b21b7677fe0b339139084800b22"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/_Imports.razor"
using TodoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
using TodoBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
using TodoBlazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todos")]
    public partial class TodoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 xmlns=\"http://www.w3.org/1999/html\">Todo list</h1>\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\n    Filter by User Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
                                                        (arg) => FilterByUserId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\n    Filter by completed status:\n    ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control selectpicker");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
                                                           (arg) => FilterByCompletedStatus(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width:100px");
            __builder.OpenElement(14, "option");
            __builder.AddContent(15, "Both");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "option");
            __builder.AddContent(18, "False");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n        ");
            __builder.OpenElement(20, "option");
            __builder.AddContent(21, "True");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
 if (todosToShow == null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p><em>Loading...</em></p>");
#nullable restore
#line 22 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
} else if (!todosToShow.Any()) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p><em>No ToDo items exist. Please add some.</em></p>");
#nullable restore
#line 26 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table");
            __builder.AddMarkupContent(26, "<thead><tr><th>User ID</th>\n            <th>Todo ID</th>\n            <th>Title</th>\n            <th>Completed?</th>\n            <th>Remove</th></tr></thead>\n        ");
            __builder.OpenElement(27, "tbody");
#nullable restore
#line 38 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
         foreach (var item in todosToShow) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 40 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
                     item.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 41 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
                     item.TodoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 42 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
                     item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "checkbox");
            __builder.AddAttribute(41, "checked", 
#nullable restore
#line 44 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
                                                    item.IsCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 44 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
                                                                                  (arg) => CompletedChange(arg, item)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                ");
            __builder.OpenElement(44, "td");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
                                        () => RemoveTodo(item.TodoId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "/Users/lennartsargezian/Desktop/TodosWebAP-master/TodoBlazor/Pages/TodoList.razor"
       
    private IList<Todo> todosToShow;
    private IList<Todo> allTodos;

    private int? filterById;
    private bool? filterByIsCompleted;

    private void FilterByUserId(ChangeEventArgs changeEventArgs) {
        filterById = null;
        try {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        } catch (Exception e) { }
        ExecuteFilter();
    }

    private void FilterByCompletedStatus(ChangeEventArgs args) {
        filterByIsCompleted = null;
        try {
            filterByIsCompleted = bool.Parse(args.Value.ToString());
        } catch (Exception e) { }
        ExecuteFilter();
    }

    private void ExecuteFilter() {
        todosToShow = allTodos.Where(t => 
            (filterById != null && t.UserId == filterById || filterById == null) &&
            (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)
        ).ToList();
    }

    protected override async Task OnInitializedAsync() {
        allTodos = await TodosService.GetTodosAsync();
        todosToShow = allTodos;
    }

    private async Task RemoveTodo(int todoId) {
        Todo todoToRemove = todosToShow.First(t => t.TodoId == todoId);
        await TodosService.RemoveTodoAsync(todoId);
        todosToShow.Remove(todoToRemove);
    }

    private async Task CompletedChange(ChangeEventArgs evt, Todo todo) {
        todo.IsCompleted = (bool) evt.Value;
        await TodosService.UpdateAsync(todo);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodosService TodosService { get; set; }
    }
}
#pragma warning restore 1591