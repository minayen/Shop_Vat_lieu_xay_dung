<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachDonHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangNhanVien.DanhSachDonHang" %>
<%--<select>
    <option>
        Tất cả đơn hàng
    </option>
    <option>Đơn hàng trong ngày</option>
</select>--%>
<table class ="table">
    <asp:Label ID="LableTieuDe" runat="server"></asp:Label>
    <asp:Literal ID="LiteralDSDH" runat="server" ></asp:Literal>
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

<asp:Label ID="LbReturn" runat="server"></asp:Label>