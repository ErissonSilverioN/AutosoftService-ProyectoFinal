#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\Pages\Consultas\CCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36a63e36b0a5e265765b510d0b1cfc163c7c76f2"
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
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\Pages\Consultas\CCliente.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\Pages\Consultas\CCliente.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cclientes")]
    public partial class CCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal8\AutosoftService\Pages\Consultas\CCliente.razor"
       

    private List<Clientes> lista { get; set; }
    private List<Clientes> listapaginada { get; set; }

    private string Filtro { get; set; }
    private string Criterio { get; set; }
    Paginacion paginacion = new Paginacion();
    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;






    protected override void OnInitialized()
    {
        lista = ClienteBLL.GetList(C => true);
        Filtro = "Todo";
        IniciarPaginacion();
    }



    public void IniciarPaginacion()
    {
        PaginaActual = 1;
        Elementos = lista.Count();
        Paginas = Math.Ceiling(Elementos / paginacion.Mostrar);
        listapaginada = lista.Take(paginacion.Mostrar).ToList();
    }

    private void PaginaSiguiente()
    {
        if (PaginaActual < Paginas)
        {
            PaginaActual++;
            listapaginada = lista
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }
    private void Mover()
    {
        if (PaginaActual < Paginas)
        {
            PaginaActual++;
            listapaginada = lista
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
        else if (PaginaActual > 1)
        {
            PaginaActual--;
            listapaginada = lista
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
            listapaginada = lista
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }




    private void Buscar()
    {
        try
        {
            if (Filtro == null)
            {
                toast.ShowWarning("Selecciones un filtro");
            }
            else
            {
                if (Filtro != null)
                {

                    switch (Filtro)
                    {
                        case "Todo":
                            lista= ClienteBLL.GetList(e => true);

                            break;
                        case "Id":
                            lista = ClienteBLL.GetList(e => e.ClienteId == Convert.ToInt32(Criterio));
                            break;
                        case "Nombre":
                            lista = ClienteBLL.GetList(e => e.Nombre == Criterio);
                            break;
                        case "Cedula":
                            lista = ClienteBLL.GetList(e => e.Cedula == Criterio);
                            break;

                    }
                }
                else
                {
                    toast.ShowWarning("debes de insertar un dato al criterio");
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
