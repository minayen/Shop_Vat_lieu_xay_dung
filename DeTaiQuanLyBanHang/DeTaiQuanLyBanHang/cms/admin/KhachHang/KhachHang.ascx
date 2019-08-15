<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="KhachHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.NewFolder1.KhachHang" %>
<%@ Register Src="~/cms/admin/KhachHang/KhachHangLoadControl.ascx" TagPrefix="uc1" TagName="KhachHangLoadControl" %>


<div class="left">
        <div class="childleft">
        <div class="Title">Danh mục khách hàng</div>
        <div class="Link">
            <img src="../../../pic/arrow-right.gif" />
            <a href ="/Admin.aspx?modul=KhachHang&modul1=DSKH">Danh sách khách hàng</a>
            <hr />
        </div> 
        <div class="Link">
                <img src="../../../pic/arrow-right.gif" />
                <a href ="/Admin.aspx?modul=KhachHang&modul1=XemDSDonHang">Danh sách đơn hàng</a>    
             <hr />
        </div>  
    </div>

</div>
<div class="right">
    <div class="childright">
        <uc1:KhachHangLoadControl runat="server" ID="KhachHangLoadControl" />
    </div>
</div>
<div class="clear"></div>