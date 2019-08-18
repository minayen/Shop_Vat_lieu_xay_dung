<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChinhSuaDonNhapHang.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang.ChinhSuaDonNhapHang" %>
<style type="text/css">
    .auto-style1 {
        height: 10px;
    }
</style>
<table>
    

    <tr class="row">
        <td class="auto-style1"> <span >Số hóa đơn:</span></td>
        <td class="auto-style1"><asp:TextBox ID="txtSoHoaDon" runat="server" class="Input"  placeholder="Số hóa đơn"></asp:TextBox></td>
        <td class="auto-style1"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Vui lòng nhập số hóa đơn" Text="*" ForeColor="Red" ControlToValidate="txtSoHoaDon" SetFocusOnError=true></asp:RequiredFieldValidator></td>
    </tr>

    <tr class="row">
        <td class="Lable"><span>Chọn nhà cung cấp:</span></td>
        <td ><asp:DropDownList ID="DrNhaCungCap" runat="server" class="Input"  placeholder=""></asp:DropDownList></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Vui lòng chọn nhà cung cấp" Text="*" ForeColor="Red" ControlToValidate="DrNhaCungCap" SetFocusOnError=true></asp:RequiredFieldValidator></td>
    </tr>

    <tr class="row">
        <td class="Lable"><span>Chọn ngày nhập:</span></td>
        <td><asp:TextBox ID="txtNgayNhap" runat="server" class="Input" placehoder="Chọn ngày nhập hàng"></asp:TextBox></td>
        <td class ="Choice"><asp:Button ID="btnChoiceDay" runat="server" Text="" class="btnChoiceDay" CausesValidation="False" OnClick="btnChoiceDay_Click" />
            <asp:Calendar ID="Calendar" runat="server"  class="Calendar" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" Width="304px"  VisibleDate="1/1/0001" OnSelectionChanged="Calendar_SelectionChanged" OnVisibleMonthChanged="Calendar_VisibleMonthChanged">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                <DayStyle BackColor="#CCCCCC" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                <TodayDayStyle BackColor="#999999" ForeColor="White" />
                
            </asp:Calendar>
        </td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Vui lòng chọn ngày" Text="*" ForeColor="Red" ControlToValidate="txtNgayNhap" SetFocusOnError=true></asp:RequiredFieldValidator></td>
        
    </tr>

    <tr class="row">
        <td class="Lable"></td>
        <td>
            <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" CssClass="btnThemMoi" OnClick="btnCapNhat_Click"  />
        </td>
    </tr>
    <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:Label ID="lbThongBao" runat="server" class="LbThongBao"></asp:Label>

        </td>
    </tr>
    <tr class="row">
        <td class="Lable"><span></span></td>
        <td>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/>
        </td>
    </tr>
</table>