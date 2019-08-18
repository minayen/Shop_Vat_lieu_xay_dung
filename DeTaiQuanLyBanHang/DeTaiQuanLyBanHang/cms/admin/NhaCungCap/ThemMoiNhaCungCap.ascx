<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThemMoiNhaCungCap.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.NhaCungCap.ThemMoiNhaCungCap" %>
<asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table>
    <tr class="row">
       <td class="Lable"> <span >Mã nhà cung cấp:</span></td>
        <td class="Input"><asp:TextBox ID="txtMaNCC" runat="server" class="Input"  placeholder="Mã nhà cung cấp"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Mã nhà cung cấp không được bỏ trống" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtMaNCC"></asp:RequiredFieldValidator></td>
    </tr>

    <tr class="row">
        <td class="Lable"><span>Tên nhà cung cấp</span></td>
        <td class="Input"><asp:TextBox ID="txtTenNCC" runat="server" class="Input"  placeholder="Tên nhà cung cấp"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Tên nhà cung cấp không được bỏ trống" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtTenNCC"></asp:RequiredFieldValidator></td>
    </tr>
    <tr class="row">
        <td class="Lable"><span>Email</span></td>
        <td class="Input"><asp:TextBox ID="txtEmailNCC" runat="server" class="Input"  placeholder="Email"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Email nhà cung cấp không được bỏ trống" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtEmailNCC"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email không hợp lệ" Text="*" ForeColor="red" SetFocusOnError="true" ControlToValidate="txtEmailNCC" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
        </td>
    
    </tr>
        <tr class="row">
        <td class="Lable"><span>Số điện thoại:</span></td>
        <td class="Input"><asp:TextBox ID="txtSDT" runat="server" class="Input"  placeholder="Số điện thoại"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Số điện thoại nhà cung cấp không được bỏ trống" ForeColor="Red" SetFocusOnError="True" Text="*" ControlToValidate="txtSDT"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtSDT" ErrorMessage="Số điện thoại không hợp lệ" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(0[0-9]{9,10})$">*</asp:RegularExpressionValidator>
            </td>
    </tr>
    <tr class="row">
        <td class="Lable"></td>
        <td>
            <asp:Button ID="btnThemmoi" runat="server" Text="Thêm mới" CssClass="btnThemMoi" OnClick="btnThemmoi_Click"/>
            <asp:Button ID="btnClearForm" runat="server" Text="Xóa trống form" CssClass="btnThemMoi" CausesValidation="False" OnClick="btnClearForm_Click" />
        </td>
    <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:Label ID="lbThongBao" runat="server" class="LbThongBao"></asp:Label>
            <asp:ValidationSummary ID="ValidationSummary1" ForeColor="red" runat="server" />
        </td>
    </tr>    
</table>



