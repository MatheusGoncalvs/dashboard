#pragma checksum "C:\Users\Teu\source\repos\dashboard\dashboard\Views\Dashboard\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1942fac0daf4c96997498953922cb24ce61b7fe0"
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
#line 2 "C:\Users\Teu\source\repos\dashboard\dashboard\Views\_ViewImports.cshtml"
using dashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1942fac0daf4c96997498953922cb24ce61b7fe0", @"/Views/Dashboard/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f5b35262d8c71d2234cd4416df7370360c37aa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Teu\source\repos\dashboard\dashboard\Views\Dashboard\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(45, 6583, true);
            WriteLiteral(@"<div class=""secao-dashboard"">
    <div id=""loader"" class=""loader""></div>
    <div class=""container-fluid"" id=""section-comercial"">
        <div class=""row block-title-dashboard block-bg"">
            <div class=""title-dashboard col-4"">
                <h2><strong>Comercial</strong></h2>
            </div>
            <div class=""icon-calendar-title col-8"">
                <a href=""#menu"" id=""toggle"">
                    <h3 id=""displayData"">01/01/0001 a 31/12/4000<i class=""far fa-calendar-alt""></i></h3>
                </a>
                <div id=""menu"">
                    <div class=""form-group"">
                        <label>Data Inicial</label>
                        <input id=""dataInicial"" name=""dataInicial"" type=""date"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label>Data Final</label>
                        <input id=""dataFinal"" name=""dataFinal"" type=""date"" class=""form-control"" />
                    </d");
            WriteLiteral(@"iv>
                    <input id=""atualizaData"" type=""submit"" class=""btn btn-success"" value=""OK"" />
                </div>
            </div>
        </div>
        <div class=""row first-chart"">
            <div class=""block col-sm-6"">
                <div class=""title-block"">
                    <div class="""">
                        <h2>Faturamento</h2>
                    </div>
                    <div class=""txt-ultima-atualizacao"">
                        <i class=""far fa-clock""></i>
                        <h2 id=""ultimaAtualizacao"" class=""ultimaAtualizacao"">Última atualização: 08/03/2020 às 08:57 hs</h2>
                    </div>
                </div>
                <div class=""middle-block"">
                    <div class=""col-1-faturamento-block"">
                        <div>
                            <h2>Diário</h2>
                        </div>
                        <div>
                            <h2>Semanal</h2>
                        </div>
                 ");
            WriteLiteral(@"       <div>
                            <h2>Mensal</h2>
                        </div>
                    </div>
                    <div class=""col-2-faturamento-block"">
                        <div>
                            <h2>R$: 702.025,00</h2>
                        </div>
                        <div>
                            <h2>R$: 4.915.025,00</h2>
                        </div>
                        <div>
                            <h2>R$: 25.900.005,00</h2>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""block chart_div col-sm-6"">
                <div class=""title-block"">
                    <div>
                        <h2>Pedidos <strong>Emitidos</strong> x Pedidos <strong>Faturados</strong></h2>
                    </div>
                    <div class=""txt-ultima-atualizacao"">
                        <i class=""far fa-clock""></i>
                        <h2 class=""ultimaAtualizacao"">");
            WriteLiteral(@"Última atualização: 08/03/2020 às 08:57 hs</h2>
                    </div>
                </div>
                <div class=""middle-block"">
                    <div id=""chart-pedidosFaturadosNaoFaturados"" class=""align-chart-center""></div>
                </div>
                <div class=""bottom-block"">
                    <div class=""row align-divs-center"">
                        <div class=""bg-switch"">
                            <input type=""radio"" id=""dia"" class=""switch selected-switch-dia"" name=""switch"" value=""dia"" checked>
                            <label for=""dia"">Dia</label><br>
                            <input type=""radio"" id=""semana"" class=""switch selected-switch-semana"" name=""switch"" value=""semana"">
                            <label for=""semana"">Semana</label><br>
                            <input type=""radio"" id=""mes"" class=""switch selected-switch-mes"" name=""switch"" value=""mes"">
                            <label for=""mes"">Mes</label>
                        </div>
        ");
            WriteLiteral(@"            </div>
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h1 id=""qtdPedidosNaoFaturados"">0</h1>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h1 id=""qtdPedidosFaturados"">0</h1>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Emitidos</h2>
                        </div>
                        <div class=""col-6 separator-collum"">
                            <h2>Pedidos Faturados</h2>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""block chart_div col-sm-6"">
                <div class=""title-block"">
                    <div>
                        <h2>Top 5 vendedores por maior valor de vendas</h2>
       ");
            WriteLiteral(@"             </div>
                    <div class=""txt-ultima-atualizacao"">
                        <i class=""far fa-clock""></i>
                        <h2 class=""ultimaAtualizacao"">Última atualização: 08/03/2020 às 08:57 hs</h2>
                    </div>
                </div>
                <div class=""middle-block"">
                    <div id=""chart-top5Vendedores"" class=""align-chart-center""></div>
                </div>
                <div class=""bottom-block"">
                    <div class=""row align-divs-center"">
                        <div class=""bg-switch"">
                            <input type=""radio"" id=""chart-vendedores-dia"" class=""switch selected-switch-vendedores-dia"" name=""switch-vendedores"" value=""dia"" checked>
                            <label for=""chart-vendedores-dia"">Dia</label><br>
                            <input type=""radio"" id=""chart-vendedores-semana"" class=""switch selected-switch-vendedores-semana"" name=""switch-vendedores"" value=""semana"">
                  ");
            WriteLiteral(@"          <label for=""chart-vendedores-semana"">Semana</label><br>
                            <input type=""radio"" id=""chart-vendedores-mes"" class=""switch selected-switch-vendedores-mes"" name=""switch-vendedores"" value=""mes"">
                            <label for=""chart-vendedores-mes"">Mes</label>
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
