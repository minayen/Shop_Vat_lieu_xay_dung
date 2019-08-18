<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietDonNhapHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang.ChiTietDonNhapHang" %>
<table class ="table">
    <tr >
        <th class ="Ma">Mã HD</th><th class ="NguoiNhap" style="width:25%;">Tên sản phẩm</th><th class ="NCC" style="width:20%;">Số lượng nhập</th><th class ="NgayNhap" style="width:20%;">Giá nhập</th><th class ="CongCu"style="width:20%;">Giá bán</th>
    </tr>
    <asp:Literal ID="LiteralChiTietDonNhapHang" runat="server"></asp:Literal>
</table>
<div style="text-align:center"><a href="/Admin.aspx?modul=SanPham&modul1=DanhSachDonNHapHang" style="color:#000000;">Quay lại</a></div>