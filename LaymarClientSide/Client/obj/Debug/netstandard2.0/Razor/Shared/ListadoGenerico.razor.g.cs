#pragma checksum "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "407ed2f5a320fa6fc56f2385691764ec9eca8efe"
// <auto-generated/>
#pragma warning disable 1591
namespace LaymarClientSide.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client;

#line default
#line hidden
#line 7 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Shared;

#line default
#line hidden
#line 8 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 9 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Helpers;

#line default
#line hidden
#line 10 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Shared;

#line default
#line hidden
#line 11 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 12 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#line 13 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#line 14 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\_Imports.razor"
using System.Drawing;

#line default
#line hidden
    public partial class ListadoGenerico<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n</style>\r\n\r\n");
#line 5 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Shared\ListadoGenerico.razor"
 if (listado == null)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, @"<div class=""col-md-12 mx-0"">
        <div class=""col-md-6 offset-md-3 text-center"">
            <div class=""loadingio-spinner-gear-6fy6tnognl6"">
                <div class=""ldio-0hnwc57mubea"">
                    <div><div></div><div></div><div></div><div></div><div></div><div></div></div>
                </div>
            </div>
        </div>
    </div>
");
            __builder.AddMarkupContent(3, "<div class=\"loadingio-spinner-gear-25iylaucyg7\">\r\n    <div class=\"ldio-ltxbqpj0lik\">\r\n        <div> <div> </div> <div> </div> <div> </div> <div> </div> <div> </div> <div> </div> </div>\r\n    </div>\r\n</div>\r\n");
#line 21 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Shared\ListadoGenerico.razor"

}
else if (listado.Count == 0)
{
    if (NoHayRegistros != null)

    {
        

#line default
#line hidden
            __builder.AddContent(4, 
#line 28 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Shared\ListadoGenerico.razor"
         NoHayRegistros

#line default
#line hidden
            );
#line 28 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Shared\ListadoGenerico.razor"
                       

    }
    else
    {

#line default
#line hidden
            __builder.AddContent(5, "        ");
            __builder.AddMarkupContent(6, "<p><strong>No hay registros para mostrar</strong></p>\r\n");
#line 34 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Shared\ListadoGenerico.razor"
    }
}
else
{
    

#line default
#line hidden
            __builder.AddContent(7, 
#line 38 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Shared\ListadoGenerico.razor"
     HayRegistros

#line default
#line hidden
            );
#line 38 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Shared\ListadoGenerico.razor"
                 
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 42 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Shared\ListadoGenerico.razor"
 
    [Parameter] public List<T> listado { get; set; }
    [Parameter]

    public RenderFragment HayRegistros { get; set; }
    [Parameter]
    public RenderFragment NoHayRegistros { get; set; }


#line default
#line hidden
    }
}
#pragma warning restore 1591
