#pragma checksum "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b26d1bd6a107f54bead6b47df38f1aaffc57c085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Verhuringen_Afrekenen), @"mvc.1.0.view", @"/Views/Verhuringen/Afrekenen.cshtml")]
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
#line 1 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\_ViewImports.cshtml"
using ASP_Eindtest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\_ViewImports.cshtml"
using ASP_Eindtest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\_ViewImports.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26d1bd6a107f54bead6b47df38f1aaffc57c085", @"/Views/Verhuringen/Afrekenen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b93bee1b716b7fa34385fed3f1d39094b3acc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Verhuringen_Afrekenen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Film>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
  
    ViewData["Title"] = "Afrekenen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Afrekenen</h1>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Titel\r\n            </th>\r\n            <th>\r\n                Prijs\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
               Write(Html.DisplayFor(modelItem => item.Titel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
               Write(Html.DisplayFor(modelItem => item.Prijs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <th>\r\n                Totaal\r\n            </th>\r\n            <th>\r\n                 ");
#nullable restore
#line 37 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
             Write(((decimal)ViewBag.totaal).ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<p>wordt gefactureerd aan:</p>\r\n<p>");
#nullable restore
#line 44 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
Write(ViewBag.klant.Voornaam);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
                      Write(ViewBag.klant.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p></p>\r\n<p>");
#nullable restore
#line 46 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
Write(ViewBag.klant.StraatNr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p></p>\r\n<p>");
#nullable restore
#line 48 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
Write(ViewBag.klant.PostCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\ejvds\Documents\programmeren\ASP\ASP_Eindtest\ASP_Eindtest\Views\Verhuringen\Afrekenen.cshtml"
                      Write(ViewBag.klant.Gemeente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Film>> Html { get; private set; }
    }
}
#pragma warning restore 1591
