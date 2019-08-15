<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="KhachHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangNhanVien.KhachHang" %>
<%@ Register Src="~/cms/TrangNhanVien/KhachHangLoadConTrol.ascx" TagPrefix="uc1" TagName="KhachHangLoadConTrol" %>



<div class="left">
        <div class="childleft">
        <div class="Title">Danh mục khách hàng</div>
        <div class="Link">
            <img src="../../../pic/arrow-right.gif" />
            <a href ="/TrangNhanVien.aspx?modul=KhachHang&modul1=DanhSachKhachHang">Danh sách khách hàng</a>
            <hr />
        </div> 
        <div class="Link">
                <img src="../../../pic/arrow-right.gif" />
                <a href ="/TrangNhanVien.aspx?modul=KhachHang&modul1=DSDonHang">Danh sách đơn hàng</a>    
             <hr />
        </div>  
    </div>

</div>
<div class="right">
    <div class="childright">
        <uc1:KhachHangLoadConTrol runat="server" ID="KhachHangLoadConTrol" />
    </div>
</div>
<div class="clear"></div>