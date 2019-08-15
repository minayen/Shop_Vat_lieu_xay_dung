<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietSanPham.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangBanHang.SanPham.ChiTietSanPham" %>
<asp:Literal ID="ltdetailpr" runat="server"></asp:Literal>
<script type="text/javascript">
    function ThemVaoGioHang(MaSP) {
        $.get("cms/TrangBanHang/GioHang/XuLyGioHang.aspx",
            {
                "MaSP": MaSP
            }, function (data, status) {
        alert(data);
  });
    }
</script>
