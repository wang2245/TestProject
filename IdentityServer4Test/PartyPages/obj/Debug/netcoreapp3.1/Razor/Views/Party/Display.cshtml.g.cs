#pragma checksum "E:\GitLearnProject\IdentityServer4Test\PartyPages\Views\Party\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b087cfb3a1cdad819e7ca2acb862caaaa339ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Party_Display), @"mvc.1.0.view", @"/Views/Party/Display.cshtml")]
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
#line 1 "E:\GitLearnProject\IdentityServer4Test\PartyPages\Views\_ViewImports.cshtml"
using PartyPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitLearnProject\IdentityServer4Test\PartyPages\Views\_ViewImports.cshtml"
using PartyPages.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b087cfb3a1cdad819e7ca2acb862caaaa339ca6", @"/Views/Party/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72b9c8d594377cd219d167f22b99897d5198153", @"/Views/_ViewImports.cshtml")]
    public class Views_Party_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/party_sample_0.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\GitLearnProject\IdentityServer4Test\PartyPages\Views\Party\Display.cshtml"
  
    ViewData["Title"] = "Display";
    Layout = "~/Views/Shared/_LayoutBootstrap.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-5\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b087cfb3a1cdad819e7ca2acb862caaaa339ca63734", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<div class=""col-7"">
    <h5><span class=""badge badge-danger"" style=""font-size:9pt"">精选</span>&nbsp;抖音短视频赚钱9大套路，轻松月入过万</h5>
    <div>
        <span class=""lable-content-default"">知运营大学</span>
        <span class=""lable-content-default"">357.8W+</span>
    </div>
    <div style=""border:1px dashed #cccccc;padding:20px;margin-top:20px;"">
            <div>
                <span class=""label-title-default"">地点</span>
                <span class=""lable-content-default"" style=""margin-left:20px"">线上活动</span>
            </div>
            <div style=""margin-top:20px"">
                <span class=""label-title-default"">时间</span>
                <span class=""lable-content-default"" style=""margin-left:20px"">2020-08-16 00:00 ~ 2021-08-14 16:00</span>
            </div>
            <div style=""margin-top:20px"">
                <span class=""label-title-default"">票种</span>
                <span class=""lable-content-default"" style=""margin-left:20px"">

                </span>
            </div>
         ");
            WriteLiteral(@"   <div style=""margin-top:20px"">
                <span class=""label-title-default"">数量</span>
                        <span class=""lable-content-default"" style=""margin-left:20px"">
                            <button class=""border"" type=""button"">-</button>
                        </span>
                        <span>
                            <input class=""border"" type=""text"" readonly=""readonly"" style=""width:50px;line-height:20px;font-size:9pt"" value=""1"">
                        </span>
                        <span class=""lable-content-default"">
                            <button class=""border"" type=""button"">+</button>
                        </span>
            </div>

            <div style=""margin-top:50px"">
                <button type=""button"" class=""btn btn-primary btn-lg"">我要报名</button>
                <button type=""button"" class=""btn btn-outline-primary btn-lg"" style=""margin-left:20px"">收藏</button>
            </div>
    </div>
</div>

<div class=""row"" style=""width:100%"">
    <ul");
            WriteLiteral(" class=\"nav nav-tabs\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link active\" href=\"#\">活动详情</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" href=\"#\">已报名</a>\r\n        </li>\r\n    </ul>\r\n</div>\r\n\r\n");
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
