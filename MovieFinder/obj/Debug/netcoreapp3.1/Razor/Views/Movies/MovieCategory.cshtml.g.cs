#pragma checksum "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\Movies\MovieCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec39a6515b7f85dd552abf4df252b045bc274080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_MovieCategory), @"mvc.1.0.view", @"/Views/Movies/MovieCategory.cshtml")]
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
#line 1 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\_ViewImports.cshtml"
using MovieFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\_ViewImports.cshtml"
using MovieFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec39a6515b7f85dd552abf4df252b045bc274080", @"/Views/Movies/MovieCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839ccae0f99769569926ae6911b3b86ffebd7cb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_MovieCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieFinder.Models.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\Movies\MovieCategory.cshtml"
  
    ViewData["Title"] = "Index";
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec39a6515b7f85dd552abf4df252b045bc2740804214", async() => {
                WriteLiteral("Yeni film oluştur");
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
            WriteLiteral("\r\n</p>\r\n\r\n<h1>");
#nullable restore
#line 12 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\Movies\MovieCategory.cshtml"
Write(TempData["category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"line\">\r\n");
#nullable restore
#line 15 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\Movies\MovieCategory.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" id=\"movie\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec39a6515b7f85dd552abf4df252b045bc2740806059", async() => {
                WriteLiteral("   <img");
                BeginWriteAttribute("src", " src=\"", 375, "\"", 407, 2);
                WriteAttributeValue("", 381, "/img/filmler/", 381, 13, true);
#nullable restore
#line 18 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\Movies\MovieCategory.cshtml"
WriteAttributeValue("", 394, item.LogoUrl, 394, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Avatar\" style=\"width:100%\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\Movies\MovieCategory.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <div class=\"container\">\r\n                <h4><b>");
#nullable restore
#line 21 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\Movies\MovieCategory.cshtml"
                  Write(Html.DisplayFor(modelItem => item.NameTr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n                <p>Score: ");
#nullable restore
#line 22 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\Movies\MovieCategory.cshtml"
                     Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\yeni\MovieFinder\MovieFinder\Views\Movies\MovieCategory.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieFinder.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
