#pragma checksum "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e029fc5a8adb32f0c27cd6996ea60e1af46bb0c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Show), @"mvc.1.0.view", @"/Views/Wedding/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/Show.cshtml", typeof(AspNetCore.Views_Wedding_Show))]
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
#line 1 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/_ViewImports.cshtml"
using WeddingPlaner;

#line default
#line hidden
#line 2 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/_ViewImports.cshtml"
using WeddingPlaner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e029fc5a8adb32f0c27cd6996ea60e1af46bb0c8", @"/Views/Wedding/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5054e658578a58b5bc4e34896013fbfa13cff3dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboared", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Wedding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(15, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(21, 15, false);
#line 3 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
Write(Model.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(36, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(40, 15, false);
#line 3 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
                  Write(Model.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(55, 16, true);
            WriteLiteral("\'s Wedding</h1>\n");
            EndContext();
            BeginContext(71, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e029fc5a8adb32f0c27cd6996ea60e1af46bb0c85689", async() => {
                BeginContext(147, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(160, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(161, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e029fc5a8adb32f0c27cd6996ea60e1af46bb0c87323", async() => {
                BeginContext(229, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(239, 12, true);
            WriteLiteral("\n\n<h2>When: ");
            EndContext();
            BeginContext(252, 36, false);
#line 7 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
     Write(Model.Date.ToString("MMMM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(288, 17, true);
            WriteLiteral("</h2>\n<h2>Where: ");
            EndContext();
            BeginContext(306, 13, false);
#line 8 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
      Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(319, 37, true);
            WriteLiteral("</h2>\n\n<div>\n    <h6>Guest List</h6>\n");
            EndContext();
#line 12 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
     if(@Model.GuestList.Count == 0)
    {

#line default
#line hidden
            BeginContext(399, 46, true);
            WriteLiteral("        <p>No one loves us but eachother.</p>\n");
            EndContext();
#line 15 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(451, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 16 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
     foreach(var r in @Model.GuestList)
    {

#line default
#line hidden
            BeginContext(497, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(509, 17, false);
#line 18 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
      Write(r.Guest.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(526, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(528, 16, false);
#line 18 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
                         Write(r.Guest.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(544, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 19 "/Users/rony/Documents/C#_Stack/MVC_C#/WeddingPlaner/Views/Wedding/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(555, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
