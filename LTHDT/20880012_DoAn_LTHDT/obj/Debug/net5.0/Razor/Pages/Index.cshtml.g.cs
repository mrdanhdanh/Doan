#pragma checksum "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1bed8489d7d23cf850a4b0ff8ab63570788b38f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20880012_DoAn_LTHDT.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1bed8489d7d23cf850a4b0ff8ab63570788b38f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c736d9bca9575e5831b7fea84af645ce223a2263", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Bai tap HK 1\Doan\LTHDT\20880012_DoAn_LTHDT\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""btn-group"">
    <a href=""Mathang"" class=""btn btn-primary"" role=""button"">Mặt hàng</a>
    <button type=""button"" class=""btn btn-primary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"">
        <span class=""caret""></span>
    </button>
    <div class=""dropdown-menu"">
        <a class=""dropdown-item"" href=""/MatHang/MH_TimKiem"">Tìm Kiếm, Chỉnh Sửa</a>
        <a class=""dropdown-item"" href=""/MatHang/MH_Them"">Thêm Mặt Hàng</a>
    </div>
</div>

<div class=""btn-group"">
    <a href=""Loaihang"" class=""btn btn-primary"" role=""button"">Loại hàng</a>
    <button type=""button"" class=""btn btn-primary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"">
        <span class=""caret""></span>
    </button>
    <div class=""dropdown-menu"">
        <a class=""dropdown-item"" href=""/LoaiHang/MH_TimKiem"">Tìm Kiếm, Chỉnh Sửa</a>
        <a class=""dropdown-item"" href=""/LoaiHang/MH_Them"">Thêm Loại Hàng</a>
    </div>
</div>

<div class=""btn-group"">
    <a href=""Xuathang"" class=""btn btn-primary"" role=""but");
            WriteLiteral(@"ton"">Hóa đơn Bán Hàng</a>
    <button type=""button"" class=""btn btn-primary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"">
        <span class=""caret""></span>
    </button>
    <div class=""dropdown-menu"">
        <a class=""dropdown-item"" href=""/XuatHang/MH_TimKiem"">Tìm Kiếm, Chỉnh Sửa</a>
        <a class=""dropdown-item"" href=""/XuatHang/MH_Them"">Thêm HĐ Bán Hàng</a>
    </div>
</div>

<div class=""btn-group"">
    <a href=""Nhaphang"" class=""btn btn-primary"" role=""button"">Hóa đơn Nhập Hàng</a>
    <button type=""button"" class=""btn btn-primary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"">
        <span class=""caret""></span>
    </button>
    <div class=""dropdown-menu"">
        <a class=""dropdown-item"" href=""/NhapHang/MH_TimKiem"">Tìm Kiếm, Chỉnh Sửa</a>
        <a class=""dropdown-item"" href=""/NhapHang/MH_Them"">Thêm HĐ Nhập Hàng</a>
    </div>
</div>

<a href=""Thongketonkho"" class=""btn btn-primary"" role=""button"">Thống kê hàng tồn kho</a>

<a href=""Thongkehangcu"" class=""btn btn-primary""");
            WriteLiteral(" role=\"button\">Thống kê hàng hết hạn</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
