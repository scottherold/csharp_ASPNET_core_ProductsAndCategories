#pragma checksum "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c875e45a99d698cffb2711cd19482c43ad422233"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Product), @"mvc.1.0.view", @"/Views/Main/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Product.cshtml", typeof(AspNetCore.Views_Main_Product))]
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
#line 2 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\_ViewImports.cshtml"
using ProductsAndCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c875e45a99d698cffb2711cd19482c43ad422233", @"/Views/Main/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a14c67890545ae6d1173c51c74e87efb4ca50563", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryBundle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryLink", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 185, true);
            WriteLiteral("<!-- Insert Model Here -->\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-lg-10 rounded justify-content-center m-4 bg-white text-center\">\r\n        <h1 class=\"mt-4 mb-5\">");
            EndContext();
            BeginContext(216, 18, false);
#line 5 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                         Write(Model.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(234, 339, true);
            WriteLiteral(@"</h1>
        <div class=""row justify-content-center m-3"">
            <div class=""col-6 border-right text-center"">
                <h3 class=""mb-4"">Categories:</h3>
                <div class=""row m-1 justify-content-start text-left"">
                    <table class=""table table-borderless ml-5"">
                        <tbody>
");
            EndContext();
#line 12 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                             if(Model.Product.Associations == null)
                            {

                            }
                            else
                            {
                                

#line default
#line hidden
#line 18 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                                 foreach(var asc in Model.Product.Associations)
                                {

#line default
#line hidden
            BeginContext(887, 93, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>&#8226 ");
            EndContext();
            BeginContext(981, 17, false);
#line 21 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                                              Write(asc.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(998, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 23 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                                }

#line default
#line hidden
#line 23 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(1114, 181, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-6 border-left text-center\">\r\n                ");
            EndContext();
            BeginContext(1295, 1245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8af04881474cb4a223055d49789d49", async() => {
                BeginContext(1363, 55, true);
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"ProductId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1418, "\"", 1450, 1);
#line 31 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
WriteAttributeValue("", 1426, Model.Product.ProductId, 1426, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1451, 293, true);
                WriteLiteral(@">
                    <label for=""CategoryId""><h3 class=""mb-4"">Add Category:</h3></label>
                    <div class=""form-row m-1 justify-content-center"">
                        <div class=""col-8 text-left mb-3"">
                            <select name=""CategoryId"" class=""w-100"">
");
                EndContext();
#line 36 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                             if(Model.CategoriesList == null)
                            {

                            }
                            else
                            {
                                

#line default
#line hidden
#line 42 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                                 foreach(var category in Model.CategoriesList)
                                {

#line default
#line hidden
                BeginContext(2051, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(2087, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a610c78dca42446a9db01ce1cf464de7", async() => {
                    BeginContext(2125, 13, false);
#line 44 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                                                                    Write(category.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 44 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                                       WriteLiteral(category.CategoryId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2147, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                                }

#line default
#line hidden
#line 45 "C:\Users\sherold\Desktop\CodingDojo\C#\ASP.NET_Entity_projects\ProductsAndCategories\Views\Main\Product.cshtml"
                                 
                            }

#line default
#line hidden
                BeginContext(2215, 318, true);
                WriteLiteral(@"                            </select>
                        </div>
                    </div>
                    <div class=""form-row mt-2 mb-4 justify-content-center"">
                        <button type=""submit"" class=""btn btn-primary mt-2"">Add Category</button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2540, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoryBundle> Html { get; private set; }
    }
}
#pragma warning restore 1591
