#pragma checksum "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "334a18d77b4cdada64cda3324651cb8f21dc7696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LMS.Pages.Authors.Pages_Authors_Details), @"mvc.1.0.razor-page", @"/Pages/Authors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Authors/Details.cshtml", typeof(LMS.Pages.Authors.Pages_Authors_Details), null)]
namespace LMS.Pages.Authors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\_ViewImports.cshtml"
using LMS;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"334a18d77b4cdada64cda3324651cb8f21dc7696", @"/Pages/Authors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41b454bf97ead46d82bb9c07b5243ad590968448", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Authors_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Author</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(212, 52, false);
#line 15 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(264, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(308, 48, false);
#line 18 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(356, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(400, 51, false);
#line 21 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(451, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(495, 47, false);
#line 24 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(542, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(586, 48, false);
#line 27 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author.Email));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(678, 44, false);
#line 30 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author.Email));

#line default
#line hidden
            EndContext();
            BeginContext(722, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(766, 49, false);
#line 33 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(815, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(859, 45, false);
#line 36 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(904, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(948, 54, false);
#line 39 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1046, 50, false);
#line 42 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1140, 49, false);
#line 45 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1233, 45, false);
#line 48 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1322, 56, false);
#line 51 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author.DisplayedName));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1422, 52, false);
#line 54 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author.DisplayedName));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1521, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22ad365dc9c14766af9e6a2eb7878e89", async() => {
                BeginContext(1580, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\LENOVO\Desktop\LMS\LMS\LMS\Pages\Authors\Details.cshtml"
                           WriteLiteral(Model.Author.AuthorId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1588, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1596, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81765f971b1a4f77a60861550ef7149e", async() => {
                BeginContext(1618, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1634, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LMS.Pages.Authors.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LMS.Pages.Authors.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LMS.Pages.Authors.DetailsModel>)PageContext?.ViewData;
        public LMS.Pages.Authors.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
