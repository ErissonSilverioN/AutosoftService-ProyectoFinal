#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Consultas\CFacturas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "134cd6698f1b47f5773c8ebcee1a75cd0f026c4c"
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
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Consultas\CFacturas.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Consultas\CFacturas.razor"
using AutosoftService.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Consultas\CFacturas.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CFacturas")]
    public partial class CFacturas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 161 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Consultas\CFacturas.razor"
       


    DateTime Desde;
    DateTime Hasta;

    bool BuscarPorFecha;
    decimal Total = 0;

    string Filtro;
    string Criterio;

    Clientes clientes = new Clientes();

    public List<Facturas> listaFacturas = new List<Facturas>();

    List<Facturas> Listado { get; set; }
    List<Facturas> ListadoPaginado { get; set; }

    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;

    Contexto db = new Contexto();
    Paginacion paginacion = new Paginacion();


    List<Facturas> ListaTemp = new List<Facturas>();


    protected override void OnInitialized()
    {
        Filtro = "0";

        Criterio = string.Empty;
        Desde = DateTime.Now;
        Hasta = DateTime.Now;
        BuscarPorFecha = false;
        Filtro = "0";
        LlenarLista();
    }


    private void LlenarLista()
    {
        listaFacturas = AutosoftService.BLL.FacturaBLL.GetList(e => true);
        Listado = new List<Facturas>();
        foreach (var item in listaFacturas)
        {
            Facturas facturas = new Facturas();
            facturas.FacturaId = item.FacturaId;
            facturas.Servicios = item.Servicios;
            clientes = BLL.ClienteBLL.Buscar(item.ClienteId);
            facturas.ClienteId = item.ClienteId;
            facturas.Fecha = item.Fecha;
            facturas.Total = item.Total;

            Listado.Add(facturas);
        }

        CagarTotal();
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



    public void FiltrarPorLaFecha()
    {
        if (Filtro == "0")
            ListaTemp = Listado;

        if (BuscarPorFecha == true && ListaTemp.Count > 0)
        {
            Listado = new List<Facturas>();
            foreach (var item in ListaTemp)
            {
                if (item.Fecha.Date >= Desde.Date && item.Fecha.Date <= Hasta.Date)
                {
                    Listado.Add(item);
                }
            }

            BuscarPorFecha = false;
        }
        else
        {
            Listado = new List<Facturas>();
            Listado = ListaTemp;
        }
        CagarTotal();
        IniciarPaginacion();
    }


    public void CagarTotal()
    {
        Total = 0;
        if (Listado != null)
            foreach (var item in Listado)
            {
                Total += item.Total;
            }
    }


    private void Buscar()
    {
        if (Filtro == "0")
        {
            LlenarLista();
            FiltrarPorLaFecha();
        }
        else
        {
            if (Criterio == "")
            {
                toast.ShowInfo("Agregue el criterio de busqueda");
            }
            else
            {
                LlenarLista();
                ListaTemp = Listado;


                switch (Filtro)
                {
                    case "0":
                        listaFacturas = AutosoftService.BLL.FacturaBLL.GetList(e => true);
                        break;

                    case "1":
                        ListaTemp = new List<Facturas>();
                        foreach (var item in listaFacturas)
                        {
                            if (Convert.ToString(item.FacturaId).Contains(Criterio))
                            {
                                Facturas facturas = new Facturas();
                                facturas.FacturaId = item.FacturaId;
                                facturas.Servicios = item.Servicios;
                                clientes = ClienteBLL.Buscar(item.ClienteId);
                                facturas.ClienteId = Convert.ToInt32(clientes.Nombre);
                                facturas.Fecha = item.Fecha;
                                facturas.Total = item.Total;

                                ListaTemp.Add(facturas);
                            }
                        }
                        break;

                    case "2":
                        ListaTemp = new List<Facturas>();
                        foreach (var item in listaFacturas)
                        {
                            clientes = ClienteBLL.Buscar(item.ClienteId);
                            if (clientes.Nombre.Contains(Criterio))
                            {
                                Facturas facturas = new Facturas();
                                facturas.FacturaId = item.FacturaId;
                                facturas.ClienteId = Convert.ToInt32(clientes.Nombre);
                                facturas.Fecha = item.Fecha;
                                facturas.Total = item.Total;

                                ListaTemp.Add(facturas);
                            }
                        }
                        break;

                    case "3":
                        ListaTemp = new List<Facturas>();
                        foreach (var item in listaFacturas)
                        {
                            if (Convert.ToString(item.Total).Contains(Criterio))
                            {
                                Facturas facturas = new Facturas();
                                facturas.FacturaId = item.FacturaId;
                                facturas.Servicios = item.Servicios;
                                facturas.ClienteId = clientes.ClienteId;
                                facturas.Fecha = item.Fecha;
                                facturas.Total = item.Total;

                                ListaTemp.Add(facturas);
                            }
                        }
                        break;
                }

                FiltrarPorLaFecha();
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
