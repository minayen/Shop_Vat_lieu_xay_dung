<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachDonNhapHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang.DanhSachDonNhapHang" %>
<%@ Register Src="~/cms/admin/SanPham/NhapHang/XoaDonNhapHang.ascx" TagPrefix="uc1" TagName="XoaDonNhapHang" %>
<asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table class ="table">
    <tr >
        <th class ="Ma">Mã HD</th><th class ="NguoiNhap">Người nhập</th><th class ="NCC">Nhà cung cấp</th><th class ="NgayNhap">Ngày nhập</th><th class ="CongCu">Công cụ</th>
    </tr>
    <asp:Literal ID="LiteralDSDonNhapHang" runat="server"></asp:Literal>
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

<script type="text/javascript">
    function Xoa(){
        return confirm("Bạn có chắc chắn muốn xóa đơn hàng này hay không?");
    }
</script>