#pragma checksum "C:\Users\Teu\source\repos\dashboard\dashboard\Views\Dashboard\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ab9d9a0657766cf5ac5606aeb1936f2aa806b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Dashboard), @"mvc.1.0.view", @"/Views/Dashboard/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Dashboard.cshtml", typeof(AspNetCore.Views_Dashboard_Dashboard))]
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
#line 1 "C:\Users\Teu\source\repos\dashboard\dashboard\Views\_ViewImports.cshtml"
using dashboard;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14ab9d9a0657766cf5ac5606aeb1936f2aa806b2", @"/Views/Dashboard/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db5428353212a15f0a3ef3a4784e2769aabc775", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Teu\source\repos\dashboard\dashboard\Views\Dashboard\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(45, 5802, true);
            WriteLiteral(@"<div class=""secao-dashboard"">
    <div id=""loader"" class=""loader""></div>
    <div class=""container-fluid"" id=""section-comercial"">
        <div class=""row first-chart"">
            <div class=""block chart_div col-sm-6"">
                <div id=""chart_div"" class=""align-chart-center""></div>
                <div class=""bottom-block"">
                    <div class=""row align-divs-center"">
                        <div class=""bg-btns-area align-divs-center"">
                            <div class=""btn--group"">
                                <input id=""btn-vendedor-semana"" class=""btn-vendedor btn-vendedor-bg btn-vendedor-semana-bg"" name=""btn-vendedor"" type=""radio"" />
                                <label for=""btn-vendedor-semana"">Semana</label>
                            </div>
                            <div class=""btn--group"">
                                <input id=""btn-vendedor-mes"" class=""btn-vendedor btn-vendedor-bg btn-vendedor-mes-bg"" name=""btn-vendedor"" type=""radio"" />
                 ");
            WriteLiteral(@"               <label for=""btn-vendedor-mes"">Mês</label>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h1 id=""qtdPedidosFaturados"">0</h1>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h1 id=""qtdPedidosNaoFaturados"">0</h1>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Faturados</h2>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Emitidos</h2>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""block columnChart_div col-sm-6"">
              ");
            WriteLiteral(@"  <div id=""columnChart_div"" class=""align-chart-center""></div>
                <div class=""bottom-block"">
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h1>R$: 50.000,00</h1>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h1>R$: 55.000,00</h1>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Faturados</h2>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Emitidos</h2>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""block chartSmallPizza_div col-sm-6"">
                <div id=""chartSmallPizza_div"" class=""align-chart-center""></div>
     ");
            WriteLiteral(@"           <div class=""bottom-block"">
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h1>200</h1>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h1>210</h1>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Faturados</h2>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Emitidos</h2>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""block chartSmallPier_div col-sm-6"">
                <div id=""chartSmallPier_div"" class=""align-chart-center""></div>
                <div class=""bottom-block"">
                    <div class=""row"">
            ");
            WriteLiteral(@"            <div class=""col-6 separator-collum"">
                            <h1>R$: 50.000,00</h1>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h1>R$: 55.000,00</h1>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Faturados</h2>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Emitidos</h2>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""block chartSmallPier_div col-sm-6"">
                <div id=""chartSmallPier_div"" class=""align-chart-center""></div>
                <div class=""bottom-block"">
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                    ");
            WriteLiteral(@"        <h1>R$: 50.000,00</h1>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h1>R$: 55.000,00</h1>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Faturados</h2>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Emitidos</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
