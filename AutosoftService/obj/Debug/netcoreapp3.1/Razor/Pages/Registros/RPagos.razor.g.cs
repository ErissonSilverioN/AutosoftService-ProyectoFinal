#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b82cccfe7ad6d74280ede02c2f7dfede663be5a9"
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
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RPagos")]
    public partial class RPagos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                     pagos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                           Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card");
                __builder2.AddMarkupContent(9, "\r\n\r\n            ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n                <div class=\"text-center\">\r\n                    <h3>Registro de Pagos</h3>\r\n                </div>\r\n            </div>\r\n\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n\r\n                ");
                __builder2.OpenElement(14, "form");
                __builder2.AddMarkupContent(15, "\r\n\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-row");
                __builder2.AddMarkupContent(18, "\r\n\r\n                        <div class=\"col-sm-0     col-md-0     col-lg-0     col-xl-1\"></div>\r\n\r\n\r\n                        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group col-sm-5     col-md-5     col-lg-3     col-xl-3     ");
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.AddMarkupContent(22, "<label>Pago ID</label>\r\n                            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "input-group ");
                __builder2.AddMarkupContent(25, "\r\n                                ");
                __Blazor.AutosoftService.Pages.Registros.RPagos.TypeInference.CreateInputNumber_0(__builder2, 26, 27, "form-control", 28, 
#nullable restore
#line 29 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                           pagos.PagoId

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pagos.PagoId = __value, pagos.PagoId)), 30, () => pagos.PagoId);
                __builder2.AddMarkupContent(31, "\r\n                                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "input-group-append");
                __builder2.AddMarkupContent(34, "\r\n                                    ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "type", "button");
                __builder2.AddAttribute(37, "class", "btn btn-primary");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                                                            Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(39, "<span class=\"oi oi-magnifying-glass\"></span>&nbsp;&nbsp;Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n\r\n                        <div class=\"col-sm-2   col-md-2   col-lg-6  col-xl-4\"></div>\r\n\r\n\r\n                        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group col-sm-5     col-md-5     col-lg-3     col-xl-3     ");
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.AddMarkupContent(47, "<label>Fecha</label>\r\n                            ");
                __Blazor.AutosoftService.Pages.Registros.RPagos.TypeInference.CreateInputDate_1(__builder2, 48, 49, "form-control", 50, 
#nullable restore
#line 42 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                     pagos.Fecha

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pagos.Fecha = __value, pagos.Fecha)), 52, () => pagos.Fecha);
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n\r\n                        <div class=\"col-sm-2   col-md-2   col-lg-0  col-xl-0\"></div>\r\n\r\n                        <br>\r\n                        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group col-sm-8     col-md-8     col-lg-8     col-xl-8    ");
                __builder2.AddMarkupContent(57, "\r\n                            ");
                __builder2.AddMarkupContent(58, "<label><b>Clientes</b></label>\r\n                            ");
                __Blazor.AutosoftService.Pages.Registros.RPagos.TypeInference.CreateInputSelect_2(__builder2, 59, 60, "form-control", 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                                                                      LlenarComboxCliente

#line default
#line hidden
#nullable disable
                ), 62, 
#nullable restore
#line 51 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                                           pagos.ClienteId

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pagos.ClienteId = __value, pagos.ClienteId)), 64, () => pagos.ClienteId, 65, (__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n                                ");
                    __builder3.AddMarkupContent(67, "<option value=\"0\">---Seleccione un Cliente---</option>\r\n\r\n");
#nullable restore
#line 54 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                 foreach (var item in ListaCliente)
                                                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(68, "                                ");
                    __builder3.OpenElement(69, "option");
                    __builder3.AddAttribute(70, "value", 
#nullable restore
#line 56 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                item.ClienteId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(71, 
#nullable restore
#line 56 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                                 item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(72, ".");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\r\n");
#nullable restore
#line 57 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(74, "\r\n                            ");
                }
                );
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                       \r\n\r\n                        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group col-sm-4     col-md-4     col-lg-1    col-xl-1     ");
                __builder2.AddMarkupContent(79, "\r\n                            ");
                __builder2.AddMarkupContent(80, "<label>Deuda</label>\r\n                            ");
                __Blazor.AutosoftService.Pages.Registros.RPagos.TypeInference.CreateInputNumber_3(__builder2, 81, 82, "form-control", 83, "true", 84, 
#nullable restore
#line 66 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                       deuda

#line default
#line hidden
#nullable disable
                , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => deuda = __value, deuda)), 86, () => deuda);
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n                        <div class=\"col-sm-2   col-md-2   col-lg-0  col-xl-0\"></div>\r\n\r\n                        ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group col-sm-6     col-md-6     col-lg-4     col-xl-4    ");
                __builder2.AddMarkupContent(91, "\r\n                            ");
                __builder2.AddMarkupContent(92, "<label>Monto a pagar</label>\r\n                            ");
                __Blazor.AutosoftService.Pages.Registros.RPagos.TypeInference.CreateInputNumber_4(__builder2, 93, 94, "form-control", 95, 
#nullable restore
#line 73 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                       pagos.Monto

#line default
#line hidden
#nullable disable
                , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => pagos.Monto = __value, pagos.Monto)), 97, () => pagos.Monto);
                __builder2.AddMarkupContent(98, "\r\n                            ");
                __Blazor.AutosoftService.Pages.Registros.RPagos.TypeInference.CreateValidationMessage_5(__builder2, 99, 100, 
#nullable restore
#line 74 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                    (() => pagos.Monto)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(101, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n\r\n            ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "card-footer");
                __builder2.AddMarkupContent(108, "\r\n                ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-group text-center");
                __builder2.AddAttribute(111, "display:", true);
                __builder2.AddAttribute(112, "inline-block", true);
                __builder2.AddMarkupContent(113, "\r\n                    ");
                __builder2.OpenElement(114, "button");
                __builder2.AddAttribute(115, "type", "button");
                __builder2.AddAttribute(116, "class", "btn btn-warning btn-lg");
                __builder2.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
                                                                                   Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(118, "<span class=\"oi oi-file\"></span>&nbsp;Limpiar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                    ");
                __builder2.AddMarkupContent(120, "<button type=\"submit\" class=\"btn btn-success btn-lg \"><span class=\"oi oi-data-transfer-download\"></span>&nbsp;Guardar</button>\r\n                    ");
                __builder2.AddMarkupContent(121, "<button type=\"button\" class=\"btn btn-danger btn-lg\"><span class=\"oi oi-trash\"></span>&nbsp;Eliminar</button>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n\r\n\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
      

    public int PagoId { get; set; }
    private Pagos pagos = new Pagos();


    Clientes clientes = new Clientes();
    List<Clientes> ListaCliente = new List<Clientes>();
    private string ClienteSelect { get; set; }

    private decimal deuda = 0;

    protected override void OnInitialized()
    {
        ListaCliente = ClienteBLL.GetList(e => true);
        pagos = new Pagos();
        Nuevo();

        if (PagoId != 0)
        {
            pagos.PagoId = PagoId;
            Buscar();
        }
    }


    private void Buscar()
    {

    }

    private void Nuevo()
    {

    }

    private void Guardar()
    {

    }

    private void Eliminar()
    {

    }


    private void LlenarComboxCliente()
    {
        pagos.ClienteId = Convert.ToInt32(ClienteSelect);
        clientes = ClienteBLL.Buscar(Convert.ToInt32(ClienteSelect));
    }




#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.AutosoftService.Pages.Registros.RPagos
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "onclick", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Readonly", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
