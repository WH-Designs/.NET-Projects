#pragma checksum "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca89376ccab1f97ee47602d02074727b17e19c85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\_ViewImports.cshtml"
using HW3Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\_ViewImports.cshtml"
using HW3Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca89376ccab1f97ee47602d02074727b17e19c85", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e34a42f6d04c27ecdfad228f98e211eddedf23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HW3Project.Models.GroceryItemModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddGroceryItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Grocery Dex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Grocery List</h1>\r\n    <div class=\"container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca89376ccab1f97ee47602d02074727b17e19c853936", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\Home\Index.cshtml"
              
                ViewBag.currentItems = Model;
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table class=""table table-bordered table-dark"">
                <thead>
                    <tr>
                        <th scope=""col"">Grocery Item</th>
                        <th scope=""col"">Amount</th>
                        <th scope=""col"">Remove</th>
                    </tr>
                </thead>
                <tbody>
                    <tr class=""grocery-item"">
");
#nullable restore
#line 23 "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\Home\Index.cshtml"
                         if (ViewBag.currentItems is not null)
                        {
                            foreach (var item in ViewBag.currentItems)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
#nullable restore
#line 27 "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\Home\Index.cshtml"
                               Write(item.ItemName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\Home\Index.cshtml"
                               Write(item.ItemCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>\r\n                                    <button id=\"remove\" type=\"button\" data-id=\"");
#nullable restore
#line 30 "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\Home\Index.cshtml"
                                                                          Write(item.ItemName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                                    class=\"btn alert-danger btn-sm my-0\">Remove</button>\r\n                                </td>\r\n");
#nullable restore
#line 33 "C:\School\CS 366\w22---cs366-WH-Designs\4_HW3\HW3Solution\HW3Project\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tr>\r\n                </tbody>\r\n            </table>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca89376ccab1f97ee47602d02074727b17e19c857821", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""itemName"">Item Name</label>
                <input name=""itemName"" type=""Text"" class=""form-control"" id=""itemName"" placeholder=""ex: carrots"">
                <label for=""itemQuantity"">Quantity</label>
                <input name=""itemQuantity"" type=""Number"" class=""form-control"" id=""itemQuantity"" placeholder=""ex: 3"">
                <button id=""add"" type=""submit"" class=""btn btn-primary"">Add</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HW3Project.Models.GroceryItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
