using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.TrangNhanVien
{
    public partial class DanhSachDonHang : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        string MaDonHang = "";
        string MaKH = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["MaDonHang"] == null && Request.QueryString["MaKH"] == null)
            {
                LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Tất cả đơn hàng</p>
                    <tr>
                        <th class ='Ma'>Mã đơn hàng</th><th class ='NguoiNhap'>Tên Khách Hàng</th><th class ='NCC' style='width:15%'>Ngày đặt</th><th class ='CongCu'style='width:7%'>Công cụ</th>
                    </tr>";
                DataTable tbDONHANG = DAO.getTable("SELECT * FROM dbo.DONHANG, dbo.KHACHHANG WHERE dbo.DONHANG.MAKH = dbo.KHACHHANG.MAKH");
                for (int i = 0; i < tbDONHANG.Rows.Count; i++)
                {
                    LiteralDSDH.Text += @"
                    <tr>
                        <td>" + tbDONHANG.Rows[i]["MADONHANG"] + @"</td>
                        <td>" + tbDONHANG.Rows[i]["TENKH"] + @"</td>
                        <td>" + tbDONHANG.Rows[i]["NGAYDATHANG"] + @"</td>
                        <td style='background-color:#ffffff; text-align:center; width:30px; height:30px;'>
                            <a href = '/TrangNhanVien.aspx?modul=KhachHang&modul1=DSDonHang&MaDonHang=" + tbDONHANG.Rows[i]["MADONHANG"] + @"'><img src='../../../../pic/detail.png' title='Detail'/></a>
                        </td>
                    </tr>";
                }
            }
            else if (Request.QueryString["MaKH"] == null)
            {
                MaDonHang = Request.QueryString["MaDonHang"];
                LableTieuDe.Text = @" 
                        <p style='text-align:center; text-transform:uppercase;'>Chi tiết đơn hàng:" + MaDonHang + @"</p>
                    <tr>
                        <th class ='Ma' style='width:20%'>Mã đơn hàng</th><th class ='NguoiNhap' style='width:50%'>Tên Sản Phẩm</th><th class ='NCC'>Số lượng Sản Phẩm</th>
                    </tr>";

                DataTable tbCHITIETDONHANGG = DAO.getTable("SELECT * FROM dbo.CHITIETDONHANG, dbo.SANPHAM WHERE dbo.CHITIETDONHANG.MASP = dbo.SANPHAM.MASP");
                for (int i = 0; i < tbCHITIETDONHANGG.Rows.Count; i++)
                {
                    LiteralDSDH.Text += @"
                    <tr>
                        <td>" + tbCHITIETDONHANGG.Rows[i]["MADONHANG"] + @"</td>
                        <td>" + tbCHITIETDONHANGG.Rows[i]["TENSP"] + @"</td>
                        <td>" + tbCHITIETDONHANGG.Rows[i]["SOLUONGSP"] + @"</td>
                        
                    </tr>";
                }

                LbReturn.Text = "<a href='/TrangNhanVien.aspx?modul=KhachHang&modul1=DSDonHang' style='text-align:center; color:#000000'>Quay lại</a>";
            }
            else
            {
                MaKH = Request.QueryString["MaKH"];
                DataTable tbKHACHHANG = DAO.getTable("SELECT * FROM dbo.KHACHHANG WHERE MAKH = '" + MaKH + "'");
                LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Tất cả đơn hàng của khách hàng:" + tbKHACHHANG.Rows[0]["TENKH"] + @"</p>
                    <tr>
                        <th class ='Ma'>Mã đơn hàng</th><th class ='NguoiNhap'>Tên Khách Hàng</th><th class ='NCC' style='width:15%'>Ngày đặt</th><th class ='CongCu'style='width:7%'>Công cụ</th>
                    </tr>";
                DataTable tbDONHANG = DAO.getTable("SELECT * FROM dbo.DONHANG, dbo.KHACHHANG WHERE dbo.DONHANG.MAKH = dbo.KHACHHANG.MAKH AND dbo.DONHANG.MaKH= '" + MaKH + "'");
                for (int i = 0; i < tbDONHANG.Rows.Count; i++)
                {
                    LiteralDSDH.Text += @"
                    <tr>
                        <td>" + tbDONHANG.Rows[i]["MADONHANG"] + @"</td>
                        <td>" + tbDONHANG.Rows[i]["TENKH"] + @"</td>
                        <td>" + tbDONHANG.Rows[i]["NGAYDATHANG"] + @"</td>
                        <td style='background-color:#ffffff; text-align:center; width:30px; height:30px;'>
                            <a href = '/TrangNhanVien.aspx?modul=KhachHang&modul1=DSDonHang&MaDonHang=" + tbDONHANG.Rows[i]["MADONHANG"] + @"'><img src='../../../../pic/detail.png' title='Detail'/></a>
                        </td>
                    </tr>";
                }
            }
        }
    }
}