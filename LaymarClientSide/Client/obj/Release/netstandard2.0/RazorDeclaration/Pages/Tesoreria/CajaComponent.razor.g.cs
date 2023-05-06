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
#line 2 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Tesoreria\CajaComponent.razor"
using LaymarClientSide.Shared.Entidades;

#line default
#line hidden
#line 5 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Tesoreria\CajaComponent.razor"
           [Authorize(Roles = "Tesoreria, Admin")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/caja")]
    public partial class CajaComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 158 "D:\GIT\AlmaLibre_Blazor\LaymarClientSide\Client\Pages\Tesoreria\CajaComponent.razor"
       
    public Caja caja { get; set; } = new Caja();
    public double montoInicial { get; set; } = 0.00;
    public DateTime fechaCaja { get; set; } = DateTime.Now.AddHours(-3);
    public bool ExisteCajaDiariaBandera { get; set; } = false;
    public List<MovimientoCaja> movimientosCaja { get; set; } = new List<MovimientoCaja>();
    public MovimientoCaja movimientoCaja { get; set; } = new MovimientoCaja();
    public List<TipoMovimientoCaja> tipoMovimientosCaja { get; set; } = new List<TipoMovimientoCaja>();
    protected override async Task OnInitializedAsync()
    {


        await ExisteCajaDiaria();
        await ListarTiposMovimientoCaja();

    }
    protected async Task ExisteCajaDiaria()
    {
        ExisteCajaDiariaBandera = await http.PostJsonAsync<bool>($"/api/Caja/ExisteCajaDia", VariablesGlobales.sucursal);
        if (ExisteCajaDiariaBandera == true)
        {
            await BuscarCaja();
            await ListarMovimientos();
        }
    }

    protected async Task BuscarCaja()
    {
        caja = await http.GetJsonAsync<Caja>($"/api/Caja/Buscar/{VariablesGlobales.sucursal.SucursalId}");

    }

    protected async Task ListarTiposMovimientoCaja()
    {
        tipoMovimientosCaja = await http.GetJsonAsync<List<TipoMovimientoCaja>>("/api/TipoMovimientoCaja/Listar");


    }
    protected async Task ListarMovimientos()
    {
        movimientosCaja = await http.GetJsonAsync<List<MovimientoCaja>>($"/api/Caja/ListarMovimientos/{caja.CajaId}");
    }

    protected async Task CrearMovimientoCaja()
    {
        if (movimientoCaja.tipoMovimientoCaja == null || movimientoCaja.tipoMovimientoCaja.TipoMovimientoCajaId == 0)
        {
            await Alerta("top-end", "error", "Tienes que seleccionar un tipo de movimeinto");
        }
        else if (!movimientoCaja.sale && !movimientoCaja.entra)
        {
            await Alerta("top-end", "error", "Tienes que seleccionar si el movimiento es de entrada o salida");
        }
        else if (movimientoCaja.importe == 0 || movimientoCaja.importe < 0)
        {
            await Alerta("top-end", "error", "El importe tiene que ser mayor que cero");

        }
        else
        {
            await http.PostJsonAsync<MovimientoCaja>($"/api/Caja/CrearMovimientoCaja/{caja.CajaId}", movimientoCaja);
            await Alerta("top-end", "success", "Se creo correctamente el movimiento");
            await BuscarCaja();
            await ModalToggle();
            await ListarMovimientos();

        }

    }

    protected async Task CrearCajaDiaria()
    {

        await http.PostJsonAsync<Caja>($"/api/Caja/IniciarCaja/{montoInicial}", VariablesGlobales.sucursal);
        await ExisteCajaDiaria();
    }


    public async Task ModalToggle()
    {
        await js.InvokeAsync<object>("ModalToggle");
    }

    public async Task Alerta(string posicion = "top-end", string icono = "success", string mensaje = "Se creó el proveedor con éxito")
    {
        await js.InvokeAsync<object>("alerta", posicion, icono, mensaje);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591