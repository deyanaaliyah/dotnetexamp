#pragma checksum "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8081d080e78c78eff17e69fdf17dda5f23f9eec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmpController1_Index), @"mvc.1.0.view", @"/Views/EmpController1/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8081d080e78c78eff17e69fdf17dda5f23f9eec8", @"/Views/EmpController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f3d25d5c805773fe3e0e100223a145bc01e9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_EmpController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<examProject21.Models.ExamClass>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n<h1>Daily Consumption Readings</h1>\r\n<hr/>\r\n<br/>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8081d080e78c78eff17e69fdf17dda5f23f9eec84333", async() => {
                WriteLiteral("\r\n    <p>\r\n        <input type=\"search\" placeholder=\"Enter your address....\"");
                BeginWriteAttribute("value", " value=\"", 270, "\"", 301, 1);
#nullable restore
#line 13 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
WriteAttributeValue("", 278, ViewData["Getdetails"], 278, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Empsearch\" style=\"width:500px;\"/>\r\n        <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\"/> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8081d080e78c78eff17e69fdf17dda5f23f9eec85199", async() => {
                    WriteLiteral("Get all Records");
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
                WriteLiteral("\r\n    </p>\r\n    <br/>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.energy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.unit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.water));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.mUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
         if(Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.address));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.energy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.unit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.water));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.mUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 74 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
             
        }
           else 
            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("               <td>Error occured</td> \r\n");
#nullable restore
#line 79 "C:\Users\hm\Desktop\csharp\dotnetexamp\examProject21\Views\EmpController1\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<examProject21.Models.ExamClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
