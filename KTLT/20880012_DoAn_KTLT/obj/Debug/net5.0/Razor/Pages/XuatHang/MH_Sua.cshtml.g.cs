#pragma checksum "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35559b30219192afc8c05768127a94a09baff59f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20880012_DoAn_KTLT.Pages.XuatHang.Pages_XuatHang_MH_Sua), @"mvc.1.0.razor-page", @"/Pages/XuatHang/MH_Sua.cshtml")]
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
#line 3 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
using _20880012_DoAn_KTLT.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35559b30219192afc8c05768127a94a09baff59f", @"/Pages/XuatHang/MH_Sua.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f58b6407f6f81083527f4f62ac60bc058fca0a7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_XuatHang_MH_Sua : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
  
    Layout = "_LayoutXH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
 if (Model.MaHD != null)
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35559b30219192afc8c05768127a94a09baff59f4072", async() => {
                WriteLiteral("\r\n    <label for=\"mahd\">Nhập mã hóa đơn:</label><br />\r\n    <input type=\"text\" name=\"mahd\"");
                BeginWriteAttribute("value", " value=\"", 274, "\"", 293, 1);
#nullable restore
#line 12 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
WriteAttributeValue("", 282, Model.MaHD, 282, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\r\n    <label for=\"ngayxuat\">Ngày bán hàng:</label><br />\r\n    <input type=\"date\" name=\"ngayxuat\"");
                BeginWriteAttribute("value", " value=\"", 408, "\"", 431, 1);
#nullable restore
#line 14 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
WriteAttributeValue("", 416, Model.NgayXuat, 416, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\r\n    <label for=\"mamh\">Chọn mặt hàng:</label><br />\r\n    <select name=\"mamh\" required>\r\n");
#nullable restore
#line 17 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
         foreach (Tonkho t in Model.DSTK)
        {
            Model.MatHang = "Error";
            foreach (Mathang m in Model.DSMH)
            {
                if (m.MaMatHang == t.MaMH)
                {
                    Model.MatHang = m.TenMatHang + " (" + m.MaMatHang + ") - Tồn kho: " + t.SL;
                }
            }
            if (t.MaMH == Model.MaMH)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35559b30219192afc8c05768127a94a09baff59f6011", async() => {
#nullable restore
#line 29 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
                                            Write(Model.MatHang);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
                   WriteLiteral(t.MaMH);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
            } else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35559b30219192afc8c05768127a94a09baff59f8421", async() => {
#nullable restore
#line 32 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
                                   Write(Model.MatHang);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
                   WriteLiteral(t.MaMH);

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
#line 33 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"

            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select><br />\r\n    <label for=\"sl\">Số lượng bán:</label><br />\r\n    <input type=\"number\" name=\"sl\"");
                BeginWriteAttribute("value", " value=\"", 1247, "\"", 1264, 1);
#nullable restore
#line 38 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
WriteAttributeValue("", 1255, Model.SL, 1255, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" required /><br />\r\n    <input type=\"submit\" value=\"Lưu chỉnh sửa\" />\r\n");
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
#line 41 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\XuatHang\MH_Sua.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_20880012_DoAn_KTLT.Pages.XuatHang.MH_SuaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.XuatHang.MH_SuaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.XuatHang.MH_SuaModel>)PageContext?.ViewData;
        public _20880012_DoAn_KTLT.Pages.XuatHang.MH_SuaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
