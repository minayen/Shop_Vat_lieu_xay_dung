<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChinhSuaSanPham.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.SanPham.ChinhSuaSanPham" %>

<asp:Label ID="LableTieuDe" runat="server" ></asp:Label>
<table>
    <tr class="row">
       <td class="Lable"> <span >Mã sản phẩm:</span></td>
        <td class="Input"><asp:TextBox ID="txtMaSP" runat="server" class="Input"  placeholder="Mã sản phẩm"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtMaSP" runat="server" ErrorMessage="Vui lòng nhập mã sản phẩm" Text="*" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator></td>
    </tr>
    
    <tr class="row">
        <td class="Lable"><span>Chọn loại sản phẩm:</span></td>
        <td ><asp:DropDownList ID="DrLoaiSP" runat="server" class="Input"  placeholder="Tên sản phẩm"></asp:DropDownList></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DrLoaiSp" ErrorMessage="Vui lòng chọn loại sản phẩm" Text="*" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator></td>

    </tr>

    <tr class="row">
       <td class="Lable"> <span >Tên sản phẩm:</span></td>
        <td class="Input"><asp:TextBox ID="txtTenSP" runat="server" class="Input"  placeholder="Tên sản phẩm"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtTenSP" runat="server" ErrorMessage="Vui lòng nhập tên sản phẩm" Text="*" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator></td>

    </tr>
    <tr class="row">
        <td class="Lable"><span>Hình ảnh sản phẩm</span></td>
        <td class="Input"><asp:Label ID="lbHinhAnhSP" runat="server" Text=""></asp:Label></td>
        <td></td>
        
    </tr>

    <tr class="row">
        <td class="Lable"><span>Chọn ảnh khác cho sản phẩm:</span></td>
        <td class="Input"><asp:FileUpload ID="fileAnh" runat="server" class="Input" style="cursor:pointer;"  placeholder="Chọn hình ảnh"/></td>
        <td></td>
        
    </tr>

<%--    <tr class="row">
        <td class="Lable"><span>Số lượng sản phẩm:</span></td>
        <td class="Input"><asp:TextBox ID="txtSoLuongSP" runat="server" class="Input"  placeholder="Số lượng"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtSoLuongSP" runat="server" ErrorMessage="Vui lòng nhập số lượng sản phẩm" Text="*" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator></td>

    </tr>
    <tr class="row">
        <td class="Lable"><span>Đơn giá sản phẩm:</span></td>
        <td class="Input"><asp:TextBox ID="txtDonGia" runat="server" class="Input"  placeholder="Đơn giá"></asp:TextBox></td>
    </tr>--%>
        <tr class="row">
        <td class="Lable"><span>Đơn vị tính:</span></td>
        <td class="Input"><asp:TextBox ID="txtDonViTinh" runat="server" class="Input"  placeholder="Đơn vị tính"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtDonViTinh" runat="server" ErrorMessage="Vui lòng nhập đơn vị tính" Text="*" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator></td>
    
        </tr>
    <tr class="row">
        <td class="Lable"></td>
        <td>
            <asp:Button ID="btnCaapNhat" runat="server" Text="Cập nhật" CssClass="btnThemMoi" OnClick="btnCaapNhat_Click"/>
        </td>
        <td></td>
    </tr>
    <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:Label ID="lbThongBao" runat="server" class="LbThongBao"></asp:Label>
        </td>
        <td></td>
    </tr> 
        <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        </td>
        <td></td>
    </tr>   
</table>