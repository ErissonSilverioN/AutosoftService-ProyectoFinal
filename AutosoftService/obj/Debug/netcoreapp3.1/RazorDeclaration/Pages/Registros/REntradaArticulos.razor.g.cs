#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\Pages\Registros\REntradaArticulos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6402cf64d53e43d4861abb255db8f98edba9a14d"
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
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\Pages\Registros\REntradaArticulos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\Pages\Registros\REntradaArticulos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/REntradaArticulos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/REntradaArticulos/{EntradasArtId:int}")]
    public partial class REntradaArticulos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal11\AutosoftService\Pages\Registros\REntradaArticulos.razor"
       

    [Parameter]
    public int EntradasArtId { get; set; }

    private EntradasArticulos entradasArticulos = new EntradasArticulos();

    Articulos articulos = new Articulos();
    ArticuloBLL articuloBLL = new ArticuloBLL();
    private List<Articulos> listaarticulos = new List<Articulos>();
    private string ArticuloSelect { get; set; }





    protected override void OnInitialized()
    {

        listaarticulos = ArticuloBLL.GetList(e => true);
        entradasArticulos = new EntradasArticulos();
        Limpiar();
      
        if (EntradasArtId != 0)
        {
            entradasArticulos.EntradasArtId = EntradasArtId;
            Buscar();
        }
        base.OnInitialized();
    }


    private void Buscar()
    {
        EntradasArticulos entradaTemp = BLL.EntradaArtBLL.Buscar(entradasArticulos.EntradasArtId);

        if (entradaTemp != null)
        {
            Limpiar();
            entradasArticulos = entradaTemp;
            ArticuloSelect = entradasArticulos.EntradasArtId.ToString();


        }
        else
        {

            Limpiar();
            toast.ShowError("La Entrada no Existe", "Fallo");

        }
    }


    private void Limpiar()
    {

        this.entradasArticulos = new EntradasArticulos();
        ArticuloSelect = "0";




    }




    private void Guardar()
    {
        LlenaCombo();

        if (EntradaArtBLL.Guardar(entradasArticulos))
        {
            Limpiar();
            ArticuloSelect = "0";
            toast.ShowSuccess("Entrada guardada correctamente", "Exito");

        }
        else
        {
            toast.ShowError("Error al guardar la entrada", "Fallo");
        }

    }



    private void Eliminar()
    {
        EntradasArticulos entradaTemp = EntradaArtBLL.Buscar(entradasArticulos.EntradasArtId);

        if (entradaTemp != null)
        {
            if (EntradaArtBLL.Eliminar(entradasArticulos.EntradasArtId))
            {
                Limpiar();
                toast.ShowSuccess("Entrada eliminada correctamente.", "Exito");


            }
            else
            {
                toast.ShowError("Error al eliminar la entrada", "Fallo");

            }
        }

    }


    private void LlenaCombo()
    {
        entradasArticulos.ArticuloId = Convert.ToInt32(ArticuloSelect);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
