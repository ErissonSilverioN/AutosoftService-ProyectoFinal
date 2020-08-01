#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RPedidos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "810cf90ff73f21c8b8a292ba4b90e11e6c7c3c7f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AutosoftService.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RPedidos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RPedidos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RPedidos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RPedios/{PedidoId:int}")]
    public partial class RPedidos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 197 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RPedidos.razor"
       

    [Parameter]
    public int PedidoId { get; set; }
    private Pedidos pedidos = new Pedidos();


    Proveedores proveedores = new Proveedores();
    private List<Proveedores> ListaProveedores = new List<Proveedores>();
    private string ProveedorSelect { get; set; }


    Articulos articulos = new Articulos();
    private List<Articulos> ListaArticulos = new List<Articulos>();
    private string ArticuloSelect { get; set; }


    private int unidad = 0;
    private decimal precio = 0;
    decimal importe = 0;
    private int existencia = 0;

    private string Notificacion = "";




    protected override void OnInitialized()
    {

        ListaProveedores = BLL.ProveedorBLL.GetList(e => true);
        ListaArticulos = ArticuloBLL.GetList(e => true);
        pedidos = new Pedidos();
        proveedores = new Proveedores();
        articulos = new Articulos();
        Nuevo();
        Buscar();

        base.OnInitialized();
    }



    private void Buscar()
    {
        if (pedidos.PedidoId != 0)
        {
            var encontrado = PedidoBLL.Buscar(pedidos.PedidoId);

            if (encontrado != null)
            {
                this.pedidos = encontrado;
            }
            else
            {
                toas.ShowWarning("NO ENCONTRADO", "Fallo");
            }
        }
    }



    private void Nuevo()
    {
        this.pedidos = new Pedidos();
    }



    private void Guardar()
    {

        CalcularSubtotal();
        if (ProveedorSelect == null)
        {
            toas.ShowInfo("Ingrese un Proveedor", "Info");
        }
        else
        {
            pedidos.ProveedorId = Convert.ToInt32(ProveedorSelect);

            if (pedidos.Pedido_Detalle.Count == 0)
            {
                toas.ShowInfo("Ingrese un Articulo al detalle", "Info");
            }
            else
            {
                if (PedidoBLL.Guardar(pedidos))
                {
                    Nuevo();
                    toas.ShowSuccess("Factura Guardada", "Exito");
                }
                else
                {
                    toas.ShowError("Error al guardar Factura", "Fallo");
                }
            }
        }
    }


    private void Eliminar()
    {
        bool paso;

        paso = PedidoBLL.Eliminar(pedidos.PedidoId);

        if (paso)
        {
            Nuevo();
            toas.ShowWarning("ELIMINADO");
        }
        else
        {
            toas.ShowError("NO SE PUDO ELIMINAR");
        }
    }


    private void Agregar()
    {
        if (ArticuloSelect == null)
        {
            toas.ShowInfo("Debe seleccionar un Articulo");
        }
        else
        {
            if (unidad <= 0)
            {
                toas.ShowInfo("La cantidad debe ser mayor a 0");
            }
            else
                if (unidad >= 999999)
            {
                toas.ShowInfo("Cantida no Valida");
                return;
            }
            else
            {
                if (unidad > articulos.Existencia)
                {
                    toas.ShowInfo("Solo quedan " + articulos.Existencia + " unidades de este producto");
                }
                else
                {

                    pedidos.Pedido_Detalle.Add(new PedidoD()
                    {
                        PedidoId = pedidos.PedidoId,
                        ArticuloId = articulos.ArticuloId,
                        Descripcion = articulos.Descripcion,
                        Precio = precio,
                        Unidad = unidad
                    }); ;
                    articulos = new Articulos();

                    CalcularSubtotal();

                    ArticuloSelect = "0";
                    unidad = 0;
                }
            }

        }
    }



    private void Remover(PedidoD detalle)
    {
        pedidos.Pedido_Detalle.Remove(detalle);
        CalcularSubtotal();
    }







    private void LlenaComboxProveedor()
    {
        try
        {
            pedidos.ProveedorId = Convert.ToInt32(ProveedorSelect);
        }
        catch (Exception)
        {

        }
    }



    private void LlenaComboxArticulo()
    {
        try
        {
            pedidos.ArticuloId = Convert.ToInt32(ArticuloSelect);
            precio = articulos.Precio;
            existencia = articulos.Existencia;
        }
        catch (Exception)
        {

        }
    }


    private void CalcularSubtotal()
    {
        decimal Result = 0;

        foreach (var item in pedidos.Pedido_Detalle)
        {
            Result += item.Precio * item.Unidad;
        }

        pedidos.Subtotal = Result;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toas { get; set; }
    }
}
#pragma warning restore 1591
