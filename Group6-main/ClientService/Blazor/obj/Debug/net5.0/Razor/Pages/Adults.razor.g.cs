#pragma checksum "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de9130619b642267732ded8c0246b3a3b2bcb0a3"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
using Blazor.code.persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Summary of adults in the database</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, " Filter by User Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                                                        (arg) => FilterForId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.AddMarkupContent(8, "<p>Shows a list of Adults with their responsive jobs and attributes</p>\r\n");
            __builder.AddMarkupContent(9, "<p> u can edit, delete and in the menu you can choose to add another adult</p>");
#nullable restore
#line 16 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
 if (adultdata == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<p><em>Loading...</em></p>");
#nullable restore
#line 21 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
}
else
{
   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
            __builder.AddMarkupContent(13, @"<thead><tr><th>JobTitle</th>
            <th>Id</th>
            <th>FirstName</th>
            <th>LastName</th>
            <th>HairColor</th>
            <th>EyeColor</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th></tr></thead>
        ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 41 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
         foreach (var item in adultdata)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 44 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 45 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 46 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 47 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 48 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 49 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 50 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 51 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 52 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 53 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "checkbox");
            __builder.AddAttribute(49, "checked", 
#nullable restore
#line 56 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                                                item.IsCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                                                                              (arg) => CompletedChange(arg, item)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "                   \r\n          \r\n            ");
            __builder.OpenElement(52, "td");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                                    () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "<i class=\"oi oi-trash\" style=\"color:#ff0000\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "td");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
                                () => Edit(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(60, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Antonio\Downloads\Antonios 1st assignment (1)\Antonios 1st assignment\Blazor\Pages\Adults.razor"
       
    private IList<Adult>  adultdata;
    private int? filterForID;
    private IList<Adult> todosToShow;
    private bool? filterCompleted;

    protected override async Task OnInitializedAsync()
    {
        adultdata= Adultdata.getAdults();
        
    }
    private void RemoveAdult(int adultId)
    {
        Adult adultRemove = adultdata.First(t => t.Id == adultId);
        Adultdata.RemoveAdult(adultId);
        adultdata.Remove(adultRemove);
        
        
    }
    private void FilterForId(ChangeEventArgs changeEventArgs)
    {
        filterForID = null;
        try
        {
            filterForID = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
    // ignored
        }
        ExecuteFilter();
    }
    private void FilterByCompletedStatus(ChangeEventArgs args)
    {
        filterCompleted = null;
        try
        {
            filterCompleted = bool.Parse(args.Value.ToString());
        }
        catch (Exception e)
        {
    // ignored
        }
        ExecuteFilter();
    }
    private void Edit(int id)
    {
        Nav.NavigateTo("/Edit");

    }
    private void CompletedChange(ChangeEventArgs evt, Adult adult)
    {
        adult.IsCompleted = (bool) evt.Value;
        Adultdata.Update(adult);
    }
    
    private void ExecuteFilter()
    {
        adultdata = adultdata.Where(t => (filterForID != null && t.Id == filterForID || filterForID == null) &&                                        
            (filterCompleted != null && t.IsCompleted == filterCompleted || filterCompleted == null)).
            ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdult Adultdata { get; set; }
    }
}
#pragma warning restore 1591