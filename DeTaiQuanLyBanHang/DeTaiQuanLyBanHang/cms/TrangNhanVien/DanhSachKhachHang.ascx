<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachKhachHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangNhanVien.DanhSachKhachHang" %>
<asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table class ="table">
    <tr >
        <th class ="Ma">Mã</th><th class ="NguoiNhap">Tên Khách Hàng</th><th class ="NCC" style="width:20%">Địa Chỉ</th><th class ="NgayNhap">Email</th><th class ="CongCu">Số điện thoại</th><th class ="CongCu" style="width:9%">Công cụ</th>
    </tr>
    <asp:Literal ID="LiteralDSKH" runat="server"></asp:Literal>
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