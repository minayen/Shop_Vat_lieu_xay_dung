<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangNhanVien.aspx.cs" Inherits="DeTaiQuanLyBanHang.TrangNhanVien" %>

<%@ Register Src="~/cms/TrangNhanVien/NhanVienLoadcontrol.ascx" TagPrefix="uc1" TagName="NhanVienLoadcontrol" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang nhân viên</title>
    <meta charset="utf-8"/>
    <link href="cms/TrangNhanVien/css/style.css" rel="stylesheet" />
    <script src="css/js/jquery-3.3.1.js"></script>
    <script src="css/js/javascript.js"></script>
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
            <asp:Button ID="btnDangXuat" runat="server" Text="Đăng xuất" CssClass="Dangxuat" OnClick="btnDangXuat_Click"  />
        </div>
            <div class ="clear"></div>
            <%--end user--%>
        <div class="menu">
          <ul>
              <li class="menu"><a href="/TrangNhanVien.aspx?modul=SanPham">Sản phẩm</a></li>
              <li class="menu"><a href="/TrangNhanVien.aspx?modul=KhachHang">Khách hàng</a></li>
              <li class="menu"><a href="/TrangNhanVien.aspx?modul=KhachHang">Thông tin tài khoản</a>
                  <ul><li><a href="/TrangNhanVien.aspx?modul=XemTT">Xem thông tin</a></li><li><a href="/TrangNhanVien.aspx?modul=CapNhatTT">Cập nhật thông tin</a></li><li><a href="/TrangNhanVien.aspx?modul=DoiMKTK">Đổi mật khẩu</a></li></ul>
              </li>
          </ul>
            <div class="clear"></div>

            <%--end menu--%>
        <div style="padding:5px;margin:5px; background:#58b6fb;height:20px;">
            
                <asp:Label ID="LabelCay" runat="server" Text="" ForeColor="Black"></asp:Label></div>
        </div>

        <div class="content">

            <uc1:NhanVienLoadcontrol runat="server" id="NhanVienLoadcontrol" />
        </div>
            <%--end content--%>
         <div class="footer">
             
        </div>
            <%--end footer--%>
        </div>
    </form>
    
</body>
</html>
