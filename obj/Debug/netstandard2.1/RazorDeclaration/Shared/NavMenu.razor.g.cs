#pragma checksum "c:\dev\netcore\ActionNotificationsSample\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b344c571b2312fde86f04546dec6238e4b2df497"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ActionNotificationsSample.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using ActionNotificationsSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using ActionNotificationsSample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using ActionNotifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\dev\netcore\ActionNotificationsSample\_Imports.razor"
using ActionNotifications.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "c:\dev\netcore\ActionNotificationsSample\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
