#pragma checksum "C:\Users\Filip\source\repos\AccountsCreate\Pages\NewUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7014564a6beec1511de6508a3d7c4682190bf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AccountsCreate.Pages.Pages_NewUser), @"mvc.1.0.razor-page", @"/Pages/NewUser.cshtml")]
namespace AccountsCreate.Pages
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
#line 1 "C:\Users\Filip\source\repos\AccountsCreate\Pages\_ViewImports.cshtml"
using AccountsCreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7014564a6beec1511de6508a3d7c4682190bf8", @"/Pages/NewUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97dca1157741cd3105046d5e0109d8013a561f50", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NewUser : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h1>New User</h1>\r\n    <p>Welcome new user!</p>\r\n    <p>Login to continue...</p>\r\n    <span><a href=\"Login.aspx\">Přihlášení</a></span>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountsCreate.Pages.NewUserModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountsCreate.Pages.NewUserModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountsCreate.Pages.NewUserModel>)PageContext?.ViewData;
        public AccountsCreate.Pages.NewUserModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
