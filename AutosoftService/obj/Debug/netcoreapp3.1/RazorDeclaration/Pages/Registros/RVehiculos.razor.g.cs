#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Registros\RVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b49b51642deaef854e25a3cc425cbd7776f39e2d"
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
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Registros\RVehiculos.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Registros\RVehiculos.razor"
using BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vehiculos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vehiculos/{VehiculoId:int}")]
    public partial class RVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal3\AutosoftService\Pages\Registros\RVehiculos.razor"
      

    [Parameter]
    public int VehiculoId { get; set; }

    Vehiculos vehiculos = new Vehiculos();

    private Usuarios Usuario = new Usuarios();

    public bool paso { get; set; }

    protected override void OnInitialized()
    {
        Nuevo();
        if (VehiculoId> 0)
        {
            var Auxvehiculos = VehiculoBLL.Buscar(VehiculoId);
            if (Auxvehiculos != null)
                this.vehiculos = Auxvehiculos;
            else
                toast.ShowWarning("No encontrado.");
        }


    }

    public List<Clientes> LlenarComboCliente()
    {
        List<Clientes> listaClientes = new List<Clientes>();

        try
        {
            listaClientes = ClienteBLL.GetList(c => true);
        }
        catch (Exception)
        {
            throw;
        }

        return listaClientes;
    }


    private void Nuevo()
    {
        this.vehiculos = new Vehiculos();

    }

    private void Buscar()
    {
        if (vehiculos.VehiculoId> 0)
        {
            var encontrado = VehiculoBLL.Buscar(vehiculos.VehiculoId);

            if (encontrado != null)
            {
                this.vehiculos = encontrado;
            }
            else
            {
                toast.ShowWarning("No encontrado");


            }
        }
    }

    private void Guardar()
    {
        bool guardo = VehiculoBLL.Guardar(vehiculos);

        if (guardo)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");

        }
        else
        {
            toast.ShowError("No fue posible guardar");

        }
    }

    private void Eliminar()
    {
        bool elimino;

        elimino = VehiculoBLL.Eliminar(vehiculos.VehiculoId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");

        }
        else
        {
            toast.ShowError("No fue posible eliminar");

        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
