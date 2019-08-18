<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietNhapHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang.ChitietNhapHang" %>
<table>
    <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:Label ID="lbSoHoaDon" runat="server" class="LbThongBao"></asp:Label>

        </td>
    </tr>    

    <tr class="row">
       <td class="Lable"> Chọn s<span >ản phẩm:</span></td>
        <td ><asp:DropDownList ID="DrTenSanPham" runat="server" class="Input"  placeholder=""></asp:DropDownList></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Vui lòng chọn sản phẩm" ForeColor ="Red" Text ="*" ControlToValidate ="DrTenSanPham"></asp:RequiredFieldValidator></td>
    </tr>

    <tr class="row">
        <td class="Lable"><span>Số lượng sản phẩm:</span></td>
        <td class="Input"><asp:TextBox ID="txtSoLuong" runat="server" class="Input"  placeholder="Số lượng sản phẩm"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Vui lòng nhập số lượng sản phẩm" ForeColor ="Red" Text ="*" ControlToValidate ="txtSoLuong"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Vui lòng nhập số" ControlToValidate="txtSoLuong" ForeColor="Red" ValidationExpression="\d+" Text ="*"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr class="row">
        <td class="Lable"><span>Giá nhập vào:</span></td>
        <td class="Input"><asp:TextBox ID="txtGiaNhapVao" runat="server" class="Input"  placeholder="Giá nhập vào"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Vui lòng nhập giá mua vào" ForeColor ="Red" Text ="*" ControlToValidate ="txtGiaNhapVao"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Vui lòng nhập số" ControlToValidate="txtGiaNhapVao" ForeColor="Red" ValidationExpression="\d+" Text ="*"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr class="row">
        <td class="Lable"><span>Giá bán ra:</span></td>
        <td class="Input"><asp:TextBox ID="txtGiaBanRa" runat="server" class="Input"  placeholder="Giá bán ra"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Vui lòng nhập giá bán ra" ForeColor ="Red" Text ="*" ControlToValidate ="txtGiaBanRa"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Vui lòng nhập số" ControlToValidate="txtGiaBanRa" ForeColor="Red" ValidationExpression="\d+" Text ="*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr class="row">
        <td>
            <asp:Button ID="btnXoaTrongForm" runat="server" Text="Xóa trống form" CssClass="btnThemMoi" style="margin-left:60px" OnClick="btnXoaTrongForm_Click" CausesValidation="False"/>
        </td>
        <td>
            <asp:Button ID="btnNhap" runat="server" Text="Nhập vào kho" CssClass="btnThemMoi" OnClick="btnNhap_Click"/>
            <asp:Button ID="btnHoanThanh" runat="server" Text="Hoàn thành" CssClass="btnThemMoi" OnClick="btnHoanThanh_Click" CausesValidation="False"/>
        </td>
    </tr>
    <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:Label ID="lbThongBao" runat="server" class="LbThongBao"></asp:Label>
        </td>
        <td></td>
    </tr>   
        <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        </td>
        <td></td>
    </tr> 
</table>