#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Registros\RArticulos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ab05d8a67eef0aa0531f6cc02d40f7a480b490"
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
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Registros\RArticulos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Registros\RArticulos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RArticulos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RArticulos/{ArticuloId:int}")]
    public partial class RArticulos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 169 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Registros\RArticulos.razor"
       

    [Parameter]
    public int ArticuloId { get; set; }
    private Articulos articulos = new Articulos();

    private List<Proveedores> listaProveedores = new List<Proveedores>();
    Proveedores proveedores = new Proveedores();
    private string ProveedorSelect { get; set; }




    protected override void OnInitialized()
    {

        listaProveedores = BLL.ProveedorBLL.GetList(e => true);
        articulos = new Articulos();
        Limpiar();
        if (ArticuloId != 0)
        {
            articulos.ArticuloId = ArticuloId;
            Buscar();
        }
        base.OnInitialized();
    }



    private void Buscar()
    {
        Articulos artTemp = BLL.ArticuloBLL.Buscar(articulos.ArticuloId);

        if (artTemp != null)
        {
            Limpiar();
            articulos = artTemp;
            ProveedorSelect = articulos.ArticuloId.ToString();

            CalcularPrecio();
            toas.ShowSuccess("Articulo encontrado.", "Exito");

        }
        else
        {

            Limpiar();
            toas.ShowError("El Artculo no fue encontrado", "Fallo");

        }
    }


    private void Guardar()
    {

        SeleccionarProveedor();
        CalcularPrecio();

        if (ArticuloBLL.Guardar(articulos))
        {
            Limpiar();
            toas.ShowSuccess("Articulo guardado correctamente", "Exito");

        }
        else
        {
            toas.ShowError("Error al guardar el Articulo", "Fallo");

        }
    }


    private void Eliminar()
    {
        Articulos artTemp = ArticuloBLL.Buscar(articulos.ArticuloId);

        if (artTemp != null)
        {
            if (ArticuloBLL.Eliminar(articulos.ArticuloId))
            {
                Limpiar();
                toas.ShowSuccess("Articulo eliminado correctamente", "Exito");
                CalcularPrecio();

            }
            else
            {
                toas.ShowError("Error al eliminar el Articulo.", "Fallo");

            }
        }
        else
        {
            toas.ShowError("Error al eliminar el Articulo.", "Fallo");

        }
    }


    private void Limpiar()
    {
        this.articulos = new Articulos();


    }


    private void SeleccionarProveedor()
    {
        articulos.ProveedorId = Convert.ToInt32(ProveedorSelect);
    }




    public void CalcularPrecio()
    {
        decimal Result = 0;

        Result = articulos.Costo + (articulos.Costo * (articulos.Ganancias / 100));

        articulos.Precio = Convert.ToDecimal(Result.ToString("N2"));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toas { get; set; }
    }
}
#pragma warning restore 1591
