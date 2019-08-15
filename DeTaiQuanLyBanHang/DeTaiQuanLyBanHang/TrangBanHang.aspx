<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangBanHang.aspx.cs" Inherits="DeTaiQuanLyBanHang.TrangBanHang" %>

<%@ Register Src="~/cms/TrangBanHang/LoadControlTrangBanHang.ascx" TagPrefix="uc1" TagName="LoadControlTrangBanHang" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang bán hàng</title>
    <meta charset="utf-8"/>
    <link href="cms/TrangBanHang/css/style.css" rel="stylesheet" />
    <script src="css/js/jquery-3.3.1.js"></script>
    <script src="css/js/javascript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="wrapper">
        <div class ="top">
                <ul>
                    <li><img src="pic/slider/BANNER.jpg" /></li>
                    <li><img src="pic/slider/BANNER2.jpg" /></li>
                    <li><img src="pic/slider/BANNER3.jpg" /></li>
                    <li><img src="pic/slider/BANNER4.jpg" /></li>
                    
                </ul>
            <div class="clear"></div>
            
        </div>
            <%--end top--%>
        <div class="user">
        </div>
            <div class ="clear"></div>
            <%--end user--%>
        <div class="menu">
          <ul>
              <li class="menu"><a href="/TrangBanHang.aspx?modul=TrangChu" title="Trang Chủ">Trang chủ</a></li>
              <li class="menu"><a href="/TrangBanHang.aspx?modul=SanPham" title="Sản phẩm">Sản phẩm</a></li>
              <li class="menu"><a href="/TrangBanHang.aspx?modul=GioHang" title="Giỏi hàng">Giỏ hàng của tôi</a></li>
              <li class="menu"><a href="/TrangBanHang.aspx?modul=GioiThieu" title="Giới thiệu">Giới thiệu</a></li>
              <li class="menu"><a href="/TrangBanHang.aspx?modul=LienHe" title="Liên hệ">Liên hệ</a></li>
              <li class="menu"><a href="/TrangBanHang.aspx?modul=TinTuc" title="Tin tức">Tin tức</a></li>
              
              <li class="Search">
                    <asp:TextBox class ="txtSearch" ID="txtSearch" type ="text" placeholder ="Tìm kiếm sản phẩm" runat="server">
                    </asp:TextBox><asp:Button  class="btnSearch" ID="btnSearch" runat="server" Text="Tìm kiếm" OnClick="btnSearch_Click"/>

              </li>
              
          </ul>
            <div class="clear"></div>

            <%--end menu--%>
        <div style="padding:5px;margin:5px; background:#58b6fb;height:20px;">
            
                <asp:Label ID="LabelCay" runat="server" Text="" ForeColor="Black"></asp:Label></div>
        </div>

        <div class="content">

            <uc1:LoadControlTrangBanHang runat="server" ID="LoadControlTrangBanHang" />
        </div>
            <%--end content--%>
         <div class="footer">
             <div style="padding-top:20px">
                 <div class="fl" style="width:500px; text-align:center; ">
                 

                <h1 style="color:#58b6fb; text-transform:uppercase">Về chúng tôi</h1>

                   <div style="text-align:left; margin-left:30px; margin-right:20px">
                        CHÚNG TÔI CHUYÊN KINH DOANH
                        <br />
                        <br />
                        <hr />
                        Xi măng, sắt thép, cát, đá, gạch ống, gạch thẻ, gạch men, sơn...
                        <br />
                            <br />
                            <hr />
                        Dịch vụ vận tải
                       <br />
                       <br />
                       <hr />
                        Thi công công trình
                       <br />
                       <br />
                       <hr />
                   </div>
            </div>
             <div class="fl" style="width:498px;text-align:center; border-left:2px solid #f78839">
                 <h1 style="color:#58b6fb; text-transform:uppercase">liên hệ</h1>

                <div style="text-align:left; margin-left:30px;margin-right:20px">
                    Công ty TNHH MTV VLXD Kiên Cường
                        <br />
                        <br />
                        <hr />
                Mã Số thuế: 0401873869
                        <br />
                        <br />
                        <hr />
                Địa chỉ Kho: Ngã ba Trần Nam Trung - Phan Thao,
                Q. Cẩm Lệ, TP. Đà Nẵng.
                        <br />
                        <br />
                        <hr />
                Văn Phòng: 42 Cổ Mân Lan 2, Phường Hòa Xuân,
                Q. Cẩm Lệ, TP. Đà Nẵng
                        <br />
                        <br />
                        <hr />
                0236.6505.999
                        <br />
                        <br />
                        <hr />
                0935.91.1979 - 0986.91.1979
                        <br />
                        <br />
                        <hr />
                Kiencuong@vatlieuxaydungdanang.com.vn
                        <br />
                        <br />
                        <hr />
                </div>
            </div>
             <div class="clear"></div>
             <div style="text-align:center; height:40px; line-height:40px; border-top:2px solid #f78839; margin-top:20px">
           Copyright © 2017 Đại học Quy Nhơn - Quy Nhon University. All Rights Reserved 
              </div>
             </div>
        </div>
            <%--end footer--%>
        </div>
    </form>
    
</body>
</html>