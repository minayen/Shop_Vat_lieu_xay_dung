<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GioHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangBanHang.GioHang.GioHang" %>

<style type="text/css">
    th{background:#a92c2c;height:40px}
    td{background:#8d8585}
</style>
<asp:Literal ID="LtGioHang" runat="server"></asp:Literal>
<div class="clear"></div>
<div style="text-align:center;"><asp:Label ID="LableGioHang" style="color:#45aefa;font-weight:bold;" runat="server" Text=""></asp:Label></div>

<script>
    function Xoa() {
        return confirm("Bạn có chắc chắn muốn xóa sản phẩm này khỏi giỏ hàng?");
    }
    function XoaDonHang() {
        return confirm("Bạn có chắc chắn muốn xóa tất cả sản phẩm trong giỏ hàng?");
    }
    function SoLuongSanPham(MaSP) {
        var SoLuong = $("#SP_" + MaSP).val();
        if (SoLuong >= 1) {
            $.post("cms/TrangBanHang/GioHang/CapNhatSoLuongSPGioHang.aspx",
                {
                    "MaSP": MaSP,
                    "SoLuong": SoLuong
                },
                function (data, status) {
                    if (data != "") {
                        $("#SP_" + MaSP).val(1);
                        alert(data);
                    } else {
                        window.location.href = "TrangBanHang.aspx?modul=GioHang";
                    }
                });
        }
        else
        {
            $("#SP_" + MaSP).val(1);
        }
    }
    
</script>
