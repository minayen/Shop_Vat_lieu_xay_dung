<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachNhaCungCap.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.NhaCungCap.DanhSachNhaCungCap" %>
<asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table class ="table">
    <asp:Literal ID="LiteralDSNCC" runat="server"></asp:Literal>
</table>
<div>
    <asp:Label ID="lbThongBao" runat="server" class="LbThongBao" style="text-align:center;"></asp:Label>
</div>
<script>
    function Xoa() {
        return confirm("Bạn có chắc chắn muốn xóa nhà cung cấp này này?");;
    }
</script>