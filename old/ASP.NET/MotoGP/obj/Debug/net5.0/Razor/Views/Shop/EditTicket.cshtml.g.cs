#pragma checksum "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e1f7ce4e2a79df4c54d85e57757927b5233ee95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_EditTicket), @"mvc.1.0.view", @"/Views/Shop/EditTicket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e1f7ce4e2a79df4c54d85e57757927b5233ee95", @"/Views/Shop/EditTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c11a21fd0de2028889f3b1a931d0560cbec79e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_EditTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MotoGP.Models.Ticket>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
  
    ViewData["Title"] = "Edit Ticket";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<dl>\r\n    <dt>\r\n        ");
#nullable restore
#line 9 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 12 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 15 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 18 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 21 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 24 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 27 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 30 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayFor(model => model.Country.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 33 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayNameFor(model => model.Race));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 36 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayFor(model => model.Race.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt>\r\n        ");
#nullable restore
#line 39 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd>\r\n        ");
#nullable restore
#line 42 "C:\Users\sian-\OneDrive\Documenten\2022-2023\ASP.NET\ASP.NET\MotoGP\Views\Shop\EditTicket.cshtml"
   Write(Html.DisplayFor(model => model.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dd>\r\n        <input type=\"checkbox\" name=\"paid\" value=\"true\" /> Paid\r\n    </dd>\r\n    <dd>\r\n        <input type=\"submit\" name=\"register\" value=\"register\" />\r\n    </dd>\r\n\r\n</dl>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MotoGP.Models.Ticket> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591