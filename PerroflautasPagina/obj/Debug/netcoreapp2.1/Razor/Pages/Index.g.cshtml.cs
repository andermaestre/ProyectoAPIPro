#pragma checksum "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a548eb5c01b9973c8a84c3941f2b5f06872472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PerroflautasPagina.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(PerroflautasPagina.Pages.Pages_Index), null)]
namespace PerroflautasPagina.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\_ViewImports.cshtml"
using PerroflautasPagina;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a548eb5c01b9973c8a84c3941f2b5f06872472", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42eec431fcc0baefbda8cdc73743c3b8c61dc580", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 242, true);
            WriteLiteral("\r\n<div id=\"cabecero\">\r\n\r\n</div>\r\n<div id=\"content\">\r\n\r\n</div>\r\n<div id=\"formulario\">\r\n\r\n</div>\r\n<script>\r\n    function EscapeRooms() {\r\n            var tabla = \'<table id=\"table\">\';\r\n            tabla += \"<th></th>\";\r\n\r\n            tabla += \"");
            EndContext();
#line 21 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
                       foreach (var er in Model.perroflautas) {

#line default
#line hidden
            BeginContext(354, 9, true);
            WriteLiteral(" <tr><td>");
            EndContext();
            BeginContext(364, 5, false);
#line 21 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
                                                                   Write(er.Id);

#line default
#line hidden
            EndContext();
            BeginContext(369, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(379, 9, false);
#line 21 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
                                                                                  Write(er.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(388, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(398, 12, false);
#line 21 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
                                                                                                     Write(er.Direccion);

#line default
#line hidden
            EndContext();
            BeginContext(410, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(420, 24, false);
#line 21 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
                                                                                                                           Write(er.OrientacionIdeologica);

#line default
#line hidden
            EndContext();
            BeginContext(444, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(454, 13, false);
#line 21 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
                                                                                                                                                             Write(er.Posesiones);

#line default
#line hidden
            EndContext();
            BeginContext(467, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(477, 13, false);
#line 21 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
                                                                                                                                                                                    Write(er.GritoComun);

#line default
#line hidden
            EndContext();
            BeginContext(490, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(500, 14, false);
#line 21 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
                                                                                                                                                                                                           Write(er.GritoAparea);

#line default
#line hidden
            EndContext();
            BeginContext(514, 11, true);
            WriteLiteral("</td></tr> ");
            EndContext();
#line 21 "C:\Users\andermaestre\source\repos\APIPerroflautasFinal\PerroflautasPagina\Pages\Index.cshtml"
                                                                                                                                                                                                                                          }

#line default
#line hidden
            BeginContext(526, 109, true);
            WriteLiteral(" \";\r\n\r\n            tabla += \"</table>\";\r\n                content.innerHTML = tabla;\r\n            }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
