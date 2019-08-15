<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPham.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.SanPham.SanPham" %>
<%@ Register Src="~/cms/admin/SanPham/SanPhamLoadControl.ascx" TagPrefix="uc1" TagName="SanPhamLoadControl" %>

<div class="left">
    <div class="childleft">
        <div class="Title">Danh mục sản phẩm</div>
        <div class="Link">
            <img src="../../../pic/arrow-right.gif" />
            <a href ="/Admin.aspx?modul=SanPham&modul1=ThemMoiSP">Thêm mới sản phẩm</a>
            <hr />
        </div> 
        <div class="Link">
                <img src="../../../pic/arrow-right.gif" />
                <a href ="/Admin.aspx?modul=SanPham&modul1=DanhSachSanPham">Danh sách sản phẩm</a>    
             <hr />
        </div>  
    </div>
    <div class="childleft">
        <div class="Title">Loại sản phẩm</div>
        <div class="Link">
            <img src="../../../pic/arrow-right.gif" />
            <a href ="/Admin.aspx?modul=SanPham&modul1=DSLoai">Xem danh sách loại</a>
            <hr />
        </div>   
    </div>

    <div class="childleft">
        <div class="Title">Danh mục nhập hàng</div>
        <div class="Link">
            <img src="../../../pic/arrow-right.gif" />
            <a href ="/Admin.aspx?modul=SanPham&modul1=NhapHang">Nhập hàng vào kho</a>
            <hr />
        </div>   
        <div class="Link">
            <img src="../../../pic/arrow-right.gif" />
            <a href ="/Admin.aspx?modul=SanPham&modul1=DanhSachDonNHapHang">Danh sách đơn nhập hàng</a>
            <hr />
        </div>   
    </div>

</div>
<div class="right">
    <div class="childright">
        <uc1:SanPhamLoadControl runat="server" id="SanPhamLoadControl" />
    </div>
</div>
<div class="clear"></div>
