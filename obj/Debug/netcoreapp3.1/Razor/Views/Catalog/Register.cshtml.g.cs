#pragma checksum "C:\Users\Zach\Documents\School\Unit 110 - ASP.NET Core\WebApp\Views\Catalog\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec005ea22d5584c84a7c74425079a3b3e983ac20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Register), @"mvc.1.0.view", @"/Views/Catalog/Register.cshtml")]
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
#line 1 "C:\Users\Zach\Documents\School\Unit 110 - ASP.NET Core\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zach\Documents\School\Unit 110 - ASP.NET Core\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec005ea22d5584c84a7c74425079a3b3e983ac20", @"/Views/Catalog/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "new", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "used", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Zach\Documents\School\Unit 110 - ASP.NET Core\WebApp\Views\Catalog\Register.cshtml"
  
ViewData["Title"] = "Car Registration";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-6 offset-md-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec005ea22d5584c84a7c74425079a3b3e983ac204237", async() => {
                WriteLiteral(@"
        <h3>Register New Car</h3>
        <div class=""form-group row"">
            <label for=""selCondition"" class=""col-4 col-form-label"">Condition</label>
            <div class=""col-8"">
                <select id=""selCondition"" name=""selCondition"" class=""custom-select"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec005ea22d5584c84a7c74425079a3b3e983ac204806", async() => {
                    WriteLiteral("New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec005ea22d5584c84a7c74425079a3b3e983ac206046", async() => {
                    WriteLiteral("Used");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""txtMake"" class=""col-4 col-form-label"">Make</label>
            <div class=""col-8"">
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                    </div>
                    <input id=""txtMake"" name=""txtMake"" type=""text"" class=""form-control"">
                </div>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""txtModel"" class=""col-4 col-form-label"">Model</label>
            <div class=""col-8"">
                <input id=""txtModel"" name=""txtModel"" type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""txtYear"" class=""col-4 col-form-label"">Year</label>
            <div class=""col-8"">
                <input id=""txtYear"" name=""txtYear"" type=""number"" class=""form-control"">
            </div>
        ");
                WriteLiteral(@"</div>
        <div class=""form-group row"">
            <label for=""txtColor"" class=""col-4 col-form-label"">Color</label>
            <div class=""col-8"">
                <input id=""txtColor"" name=""txtColor"" type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""txtPrice"" class=""col-4 col-form-label"">Price</label>
            <div class=""col-8"">
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text"">
                            <i class=""fa fa-dollar""></i>
                        </div>
                    </div>
                    <input id=""txtPrice"" name=""txtPrice"" type=""number"" class=""form-control"">
                </div>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""txtSeating"" class=""col-4 col-form-label"">Seating</label>
            <div class=""col-8"">
               ");
                WriteLiteral(@" <input id=""txtSeats"" name=""txtSeating"" type=""number"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""txtMileage"" class=""col-4 col-form-label"">Mileage</label>
            <div class=""col-8"">
                <input id=""txtMileage"" name=""txtMileage"" type=""number"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""txtMPG"" class=""col-4 col-form-label"">MPG</label>
            <div class=""col-8"">
                <div class=""input-group"">
                    <input id=""txtMPG"" name=""txtMPG"" type=""number"" class=""form-control"">
                    <div class=""input-group-append"">
                        <div class=""input-group-text"">mi</div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""form-group row"">
            <label for=""txtImage"" class=""col-4 col-form-label"">Image URL</label>
            <div class=""");
                WriteLiteral(@"col-8"">
                <input id=""txtImage"" name=""txtImage"" type=""text"" class=""form-control"">
            </div>
        </div>
        <div class=""form-group row"">
            <div class=""offset-4 col-8"">
                <button id=""btn-save"" name=""submit"" type=""button"" class=""btn btn-primary"">
                    <i class=""fa fa-save""></i>
                    Register Car</button>
            </div>
        </div>
    ");
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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script src=\"/js/register.js\"></script>\r\n");
            }
            );
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
