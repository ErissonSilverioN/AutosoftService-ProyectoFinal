#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a12f02439e45d7d8285acff039faea47e80d764b"
// <auto-generated/>
#pragma warning disable 1591
namespace AutosoftService.Pages
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
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Index.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n\r\n\r\n        ");
                __builder2.AddMarkupContent(3, "<div class=\"card\">\r\n\r\n            <div class=\"card-header-tabs\">\r\n\r\n                <h2 class=\"text-center\" style=\"        background-color: #eedb7e;\r\n        font-family: \'Lucida Sans\', \'Lucida Sans Regular\', \'Lucida Grande\', \'Lucida Sans Unicode\', Geneva, Verdana, sans-serif;\r\n        color: #0f1e71\">\r\n                    ¿QUE ES AUTOSOFT SERVICE?\r\n                </h2>\r\n\r\n            </div>\r\n\r\n            <div class=\"card-body\" style=\"align-content:center\">\r\n\r\n                <img src=\"Resources/Logo.jpeg\" class=\"align-items-md-center\" cont alt=\"Logoweb\" height=\"400\" width=\"400\" style=\"border-radius: 25px; align-content:space-between\">\r\n\r\n                <br>\r\n                <br>\r\n\r\n                <div class=\"align-content-end\">\r\n                    <p>\r\n                        <b>\r\n                            AUTOSOFT SERVICE es una aplicacion web consebida para pequeños y medianos negocio del campo automatriz, esta busca sistematizar los\r\n                            principales procesos que se llevan a cabo en la praxis de estos negocio. Es una aplicacion desarrollada en el ecositema tecnologico de Microsoft,\r\n                            con tecnologias tendencias como son ASP.NET CORE, SQL Server y Blazor Server.\r\n                        </b>\r\n                    </p>\r\n                </div>\r\n                <br>\r\n\r\n                <div class=\"card-header-tabs\">\r\n\r\n                    <h2 class=\"text-center\" style=\"  background-color: #eedb7e; font-family:\'Lucida Sans\', \'Lucida Sans Regular\', \'Lucida Grande\', \'Lucida Sans Unicode\', Geneva, Verdana, sans-serif; color:#0f1e71\r\n\">\r\n                       PRINCIPALES MODULOS\r\n                    </h2>\r\n\r\n                </div>\r\n\r\n\r\n                <div class=\"card\" style=\"border-bottom-style\">\r\n                    <img src=\"Resources/Register.png\" height=\"225\" width=\"225\" alt=\"...\">\r\n                    <div class=\"card-body\" style=\"font-family:\'Gill Sans\', \'Gill Sans MT\', Calibri, \'Trebuchet MS\', sans-serif\">\r\n                        <h5 class=\"card-title\"><b>Registros de transacciones</b></h5>\r\n                        <p class=\"card-text\">En Autosoft Servive cuenta con un modulo para realizar el registro de casi todas sus transacciones de su negocio,\r\n                                             eficientizando asi los procesos  para tener la informacion de su negocio de manera segura y accesible.</p>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n                <div class=\"card\">\r\n                    <img src=\"Resources/Consultar.png\" height=\"225\" width=\"225\" alt=\"...\">\r\n                    <div class=\"card-body\" style=\"font-family:\'Gill Sans\', \'Gill Sans MT\', Calibri, \'Trebuchet MS\', sans-serif\">\r\n                        <h5 class=\"card-title\"><b>Consultas</b></h5>\r\n                        <p class=\"card-text\">La app de igual forma brinda la opcion consultar los datos previamente almacenados, mediante este modulo puede llevar el \r\n                                            control de su negocio, teniendo la oportunidad de saber como se encuentra en un momento determinado. \r\n                                            En otras palabras, es un modulo por el cual se puede monitorear la informacion contenida en su negocio.</p>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n            <div class=\"card-footer\">\r\n                <h4 class=\"text-center\">\r\n                    GRACIAS POR SU VISITA\r\n                </h4>\r\n                <div class=\"text-center\">\r\n                    <h5>\r\n                        © 2020 Derechos reservados, AUTOSOFT SERRVICE APP.\r\n                    </h5>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
