#pragma checksum "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\MatHang\MH_Them.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f57b542fe03abd6e0d3c3796700b26130953019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20880012_DoAn_KTLT.Pages.MatHang.Pages_MatHang_MH_Them), @"mvc.1.0.razor-page", @"/Pages/MatHang/MH_Them.cshtml")]
namespace _20880012_DoAn_KTLT.Pages.MatHang
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
#line 3 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\MatHang\MH_Them.cshtml"
using _20880012_DoAn_KTLT.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f57b542fe03abd6e0d3c3796700b26130953019", @"/Pages/MatHang/MH_Them.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f58b6407f6f81083527f4f62ac60bc058fca0a7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MatHang_MH_Them : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\MatHang\MH_Them.cshtml"
  
    Layout = "_LayoutMH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f57b542fe03abd6e0d3c3796700b261309530193887", async() => {
                WriteLiteral("\r\n    <label for=\"mamh\">Mã mặt hàng:</label><br />\r\n    <input type=\"text\" name=\"mamh\"");
                BeginWriteAttribute("value", " value=\"", 243, "\"", 251, 0);
                EndWriteAttribute();
                WriteLiteral(" required/><br />\r\n    <label for=\"tenmh\">Tên mặt hàng:</label><br />\r\n    <input type=\"text\" name=\"tenmh\"");
                BeginWriteAttribute("value", " value=\"", 358, "\"", 366, 0);
                EndWriteAttribute();
                WriteLiteral(" required/><br />\r\n    <label for=\"ctysx\">Công ty sản xuất:</label><br />\r\n    <input type=\"text\" name=\"ctysx\"");
                BeginWriteAttribute("value", " value=\"", 477, "\"", 485, 0);
                EndWriteAttribute();
                WriteLiteral(" required/><br />\r\n    <label for=\"tenlh\">Loại hàng:</label><br />\r\n    <select name=\"tenlh\" required>\r\n");
#nullable restore
#line 17 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\MatHang\MH_Them.cshtml"
         foreach (Loaihang l in Model.DSLH)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f57b542fe03abd6e0d3c3796700b261309530195301", async() => {
#nullable restore
#line 19 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\MatHang\MH_Them.cshtml"
                                      Write(l.TenLoaiHang);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\MatHang\MH_Them.cshtml"
               WriteLiteral(l.TenLoaiHang);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\MatHang\MH_Them.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select><br />\r\n    <label for=\"namsx\">Năm sản xuất:</label><br />\r\n    <input type=\"number\" name=\"namsx\"");
                BeginWriteAttribute("value", " value=\"", 835, "\"", 843, 0);
                EndWriteAttribute();
                WriteLiteral(" min=\"1900\" max=\"2022\" required/><br />\r\n    <label for=\"namsx\">Hạn sử dụng (đơn vị: năm):</label><br />\r\n    <input type=\"number\" name=\"hansd\"");
                BeginWriteAttribute("value", " value=\"", 987, "\"", 995, 0);
                EndWriteAttribute();
                WriteLiteral(" required/><br />\r\n    <br />\r\n    <input type=\"submit\" value=\"Thêm mặt hàng\" />\r\n    <input type=\"reset\" value=\"Reset\">\r\n");
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 31 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\MatHang\MH_Them.cshtml"
Write(Model.Ketqua);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_20880012_DoAn_KTLT.Pages.MatHang.MH_ThemModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.MatHang.MH_ThemModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.MatHang.MH_ThemModel>)PageContext?.ViewData;
        public _20880012_DoAn_KTLT.Pages.MatHang.MH_ThemModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
