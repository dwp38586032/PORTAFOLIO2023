#pragma checksum "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab45a14decce4aa4cb17d5cca24aa025b3262bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cocina_Cocina), @"mvc.1.0.view", @"/Views/Cocina/Cocina.cshtml")]
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
#line 1 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\_ViewImports.cshtml"
using cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\_ViewImports.cshtml"
using cliente.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab45a14decce4aa4cb17d5cca24aa025b3262bc", @"/Views/Cocina/Cocina.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a0ae87e171a223eca5ae858c3a82e33705a7cf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Cocina_Cocina : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrdenPedidoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cocina.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/cocina.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
  
    ViewData["Title"] = "Pedidos en Cocina";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab45a14decce4aa4cb17d5cca24aa025b3262bc4719", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ab45a14decce4aa4cb17d5cca24aa025b3262bc4981", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h2>Pedidos Activos en Cocina</h2>\r\n\r\n<div class=\"pedidos-container\">\r\n");
#nullable restore
#line 13 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
     foreach (var pedido in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pedido-card\"");
            BeginWriteAttribute("id", " id=\"", 314, "\"", 336, 2);
            WriteAttributeValue("", 319, "pedido-", 319, 7, true);
#nullable restore
#line 15 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
WriteAttributeValue("", 326, pedido.Id, 326, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h3 class=\"pedido-id\">Pedido #");
#nullable restore
#line 16 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
                                         Write(pedido.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p class=\"pedido-contenido\"><strong>Contenido:</strong> ");
#nullable restore
#line 17 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
                                                                   Write(pedido.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"pedido-estado\"");
            BeginWriteAttribute("id", " id=\"", 538, "\"", 560, 2);
            WriteAttributeValue("", 543, "estado-", 543, 7, true);
#nullable restore
#line 18 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
WriteAttributeValue("", 550, pedido.Id, 550, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>Estado:</strong> ");
#nullable restore
#line 18 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
                                                                                    Write(pedido.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"progress-bar\">\r\n                    <div class=\"progress-bar-fill\"");
            BeginWriteAttribute("style", " style=\"", 701, "\"", 744, 3);
            WriteAttributeValue("", 709, "width:", 709, 6, true);
#nullable restore
#line 20 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
WriteAttributeValue(" ", 715, pedido.GetProgressValue(), 716, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 742, "%;", 742, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n                <div class=\"pedido-actions\">\r\n    <button class=\"btn btn-primary\" data-id=\"");
#nullable restore
#line 23 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
                                        Write(pedido.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-update-url=\"");
#nullable restore
#line 23 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
                                                                     Write(Url.Action("ActualizarEstado", "Cocina", new { id = pedido.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"actualizarPedido(this)\">Actualizar</button>\r\n    <button class=\"btn btn-secondary\" data-id=\"");
#nullable restore
#line 24 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
                                          Write(pedido.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-revert-url=\"");
#nullable restore
#line 24 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
                                                                       Write(Url.Action("RevertirEstado", "Cocina", new { id = pedido.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"revertirPedido(this)\">Revertir</button>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ab45a14decce4aa4cb17d5cca24aa025b3262bc12050", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 33 "C:\Users\javie\OneDrive\Escritorio\ITERACION 3 Grupo 4\App Mobile (Tablet)\cliente\Views\Cocina\Cocina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrdenPedidoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
