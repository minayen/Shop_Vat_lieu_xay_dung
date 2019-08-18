<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="XacNhanGioHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangBanHang.GioHang.XacNhanGioHang" %>
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
<div class="TieuDe">Thông tin khách hàng</div>
<table style="margin-left:37%">
    <tr class="row">
       <td class="Lable"> <span >HỌ TÊN</span></td>
        <td class="Input"><asp:TextBox ID="txtHoTen" runat="server" class="Input"  placeholder="Tên tài khoản"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtHoTen"></asp:RequiredFieldValidator></td>
    </tr>
    <tr class="row">
        <td class="Lable"><span>EMAIL</span></td>
        <td class="Input"><asp:TextBox ID="txtEmail" runat="server" class="Input"  placeholder="Email"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="" Text="*" ForeColor="red" SetFocusOnError="true" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
        </td>
    
    </tr>
    <tr class="row">
        <td class="Lable"><span>ĐỊA CHỈ</span></td>
        <td class="Input"><asp:TextBox ID="txtDiaChi" runat="server" class="Input"  placeholder="Địa chỉ"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtDiaChi"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr class="row">
        <td class="Lable"><span>SỐ ĐIỆN THOẠI</span></td>
        <td class="Input"><asp:TextBox ID="txtSDT" runat="server" class="Input"  placeholder="Số điện thoại"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtSDT"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtSDT" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(0[0-9]{9,10})$">*</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr class="row">
        <td class="Lable"></td>
        <td>
            <asp:Button ID="btnDatHang" runat="server" Text="Đặt hàng" class="btnThemMoi" OnClick="btnDatHang_Click" />
        </td>

    </tr>    
</table>