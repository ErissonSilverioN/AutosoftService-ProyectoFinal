#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Consultas\CPedido.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc610f724280b9aa45bbc3b7c164c91483c5401e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AutosoftService.Pages.Consultas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Consultas\CPedido.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Consultas\CPedido.razor"
using AutosoftService.Model.Consultas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Consultas\CPedido.razor"
using AutosoftService.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Consultas\CPedido.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CPedidos")]
    public partial class CPedido : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 165 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Consultas\CPedido.razor"
       


    DateTime Desde;
    DateTime Hasta;

    string Filtro;
    string Criterio;

    bool FiltrarFecha;
    decimal Total = 0;

    Articulos articuloTemp = new Articulos();
    Proveedores proveedorTemp = new Proveedores();
    Pedidos pedidosTemp = new Pedidos();

    public List<Pedidos> listaPedidos = new List<Pedidos>();

    List<PedidosConsult> Listado { get; set; }
    List<PedidosConsult> ListadoPaginado { get; set; }

    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;

    Contexto contexto = new Contexto();
    Paginacion paginacion = new Paginacion();

    List<PedidosConsult> listaTemp = new List<PedidosConsult>();

    protected override void OnInitialized()
    {
        Filtro = "0";

        Criterio = string.Empty;
        Desde = DateTime.Now;
        Hasta = DateTime.Now;
        FiltrarFecha = false;


        LlenarLista();
    }

    private void LlenarLista()
    {
        listaPedidos = PedidoBLL.GetList(e => true);
        Listado = new List<PedidosConsult>();
        foreach (var item in listaPedidos)
        {
            PedidosConsult pedidos = new PedidosConsult();
            pedidos.PedidoId = item.PedidoId;
            pedidosTemp = PedidoBLL.Buscar(item.PedidoId);

            articuloTemp = ArticuloBLL.Buscar(item.ArticuloId);
            pedidos.Articulo = (articuloTemp == null) ? "Articulo elimindo" : articuloTemp.Descripcion;



            pedidos.Subtotal = item.Subtotal;
            pedidos.Fecha = item.Fecha;

            Listado.Add(pedidos);
        }


        IniciarPaginacion();
    }



    public void IniciarPaginacion()
    {
        PaginaActual = 1;
        Elementos = Listado.Count();
        Paginas = Math.Ceiling(Elementos / paginacion.Mostrar);
        ListadoPaginado = Listado.Take(paginacion.Mostrar).ToList();
    }



    private void PaginaSiguiente()
    {
        if (PaginaActual < Paginas)
        {
            PaginaActual++;
            ListadoPaginado = Listado
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }




    private void PaginaAnterior()
    {
        if (PaginaActual > 1)
        {
            PaginaActual--;
            ListadoPaginado = Listado
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }




    public void FiltrarFechas()
    {
        if (Filtro == "0")
            listaTemp = Listado;

        if (FiltrarFecha == true && listaTemp.Count > 0)
        {
            Listado = new List<PedidosConsult>();

            foreach (var item in listaTemp)
            {
                if (item.Fecha.Date >= Desde.Date && item.Fecha.Date <= Hasta.Date)
                {
                    Listado.Add(item);
                }
            }
            FiltrarFecha = false;
        }
        else
        {
            Listado = new List<PedidosConsult>();
            Listado = listaTemp;
        }

        IniciarPaginacion();
    }





    private void Buscar()
    {
        if (Filtro == "0")
        {
            LlenarLista();
            FiltrarFechas();
        }
        else
        {
            if (Criterio == "")
            {
                toast.ShowInfo("Debe ingresar un criterio");
            }
            else
            {
                LlenarLista();
                listaTemp = Listado;
                switch (Filtro)
                {
                    case "0":
                        listaPedidos = PedidoBLL.GetList(e => true);
                        break;

                    case "1":
                        listaTemp = new List<PedidosConsult>();
                        foreach (var item in listaPedidos)
                        {
                            if (Convert.ToString(item.PedidoId).Contains(Criterio))
                            {
                                PedidosConsult pedidos = new PedidosConsult();
                                pedidos.PedidoId = item.PedidoId;
                                pedidosTemp = PedidoBLL.Buscar(item.PedidoId);

                                articuloTemp = ArticuloBLL.Buscar(item.ArticuloId);
                                pedidos.Articulo = (articuloTemp == null) ? "Articulo elimindo" : articuloTemp.Descripcion;




                                pedidos.Subtotal = item.Subtotal;
                                pedidos.Fecha = item.Fecha;

                                listaTemp.Add(pedidos);
                            }
                        }
                        break;

                    case "2":
                        listaTemp = new List<PedidosConsult>();
                        foreach (var item in listaPedidos)
                        {
                            articuloTemp = ArticuloBLL.Buscar(item.ArticuloId);
                            if (articuloTemp.Descripcion.Contains(Criterio))
                            {
                                PedidosConsult pedidos = new PedidosConsult();
                                pedidos.PedidoId = item.PedidoId;
                                pedidosTemp = PedidoBLL.Buscar(item.PedidoId);
                                articuloTemp = ArticuloBLL.Buscar(item.ArticuloId);
                                pedidos.Articulo = (articuloTemp == null) ? "Articulo elimindo" : articuloTemp.Descripcion;

                                pedidos.Subtotal = item.Subtotal;
                                pedidos.Fecha = item.Fecha;

                                listaTemp.Add(pedidos);
                            }
                        }
                        break;


                }

                FiltrarFechas();
            }
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
