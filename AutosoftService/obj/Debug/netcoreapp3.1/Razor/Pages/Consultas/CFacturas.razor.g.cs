#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8248ee5746d0a6bfcfc2a96ea0c1c92537172195"
// <auto-generated/>
#pragma warning disable 1591
namespace AutosoftService.Pages.Consultas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
using AutosoftService.Model.Consultas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
using AutosoftService.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                 listaFacturas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "card");
                __builder2.AddMarkupContent(6, "\r\n\r\n        ");
                __builder2.AddMarkupContent(7, "<div class=\"card-header\">\r\n            <center>\r\n                <h1>Consulta de Facturas</h1>\r\n            </center>\r\n        </div>\r\n\r\n\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-body");
                __builder2.AddMarkupContent(10, "\r\n\r\n            ");
                __builder2.OpenElement(11, "form");
                __builder2.AddMarkupContent(12, "\r\n\r\n                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-row");
                __builder2.AddMarkupContent(15, "\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n                   \r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.AddMarkupContent(19, "<label for=\"Filtro\" class=\"LabelConsulta     col-sm-3     col-md-2\">Filtro: </label>\r\n                        ");
                __builder2.OpenElement(20, "select");
                __builder2.AddAttribute(21, "class", "form-control     col-sm-8     col-md-9");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                                                      Filtro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filtro = __value, Filtro));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "option");
                __builder2.AddAttribute(26, "value", "0");
                __builder2.AddContent(27, "Todo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenElement(29, "option");
                __builder2.AddAttribute(30, "value", "1");
                __builder2.AddContent(31, "Codigo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "option");
                __builder2.AddAttribute(34, "value", "2");
                __builder2.AddContent(35, "Cliente");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __builder2.OpenElement(37, "option");
                __builder2.AddAttribute(38, "value", "3");
                __builder2.AddContent(39, "Total");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.AddMarkupContent(46, "<label for=\"Criterio\" class=\"LabelConsulta     col-sm-3      col-md-2\">Criterio: </label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control     col-sm-8     col-md-9");
                __builder2.AddAttribute(49, "placeholder", "Criterio");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                 Criterio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Criterio = __value, Criterio))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Criterio));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n                    <br>\r\n\r\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "DivConsulta text-center     col-12");
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "class", "ml-1");
                __builder2.AddAttribute(60, "type", "checkbox");
                __builder2.AddAttribute(61, "style", "margin-top:15px");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                                         FiltrarFecha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FiltrarFecha = __value, FiltrarFecha));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "&nbsp;&nbsp;Filtrar por Fecha\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n\r\n                    \r\n                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(68, "\r\n                        ");
                __builder2.AddMarkupContent(69, "<label for=\"Desde\" class=\"LabelConsulta     col-sm-3     col-md-2\">Desde: </label>\r\n                        ");
                __Blazor.AutosoftService.Pages.Consultas.CFacturas.TypeInference.CreateInputDate_0(__builder2, 70, 71, "form-control     col-sm-8     col-md-9", 72, 
#nullable restore
#line 61 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                 Desde

#line default
#line hidden
#nullable disable
                , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Desde = __value, Desde)), 74, () => Desde);
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                    \r\n                    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __builder2.AddMarkupContent(80, "<label for=\"Hasta\" class=\"LabelConsulta     col-sm-3     col-md-2\">Hasta: </label>\r\n                        ");
                __Blazor.AutosoftService.Pages.Consultas.CFacturas.TypeInference.CreateInputDate_1(__builder2, 81, 82, "form-control     col-sm-8     col-md-9", 83, 
#nullable restore
#line 67 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                 Hasta

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Hasta = __value, Hasta)), 85, () => Hasta);
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\r\n                    ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "DivConsulta text-center     container     col-sm-12     col-md-12          col-lg-1     col-xl-1");
                __builder2.AddMarkupContent(90, "\r\n                        ");
                __builder2.OpenElement(91, "button");
                __builder2.AddAttribute(92, "type", "button");
                __builder2.AddAttribute(93, "class", "btn btn-primary");
                __builder2.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                                                Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(95, " Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n\r\n                    ");
                __builder2.OpenElement(98, "table");
                __builder2.AddAttribute(99, "class", "table");
                __builder2.AddAttribute(100, "style", "margin-top: 20px");
                __builder2.AddMarkupContent(101, "\r\n                        ");
                __builder2.AddMarkupContent(102, @"<thead class=""thead-light"">
                            <tr>
                                <th>Codigo</th>
                                <th>Servicio</th>
                                <th>Cliente</th>
                                <th>Total</th>
                                <th>Fecha</th>
                                <th></th>
                            </tr>
                        </thead>
                        ");
                __builder2.OpenElement(103, "tbody");
                __builder2.AddMarkupContent(104, "\r\n");
#nullable restore
#line 90 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                             if (Listado.Count == 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(105, "                                ");
                __builder2.AddMarkupContent(106, "<tr>\r\n                                    <th colspan=\"12\" style=\"color:black; text-align: center\">\"No hay datos que mostrar\"</th>\r\n                                </tr>\r\n");
#nullable restore
#line 95 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                            }
                            else
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                 foreach (var item in ListadoPaginado)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(107, "                        ");
                __builder2.OpenElement(108, "tr");
                __builder2.AddMarkupContent(109, "\r\n                                    ");
                __builder2.OpenElement(110, "th");
                __builder2.AddContent(111, 
#nullable restore
#line 102 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                         item.FacturaId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                                    ");
                __builder2.OpenElement(113, "th");
                __builder2.AddContent(114, 
#nullable restore
#line 103 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                         item.Servicios

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                                    ");
                __builder2.OpenElement(116, "th");
                __builder2.AddContent(117, 
#nullable restore
#line 104 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                         item.Cliente

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                                    ");
                __builder2.OpenElement(119, "th");
                __builder2.AddContent(120, 
#nullable restore
#line 105 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                         item.Total.ToString("N2")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                                    ");
                __builder2.OpenElement(122, "th");
                __builder2.AddContent(123, 
#nullable restore
#line 106 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                         item.Fecha.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                                    ");
                __builder2.OpenElement(125, "th");
                __builder2.OpenElement(126, "a");
                __builder2.AddAttribute(127, "class", "btn btn-light");
                __builder2.AddAttribute(128, "href", "rFacturas/" + (
#nullable restore
#line 107 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                                                  item.FacturaId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(129, "Ver");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n");
#nullable restore
#line 109 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(132, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n\r\n                <br>\r\n\r\n\r\n                ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "form-inline justify-content-end");
                __builder2.AddMarkupContent(138, "\r\n                    ");
                __builder2.AddMarkupContent(139, "<label>Total:&nbsp;</label>\r\n                    ");
                __builder2.OpenElement(140, "input");
                __builder2.AddAttribute(141, "type", "number");
                __builder2.AddAttribute(142, "step", "1.0");
                __builder2.AddAttribute(143, "disabled", true);
                __builder2.AddAttribute(144, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 121 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                                  Total

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(145, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Total = __value, Total, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "card-footer");
                __builder2.AddMarkupContent(152, "\r\n            ");
                __builder2.OpenElement(153, "div");
                __builder2.AddAttribute(154, "class", "form-row col-12 justify-content-center");
                __builder2.AddMarkupContent(155, "\r\n                ");
                __builder2.OpenElement(156, "nav");
                __builder2.AddAttribute(157, "aria-label", "Page navigation example");
                __builder2.AddMarkupContent(158, "\r\n                    ");
                __builder2.OpenElement(159, "ul");
                __builder2.AddAttribute(160, "class", "pagination");
                __builder2.AddMarkupContent(161, "\r\n                        ");
                __builder2.OpenElement(162, "li");
                __builder2.AddAttribute(163, "class", "page-item");
                __builder2.AddMarkupContent(164, "\r\n                            ");
                __builder2.OpenElement(165, "a");
                __builder2.AddAttribute(166, "class", "page-link");
                __builder2.AddAttribute(167, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 135 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                           PaginaAnterior

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(168, "\r\n                                <span class=\"oi oi-media-skip-backward\"></span>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(169, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(170, "\r\n\r\n");
#nullable restore
#line 140 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                         for (int i = 1; i <= Paginas; i++)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(171, "                            ");
                __builder2.OpenElement(172, "li");
                __builder2.AddAttribute(173, "class", "page-item disabled");
                __builder2.OpenElement(174, "a");
                __builder2.AddAttribute(175, "class", "page-link");
                __builder2.AddContent(176, 
#nullable restore
#line 142 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                                                 i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(177, "\r\n");
#nullable restore
#line 143 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(178, "\r\n                        ");
                __builder2.OpenElement(179, "li");
                __builder2.AddAttribute(180, "class", "page-item");
                __builder2.AddMarkupContent(181, "\r\n                            ");
                __builder2.OpenElement(182, "a");
                __builder2.AddAttribute(183, "class", "page-link");
                __builder2.AddAttribute(184, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 146 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
                                                           PaginaSiguiente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(185, "\r\n                                <span class=\"oi oi-media-skip-forward\"></span>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(187, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(188, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(189, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(190, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(191, "\r\n      \r\n\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(192, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 163 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CFacturas.razor"
       


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
namespace __Blazor.AutosoftService.Pages.Consultas.CFacturas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
