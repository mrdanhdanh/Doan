#pragma checksum "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de969597bd9ba87f872d763294dbbf6d4ed8fe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20880012_DoAn_LTHDT.Pages.Pages_Thongkehangcu), @"mvc.1.0.razor-page", @"/Pages/Thongkehangcu.cshtml")]
namespace _20880012_DoAn_LTHDT.Pages
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
#line 3 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5de969597bd9ba87f872d763294dbbf6d4ed8fe9", @"/Pages/Thongkehangcu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c736d9bca9575e5831b7fea84af645ce223a2263", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Thongkehangcu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
  
    Layout = "_LayoutTK";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
Write(Model.ThongBao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
 if (Model.KiemTra)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de969597bd9ba87f872d763294dbbf6d4ed8fe94564", async() => {
                WriteLiteral("\r\n        <label for=\"mamh\">Chọn mặt hàng:</label>\r\n        <select name=\"mamh\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de969597bd9ba87f872d763294dbbf6d4ed8fe94922", async() => {
                    WriteLiteral("Xem tất cả");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
#line 15 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
             foreach (TonkhoMH t in Model.DSTK)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de969597bd9ba87f872d763294dbbf6d4ed8fe96742", async() => {
#nullable restore
#line 17 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
                                   Write(t.TenMH);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" (");
#nullable restore
#line 17 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
                                             Write(t.MaMH);

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
#line 17 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
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
#line 18 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n        <label for=\"outdate\">\r\n");
#nullable restore
#line 21 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
             if (Model.OutDate == "on")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"checkbox\" name=\"outdate\" value=\"on\" checked />\r\n");
#nullable restore
#line 24 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"checkbox\" name=\"outdate\" value=\"on\" />\r\n");
#nullable restore
#line 28 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            Lọc hết hạn\r\n        </label>\r\n\r\n        <input type=\"submit\" value=\"Xem tồn kho\" />\r\n    ");
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
            WriteLiteral("    <table class=\"table table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>Tên mặt hàng</th>\r\n                <th>Số lượng tồn</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 44 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
             foreach (TonkhoMH t in Model.DSloc)
            {
                var MatHang = t.TenMH + " (" + t.MaMH + ")";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 49 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
                   Write(MatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
                   Write(t.TonKho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 55 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Thongkehangcu.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_20880012_DoAn_LTHDT.Pages.ThongkehangcuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_LTHDT.Pages.ThongkehangcuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_20880012_DoAn_LTHDT.Pages.ThongkehangcuModel>)PageContext?.ViewData;
        public _20880012_DoAn_LTHDT.Pages.ThongkehangcuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591