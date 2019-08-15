<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoaiSanPham.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.SanPham.LoaiSanPham.LoaiSanPham" %>
<div class="fl" style="width:40%">
    <asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table class ="table">
    <tr >
        <th class ="Ma">Mã Loại</th><th class ="NguoiNhap">Tên loại</th><th class ="NCC" style="width:10%">Công cụ</th>
    </tr>
    <asp:Literal ID="LiteralLOAISP" runat="server"></asp:Literal>
    <%--<asp:Label ID="LabelLoaiSP" runat="server"></asp:Label>--%>
<%--    <tr>
        <td> 1 </td>
        <td> 2 </td>
        <td> 3 </td>
        <td> 4 </td>
        <td class='img' style='background-color:#ffffff; text-align:left;'>
            <a href = '#' ><img src='../../../../pic/delete.png' /></a>
            <a href = '#' >
                <img src='../../../../pic/edit.png' /></a>
        </td>
    </tr>--%>
</table>
    </div>
<div class="fl" style="width:60%">
    <table style=" width:100%; color:#ff6a00; margin-left:4px;">
            <tr><td>Mã loại:</td><td><asp:TextBox ID="txtMaLoai" runat="server" style="width:70%; border-radius:4px; padding:3px; margin-bottom:4px;"  placeholder ="Mã loại sản phẩm"></asp:TextBox><asp:RequiredFieldValidator ControlToValidate="txtMaLoai" ID="RequiredFieldValidator1" runat="server" ErrorMessage="" Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr><td>Tên loại:</td><td><asp:TextBox ID="txtTenLoai" runat="server" style="width:70%; border-radius:4px;padding:3px; margin-bottom:4px;"  placeholder ="Tên loại sản phẩm"></asp:TextBox >
                <asp:RequiredFieldValidator ControlToValidate="txtTenLoai" ID="RequiredFieldValidator2" runat="server" ErrorMessage="" Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
            <tr><td></td><td><asp:Button ID="btnThem" runat="server" Text="Thêm" style="width:100px;  border-radius:4px; background:#808080; padding:3px; cursor:pointer;" OnClick="btnThem_Click"  /> 
                <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" style="width:100px; border-radius:4px; background:#808080; padding:3px; cursor:pointer;" OnClick="btnCapNhat_Click"/> 
                <asp:Button ID="btnXoaForm" runat="server" Text="Xóa form" style="width:100px;  border-radius:4px; background:#808080; padding:3px; cursor:pointer;" CausesValidation="False" OnClick="btnXoaForm_Click" /></td></tr>
            <tr><td></td><td><asp:Label ID="lbThongBao" runat="server"  class="LbThongBao"></asp:Label></td></tr>
    </table>
</div>
<div class="clear"></div>

<script>
    function Xoa() {
        return confirm("Bạn có chắc chắn muốn xóa loại sản phẩm này?");;
    }
</script>