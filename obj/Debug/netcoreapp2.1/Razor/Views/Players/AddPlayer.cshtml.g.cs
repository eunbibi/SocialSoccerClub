#pragma checksum "C:\Cencol-2sem\Web\Soccer-Club-master\Soccer-Club-master\Anna_E_Seo_301098222\Views\Players\AddPlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be559cf186a0cf6aaf34d03dc34b5b82b4a3825"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_AddPlayer), @"mvc.1.0.view", @"/Views/Players/AddPlayer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Players/AddPlayer.cshtml", typeof(AspNetCore.Views_Players_AddPlayer))]
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
#line 1 "C:\Cencol-2sem\Web\Soccer-Club-master\Soccer-Club-master\Anna_E_Seo_301098222\Views\_ViewImports.cshtml"
using Anna_E_Seo_301098222;

#line default
#line hidden
#line 2 "C:\Cencol-2sem\Web\Soccer-Club-master\Soccer-Club-master\Anna_E_Seo_301098222\Views\_ViewImports.cshtml"
using Anna_E_Seo_301098222.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be559cf186a0cf6aaf34d03dc34b5b82b4a3825", @"/Views/Players/AddPlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b23df2a8220513ac63813f423a922c134b74ac2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_AddPlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Anna_E_Seo_301098222.Models.Player>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Cencol-2sem\Web\Soccer-Club-master\Soccer-Club-master\Anna_E_Seo_301098222\Views\Players\AddPlayer.cshtml"
  
    ViewData["Title"] = "Add Player";

#line default
#line hidden
            BeginContext(87, 123, true);
            WriteLiteral("\n<div class=\"container m-2 mx-auto\">\n    <div class=\"border-bottom-2 border-dark\">\n        <h2>Add Player</h2>\n    </div>\n\n");
            EndContext();
#line 12 "C:\Cencol-2sem\Web\Soccer-Club-master\Soccer-Club-master\Anna_E_Seo_301098222\Views\Players\AddPlayer.cshtml"
      
        Html.RenderPartial("~/Views/Shared/partialPlayerView.cshtml");
    

#line default
#line hidden
            BeginContext(294, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Anna_E_Seo_301098222.Models.Player> Html { get; private set; }
    }
}
#pragma warning restore 1591
