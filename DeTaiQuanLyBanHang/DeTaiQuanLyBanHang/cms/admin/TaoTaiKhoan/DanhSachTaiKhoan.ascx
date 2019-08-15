<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachTaiKhoan.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.TaoTaiKhoan.DanhSachTaiKhoan" %>
<asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table class ="table">
    <asp:Literal ID="LiteralDSTaiKhoan" runat="server"></asp:Literal>
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
<%--<div>
    <asp:Label ID="lbThongBao" runat="server" class="LbThongBao" style="text-align:center;"></asp:Label>
    <a onclick="return Xoa();" href="/Admin.aspx?modul=TaiKhoan&modul1=DSTaiKhoan"> ABCCCC</a>
</div>--%>
<script>
    function Xoa() {
        return confirm("Bạn có chắc chắn muốn xóa tài khoản này?");;
    }
</script>