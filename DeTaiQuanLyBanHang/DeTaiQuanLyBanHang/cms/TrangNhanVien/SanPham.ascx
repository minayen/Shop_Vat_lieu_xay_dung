<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPham.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangNhanVien.SanPham" %>
<style type="text/css">
    th{background:#a92c2c;height:40px}
    td{background:#8d8585}
</style>
<div style="background-color:#ffffff; margin:5px;">
    <asp:DropDownList ID="DrLoaiSanPham" runat="server" style="padding:5px; margin-top:10px;width:990px; text-align:center" OnSelectedIndexChanged="DrLoaiSanPham_SelectedIndexChanged" OnTextChanged="DrLoaiSanPham_TextChanged" AutoPostBack="True">
        <asp:ListItem Selected="True">Chọn Loại sản phẩm</asp:ListItem>
</asp:DropDownList>
    <asp:Label ID="LableTieuDe" runat="server"></asp:Label>
<table style="margin:auto;width:980px; text-align:center;">
    
    

    <tr>
        <th class ="Ma" style="width:8%">Mã</th><th class ="NguoiNhap"style="width:15%">Tên Sản phẩm</th><th class ="NCC" >Hình ảnh</th><th class ="NgayNhap" style="width:8%">ĐVT</th><th class ="CongCu" style="width:13%">Số lượng</th><th class ="NCC">Đơn giá</th><th class ="NgayNhap" style="width:10%">Tên loại</th>
    </tr>
    <asp:Literal ID="LiteralLoadSanPham" runat="server"></asp:Literal>
</table>
<asp:Label ID="LbReturn" runat="server"></asp:Label>
</div>