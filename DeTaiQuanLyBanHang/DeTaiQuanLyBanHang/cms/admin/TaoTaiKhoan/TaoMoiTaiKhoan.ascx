<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaoMoiTaiKhoan.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.TaoTaiKhoan.TaoMoiTaiKhoan" %>
<asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table>
    <tr class="row">
       <td class="Lable"> <span >Tên tài khoản:</span></td>
        <td class="Input"><asp:TextBox ID="txtTenTaiKhoan" runat="server" class="Input"  placeholder="Tên tài khoản"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtTenTaiKhoan"></asp:RequiredFieldValidator></td>
    </tr>

    <tr class="row">
        <td class="Lable"><span>Mật khẩu:</span></td>
        <td class="Input"><asp:TextBox ID="txtMatKhau1" runat="server" class="Input"  placeholder="Mật khẩu" TextMode="Password"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtMatKhau1"></asp:RequiredFieldValidator></td>
    </tr>
        <tr class="row">
        <td class="Lable"><span>Nhập lại mật khẩu:</span></td>
        <td class="Input"><asp:TextBox ID="txtMatKhau2" runat="server" class="Input"  placeholder="Nhập lại mật khẩu" TextMode="Password"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtMatKhau2"></asp:RequiredFieldValidator></td>
    </tr>
    <tr class="row">
        <td class="Lable"><span>Email:</span></td>
        <td class="Input"><asp:TextBox ID="txtEmail" runat="server" class="Input"  placeholder="Email"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="" Text="*" ForeColor="red" SetFocusOnError="true" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
        </td>
    
    </tr>
        <tr class="row">
        <td class="Lable"><span>Địa chỉ:</span></td>
        <td class="Input"><asp:TextBox ID="txtDiaChi" runat="server" class="Input"  placeholder="Địa chỉ"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtDiaChi"></asp:RequiredFieldValidator>
        </td>
    </tr>

        <tr class="row">
        <td class="Lable"><span>Họ & tên:</span></td>
        <td class="Input"><asp:TextBox ID="txtHoTen" runat="server" class="Input"  placeholder="Họ & tên"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtHoTen"></asp:RequiredFieldValidator>
        </td>
    </tr>
        <tr class="row">
        <td class="Lable"><span>Số điện thoại:</span></td>
        <td class="Input"><asp:TextBox ID="txtSDT" runat="server" class="Input"  placeholder="Số điện thoại"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtSDT"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtSDT" ErrorMessage="" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(0[0-9]{9,10})$">*</asp:RegularExpressionValidator>
        </td>
    </tr>
        <tr class="row">
        <td class="Lable"><span>Quyền hạn</span></td>
        <td class="Input">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="0">Quản trị bán hàng</asp:ListItem>
            </asp:DropDownList></td>
    </tr>
    <tr class="row">
        <td class="Lable"></td>
        <td>
            <asp:Button ID="btnThemmoi" runat="server" Text="Thêm mới" CssClass="btnThemMoi" OnClick="btnThemmoi_Click" />
        </td>
    <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:Label ID="lbThongBao" runat="server" class="LbThongBao"></asp:Label>
            <asp:ValidationSummary ID="ValidationSummary1" ForeColor="red" runat="server" />
        </td>
    </tr>    
</table>