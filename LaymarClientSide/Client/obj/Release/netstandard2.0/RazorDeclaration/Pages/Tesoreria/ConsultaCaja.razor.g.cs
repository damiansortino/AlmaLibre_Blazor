// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LaymarClientSide.Client.Pages.Tesoreria
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
#line 1 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Tesoreria\ConsultaCaja.razor"
using LaymarClientSide.Shared.Entidades;

#line default
#line hidden
#line 4 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Tesoreria\ConsultaCaja.razor"
using LaymarClientSide.Shared.Dtos;

#line default
#line hidden
#line 3 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Tesoreria\ConsultaCaja.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/ConsultaCaja")]
    public partial class ConsultaCaja : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 110 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Tesoreria\ConsultaCaja.razor"
       

    public DateTime fecha { get; set; } = DateTime.Now.AddHours(-3);
    public List<CajaDto> cajas { get; set; } = new List<CajaDto>();
    public List<Sucursal> sucursales { get; set; } = new List<Sucursal>();
    public Sucursal sucursal { get; set; } = new Sucursal();

    protected override async Task OnInitializedAsync()
    {
        await ListarSucursales();
        await ConsultarCaja();
    }

    protected async Task ListarSucursales()
    {

        sucursales = await http.GetJsonAsync<List<Sucursal>>("api/Sucursal/Listar");
    }

    protected async Task ConsultarCaja() {
        if (sucursal.SucursalId == 0) {
            cajas = await http.GetJsonAsync<List<CajaDto>>($"/api/Caja/ConsultarCaja/{fecha.ToString("dd-MM-yyyy")}/Todas");

        }
        else
        {
            Console.WriteLine($"/api/Caja/ConsultarCaja/{fecha.ToString("dd-MM-yyyy")}/{Convert.ToString(sucursal.SucursalId)}");
            cajas = await http.GetJsonAsync<List<CajaDto>>($"/api/Caja/ConsultarCaja/{fecha.ToString("dd-MM-yyyy")}/{Convert.ToString(sucursal.SucursalId)}");


        }
    }


    


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
