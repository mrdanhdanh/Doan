#pragma checksum "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "856c22d815c0d105ed33c36e0eb86e1bea7760e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20880012_DoAn_KTLT.Pages.LoaiHang.Pages_LoaiHang_MH_TimKiem), @"mvc.1.0.razor-page", @"/Pages/LoaiHang/MH_TimKiem.cshtml")]
namespace _20880012_DoAn_KTLT.Pages.LoaiHang
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
#line 1 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\_ViewImports.cshtml"
using _20880012_DoAn_KTLT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml"
using _20880012_DoAn_KTLT.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"856c22d815c0d105ed33c36e0eb86e1bea7760e1", @"/Pages/LoaiHang/MH_TimKiem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f58b6407f6f81083527f4f62ac60bc058fca0a7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoaiHang_MH_TimKiem : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml"
  
    Layout = "_LayoutLH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "856c22d815c0d105ed33c36e0eb86e1bea7760e13785", async() => {
                WriteLiteral("\r\n    <label for=\"malh\">Nh???p m?? ho???c t??n lo???i h??ng c???n t??m:</label><br />\r\n    <input type=\"text\" name=\"keyword\"");
                BeginWriteAttribute("value", " value=\"", 273, "\"", 281, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"submit\" value=\"T??m ki???m\" />\r\n");
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
            WriteLiteral("\r\n");
#nullable restore
#line 13 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml"
Write(Model.Ketqua);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>M?? lo???i h??ng</th>\r\n            <th>T??n lo???i h??ng</th>\r\n            <th>Ch???c n??ng</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml"
         foreach (Loaihang l in Model.DSLH) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml"
               Write(l.MaLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml"
               Write(l.TenLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 766, "\"", 806, 2);
            WriteAttributeValue("", 773, "/LoaiHang/MH_Sua?id=", 773, 20, true);
#nullable restore
#line 30 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml"
WriteAttributeValue("", 793, l.MaLoaiHang, 793, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\" role=\"button\">S???a</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 874, "\"", 914, 2);
            WriteAttributeValue("", 881, "/LoaiHang/MH_Xoa?id=", 881, 20, true);
#nullable restore
#line 31 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml"
WriteAttributeValue("", 901, l.MaLoaiHang, 901, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" role=\"button\">X??a</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\LoaiHang\MH_TimKiem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_20880012_DoAn_KTLT.Pages.LoaiHang.MH_TimKiemModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.LoaiHang.MH_TimKiemModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.LoaiHang.MH_TimKiemModel>)PageContext?.ViewData;
        public _20880012_DoAn_KTLT.Pages.LoaiHang.MH_TimKiemModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
