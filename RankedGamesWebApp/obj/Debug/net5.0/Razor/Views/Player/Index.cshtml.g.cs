#pragma checksum "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d77393cdfae55e62187578c60fa4210230cf91c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Index), @"mvc.1.0.view", @"/Views/Player/Index.cshtml")]
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
#line 1 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/_ViewImports.cshtml"
using RankedGamesWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/_ViewImports.cshtml"
using RankedGamesWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d77393cdfae55e62187578c60fa4210230cf91c", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca44f2d98a036f139e0de6d450153ce7a351ba2", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RankedGamesWebApp.Models.Player>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sb-nav-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
  
    ViewData["Title"] = "Scoreboard Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d77393cdfae55e62187578c60fa4210230cf91c5142", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 352, "\"", 362, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 390, "\"", 400, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <title>Ranking Project</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d77393cdfae55e62187578c60fa4210230cf91c6002", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/1.10.24/css/jquery.dataTables.css\" />\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/js/all.min.js\" crossorigin=\"anonymous\"></script>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d77393cdfae55e62187578c60fa4210230cf91c8190", async() => {
                WriteLiteral(@"
    <main>
        <div class=""container-fluid"">
            <h1 class=""mt-4 text-center"">Scoreboard</h1>
            <ol class=""breadcrumb mb-4"">
                <li class=""breadcrumb-item active"">Score for the top 5 matches out of your last 7 games.</li>
            </ol>
            <div class=""card mb-6"">
                <div class=""card-header"">
                    <i class=""fas fa-table mr-1""></i>
                    Rankings
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"" id=""score_dataTable"" width=""100%"" cellspacing=""0"">
                            <tr>
                                <th>");
#nullable restore
#line 36 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Rank));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                                <th>");
#nullable restore
#line 37 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                                <th>");
#nullable restore
#line 38 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Kills));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                                <th>");
#nullable restore
#line 39 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Deaths));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                                <th>");
#nullable restore
#line 40 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                            </tr>\n");
#nullable restore
#line 42 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 45 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                                   Write(item.Rank);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 46 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                                   Write(item.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 47 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                                   Write(item.Kills);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 48 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                                   Write(item.Deaths);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 49 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                                   Write(item.Score);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                </tr>\n");
#nullable restore
#line 51 "/Users/Matarim/Development/c_sharp/project_3/RankedGamesWebApp/RankedGamesWebApp/Views/Player/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </table>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </main>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RankedGamesWebApp.Models.Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591