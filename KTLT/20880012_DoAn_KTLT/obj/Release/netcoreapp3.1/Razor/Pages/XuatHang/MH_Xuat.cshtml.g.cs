#pragma checksum "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "532575061f3cfc720b80aba8f470927a54d52339"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20880012_DoAn_KTLT.Pages.XuatHang.Pages_XuatHang_MH_Xuat), @"mvc.1.0.razor-page", @"/Pages/XuatHang/MH_Xuat.cshtml")]
namespace _20880012_DoAn_KTLT.Pages.XuatHang
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
#line 3 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
using _20880012_DoAn_KTLT.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"532575061f3cfc720b80aba8f470927a54d52339", @"/Pages/XuatHang/MH_Xuat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f58b6407f6f81083527f4f62ac60bc058fca0a7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_XuatHang_MH_Xuat : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
  
    Layout = "_LayoutXH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "532575061f3cfc720b80aba8f470927a54d523394186", async() => {
                WriteLiteral("\r\n    <label for=\"mahd\">Nhập mã hóa đơn:</label><br />\r\n    <input type=\"text\" name=\"mahd\"");
                BeginWriteAttribute("value", " value=\"", 246, "\"", 254, 0);
                EndWriteAttribute();
                WriteLiteral(" required /><br />\r\n    <label for=\"ngayxuat\">Ngày bán hàng:</label><br />\r\n    <input type=\"date\" name=\"ngayxuat\"");
                BeginWriteAttribute("value", " value=\"", 369, "\"", 377, 0);
                EndWriteAttribute();
                WriteLiteral(" required /><br />\r\n    <p>Thông tin bán hàng:</p>\r\n    <div id=\"spban\">\r\n");
#nullable restore
#line 15 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
         for (int i = 0; i < 5; i++)
        {
            var mamh = "mamh" + i;
            var gia = "gia" + i;
            var sl = "sl" + i;

#line default
#line hidden
#nullable disable
                WriteLiteral("        <select");
                BeginWriteAttribute("name", " name=\"", 618, "\"", 630, 1);
#nullable restore
#line 20 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
WriteAttributeValue("", 625, mamh, 625, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "532575061f3cfc720b80aba8f470927a54d523395782", async() => {
                    WriteLiteral("Chọn mặt hàng");
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
                WriteLiteral("\r\n");
#nullable restore
#line 22 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
             foreach (TonkhoMH t in Model.DSTKMH)
            {
                foreach (Mathang m in Model.DSMH)
                {
                    if (t.MaMH == m.MaMatHang)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "532575061f3cfc720b80aba8f470927a54d523397434", async() => {
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
                                                Write(m.TenMatHang);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" (");
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
                                                               Write(m.MaMatHang);

#line default
#line hidden
#nullable disable
                    WriteLiteral(") - Tồn kho: ");
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
                                                                                        Write(t.SL);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
                           WriteLiteral(m.MaMatHang);

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
#line 29 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
                    }
                }

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n            <label");
                BeginWriteAttribute("for", " for=", 1099, "", 1108, 1);
#nullable restore
#line 34 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
WriteAttributeValue("", 1104, gia, 1104, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Giá:</label>\r\n            <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 1155, "", 1165, 1);
#nullable restore
#line 35 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
WriteAttributeValue("", 1161, gia, 1161, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1165, "\"", 1173, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <label");
                BeginWriteAttribute("for", " for=", 1197, "", 1205, 1);
#nullable restore
#line 36 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
WriteAttributeValue("", 1202, sl, 1202, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Số lượng bán:</label>\r\n            <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 1261, "", 1270, 1);
#nullable restore
#line 37 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
WriteAttributeValue("", 1267, sl, 1267, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1270, "\"", 1278, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n");
#nullable restore
#line 38 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <input type=\"submit\" value=\"Bán hàng\" />\r\n    <input type=\"reset\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 45 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Xuat.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_20880012_DoAn_KTLT.Pages.XuatHang.MH_XuatModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.XuatHang.MH_XuatModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.XuatHang.MH_XuatModel>)PageContext?.ViewData;
        public _20880012_DoAn_KTLT.Pages.XuatHang.MH_XuatModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591