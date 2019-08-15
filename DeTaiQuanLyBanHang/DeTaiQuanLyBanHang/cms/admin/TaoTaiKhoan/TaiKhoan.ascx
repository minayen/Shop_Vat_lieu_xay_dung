<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaiKhoan.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.TaoTaiKhoan.TaiKhoan" %>
<%@ Register Src="~/cms/admin/TaoTaiKhoan/TaoTaiKhoanLoadControl.ascx" TagPrefix="uc1" TagName="TaoTaiKhoanLoadControl" %>



<div class="left">
        <div class="childleft">
        <div class="Title">Danh mục nhà cung cấp</div>
        <div class="Link">
                <img src="../../../pic/arrow-right.gif" />
                <a href ="/Admin.aspx?modul=TaiKhoan&modul1=DSTaiKhoan">Danh sách tài khoản</a>    
             <hr />
        </div>  
        <div class="Link">
            <img src="../../../pic/arrow-right.gif" />
            <a href ="/Admin.aspx?modul=TaiKhoan&modul1=TaoTaiKhoan">Thêm mới tài khoản</a>
            <hr />
        </div> 
    </div>

</div>
<div class="right">
    <div class="childright">
        <uc1:TaoTaiKhoanLoadControl runat="server" ID="TaoTaiKhoanLoadControl" />
    </div>
</div>
<div class="clear"></div>