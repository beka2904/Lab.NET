#pragma checksum "C:\Users\user\Desktop\tut1\tut1\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b4c8f6797e285bcb16d9fe90a1a3b2c346334e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Index.cshtml", typeof(AspNetCore.Views_Search_Index))]
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
#line 4 "C:\Users\user\Desktop\tut1\tut1\Views\Search\Index.cshtml"
using tut1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b4c8f6797e285bcb16d9fe90a1a3b2c346334e4", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user\Desktop\tut1\tut1\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(55, 859, true);
            WriteLiteral(@"
<h1
<p style=""font-size:large;"">
    ID is generated by this logic: <br />
    </p>

<p style=""font-size:medium"">
    For example, we have a student Beknazar,
    he was born on 29/04/2000, studying in the CSSE-1703K group.
</p>   
<div class=""content"">
    <ol type=""i"">
        <li>Take the first letter of the name: <b>B</b></li>
        <li>Take the last letter of the name: <b>R</b></li>
        <li>Add the size of the name: <b>8</b></li>
        <li> add the last digits of the year of birth: <b>00</b></li>
        <li>add the year of arrival it is written in the group number, that is:<b>7</b></li>
        <li>add the last number of group: <b>3</b></li>
    </ol>
</div>

<p style=""font-size:medium;"">We got the same ID: <strong>BR80073</strong>. You can <strong>enter</strong> and do a <strong>search</strong>.</p>
<br />

");
            EndContext();
            BeginContext(914, 292, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b4c8f6797e285bcb16d9fe90a1a3b2c346334e44436", async() => {
                BeginContext(934, 265, true);
                WriteLiteral(@"
    <div class=""field is-grouped"">
        <p class=""control is-expanded"">
            <input class=""input"" type=""text"" name=""student_id"" placeholder=""Enter ID"">
        </p>
        <input class=""button is-success"" type=""submit"" value=""search"">
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1206, 282, true);
            WriteLiteral(@"

    <table class=""table is-bordered is-striped is-narrow is-hoverable is-fullwidth"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Date of Birth</th>
                <th>Group</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 47 "C:\Users\user\Desktop\tut1\tut1\Views\Search\Index.cshtml"
             foreach (var std in Database.shared.students)
            {

#line default
#line hidden
            BeginContext(1563, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1610, 12, false);
#line 50 "C:\Users\user\Desktop\tut1\tut1\Views\Search\Index.cshtml"
                   Write(std.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1622, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1654, 7, false);
#line 51 "C:\Users\user\Desktop\tut1\tut1\Views\Search\Index.cshtml"
                   Write(std.DOB);

#line default
#line hidden
            EndContext();
            BeginContext(1661, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1693, 9, false);
#line 52 "C:\Users\user\Desktop\tut1\tut1\Views\Search\Index.cshtml"
                   Write(std.Group);

#line default
#line hidden
            EndContext();
            BeginContext(1702, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 54 "C:\Users\user\Desktop\tut1\tut1\Views\Search\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1747, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591