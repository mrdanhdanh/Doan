#pragma checksum "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48ade689a5200039d7cf7e19ec7eee313e56288b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20880012_DoAn_LTHDT.Pages.MatHang.Pages_MatHang_MH_Sua), @"mvc.1.0.razor-page", @"/Pages/MatHang/MH_Sua.cshtml")]
namespace _20880012_DoAn_LTHDT.Pages.MatHang
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
#line 3 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48ade689a5200039d7cf7e19ec7eee313e56288b", @"/Pages/MatHang/MH_Sua.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c736d9bca9575e5831b7fea84af645ce223a2263", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MatHang_MH_Sua : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
  
    Layout = "_LayoutMH";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
 if (Model.KiemtraID)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ade689a5200039d7cf7e19ec7eee313e56288b4082", async() => {
                WriteLiteral("\n        <label for=\"mamh\">M?? m???t h??ng:</label><br />\n        <input type=\"text\" name=\"mamh\"");
                BeginWriteAttribute("value", " value=\"", 251, "\"", 270, 1);
#nullable restore
#line 13 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
WriteAttributeValue("", 259, Model.MaMH, 259, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\n        <label for=\"tenmh\">T??n m???t h??ng:</label><br />\n        <input type=\"text\" name=\"tenmh\"");
                BeginWriteAttribute("value", " value=\"", 384, "\"", 404, 1);
#nullable restore
#line 15 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
WriteAttributeValue("", 392, Model.TenMH, 392, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\n        <label for=\"ctysx\">C??ng ty s???n xu???t:</label><br />\n        <input type=\"text\" name=\"ctysx\"");
                BeginWriteAttribute("value", " value=\"", 522, "\"", 542, 1);
#nullable restore
#line 17 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
WriteAttributeValue("", 530, Model.CtySX, 530, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\n        <label for=\"tenlh\">Lo???i h??ng:</label><br />\n        <select name=\"tenlh\" required>\n");
#nullable restore
#line 20 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
             foreach (Loaihang l in Model.DSLH)
            {
                if (l.TenLoaiHang == Model.TenLH)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ade689a5200039d7cf7e19ec7eee313e56288b6243", async() => {
#nullable restore
#line 24 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
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
#line 24 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
                       WriteLiteral(l.TenLoaiHang);

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
                WriteLiteral("\n");
#nullable restore
#line 25 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ade689a5200039d7cf7e19ec7eee313e56288b8702", async() => {
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
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
#line 28 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
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
                WriteLiteral("\n");
#nullable restore
#line 29 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select><br />\n        <label for=\"gia\">Gi?? m???t h??ng:</label><br />\n        <input type=\"number\" name=\"gia\" min=\"0\"");
                BeginWriteAttribute("value", " value=\"", 1156, "\"", 1174, 1);
#nullable restore
#line 34 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
WriteAttributeValue("", 1164, Model.Gia, 1164, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\n        <label for=\"ngaysx\">Ng??y s???n xu???t:</label><br />\n        <input type=\"date\" name=\"ngaysx\"");
                BeginWriteAttribute("value", " value=\"", 1291, "\"", 1312, 1);
#nullable restore
#line 36 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
WriteAttributeValue("", 1299, Model.NgaySX, 1299, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\n        <label for=\"hansd\">H???n s??? d???ng:</label><br />\n        <input type=\"date\" name=\"hansd\"");
                BeginWriteAttribute("value", " value=\"", 1425, "\"", 1445, 1);
#nullable restore
#line 38 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
WriteAttributeValue("", 1433, Model.HanSD, 1433, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\n        <br />\n        <input type=\"submit\" value=\"S???a m???t h??ng\" />\n        <input type=\"reset\" value=\"Reset\">\n    ");
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
            WriteLiteral("\n");
#nullable restore
#line 43 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\MatHang\MH_Sua.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_20880012_DoAn_LTHDT.Pages.MatHang.MH_SuaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_LTHDT.Pages.MatHang.MH_SuaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_LTHDT.Pages.MatHang.MH_SuaModel>)PageContext?.ViewData;
        public _20880012_DoAn_LTHDT.Pages.MatHang.MH_SuaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
