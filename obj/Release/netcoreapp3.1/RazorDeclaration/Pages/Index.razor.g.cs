#pragma checksum "C:\Users\tbtom\Source\Repos\odskee\ExternED\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09425ba476eae8668fd1c9067c88049571efa437"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ExternED.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tbtom\Source\Repos\odskee\ExternED\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tbtom\Source\Repos\odskee\ExternED\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tbtom\Source\Repos\odskee\ExternED\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tbtom\Source\Repos\odskee\ExternED\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tbtom\Source\Repos\odskee\ExternED\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tbtom\Source\Repos\odskee\ExternED\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tbtom\Source\Repos\odskee\ExternED\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tbtom\Source\Repos\odskee\ExternED\_Imports.razor"
using ExternED;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tbtom\Source\Repos\odskee\ExternED\_Imports.razor"
using ExternED.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tbtom\Source\Repos\odskee\ExternED\Pages\Index.razor"
using ExternED.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\tbtom\Source\Repos\odskee\ExternED\Pages\Index.razor"
      
    private async Task<bool> POC()
    {
        await KeyManager.ProofOfConcept();
        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private KeyManager KeyManager { get; set; }
    }
}
#pragma warning restore 1591
