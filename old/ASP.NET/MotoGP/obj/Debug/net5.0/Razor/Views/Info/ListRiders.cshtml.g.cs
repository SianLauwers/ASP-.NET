#pragma checksum "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98902006b4512545cb447c0527ac59b4c689c533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Info_ListRiders), @"mvc.1.0.view", @"/Views/Info/ListRiders.cshtml")]
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
#line 1 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\_ViewImports.cshtml"
using MotoGP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\_ViewImports.cshtml"
using MotoGP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98902006b4512545cb447c0527ac59b4c689c533", @"/Views/Info/ListRiders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c11a21fd0de2028889f3b1a931d0560cbec79e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Info_ListRiders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MotoGP.Models.Rider>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
  
    Layout = "~/views/shared/_Layout.cshtml";
    ViewData["Title"] = "Riders";
    var jpg = ".jpg";
    var png = ".png";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    * {
        padding: 5px;
    }

    div {
        display: flex;
        flex-wrap: wrap;
    }

    .card {
        background-color: #eee;
        margin: auto;
        margin-bottom: 25px;
        padding: 15px;
        flex-direction: column;
        flex: 0 0 25%;
    }

    .card-img {
        margin:auto;
        margin-left: 0px;
    }

    .card-body {
        font-size: 28px;
    }

    .card-footer {
        color: dimgrey;
    }

</style>

<div>
");
#nullable restore
#line 45 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
     foreach (var rider in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "98902006b4512545cb447c0527ac59b4c689c5335799", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 782, "~/images/riders/", 782, 16, true);
#nullable restore
#line 48 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
AddHtmlAttributeValue("", 798, rider.Number, 798, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
AddHtmlAttributeValue("", 811, jpg, 811, 4, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "98902006b4512545cb447c0527ac59b4c689c5337652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 904, "~/images/flags/", 904, 15, true);
#nullable restore
#line 50 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
AddHtmlAttributeValue("", 919, rider.CountryID, 919, 16, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
AddHtmlAttributeValue("", 935, png, 935, 4, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                <p class=\"card-body\">");
#nullable restore
#line 51 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
                                Write(rider.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n            <p class=\"card-footer\">");
#nullable restore
#line 54 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
                              Write(rider.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
                                               Write(rider.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 56 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Info\ListRiders.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98902006b4512545cb447c0527ac59b4c689c53310724", async() => {
                WriteLiteral("back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MotoGP.Models.Rider>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
