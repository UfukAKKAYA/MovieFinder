#pragma checksum "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57ee7f15ed012821ecdda2d97db85817a464c871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_MovieDetail), @"mvc.1.0.view", @"/Views/Movies/MovieDetail.cshtml")]
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
#line 1 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\_ViewImports.cshtml"
using MovieFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\_ViewImports.cshtml"
using MovieFinder.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ee7f15ed012821ecdda2d97db85817a464c871", @"/Views/Movies/MovieDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"839ccae0f99769569926ae6911b3b86ffebd7cb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_MovieDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieFinder.Models.MovieRecord>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("SetCulture(this.value)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DirectorMovies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
  
    ViewData["Title"] = "MovieDetail";
    string culture = "", uiculture = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
  
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();
    var cultureItems = LocOptions.Value.SupportedUICultures
        .Select(c => new SelectListItem { Value = c.Name, Text = c.DisplayName })
        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<label>Language:</label>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ee7f15ed012821ecdda2d97db85817a464c8718009", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => requestCulture.RequestCulture.UICulture.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = cultureItems;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ee7f15ed012821ecdda2d97db85817a464c87110166", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 28 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
  

    if (Context.Request.QueryString.HasValue)
    {
        string url = Context.Request.QueryString.Value;
        culture = Context.Request.Query["culture"];
        uiculture = Context.Request.Query["ui-culture"];
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    * {
        box-sizing: border-box;
    }

    .movieimg {
        float: left;
        width: 353px;
    }

    .movietrailer {
        float: left;
        width: 753px;
    }

    .movietitle {
        float: left;
        width: 1020px;
        height: 60px;
    }

    .moviescore {
        float: left;
        width: 80PX;
        height: 60px;
    }

    .movieinfo {
        float: left;
        width: 100%;
        padding-top: 10px;
        padding-right: 30px;
        padding-bottom: 50px;
        padding-left: 30px;
    }

    .clearfix::after {
        content: """";
        clear: both;
        display: table;
    }
</style>


<div style=""background-color:#000"">

    <div class=""clearfix"">
        <div class=""movietitle"" style=""background-color:#000"">
");
#nullable restore
#line 88 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
             if (culture == "en-US" || culture == "fr")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1 style=\"color: white; padding-left: 14px;\"> ");
#nullable restore
#line 90 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                                          Write(Html.DisplayFor(modelItem => Model.Movie.NameEN));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 91 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1 style=\"color: white; padding-left: 14px;\"> ");
#nullable restore
#line 94 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                                          Write(Html.DisplayFor(modelItem => Model.Movie.NameTr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 95 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"moviescore\" style=\"background-color:#000;\">\r\n            <div class=\"row\">\r\n                <div data-value=");
#nullable restore
#line 101 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                           Write(Model.Movie.Score.ToString());

#line default
#line hidden
#nullable disable
            BeginWriteAttribute("id", " id=\"", 2488, "\"", 2493, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"--circle-size: 80px;\">\r\n                    <div data-progress-type=\"POINT\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"clearfix\">\r\n        <div class=\"movieimg\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ee7f15ed012821ecdda2d97db85817a464c87115712", async() => {
                WriteLiteral("   <img");
                BeginWriteAttribute("src", " src=\"", 2800, "\"", 2839, 2);
                WriteAttributeValue("", 2806, "/img/filmler/", 2806, 13, true);
#nullable restore
#line 111 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
WriteAttributeValue("", 2819, Model.Movie.LogoUrl, 2819, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Avatar\" width=\"353\" height=\"470\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                          WriteLiteral(Model.Movie.Id);

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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"movietrailer\">\r\n            <iframe width=\"753\" height=\"472\"");
            BeginWriteAttribute("src", " src=", 2981, "", 3009, 1);
#nullable restore
#line 114 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
WriteAttributeValue("", 2986, Model.Movie.TrailerUrl, 2986, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=", 3009, "", 3035, 1);
#nullable restore
#line 114 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
WriteAttributeValue("", 3016, Model.Movie.NameTr, 3016, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
        </div>
    </div>
</div>

<div style=""background-color:black"">

    <div class=""movieinfo"" style=""background-color:black"">
        <dl class=""row"" style=""color:white"">

            <dt class=""col-sm-12"" style=""font-size: x-large"">
                ");
#nullable restore
#line 125 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
           Write(Localizer["Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-12\" style=\"font-size: x-large\">\r\n");
#nullable restore
#line 128 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                 foreach (Category c in Model.Categories)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ee7f15ed012821ecdda2d97db85817a464c87120542", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 132 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                   Write(c.Type.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 131 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                                    WriteLiteral(c.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 134 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n            <dt class=\"col-sm-12\" style=\"font-size: x-large\">\r\n                ");
#nullable restore
#line 137 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
           Write(Localizer["Director"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-12\" style=\"font-size: x-large\">\r\n");
#nullable restore
#line 140 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                 if (@Model.Movie.Director != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ee7f15ed012821ecdda2d97db85817a464c87124175", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 143 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                   Write(Html.DisplayFor(model => model.Movie.Director.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 143 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                                                        Write(Html.DisplayFor(model => model.Movie.Director.SurName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                                     WriteLiteral(Model.Movie.Director.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 145 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-12\" style=\"font-size:x-large\">\r\n                ");
#nullable restore
#line 150 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
           Write(Localizer["ProdictionYear"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-12\" style=\"font-size:x-large\">\r\n                ");
#nullable restore
#line 153 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
           Write(Html.DisplayFor(model => model.Movie.ProductionYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n\r\n            <dd class=\"text-justify\" style=\"padding-left: 14px; padding-right:14px\">\r\n");
#nullable restore
#line 157 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                 if (culture == "en-US" || culture == "fr")
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
               Write(Html.DisplayFor(model => model.Movie.DescriptionEN));

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                                                        
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
               Write(Html.DisplayFor(model => model.Movie.DescriptionTR));

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                                                        
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 172 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
 if (User.Identity.IsAuthenticated)
{
    if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ee7f15ed012821ecdda2d97db85817a464c87130395", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 177 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                   WriteLiteral(Model.Movie.Id);

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
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ee7f15ed012821ecdda2d97db85817a464c87132611", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 178 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
                                     WriteLiteral(Model.Movie.Id);

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
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57ee7f15ed012821ecdda2d97db85817a464c87134831", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 181 "C:\Users\akkay\OneDrive\Masaüstü\Disk\YuksekLisans\Dersler\WebProgramlama\MovieFinder\MovieFinder\Views\Movies\MovieDetail.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    function SetCulture(selectedValue) {
        var url = window.location.href.split('?')[0];
        var culture = ""?culture="" + selectedValue + ""&ui-culture="" + selectedValue;
        window.location.href = url + culture;
    }
</script>












");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> LocOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieFinder.Models.MovieRecord> Html { get; private set; }
    }
}
#pragma warning restore 1591
