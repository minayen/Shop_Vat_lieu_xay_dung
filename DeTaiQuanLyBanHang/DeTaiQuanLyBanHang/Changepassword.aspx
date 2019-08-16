<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Changepassword.aspx.cs" Inherits="DeTaiQuanLyBanHang.ForgotPassWord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            margin:0px;
            padding:0px;
            font: arial 18px bold;
        }
        .clear {
            clear: both;
        }
        #Login{
            width:400px;
            margin:auto;
            margin-top:100px;
            background-color:#f1f1f1;
            border-radius: 4px;
        }
        #Login .Dangnhap{
            width: 400px;
            text-align: center;
            text-transform:uppercase; 
            background-color:#0094ff;
            font-size: 20px;
            color: white;
            line-height:60px;
            height: 60px;
            margin-bottom: 7px;
            border-radius:4px;
        }

        #Login .txtThongtin:focus{border-color:deepskyblue}
        #Login .txtThongtin {
            width:350px;
            font-size: 14px;
            line-height:30px;
            height: 30px;
            margin-bottom: 5px;
            border-radius: 3px;
        }
        #Login .btnDangnhap {
            width:350px;
            margin: auto;
            text-align: center;
            font-size: 14px;
            text-transform:uppercase; 
            background-color:#0094ff;
            color: white;
            line-height:50px;
            height: 50px;
            margin-top: 7px;
            margin-bottom: 15px;
            cursor: pointer;
        }
        .center{
            width: 350px;
            margin: auto;
           
        }
        .lbThongbao{
            text-align: center;
            color: red;
        }
        a{
            text-decoration:none;
            margin-right: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Login">
            <div class="Dangnhap"><asp:Label  runat="server" Text="Đổi mật khẩu"></asp:Label></div>
            <div class="center"><asp:TextBox class="txtThongtin" runat="server" placeholder ="Mật khẩu cũ" ID="txtUserName" TextMode="Password"></asp:TextBox></div>
            <div class="center"><asp:TextBox class="txtThongtin"  runat="server" TextMode="Password"  placeholder ="Mật khẩu mới" ID="txtPass"></asp:TextBox></div>
            <div class="center"><asp:TextBox class="txtThongtin"  runat="server" TextMode="Password"  placeholder ="Nhập lại mật khẩu mới" ID="TextBox1"></asp:TextBox></div>
            <div class="lbThongbao"><asp:Label runat="server" ID="lbThongbao">Thông báo</asp:Label></div>
            <div  class="center"><asp:Button  class="btnDangnhap" runat="server" Text="Hoàn thành" ID="btnDangNhap"/></div>
        </div>
    </form>
</body>
</html>