<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="DeTaiQuanLyBanHang.Admin" %>

<%@ Register Src="~/cms/admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang quản lý</title>
    <meta charset="utf-8"/>
    <link href="cms/admin/css/admin.css" rel="stylesheet" />
    <script src="css/js/jquery-3.3.1.js"></script>
    <%--<script src="css/js/javascript.js"></script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="wrapper">
        <div class ="top">
            <div class="clear"></div>
            
        </div>
            <%--end top--%>
        <div class="user">
            <asp:Label ID="lbXinChao" runat="server" Text="Xin chào" CssClass="Float"></asp:Label>
            <asp:Button ID="btnDangXuat" runat="server" Text="Đăng xuất" CssClass="Dangxuat" OnClick="btnDangXuat_Click" CausesValidation="False" />
        </div>
            <div class ="clear"></div>
            <%--end user--%>
        <div class="menu">
          <ul>
              <%--<li class="menu"><a href="/Admin.aspx?modul=TrangChu">Trang chủ</a></li>--%>
              <li class="menu"><a href="/Admin.aspx?modul=SanPham&modul1=DanhSachSanPham">Sản phẩm</a></li>
              <li class="menu"><a href="/Admin.aspx?modul=KhachHang&modul1=DSKH">Khách hàng</a></li>
              <li class="menu"><a href="/Admin.aspx?modul=NhaCungCap&modul1=DanhSachNCC">Nhà cung cấp</a></li>
              <li class="menu"><a href="/Admin.aspx?modul=TaiKhoan&modul1=DSTaiKhoan">Tài khoản</a></li>
              <%--<li class="menu"><a href="/Admin.aspx?modul=TinTuc">Tin tức</a></li>--%>
   <%--           <li class="menu"><a href="/Admin.aspx?modul=GioiThieu">Giới thiệu</a></li>
              <li class="menu"><a href="/Admin.aspx?modul=LienHe">Liên hệ</a></li>--%>
              
             <%-- <li class="Search">
                    <asp:TextBox class ="txtSearch" type ="text" placeholder ="Tìm kiếm sản phẩm" runat="server">
                    </asp:TextBox><asp:Button  class="btnSearch" ID="btnSearch" runat="server" Text="Tìm kiếm"/>

              </li>--%>
              
          </ul>
            <div class="clear"></div>

            <%--end menu--%>
        <div style="padding:5px;margin:5px; background:#58b6fb;height:20px;">
            
                <asp:Label ID="LabelCay" runat="server" Text="" ForeColor="Black"></asp:Label></div>
        </div>

        <div class="content">

            <uc1:AdminLoadControl runat="server" id="AdminLoadControl1" />
        </div>
            <%--end content--%>
         <div class="footer">
         </div>
        </div>
    </form>
</body>
</html>
