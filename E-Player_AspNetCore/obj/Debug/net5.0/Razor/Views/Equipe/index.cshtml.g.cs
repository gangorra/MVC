#pragma checksum "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300ec56cc2aae8bb9011ab1ef663b035015e72c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipe_index), @"mvc.1.0.view", @"/Views/Equipe/index.cshtml")]
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
#line 1 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/_ViewImports.cshtml"
using E_Player_AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/_ViewImports.cshtml"
using E_Player_AspNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"300ec56cc2aae8bb9011ab1ef663b035015e72c1", @"/Views/Equipe/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"478f7698aaef06f7a2333b6ad8507d1074c8c1d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipe_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Equipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
  
    ViewData["Title"] = "Equipes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300ec56cc2aae8bb9011ab1ef663b035015e72c14134", async() => {
                WriteLiteral("\n\n    <label>ID</label>\n    <input type=\"text\" name=\"IdEquipe\"/>\n\n    <label>Nome</label>\n    <input type=\"text\" name=\"Nome\"/>\n\n    <label>Imagem</label>\n    <<input type=\"file\" name=\"Imagem\"/>\n\n    <button type=\"submit\">Cadastrar</button>\n    \n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 7 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
AddHtmlAttributeValue("", 84, Url.Action("Cadastrar"), 84, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<table class=\"table table-striped table-responsive\">\n\n    <thead>\n        <th>ID</th>\n        <th>Nome</th>\n        <th>Foto</th>\n    </thead>\n        <tbody>\n");
#nullable restore
#line 31 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
             foreach (Equipe equipe in ViewBag.Equipes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 34 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
                   Write(equipe.IdEquipe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 35 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
                   Write(equipe.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><img");
            BeginWriteAttribute("src", " src=\"", 762, "\"", 795, 2);
            WriteAttributeValue("", 768, "/img/Equipes/", 768, 13, true);
#nullable restore
#line 36 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
WriteAttributeValue("", 781, equipe.Imagem, 781, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 796, "\"", 831, 4);
            WriteAttributeValue("", 802, "Imagem", 802, 6, true);
            WriteAttributeValue(" ", 808, "da", 809, 3, true);
            WriteAttributeValue(" ", 811, "equipe", 812, 7, true);
#nullable restore
#line 36 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
WriteAttributeValue(" ", 818, equipe.Nome, 819, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\"></td>\n\n                </tr>\n");
#nullable restore
#line 39 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Equipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
