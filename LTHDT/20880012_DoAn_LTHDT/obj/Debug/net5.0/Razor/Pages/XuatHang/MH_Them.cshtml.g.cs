#pragma checksum "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e5b54a0ed8804068d2934e804e556838bc59fef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20880012_DoAn_LTHDT.Pages.XuatHang.Pages_XuatHang_MH_Them), @"mvc.1.0.razor-page", @"/Pages/XuatHang/MH_Them.cshtml")]
namespace _20880012_DoAn_LTHDT.Pages.XuatHang
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
#line 1 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\_ViewImports.cshtml"
using _20880012_DoAn_LTHDT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e5b54a0ed8804068d2934e804e556838bc59fef", @"/Pages/XuatHang/MH_Them.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c736d9bca9575e5831b7fea84af645ce223a2263", @"/Pages/_ViewImports.cshtml")]
    public class Pages_XuatHang_MH_Them : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
  
    Layout = "_LayoutXH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
 if (Model.KiemTra)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e5b54a0ed8804068d2934e804e556838bc59fef4387", async() => {
                WriteLiteral("\n        <label for=\"mahd\">Nhập mã hóa đơn:</label><br />\n        <input type=\"text\" name=\"mahd\"");
                BeginWriteAttribute("value", " value=\"", 253, "\"", 261, 0);
                EndWriteAttribute();
                WriteLiteral(" required /><br />\n        <label for=\"ngaynhap\">Ngày nhập hàng:</label><br />\n        <input type=\"date\" name=\"ngaytao\"");
                BeginWriteAttribute("value", " value=\"", 382, "\"", 390, 0);
                EndWriteAttribute();
                WriteLiteral(" required /><br /><br />\n        <p>Thông tin nhập hàng: <input type=\"button\" onclick=\"themsp()\" value=\"Thêm Sản Phẩm\"></p>\n        <div id=\"dssp\">\n            <input id=\"demsp\" name=\"demsp\"");
                BeginWriteAttribute("value", " value=\"", 581, "\"", 601, 1);
#nullable restore
#line 17 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
WriteAttributeValue("", 589, Model.DemSP, 589, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\n");
#nullable restore
#line 18 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
             for (int i = 0; i < Model.DemSP; i++)
            {
                var mamh = "mamh" + i;
                var gia = "gia" + i;
                var sl = "sl" + i;
                var sp = "sp" + i;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div");
                BeginWriteAttribute("id", " id=\"", 844, "\"", 852, 1);
#nullable restore
#line 24 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
WriteAttributeValue("", 849, sp, 849, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <select");
                BeginWriteAttribute("name", " name=\"", 882, "\"", 894, 1);
#nullable restore
#line 25 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
WriteAttributeValue("", 889, mamh, 889, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 895, "\"", 905, 1);
#nullable restore
#line 25 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
WriteAttributeValue("", 900, mamh, 900, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e5b54a0ed8804068d2934e804e556838bc59fef7280", async() => {
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
                WriteLiteral("\n");
#nullable restore
#line 27 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
                         foreach (TonkhoMH t in Model.DSTK)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e5b54a0ed8804068d2934e804e556838bc59fef8815", async() => {
#nullable restore
#line 29 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
                                               Write(t.TenMH);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" (");
#nullable restore
#line 29 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
                                                         Write(t.MaMH);

#line default
#line hidden
#nullable disable
                    WriteLiteral(") - Tồn kho: ");
#nullable restore
#line 29 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
                                                                             Write(t.TonKho);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
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
                WriteLiteral("\n");
#nullable restore
#line 30 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\n                    <label");
                BeginWriteAttribute("for", " for=", 1241, "", 1250, 1);
#nullable restore
#line 32 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
WriteAttributeValue("", 1246, gia, 1246, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Giá:</label>\n                    <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 1304, "", 1314, 1);
#nullable restore
#line 33 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
WriteAttributeValue("", 1310, gia, 1310, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"0\" value=\"0\" required />\n                    <label");
                BeginWriteAttribute("for", " for=", 1371, "", 1379, 1);
#nullable restore
#line 34 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
WriteAttributeValue("", 1376, sl, 1376, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Số lượng bán:</label>\n                    <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 1442, "", 1451, 1);
#nullable restore
#line 35 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
WriteAttributeValue("", 1448, sl, 1448, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"0\" value=\"0\" required /><br />\n                </div>\n");
#nullable restore
#line 37 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </div><br />\n        <input type=\"submit\" value=\"Lưu hóa đơn bán\" />\n        <input type=\"reset\" />\n    ");
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
            WriteLiteral("\n");
#nullable restore
#line 43 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 46 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\XuatHang\MH_Them.cshtml"
Write(Model.Ketqua);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    function themsp() {
        let i = $(""#demsp"").val();
        let mamh = ""mamh"" + i;
        let gia = ""gia"" + i;
        let sl = ""sl"" + i;
        let sp = ""sp"" + i;
        let spmoi = """";
        spmoi += '<div id=""' + sp + '""><select name=""' + mamh + '"">';
        spmoi += $(""#mamh0"").html();
        spmoi += '</select><label for=' + gia + '>&#8197;Giá:&#8197;</label><input type=""number"" name=' + gia + ' min=""0"" value=""0"" required />';
        spmoi += '<label for=' + sl + '>&#8197;Số lượng bán:&#8197;</label><input type=""number"" name=' + sl + ' min=""0"" value=""0"" required/><br />';

        $(""#dssp"").append(spmoi);
        i++;
        $(""#demsp"").val(i);
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_20880012_DoAn_LTHDT.Pages.XuatHang.MH_ThemModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_LTHDT.Pages.XuatHang.MH_ThemModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_LTHDT.Pages.XuatHang.MH_ThemModel>)PageContext?.ViewData;
        public _20880012_DoAn_LTHDT.Pages.XuatHang.MH_ThemModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
