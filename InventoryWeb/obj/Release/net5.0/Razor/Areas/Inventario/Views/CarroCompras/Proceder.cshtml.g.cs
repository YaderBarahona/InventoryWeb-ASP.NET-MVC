#pragma checksum "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6c568a12d54ace12aad95e0edbce4bb87a6c4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Inventario_Views_CarroCompras_Proceder), @"mvc.1.0.view", @"/Areas/Inventario/Views/CarroCompras/Proceder.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\_ViewImports.cshtml"
using InventoryWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\_ViewImports.cshtml"
using InventoryWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6c568a12d54ace12aad95e0edbce4bb87a6c4b", @"/Areas/Inventario/Views/CarroCompras/Proceder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a833584978aed5848ef7c15b5743eab4962dce7", @"/Areas/Inventario/Views/_ViewImports.cshtml")]
    public class Areas_Inventario_Views_CarroCompras_Proceder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inventory.Models.ViewModels.CarroComprasVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Inventario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarroCompras", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f6c568a12d54ace12aad95e0edbce4bb87a6c4b6202", async() => {
                WriteLiteral("\r\n    <br />   <br />\r\n");
                WriteLiteral(@"        <div class=""container-fluid mt-5"">
            <div class=""card"">
                <div class=""card-header bg-dark text-light ml-0 row container"">
                    <div class=""col-12 col-md-6"">
                        <i class=""fa fa-shopping-cart""></i> &nbsp;
                        Detalles de la Orden
                    </div>
                    <div class=""col-12 col-md-6"" style=""margin-left:10%"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f6c568a12d54ace12aad95e0edbce4bb87a6c4b6982", async() => {
                    WriteLiteral("Regresar al Carro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>

                <div class=""card-body"">
                    <div class=""container rounded p-2"">
                        <div class=""row"">
                            <div class=""col-12 col-md-6 pb-4"">
                                <div class=""row"">
                                    <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                                        <span class=""text-info"">Detalles de Envío:</span>
                                    </h4>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-md-3 col-12"">
                                        <label>Cliente:</label>
                                    </div>
                                    <div class=""col-md-6 col-12"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f6c568a12d54ace12aad95e0edbce4bb87a6c4b9668", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 35 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Orden.NombreCliente);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""row my-1"">
                                    <div class=""col-md-3 col-12"">
                                        <label>Telefono</label>
                                    </div>
                                    <div class=""col-md-6 col-12"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f6c568a12d54ace12aad95e0edbce4bb87a6c4b11900", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 44 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Orden.Telefono);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""row my-1"">
                                    <div class=""col-md-3 col-12"">
                                        <label>Direccion</label>
                                    </div>
                                    <div class=""col-md-6 col-12"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f6c568a12d54ace12aad95e0edbce4bb87a6c4b14129", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 53 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Orden.Direccion);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-md-3 col-12"">
                                        <label>Ciudad</label>
                                    </div>
                                    <div class=""col-md-6 col-12"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f6c568a12d54ace12aad95e0edbce4bb87a6c4b16354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 61 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Orden.Ciudad);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row my-1"">
                                    <div class=""col-md-3 col-12"">
                                        <label>Pais</label>
                                    </div>
                                    <div class=""col-md-6 col-12"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f6c568a12d54ace12aad95e0edbce4bb87a6c4b18574", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 69 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Orden.Pais);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""col-12 col-lg-5 offset-lg-1"">
                                <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                                    <span class=""text-info"">Productos:</span>
                                </h4>
                                <ul class=""list-group mb-3"">
");
#nullable restore
#line 78 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                     foreach (var item in Model.CarroComprasLista)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li class=\"list-group-item d-flex justify-content-between\">\r\n                                            <div>\r\n                                                <h6 class=\"my-0\">");
#nullable restore
#line 82 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                                            Write(item.Producto.Descripcion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                                <small class=\"text-danger\">Cantidad: ");
#nullable restore
#line 83 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                                                                Write(item.Cantidad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                                <small class=\"text-info\">Precio: $");
#nullable restore
#line 84 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                                                             Write(item.Precio.ToString("0.##"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                            </div>\r\n                                            <span class=\"text-info\"> \r\n");
#nullable restore
#line 87 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                                     
                                                    var total = item.Cantidad * item.Precio;
                                                   

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                   $");
#nullable restore
#line 90 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                               Write(total.ToString("0.##"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </li>\r\n");
#nullable restore
#line 92 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <li class=""list-group-item d-flex justify-content-between bg-light"">
                                        <strong class=""text-info"">Total: </strong>
                                        <strong class=""text-info"">$");
#nullable restore
#line 96 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                                               Write(Model.Orden.TotalOrden.ToString("0.##"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""row"">
                        <div class=""col-12 col-md-8 pt-2"">
                            <p style=""color:maroon; font-size:14px;"">
                                Fecha Estimada de Envío: ");
#nullable restore
#line 107 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                                    Write(DateTime.Now.AddDays(7).ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" -\r\n                                ");
#nullable restore
#line 108 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                           Write(DateTime.Now.AddDays(14).ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"col-12 col-md-4\">\r\n");
#nullable restore
#line 112 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                              
                                var TotalOrdenStripe = Model.Orden.TotalOrden * 100;
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <script src=\"https://checkout.stripe.com/checkout.js\" class=\"stripe-button\"\r\n                                    data-key=\"");
#nullable restore
#line 116 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                         Write(Stripe.Value.PublishableKey);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                                    data-amount=\"");
#nullable restore
#line 117 "D:\InventoryWeb\InventoryWeb\Areas\Inventario\Views\CarroCompras\Proceder.cshtml"
                                            Write(TotalOrdenStripe);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                                    data-name=""Sistema Inventario""
                                    data-label=""Realizar Pedido""
                                    data-description=""Compra de Productos en Linea""
                                    data-locale=""auto""
                                    data-allow-remember-me=""false""
                                    data-image=""https://stripe.com/img/documentation/checkout/marketplace.png"">
                            </script>
                            <script>
                                document.getElementsByClassName(""stripe-button-el"")[0].style.display = 'none';
                            </script>
                            <button type=""submit"" value=""Realizar Pedido""
                                    class=""btn btn-success form-control"">
                                Realizar Pedido
                            </button>
                        </div>
                    </div>
                </div>
            </d");
                WriteLiteral("iv>\r\n        </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<InventoryWeb.Utilities.StripeSettings> Stripe { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inventory.Models.ViewModels.CarroComprasVM> Html { get; private set; }
    }
}
#pragma warning restore 1591