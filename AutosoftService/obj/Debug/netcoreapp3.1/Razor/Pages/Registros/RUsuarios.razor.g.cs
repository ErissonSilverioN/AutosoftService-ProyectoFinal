#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa3c7241eaa1bcf5eb67171307f2041285e2ceb"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                 usuarios

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card w-100");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n            <h3>Registro de Usuarios</h3>\r\n        </div>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "form");
                __builder2.AddMarkupContent(15, "\r\n\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col");
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.AddMarkupContent(25, "<label>Id</label>\r\n                            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "input-group");
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateInputNumber_0(__builder2, 29, 30, "form-control col-4", 31, 
#nullable restore
#line 24 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                                          usuarios.UsuarioId

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuarios.UsuarioId = __value, usuarios.UsuarioId)), 33, () => usuarios.UsuarioId);
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 25 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                                          () => usuarios.UsuarioId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\r\n                                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "input-group-append");
                __builder2.AddMarkupContent(40, "\r\n                                    ");
                __builder2.OpenElement(41, "button");
                __builder2.AddAttribute(42, "type", "button");
                __builder2.AddAttribute(43, "class", "btn btn-primary");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                                                                            Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(45, " <i class=\"fa fa-search\"></i>  Buscar ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.AddMarkupContent(55, "<label>Nombres</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "class", "form-control ");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                            usuarios.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuarios.Nombre = __value, usuarios.Nombre))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuarios.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateValidationMessage_2(__builder2, 62, 63, 
#nullable restore
#line 37 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                              () => usuarios.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.AddMarkupContent(69, "<label>Apellidos</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "class", "form-control ");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                            usuarios.Apellidos

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuarios.Apellidos = __value, usuarios.Apellidos))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuarios.Apellidos));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateValidationMessage_3(__builder2, 76, 77, 
#nullable restore
#line 43 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                              () => usuarios.Apellidos

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "\r\n                    ");
                __builder2.AddMarkupContent(83, "<label>Email</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                __builder2.AddAttribute(85, "class", "form-control ");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                            usuarios.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuarios.Email = __value, usuarios.Email))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuarios.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateValidationMessage_4(__builder2, 90, 91, 
#nullable restore
#line 49 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                              () => usuarios.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(92, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "form-group");
                __builder2.AddMarkupContent(96, "\r\n                    ");
                __builder2.AddMarkupContent(97, "<label>Nombre de usuario:</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(98);
                __builder2.AddAttribute(99, "class", "form-control ");
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                            usuarios.Usuario

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuarios.Usuario = __value, usuarios.Usuario))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuarios.Usuario));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateValidationMessage_5(__builder2, 104, 105, 
#nullable restore
#line 55 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                              () => usuarios.Usuario

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(106, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group");
                __builder2.AddMarkupContent(110, "\r\n                    ");
                __builder2.AddMarkupContent(111, "<label>Roles de usuarios</label>\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateInputSelect_6(__builder2, 112, 113, "form-control", 114, 
#nullable restore
#line 60 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                               usuarios.NivelUsuario

#line default
#line hidden
#nullable disable
                , 115, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuarios.NivelUsuario = __value, usuarios.NivelUsuario)), 116, () => usuarios.NivelUsuario, 117, (__builder3) => {
                    __builder3.AddMarkupContent(118, "\r\n                        ");
                    __builder3.AddMarkupContent(119, "<option value disabled selected>Seleccione un Rol</option>\r\n                        ");
                    __builder3.AddMarkupContent(120, "<option value=\"Administrador\">Administrador</option>\r\n                        ");
                    __builder3.AddMarkupContent(121, "<option value=\"Empleado\">Empleado</option>\r\n                        ");
                    __builder3.AddMarkupContent(122, "<option value=\"Normal\">Normal</option>\r\n                    ");
                }
                );
                __builder2.AddMarkupContent(123, "\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateValidationMessage_7(__builder2, 124, 125, 
#nullable restore
#line 66 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                              () => usuarios.NivelUsuario

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(126, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "form-group");
                __builder2.AddMarkupContent(130, "\r\n                    ");
                __builder2.AddMarkupContent(131, "<label>Clave</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(132);
                __builder2.AddAttribute(133, "type", "password");
                __builder2.AddAttribute(134, "class", "form-control ");
                __builder2.AddAttribute(135, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                                                                  usuarios.Contrasena

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(136, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuarios.Contrasena = __value, usuarios.Contrasena))));
                __builder2.AddAttribute(137, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuarios.Contrasena));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateValidationMessage_8(__builder2, 139, 140, 
#nullable restore
#line 72 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                              () => usuarios.Contrasena

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(141, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n\r\n                ");
                __builder2.OpenElement(143, "div");
                __builder2.AddAttribute(144, "class", "form-group");
                __builder2.AddMarkupContent(145, "\r\n                    ");
                __builder2.AddMarkupContent(146, "<label>Confirmar Clave</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(147);
                __builder2.AddAttribute(148, "type", "password");
                __builder2.AddAttribute(149, "class", "form-control ");
                __builder2.AddAttribute(150, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                                                                  usuarios.ConfirmarContrasena

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(151, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuarios.ConfirmarContrasena = __value, usuarios.ConfirmarContrasena))));
                __builder2.AddAttribute(152, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => usuarios.ConfirmarContrasena));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(153, "\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateValidationMessage_9(__builder2, 154, 155, 
#nullable restore
#line 79 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                              () => usuarios.ConfirmarContrasena

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(156, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n                ");
                __builder2.OpenElement(158, "div");
                __builder2.AddAttribute(159, "class", "form-group");
                __builder2.AddMarkupContent(160, "\r\n                    ");
                __builder2.AddMarkupContent(161, "<label>Fecha</label>\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateInputDate_10(__builder2, 162, 163, "form-control ", 164, 
#nullable restore
#line 84 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                            usuarios.FechaIngreso

#line default
#line hidden
#nullable disable
                , 165, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => usuarios.FechaIngreso = __value, usuarios.FechaIngreso)), 166, () => usuarios.FechaIngreso);
                __builder2.AddMarkupContent(167, "\r\n                    ");
                __Blazor.AutosoftService.Pages.Registros.RUsuarios.TypeInference.CreateValidationMessage_11(__builder2, 168, 169, 
#nullable restore
#line 85 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                              () => usuarios.FechaIngreso

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(170, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(171, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\r\n        ");
                __builder2.OpenElement(174, "div");
                __builder2.AddAttribute(175, "class", "card-footer");
                __builder2.AddMarkupContent(176, "\r\n            ");
                __builder2.OpenElement(177, "div");
                __builder2.AddAttribute(178, "class", "form-group text-center");
                __builder2.AddAttribute(179, "display:", true);
                __builder2.AddAttribute(180, "inline-block", true);
                __builder2.AddMarkupContent(181, "\r\n                ");
                __builder2.OpenElement(182, "button");
                __builder2.AddAttribute(183, "type", "button");
                __builder2.AddAttribute(184, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(185, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                                                               Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(186, "<i class=\"fa fa-plus\"></i> Nuevo ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(187, "\r\n                ");
                __builder2.AddMarkupContent(188, "<button type=\"submit\" class=\"btn btn-lg btn-success\"><i class=\"fa fa-save\"></i> Guardar </button>\r\n                ");
                __builder2.OpenElement(189, "button");
                __builder2.AddAttribute(190, "type", "button");
                __builder2.AddAttribute(191, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(192, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal5\AutosoftService\Pages\Registros\RUsuarios.razor"
                                                                              Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(193, "<i class=\"fa fa-trash\"></i> Eliminar ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(194, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(196, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(197, "\r\n\r\n\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.AutosoftService.Pages.Registros.RUsuarios
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
