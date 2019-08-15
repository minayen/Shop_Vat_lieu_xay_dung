<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachSanPham.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.SanPham.DanhSachSanPham" %>
<asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table class ="table">
    <tr >
        <th class ="Ma" style="width:8%">Mã</th><th class ="NguoiNhap"style="width:15%">Tên Sản phẩm</th><th class ="NCC" >Hình ảnh</th><th class ="NgayNhap" style="width:8%">ĐVT</th><th class ="CongCu" style="width:13%">Số lượng</th><th class ="NCC">Đơn giá</th><th class ="NgayNhap" style="width:10%">Tên loại</th><th class ="CongCu"style="width:10%">Công cụ</th>
    </tr>
    <asp:Literal ID="LiteralDSSP" runat="server"></asp:Literal>
    
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
<script>
    function Xoa() {
        return confirm("Bạn có chắc chắn muốn xóa sản phẩm này?");;
    }
</script>
