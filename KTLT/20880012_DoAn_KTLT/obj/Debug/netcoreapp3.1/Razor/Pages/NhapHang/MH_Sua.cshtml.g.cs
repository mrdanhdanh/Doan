#pragma checksum "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdf892e48dfbed5f100895491918190f3e70d318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20880012_DoAn_KTLT.Pages.NhapHang.Pages_NhapHang_MH_Sua), @"mvc.1.0.razor-page", @"/Pages/NhapHang/MH_Sua.cshtml")]
namespace _20880012_DoAn_KTLT.Pages.NhapHang
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
#line 3 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
using _20880012_DoAn_KTLT.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdf892e48dfbed5f100895491918190f3e70d318", @"/Pages/NhapHang/MH_Sua.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f58b6407f6f81083527f4f62ac60bc058fca0a7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NhapHang_MH_Sua : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
  
    Layout = "_LayoutNH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
 if (Model.MaHD != null)
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf892e48dfbed5f100895491918190f3e70d3184362", async() => {
                WriteLiteral("\r\n    <label for=\"mahd\">Nh???p m?? h??a ????n:</label><br />\r\n    <input type=\"text\" name=\"mahd\"");
                BeginWriteAttribute("value", " value=\"", 274, "\"", 293, 1);
#nullable restore
#line 12 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
WriteAttributeValue("", 282, Model.MaHD, 282, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\r\n    <label for=\"ngaynhap\">Ng??y nh???p h??ng:</label><br />\r\n    <input type=\"date\" name=\"ngaynhap\"");
                BeginWriteAttribute("value", " value=\"", 409, "\"", 432, 1);
#nullable restore
#line 14 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
WriteAttributeValue("", 417, Model.NgayNhap, 417, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\r\n    <p>Thong tin nhap h??ng:</p>\r\n    <div id=\"spnhap\">\r\n");
#nullable restore
#line 17 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
         for (int i = 0; i < 5; i++)
        {
            var mamh = "mamh" + i;
            var gia = "gia" + i;
            var sl = "sl" + i;

#line default
#line hidden
#nullable disable
                WriteLiteral("        <select");
                BeginWriteAttribute("name", " name=\"", 675, "\"", 687, 1);
#nullable restore
#line 22 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
WriteAttributeValue("", 682, mamh, 682, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf892e48dfbed5f100895491918190f3e70d3186391", async() => {
                    WriteLiteral("Chon mat hang");
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
#line 24 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
             foreach (Mathang m in Model.DSMH)
            {
                if (m.MaMatHang == Model.DSHH[i].MaMH)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf892e48dfbed5f100895491918190f3e70d3187969", async() => {
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
                                                     Write(m.TenMatHang);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" (");
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
                                                                    Write(m.MaMatHang);

#line default
#line hidden
#nullable disable
                    WriteLiteral(")");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
                       WriteLiteral(m.MaMatHang);

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
#line 29 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf892e48dfbed5f100895491918190f3e70d31810750", async() => {
#nullable restore
#line 32 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
                                            Write(m.TenMatHang);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" (");
#nullable restore
#line 32 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
                                                           Write(m.MaMatHang);

#line default
#line hidden
#nullable disable
                    WriteLiteral(")");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
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
#line 33 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n            <label");
                BeginWriteAttribute("for", " for=", 1198, "", 1207, 1);
#nullable restore
#line 36 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
WriteAttributeValue("", 1203, gia, 1203, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Gia:</label>\r\n            <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 1254, "", 1264, 1);
#nullable restore
#line 37 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
WriteAttributeValue("", 1260, gia, 1260, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1264, "\"", 1290, 1);
#nullable restore
#line 37 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
WriteAttributeValue("", 1272, Model.DSHH[i].Gia, 1272, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <label");
                BeginWriteAttribute("for", " for=", 1314, "", 1322, 1);
#nullable restore
#line 38 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
WriteAttributeValue("", 1319, sl, 1319, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">S??? l?????ng nh???p:</label>\r\n            <input type=\"number\"");
                BeginWriteAttribute("name", " name=", 1379, "", 1388, 1);
#nullable restore
#line 39 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
WriteAttributeValue("", 1385, sl, 1385, 3, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1388, "\"", 1418, 1);
#nullable restore
#line 39 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
WriteAttributeValue("", 1396, Model.DSHH[i].SoLuong, 1396, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n");
#nullable restore
#line 40 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <input type=\"submit\" value=\"S???a H??a ????n\" />\r\n    <input type=\"reset\" />\r\n");
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
            WriteLiteral("\r\n");
#nullable restore
#line 46 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 48 "D:\Bai tap HK 1\Doan\KTLT\20880012_DoAn_KTLT\Pages\NhapHang\MH_Sua.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_20880012_DoAn_KTLT.Pages.NhapHang.MH_SuaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.NhapHang.MH_SuaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_KTLT.Pages.NhapHang.MH_SuaModel>)PageContext?.ViewData;
        public _20880012_DoAn_KTLT.Pages.NhapHang.MH_SuaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
