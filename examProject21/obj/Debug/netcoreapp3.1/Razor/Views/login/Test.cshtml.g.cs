#pragma checksum "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\login\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53613b5b302d172419427aea8370b905e01ec2ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_login_Test), @"mvc.1.0.view", @"/Views/login/Test.cshtml")]
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
#line 1 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\_ViewImports.cshtml"
using examProject21;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\_ViewImports.cshtml"
using examProject21.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53613b5b302d172419427aea8370b905e01ec2ef", @"/Views/login/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f3d25d5c805773fe3e0e100223a145bc01e9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_login_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<examProject21.Models.Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>");
#nullable restore
#line 7 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\login\Test.cshtml"
Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<examProject21.Models.Login> Html { get; private set; }
    }
}
#pragma warning restore 1591