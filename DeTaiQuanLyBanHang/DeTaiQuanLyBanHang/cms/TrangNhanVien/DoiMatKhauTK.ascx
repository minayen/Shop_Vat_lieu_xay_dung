<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DoiMatKhauTK.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangNhanVien.DoiMatKhauTK" %>
<style>
    .Input{
        padding:4px;
    }
    .TieuDe{
        text-align:center;
        font-size:20px;
        font-weight:bold;
        color:#140e0e
    }
    .btnThemMoi{
        padding:8px;
        background:#413737;
        font:bold 15px;
        color:#ffffff;
    }
    .btnThemMoi:hover{
        background:#f83030;
        cursor:pointer;
    }
</style>
<div class="TieuDe">Đổi mật khẩu</div>
<table style="margin-left:37%">
    <tr class="row">
       <td class="Lable"> <span >MẬT KHẨU CŨ</span></td>
        <td class="Input"><asp:TextBox ID="txtMatKhauCu" runat="server" class="Input"  placeholder="Mật khẩu cũ" TextMode="Password"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtMatKhauCu"></asp:RequiredFieldValidator></td>
    </tr>
    <tr class="row">
        <td class="Lable"><span>MẬT KHẨU MỚI</span></td>
        <td class="Input"><asp:TextBox ID="txtMatKhauMoi" runat="server" class="Input"  placeholder="Nật khẩu mới" TextMode="Password"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtMatKhauMoi"></asp:RequiredFieldValidator>
        </td>
    
    </tr>
        <tr class="row">
        <td class="Lable"><span>NHẬP LẠI MẬT KHẨU</span></td>
        <td class="Input"><asp:TextBox ID="txtMatKhauMoi2" runat="server" class="Input"  placeholder="Nhập lại mật khẩu mới" TextMode="Password"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtMatKhauMoi2"></asp:RequiredFieldValidator>
        </td>
    
    </tr>

    <tr class="row">
        <td class="Lable"></td>
        <td>
            <asp:Button ID="btnXacNhan" runat="server" Text="Xác nhận" class="btnThemMoi" OnClick="btnXacNhan_Click"/>
        </td>

    </tr>    
</table>