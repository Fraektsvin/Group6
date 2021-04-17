// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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