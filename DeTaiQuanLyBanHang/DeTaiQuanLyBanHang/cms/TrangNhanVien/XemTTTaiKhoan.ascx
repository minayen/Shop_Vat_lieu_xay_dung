<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="XemTTTaiKhoan.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangNhanVien.XemTTTaiKhoan" %>
<style>
    .Input{
        padding:4px;
    }
    .TieuDe{
        text-align:center;
        font-size:20px;
        font-weight:bold;
        color:#140e0e
    }
    .btnThemMoi{
        padding:8px;
        background:#413737;
        font:bold 15px;
        color:#ffffff;
    }
    .btnThemMoi:hover{
        background:#f83030;
        cursor:pointer;
    }
</style>
<div class="TieuDe">Thông tin tài khoản</div>
<table style="margin-left:37%">
    <tr class="row">
       <td class="Lable"> <span >HỌ TÊN</span></td>
        <td class="Input"><asp:TextBox ID="txtHoTen" runat="server" class="Input"  placeholder="Tên tài khoản"></asp:TextBox></td>
        </tr>
    <tr class="row">
        <td class="Lable"><span>EMAIL</span></td>
        <td class="Input"><asp:TextBox ID="txtEmail" runat="server" class="Input"  placeholder="Email"></asp:TextBox></td>
        
    
    </tr>
    <tr class="row">
        <td class="Lable"><span>ĐỊA CHỈ</span></td>
        <td class="Input"><asp:TextBox ID="txtDiaChi" runat="server" class="Input"  placeholder="Địa chỉ"></asp:TextBox></td>

    </tr>
    <tr class="row">
        <td class="Lable"><span>SỐ ĐIỆN THOẠI</span></td>
        <td class="Input"><asp:TextBox ID="txtSDT" runat="server" class="Input"  placeholder="Số điện thoại"></asp:TextBox></td>
        
    </tr>
    <tr class="row">
        <td class="Lable"></td>
        <td>
            <asp:Button ID="btnDatHang" runat="server" Text="Cập nhật thông tin" class="btnThemMoi" OnClick="btnDatHang_Click"  />
        </td>

    </tr>    
</table>