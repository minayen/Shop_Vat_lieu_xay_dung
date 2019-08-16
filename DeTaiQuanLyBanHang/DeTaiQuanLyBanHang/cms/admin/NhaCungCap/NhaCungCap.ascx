<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NhaCungCap.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.NhaCungCap.NhaCungCapLoadControl" %>
<%@ Register Src="~/cms/admin/NhaCungCap/NhaCungCapLoadControl.ascx" TagPrefix="uc1" TagName="NhaCungCapLoadControl" %>

<div class="left">
        <div class="childleft">
        <div class="Title">Danh mục nhà cung cấp</div>
        <div class="Link">
                <img src="../../../pic/arrow-right.gif" />
                <a href ="/Admin.aspx?modul=NhaCungCap&modul1=DanhSachNCC">Danh sách nhà cung cấp</a>    
             <hr />
        </div>  
        <div class="Link">
            <img src="../../../pic/arrow-right.gif" />
            <a href ="/Admin.aspx?modul=NhaCungCap&modul1=ThemMoi">Thêm mới nhà cung cấp</a>
            <hr />
        </div> 
    </div>

</div>
<div class="right">
    <div class="childright">
        <uc1:NhaCungCapLoadControl runat="server" ID="NhaCungCapLoadControl" />
    </div>
</div>
<div class="clear"></div>