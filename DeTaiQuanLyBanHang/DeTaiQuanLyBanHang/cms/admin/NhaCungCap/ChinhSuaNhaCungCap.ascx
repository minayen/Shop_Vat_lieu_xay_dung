<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChinhSuaNhaCungCap.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.NhaCungCap.ChinhSuaNhaCungCap" %>
<asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table>
    <tr class="row">
       <td class="Lable"> <span >Mã nhà cung cấp:</span></td>
        <td class="Input"><asp:TextBox ID="txtMaNCC" runat="server" class="Input"  placeholder="Mã nhà cung cấp"></asp:TextBox></td>
    </tr>

    <tr class="row">
        <td class="Lable"><span>Tên nhà cung cấp:</span></td>
        <td class="Input"><asp:TextBox ID="txtTenNCC" runat="server" class="Input"  placeholder="Tên nhà cung cấp"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Tên nhà cung cấp không được bỏ trống" ForeColor="Red" SetFocusOnError="True" ControlToValidate="txtTenNCC">*</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr class="row">
        <td class="Lable"><span>Email:</span></td>
        <td class="Input"><asp:TextBox ID="txtEmail" runat="server" class="Input"  placeholder="Email"></asp:TextBox></td>
                <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Email không được bỏ trống" Text="*" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email không hợp lệ" ControlToValidate="txtEmail" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        </td>
    </tr>
        <tr class="row">
        <td class="Lable"><span>Số điện thoại:</span></td>
        <td class="Input"><asp:TextBox ID="txtSDT" runat="server" class="Input"  placeholder="Số điện thoại"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Số điện thoại không được bỏ trống" Text="*" ControlToValidate="txtSDT" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtSDT" ErrorMessage="Số điện thoại không hợp lệ" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(0[0-9]{9,10})$">*</asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr class="row">
        <td class="Lable"></td>
        <td>
            <asp:Button ID="txtCapNhat" runat="server" Text="Cập nhật" CssClass="btnThemMoi" OnClick="txtCapNhat_Click"/>
        </td>
        <td></td>
    </tr>
    <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:Label ID="lbThongBao" runat="server" class="LbThongBao" ForeColor="Red"></asp:Label>
        </td>
    </tr>   
        <tr class="row">
        <td class="Lable"><span></span></td>
        <td> <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" /></td>
    </tr>   
</table>
