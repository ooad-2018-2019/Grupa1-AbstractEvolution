#pragma checksum "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/Nekretnina/Nekretnina.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dcd5537bea83a0319308b50458de0c7d02ab20d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nekretnina_Nekretnina), @"mvc.1.0.view", @"/Views/Nekretnina/Nekretnina.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Nekretnina/Nekretnina.cshtml", typeof(AspNetCore.Views_Nekretnina_Nekretnina))]
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
#line 1 "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/_ViewImports.cshtml"
using Bluestate;

#line default
#line hidden
#line 2 "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/_ViewImports.cshtml"
using Bluestate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dcd5537bea83a0319308b50458de0c7d02ab20d", @"/Views/Nekretnina/Nekretnina.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e8593e8e9340962f3bac5ef4caddff974994088", @"/Views/_ViewImports.cshtml")]
    public class Views_Nekretnina_Nekretnina : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Nekretnina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VratiNazad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/Nekretnina/Nekretnina.cshtml"
  
    ViewData["Title"] = "Detalji";

#line default
#line hidden
            BeginContext(59, 144, true);
            WriteLiteral("\n<h1>Detalji o nekretnini</h1>\n\n<div>\n    <h4>Nekretnina</h4>\n    <hr />\n    <dl class=\"container\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(204, 41, false);
#line 14 "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/Nekretnina/Nekretnina.cshtml"
       Write(Html.DisplayNameFor(model => model.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(245, 59, true);
            WriteLiteral("\n        </dt>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(305, 42, false);
#line 17 "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/Nekretnina/Nekretnina.cshtml"
       Write(Html.DisplayNameFor(model => model.Cijena));

#line default
#line hidden
            EndContext();
            BeginContext(347, 59, true);
            WriteLiteral("\n        </dt>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(407, 44, false);
#line 20 "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/Nekretnina/Nekretnina.cshtml"
       Write(Html.DisplayNameFor(model => model.Prodavac));

#line default
#line hidden
            EndContext();
            BeginContext(451, 59, true);
            WriteLiteral("\n        </dt>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(511, 42, false);
#line 23 "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/Nekretnina/Nekretnina.cshtml"
       Write(Html.DisplayNameFor(model => model.Adresa));

#line default
#line hidden
            EndContext();
            BeginContext(553, 59, true);
            WriteLiteral("\n        </dt>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(613, 40, false);
#line 26 "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/Nekretnina/Nekretnina.cshtml"
       Write(Html.DisplayNameFor(model => model.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(653, 59, true);
            WriteLiteral("\n        </dt>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(713, 46, false);
#line 29 "/Users/kerim/RiderProjects/Grupa1-AbstractEvolution/Bluestate/Bluestate/Views/Nekretnina/Nekretnina.cshtml"
       Write(Html.DisplayNameFor(model => model.Kvadratura));

#line default
#line hidden
            EndContext();
            BeginContext(759, 42, true);
            WriteLiteral("\n        </dt>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(801, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dcd5537bea83a0319308b50458de0c7d02ab20d6566", async() => {
                BeginContext(828, 16, true);
                WriteLiteral("Nazad na pocetnu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(848, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nekretnina> Html { get; private set; }
    }
}
#pragma warning restore 1591
