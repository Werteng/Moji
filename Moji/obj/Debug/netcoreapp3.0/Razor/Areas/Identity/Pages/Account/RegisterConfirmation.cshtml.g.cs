#pragma checksum "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f62effacc2eac0705d0a37ed0a76a5af997c632f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\_ViewImports.cshtml"
using Moji.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\_ViewImports.cshtml"
using Moji.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\_ViewImports.cshtml"
using Moji.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Moji.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f62effacc2eac0705d0a37ed0a76a5af997c632f", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6636bba19998b8677ee0622bbe510231614580c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8515049762a2399753d8ceb51f7ce17df954a034", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = "Confirmation d'inscription ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <p>
        Cette application ne dispose pas actuellement d'un véritable expéditeur d'e-mails enregistré, voir<a href=""https://aka.ms/aspaccountconf"">these docs</a> pour savoir comment configurer un véritable expéditeur d'e-mails.
        Normalement, cela serait envoyé par e-mail:<a id=""confirm-link""");
            BeginWriteAttribute("href", " href=\"", 497, "\"", 531, 1);
#nullable restore
#line 13 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 504, Model.EmailConfirmationUrl, 504, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cliquez ici pour confirmer votre compte</a>\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    Veuillez vérifier votre e-mail pour confirmer votre compte.\r\n</p>\r\n");
#nullable restore
#line 21 "C:\Users\SEVE Ludivine\Documents\Nicolas\Moji\Moji\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
