#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa3c7241eaa1bcf5eb67171307f2041285e2ceb"
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
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RUsuarios")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RUsuarios/{Id:int}")]
    public partial class RUsuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
       
    Usuarios usuarios = new Usuarios();

    [Parameter]
    public int Id { get; set; }

    protected override void OnInitialized()
    {
        Nuevo();
        if (Id > 0)
        {
            var Auxclientes = UsuarioBLL.Buscar(Id);
            if (Auxclientes != null)
                this.usuarios = Auxclientes;
            else
                toast.ShowWarning("No encontrado.");
        }


    }
    private void Nuevo()
    {
        this.usuarios = new Usuarios();
    }
    private void Guardar()
    {
        bool paso;
        if (usuarios.Contrasena != usuarios.ConfirmarContrasena)
        {
            usuarios.Contrasena = string.Empty;
            usuarios.ConfirmarContrasena = string.Empty;
            toast.ShowWarning("Las Claves No coinciden  !Por favor Intente de Nuevo");
        }
        else
        {
            paso = UsuarioBLL.Guardar(usuarios);
            if (paso)
            {

                Nuevo();
                toast.ShowSuccess("Guardado Correctamente");
            }
            else
            {
                toast.ShowError("No fue posible guardar");
            }
        }

    }

    private void Buscar()
    {
        var encontrado = UsuarioBLL.Buscar(usuarios.UsuarioId);
        if (encontrado != null)
        {

            this.usuarios = encontrado;
        }
        else
        {
            toast.ShowWarning("No encontrado");
        }
    }

    private void Eliminar()
    {
        bool eliminar;

        eliminar = UsuarioBLL.Eliminar(usuarios.UsuarioId);

        if (eliminar)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado Correctamente");
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
    }
}
#pragma warning restore 1591
