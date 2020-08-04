#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Consultas\CFacturas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8248ee5746d0a6bfcfc2a96ea0c1c92537172195"
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
#line 1 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Consultas\CFacturas.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Consultas\CFacturas.razor"
using AutosoftService.Model.Consultas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Consultas\CFacturas.razor"
using AutosoftService.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Consultas\CFacturas.razor"
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
#line 163 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Consultas\CFacturas.razor"
       


    DateTime Desde;
    DateTime Hasta;

    string Filtro;
    string Criterio;

    bool FiltrarFecha;
    decimal Total = 0;

    Clientes clienteTemp = new Clientes();
    Facturas facturaTemp = new Facturas();

    public List<Facturas> listaFacturas = new List<Facturas>();

    List<FacturasConsult> Listado { get; set; }
    List<FacturasConsult> ListadoPaginado { get; set; }

    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;

    Contexto contexto = new Contexto();
    Paginacion paginacion = new Paginacion();

    List<FacturasConsult> listaTemp = new List<FacturasConsult>();

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
        listaFacturas = FacturaBLL.GetList(e => true);
        Listado = new List<FacturasConsult>();
        foreach (var item in listaFacturas)
        {
            FacturasConsult facturas = new FacturasConsult();
            facturas.FacturaId = item.FacturaId;
            facturaTemp = FacturaBLL.Buscar(item.FacturaId);
            facturas.Servicios = (clienteTemp == null) ? "Factura eliminda" : facturaTemp.Servicios;
            clienteTemp = ClienteBLL.Buscar(item.ClienteId);
            facturas.Cliente = (clienteTemp == null) ? "Cliente eliminado" : clienteTemp.Nombre;
            facturas.Total = item.Total;
            facturas.Fecha = item.Fecha;

            Listado.Add(facturas);
        }

        CalcularTotal();
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
            Listado = new List<FacturasConsult>();

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
            Listado = new List<FacturasConsult>();
            Listado = listaTemp;
        }
        CalcularTotal();
        IniciarPaginacion();
    }

    public void CalcularTotal()
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
                        listaFacturas = FacturaBLL.GetList(e => true);
                        break;

                    case "1":
                        listaTemp = new List<FacturasConsult>();
                        foreach (var item in listaFacturas)
                        {
                            if (Convert.ToString(item.FacturaId).Contains(Criterio))
                            {
                                FacturasConsult facturas = new FacturasConsult();
                                facturas.FacturaId = item.FacturaId;
                                facturaTemp = FacturaBLL.Buscar(item.FacturaId);
                                facturas.Servicios = (clienteTemp == null) ? "Factura eliminda" : facturaTemp.Servicios;
                                clienteTemp = ClienteBLL.Buscar(item.ClienteId);
                                facturas.Cliente = clienteTemp.Nombre;
                                facturas.Total = item.Total;
                                facturas.Fecha = item.Fecha;

                                listaTemp.Add(facturas);
                            }
                        }
                        break;

                    case "2":
                        listaTemp = new List<FacturasConsult>();
                        foreach (var item in listaFacturas)
                        {
                            clienteTemp = ClienteBLL.Buscar(item.ClienteId);
                            if (clienteTemp.Nombre.Contains(Criterio))
                            {
                                FacturasConsult facturas = new FacturasConsult();
                                facturas.FacturaId = item.FacturaId;
                                facturaTemp = FacturaBLL.Buscar(item.FacturaId);
                                facturas.Servicios = (clienteTemp == null) ? "Factura eliminda" : facturaTemp.Servicios;
                                facturas.Cliente = clienteTemp.Nombre;
                                facturas.Total = item.Total;
                                facturas.Fecha = item.Fecha;

                                listaTemp.Add(facturas);
                            }
                        }
                        break;

                    case "3":
                        listaTemp = new List<FacturasConsult>();
                        foreach (var item in listaFacturas)
                        {
                            if (Convert.ToString(item.Total).Contains(Criterio))
                            {
                                FacturasConsult facturas = new FacturasConsult();
                                facturas.FacturaId = item.FacturaId;
                                facturaTemp = FacturaBLL.Buscar(item.FacturaId);
                                facturas.Servicios = (clienteTemp == null) ? "Factura eliminda" : facturaTemp.Servicios;
                                clienteTemp = ClienteBLL.Buscar(item.ClienteId);
                                facturas.Cliente = clienteTemp.Nombre;
                                facturas.Total = item.Total;
                                facturas.Fecha = item.Fecha;

                                listaTemp.Add(facturas);
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
