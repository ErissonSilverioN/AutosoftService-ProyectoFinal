#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ecfd693532e66bc810f5040ef8eef5c000da16a"
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
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CProveedores")]
    public partial class CProveedor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                 listapaginada 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "card");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.AddMarkupContent(9, "<div class=\"card-header\" style=\"        background-color: #6378F0\r\n\">\r\n            <h3>Consultas De Proveedores</h3>\r\n        </div>\r\n\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "card-body");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "input-group mb-4");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "input-group");
                __builder2.AddMarkupContent(18, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(19, "<label for=\"filtro\">Filtro: </label>\r\n                    ");
                __builder2.OpenElement(20, "select");
                __builder2.AddAttribute(21, "class", "form-control ml-3 mr-3");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                                  Filtro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filtro = __value, Filtro));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "option");
                __builder2.AddAttribute(26, "value", true);
                __builder2.AddAttribute(27, "disabled", true);
                __builder2.AddAttribute(28, "selected", true);
                __builder2.AddContent(29, "Seleccione un filtro");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.OpenElement(31, "option");
                __builder2.AddAttribute(32, "value", "Todo");
                __builder2.AddContent(33, "Todo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.OpenElement(35, "option");
                __builder2.AddAttribute(36, "value", "ID");
                __builder2.AddContent(37, "ID");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                        ");
                __builder2.OpenElement(39, "option");
                __builder2.AddAttribute(40, "value", "Nombre");
                __builder2.AddContent(41, "Nombre");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.OpenElement(43, "option");
                __builder2.AddAttribute(44, "value", "RNC");
                __builder2.AddContent(45, "Rnc");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(48, "<label for=\"criterio ml-3 mr-3\"> Criterio: </label>\r\n                    ");
                __builder2.OpenElement(49, "input");
                __builder2.AddAttribute(50, "type", "search");
                __builder2.AddAttribute(51, "class", "form-control ml-3 mr-3");
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                                                     Criterio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Criterio = __value, Criterio));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n                    ");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "type", "button");
                __builder2.AddAttribute(57, "class", "btn btn-primary");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                                            Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(59, "Buscar ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n            ");
                __builder2.OpenElement(63, "table");
                __builder2.AddAttribute(64, "class", " table mb-3 mt-3");
                __builder2.AddAttribute(65, "id", "example");
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.AddMarkupContent(67, @"<thead class=""thead-light"">
                    <tr>
                        <th>ID</th>
                        <th style="" width:auto"">Nombre</th>
                        <th style="" width:auto"">Rnc</th>
                        <th style="" width:auto"">Telefono</th>
                        <th style="" width:auto"">Direccion</th>
                        <th style="" width:auto"">Email</th>
                        <th style="" width:auto"">Fecha</th>
                        <th style="" width:auto"">Cantidad Pedidos </th>

                    </tr>
                </thead>
                ");
                __builder2.OpenElement(68, "tbody");
                __builder2.AddMarkupContent(69, "\r\n\r\n");
#nullable restore
#line 51 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                     if (listapaginada.Count == 0)
                    {
                        toast.ShowWarning("No hay datos");
                    }
                    else
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                         foreach (var item in listapaginada)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(70, "                            ");
                __builder2.OpenElement(71, "tr");
                __builder2.AddAttribute(72, "class", "table-striped");
                __builder2.AddMarkupContent(73, "\r\n                                ");
                __builder2.OpenElement(74, "td");
                __builder2.AddAttribute(75, "style", " width:auto");
                __builder2.AddContent(76, 
#nullable restore
#line 61 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                         item.ProveedorId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                                ");
                __builder2.OpenElement(78, "td");
                __builder2.AddAttribute(79, "style", " width:auto");
                __builder2.AddContent(80, 
#nullable restore
#line 62 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                         item.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                ");
                __builder2.OpenElement(82, "td");
                __builder2.AddAttribute(83, "style", " width:auto");
                __builder2.AddContent(84, 
#nullable restore
#line 63 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                         item.RNC

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                                ");
                __builder2.OpenElement(86, "td");
                __builder2.AddAttribute(87, "style", " width:auto");
                __builder2.AddContent(88, 
#nullable restore
#line 64 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                         item.Telefono

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                                ");
                __builder2.OpenElement(90, "td");
                __builder2.AddAttribute(91, "style", " width:auto");
                __builder2.AddContent(92, 
#nullable restore
#line 65 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                         item.Direccion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                                ");
                __builder2.OpenElement(94, "td");
                __builder2.AddAttribute(95, "style", " width:auto");
                __builder2.AddContent(96, 
#nullable restore
#line 66 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                         item.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                                ");
                __builder2.OpenElement(98, "td");
                __builder2.AddContent(99, 
#nullable restore
#line 67 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                     item.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                                ");
                __builder2.OpenElement(101, "td");
                __builder2.AddAttribute(102, "style", " width:auto");
                __builder2.AddContent(103, 
#nullable restore
#line 68 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                         item.CantidadPedidos

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n");
#nullable restore
#line 70 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                         
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(106, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n\r\n            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "card-footer text-center");
                __builder2.AddMarkupContent(111, "\r\n                ");
                __builder2.OpenElement(112, "button");
                __builder2.AddAttribute(113, "class", "btn btn-outline-success");
                __builder2.AddAttribute(114, "data-toggle", "modal");
                __builder2.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                                                      PDF

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "data-target", "#myModals");
                __builder2.AddMarkupContent(117, "<i class=\"oi oi-print\"></i> Generar Reporte");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n\r\n            ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "form-row col-12 justify-content-center");
                __builder2.AddMarkupContent(122, "\r\n                ");
                __builder2.OpenElement(123, "nav");
                __builder2.AddMarkupContent(124, "\r\n                    ");
                __builder2.OpenElement(125, "ul");
                __builder2.AddAttribute(126, "class", "pagination");
                __builder2.AddMarkupContent(127, "\r\n                        ");
                __builder2.OpenElement(128, "li");
                __builder2.AddAttribute(129, "class", "page-item bt");
                __builder2.AddMarkupContent(130, "\r\n                            ");
                __builder2.OpenElement(131, "a");
                __builder2.AddAttribute(132, "class", "page-link");
                __builder2.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                           PaginaAnterior

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(134, "\r\n                                <span class=\"oi oi-media-skip-backward \"></span>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n\r\n");
#nullable restore
#line 90 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                         for (int i = 1; i <= Paginas; i++)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(137, "                            ");
                __builder2.OpenElement(138, "li");
                __builder2.AddAttribute(139, "class", " " + (
#nullable restore
#line 92 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                          PaginaActual == i ? "text-danger" : "page-item"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                                                                      Mover

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(141, " ");
                __builder2.OpenElement(142, "a");
                __builder2.AddAttribute(143, "class", "page-link disabled");
                __builder2.AddContent(144, 
#nullable restore
#line 92 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                                                                                                             i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n");
#nullable restore
#line 93 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"

                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(146, "\r\n                        ");
                __builder2.OpenElement(147, "li");
                __builder2.AddAttribute(148, "class", "page-item");
                __builder2.AddMarkupContent(149, "\r\n                            ");
                __builder2.OpenElement(150, "a");
                __builder2.AddAttribute(151, "class", "page-link");
                __builder2.AddAttribute(152, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                                           PaginaSiguiente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(153, "\r\n                                <span class=\"oi oi-media-skip-forward \"></span>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(161, "\r\n\r\n\r\n");
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "class", "modal fade");
            __builder.AddAttribute(164, "id", "myModals");
            __builder.AddAttribute(165, "tabindex", "-1");
            __builder.AddAttribute(166, "role", "dialog");
            __builder.AddAttribute(167, "aria-labelledby", "myModalsLabel");
            __builder.AddAttribute(168, "aria-hidden", "true");
            __builder.AddMarkupContent(169, "\r\n    ");
            __builder.OpenElement(170, "div");
            __builder.AddAttribute(171, "class", "modal-dialog");
            __builder.AddMarkupContent(172, "\r\n        ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "modal-content m-md-auto");
            __builder.AddMarkupContent(175, "\r\n            ");
            __builder.AddMarkupContent(176, "<div class=\"modal-header\">\r\n                <button type=\"button\" class=\"close text-danger\" data-dismiss=\"modal\" aria-hidden=\"true\">×</button>\r\n                <h4 class=\"modal-title\"></h4>\r\n            </div>\r\n            ");
            __builder.OpenElement(177, "div");
            __builder.AddAttribute(178, "class", "modal-body");
            __builder.AddMarkupContent(179, "\r\n                ");
            __builder.OpenElement(180, "div");
            __builder.AddAttribute(181, "style", "text-align: center;");
            __builder.AddMarkupContent(182, "\r\n                    ");
            __builder.OpenElement(183, "iframe");
            __builder.AddAttribute(184, "src", 
#nullable restore
#line 120 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
                                  pdfContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(185, "style", "width:950px; height:600px;");
            __builder.AddAttribute(186, "frameborder", "0");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n            ");
            __builder.AddMarkupContent(190, "<div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal13\AutosoftService\Pages\Consultas\CProveedor.razor"
       

    private List<Proveedores> lista { get; set; }
    private List<Proveedores> listapaginada { get; set; }
    Paginacion paginacion = new Paginacion();

    private string Filtro { get; set; }
    private string Criterio { get; set; }

    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;

    public byte[] Data { get; set; }
    public string pdfContent { get; set; }


    ProveedorBLL proveedorBLL = new ProveedorBLL();



    protected override void OnInitialized()
    {
        lista = ProveedorBLL.GetList(C => true);
        Filtro = "Todo";
        IniciarPaginacion();
    }



    private void PDF()
    {
        AutosoftService.Pages.Reporte.ReporteProveedores co = new Reporte.ReporteProveedores();

        Data = co.Reporte();

        pdfContent = "data:application/pdf;base64,";
        pdfContent += System.Convert.ToBase64String(Data);
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
                            lista = ProveedorBLL.GetList(e => true);

                            break;
                        case "Id":
                            lista = ProveedorBLL.GetList(e => e.ProveedorId == Convert.ToInt32(Criterio));
                            break;
                        case "Nombre":
                            lista = ProveedorBLL.GetList(e => e.Nombre == Criterio);
                            break;
                        case "Rnc":
                            lista = ProveedorBLL.GetList(e => e.RNC == Criterio);
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
