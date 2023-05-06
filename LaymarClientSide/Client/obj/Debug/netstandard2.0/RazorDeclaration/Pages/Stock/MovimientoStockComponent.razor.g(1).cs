#pragma checksum "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Stock\MovimientoStockComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13d0598f0793e1a0f0bf986e1c6208666a10ce0a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LaymarClientSide.Client.Pages.Stock
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client;

#line default
#line hidden
#line 7 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 9 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Client.Helpers;

#line default
#line hidden
#line 10 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using LaymarClientSide.Shared;

#line default
#line hidden
#line 11 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 12 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#line 13 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#line 14 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#line 1 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Stock\MovimientoStockComponent.razor"
using LaymarClientSide.Shared.Entidades;

#line default
#line hidden
#line 3 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Stock\MovimientoStockComponent.razor"
using LaymarClientSide.Shared.Dtos;

#line default
#line hidden
#line 6 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Stock\MovimientoStockComponent.razor"
using LaymarClientSide.Client.Repositorio;

#line default
#line hidden
#line 4 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Stock\MovimientoStockComponent.razor"
           [Authorize(Roles = "Stock, Admin")]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/movimientoStock")]
    public partial class MovimientoStockComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 230 "C:\Users\DAMIAN\Desktop\LAYMAR_200521\LaymarClientSide\Client\Pages\Stock\MovimientoStockComponent.razor"
       
    public string cadenaBusquedaProducto { get; set; } = String.Empty;
    public string cadenafiltroBusqueda { get; set; } = String.Empty;
    public string criterioBusqueda { get; set; } = "Producto";
    public DateTime fechaDesde { get; set; } = DateTime.Now;
    public DateTime fechaHasta { get; set; } = DateTime.Now;
    public bool error { get; set; }
    public string errorMessage { get; set; }
    public Producto producto { get; set; } = new Producto();
    public Sucursal sucursal { get; set; } = new Sucursal();
    private int paginaActual = 1;
    private int paginasTotales;
    private HttpResponseWrapper<List<MovimientoStock>> responseHttp;

    public MovimientoStock movimientoStock { get; set; } = new MovimientoStock();
    public List<MovimientoStock>
    movimientoStocks
    { get; set; } = new List<MovimientoStock>
        ();

    public Stock stock { get; set; } = new Stock();

    public List<MovimientoStock>
        movimientoStocksBuscados
    { get; set; }
    public List<TipoMovimientoStock>
        tipoMovimientoStock
    { get; set; } = new List<TipoMovimientoStock>
            ();

    public List<Sucursal>
        sucursales
    { get; set; } = new List<Sucursal>
            ();
    public List<Producto>
        productos
    { get; set; } = new List<Producto>
            ();
    public MovimientoStockDto movimientoDto { get; set; } = new MovimientoStockDto();



    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await ListarMovimientoStock();
    }

    protected void buscarProducto(int codigo)
    {
        try
        {
            producto = productos.Where(x => x.ProductoId == codigo).First();
            error = false;
        }
        catch (Exception)
        {
            error = true;
            errorMessage = "No hay productos con este código";
        }
    }


    protected override async Task OnInitializedAsync()
    {


        await ListarTipoMovimientoStock();
        await ListarMovimientoStock();
        await ListarSucursales();
        await ListarProductos();
    }
    protected async Task ListarTipoMovimientoStock()
    {
        tipoMovimientoStock = await http.GetJsonAsync<List<TipoMovimientoStock>>("/api/Stock/ListarTipoMovimientoStock");
    }

    protected async Task ListarSucursales()
    {
        sucursales = await http.GetJsonAsync<List<Sucursal>>("/api/Sucursal/Listar");
    }


    protected async Task ListarProductos()
    {
        productos = await http.GetJsonAsync<List<Producto>>("/api/Producto/Listar");
    }


    protected async Task ListarMovimientoStock()
    {
        movimientoStocks = null;
        movimientoStocksBuscados = null;
        responseHttp = await repositorio.Get<List<MovimientoStock>>($"/api/Stock/ListarMovimientoStock?pagina={paginaActual}&fechaDesde={fechaDesde.ToString()}&fechaHasta={fechaHasta.ToString()}");
        if (!responseHttp.Error)
        {
            movimientoStocks = responseHttp.Response;
            movimientoStocksBuscados = movimientoStocks;

            var conteo = responseHttp.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault();

            paginasTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());

        }

    }



    protected async Task GuardarMovimientoStock()
    {


        movimientoDto.producto = producto;
        movimientoDto.sucursal = sucursal;
        movimientoDto.movimiento = movimientoStock;

        if (movimientoStock.tipoMovimientoStock == null || movimientoStock.tipoMovimientoStock.TipoMovimientoStockId == 0)
        {
            await Alerta("top-end", "error", "Tienes que seleccionar un tipo de movimiento");
        }
        if (movimientoDto.producto == null || movimientoDto.producto.ProductoId == 0)
        {
            await Alerta("top-end", "error", "Tienes que seleccionar un producto");
        }
        if (movimientoDto.sucursal == null || movimientoDto.sucursal.SucursalId == 0)
        {
            await Alerta("top-end", "error", "Tienes que seleccionar una Sucursal");
        }
        else if (!movimientoStock.sale && !movimientoStock.entra)
        {
            await Alerta("top-end", "error", "Tienes que seleccionar si el movimiento es de entrada o salida");
        }
        else if (movimientoStock.cantidad == 0 || movimientoStock.cantidad < 0)
        {
            await Alerta("top-end", "error", "La cantidad tiene que ser mayor que cero");

        }
        else
        {

            await http.PostJsonAsync($"/api/Stock/CrearMovimiento", movimientoDto);
            
            await Alerta("top-end", "success", "Se creó el movimientoStock con éxito");
            await ListarMovimientoStock();
            await ModalToggle();
        }
    }


    protected void FiltrarMovimientoStock(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            if (cadenafiltroBusqueda != "" && cadenafiltroBusqueda != string.Empty)
            {
                try
                {
                    if (criterioBusqueda == "Codigo")
                    {
                        movimientoStocksBuscados = movimientoStocks.Where(x => x.MovimientoStockId.ToString().ToLower().Contains(cadenafiltroBusqueda.ToLower()) && x.fechaAlta > fechaDesde && x.fechaAlta < fechaHasta.AddHours(24)).ToList();
                    }
                    if (criterioBusqueda == "Producto")
                    {
                        movimientoStocksBuscados = movimientoStocks.Where(x => x.stock.producto.nombre.ToString().ToLower().Contains(cadenafiltroBusqueda.ToLower()) && x.fechaAlta > fechaDesde && x.fechaAlta < fechaHasta.AddHours(24)).ToList();
                    }

                    if (criterioBusqueda == "Sucursal")
                    {
                        movimientoStocksBuscados = movimientoStocks.Where(x => x.stock.sucursal.nombreSucursal.ToString().ToLower().Contains(cadenafiltroBusqueda.ToLower()) && x.fechaAlta > fechaDesde && x.fechaAlta < fechaHasta.AddHours(24)).ToList();
                    }
                    if (criterioBusqueda == "TipoMovimiento")
                    {
                        movimientoStocksBuscados = movimientoStocks.Where(x => x.tipoMovimientoStock.nombreTipoMovimientoStock.ToString().ToLower().Contains(cadenafiltroBusqueda.ToLower()) && x.fechaAlta > fechaDesde && x.fechaAlta < fechaHasta.AddHours(24)).ToList();
                    }

                }
                catch (Exception)
                {


                }

            }
            else { movimientoStocksBuscados = movimientoStocks.Where(x => x.fechaAlta > fechaDesde && x.fechaAlta < fechaHasta.AddHours(24)).ToList(); }
        }
    }


    public async Task Alerta(string posicion = "top-end", string icono = "success", string mensaje = "Se creó el movimientoStock con éxito")
    {
        await js.InvokeAsync<object>("alerta", posicion, icono, mensaje);
    }

    public async Task ModalToggle()
    {
        await js.InvokeAsync<object>("ModalToggle");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repositorio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591