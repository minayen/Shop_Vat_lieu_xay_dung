using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.TrangNhanVien
{
    public partial class SanPham : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        string MaDonHang = "";
        string MaKH = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadLoaiSP();
            if (Request.QueryString["LoaiSP"] == null)
            {
                
                DataTable tbDSSP = DAO.getTable("SELECT * FROM dbo.SANPHAM, dbo.LOAISANPHAM WHERE dbo.SANPHAM.MALOAI = dbo.LOAISANPHAM.MALOAI");
                                LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Tất cả sản phẩm</p>
                      ";
                for (int i = 0; i < tbDSSP.Rows.Count; i++)
                {

                    LiteralLoadSanPham.Text += @"
                    <tr>
                        <td>" + tbDSSP.Rows[i]["MASP"] + @"</td>
                        <td>" + tbDSSP.Rows[i]["TENSP"].ToString() + @"</td>
                        <td style='background-color:#ffffff; text-align:center;'><img src='../../../pic/img/" + tbDSSP.Rows[i]["HINHANH"] + @"' style='width: 100px; height: auto'/></td>
                        <td>" + tbDSSP.Rows[i]["DONVITINH"] + @"</td>
                        <td>" + tbDSSP.Rows[i]["SOLUONG"].ToString() + @"</td>
                        <td>" + tbDSSP.Rows[i]["DONGIA"].ToString() + @"</td>
                        <td>" + tbDSSP.Rows[i]["TENLOAI"] + @"</td>
                        
                    </tr>";
                }
            }else if(Request.QueryString["LoaiSP"] != null)
            {
                DrLoaiSanPham.SelectedValue = Request.QueryString["LoaiSP"];
                DataTable tbLoaiSP = DAO.getTable("SELECT * FROM dbo.LOAISANPHAM WHERE dbo.LOAISANPHAM.MALOAI='" + Request.QueryString["LoaiSP"] + "'");
                LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Tất cả sản phẩm thuộc loai:" + tbLoaiSP.Rows[0]["TENLOAI"] + @"</p>
                      ";
                DataTable tbDSSP = DAO.getTable("SELECT * FROM dbo.SANPHAM, dbo.LOAISANPHAM WHERE dbo.SANPHAM.MALOAI = dbo.LOAISANPHAM.MALOAI  AND dbo.SANPHAM.MALOAI='"+ Request.QueryString["LoaiSP"] + "'");
                for (int i = 0; i < tbDSSP.Rows.Count; i++)
                {

                    LiteralLoadSanPham.Text += @"
                    <tr>
                        <td>" + tbDSSP.Rows[i]["MASP"] + @"</td>
                        <td>" + tbDSSP.Rows[i]["TENSP"].ToString() + @"</td>
                        <td style='background-color:#ffffff; text-align:center;'><img src='../../../pic/img/" + tbDSSP.Rows[i]["HINHANH"] + @"' style='width: 100px; height: auto'/></td>
                        <td>" + tbDSSP.Rows[i]["DONVITINH"] + @"</td>
                        <td>" + tbDSSP.Rows[i]["SOLUONG"].ToString() + @"</td>
                        <td>" + tbDSSP.Rows[i]["DONGIA"].ToString() + @"</td>
                        <td>" + tbDSSP.Rows[i]["TENLOAI"] + @"</td>
                        
                    </tr>";
                }
            }
            //else if (Request.QueryString["MaKH"] == null)
            //{
            //    MaDonHang = Request.QueryString["MaDonHang"];
            //    LableTieuDe.Text = @" 
            //        <p style='text-align:center; text-transform:uppercase;'>Chi tiết đơn hàng:" + MaDonHang + @"</p>
            //    <tr>
            //        <th class ='Ma' style='width:20%'>Mã đơn hàng</th><th class ='NguoiNhap' style='width:50%'>Tên Sản Phẩm</th><th class ='NCC'>Số lượng Sản Phẩm</th>
            //    </tr>";

            //    DataTable tbCHITIETDONHANGG = DAO.getTable("SELECT * FROM dbo.CHITIETDONHANG, dbo.SANPHAM WHERE dbo.CHITIETDONHANG.MASP = dbo.SANPHAM.MASP");
            //    for (int i = 0; i < tbCHITIETDONHANGG.Rows.Count; i++)
            //    {
            //    LiteralLoadSanPham.Text += @"
            //    <tr>
            //        <td>" + tbCHITIETDONHANGG.Rows[i]["MADONHANG"] + @"</td>
            //        <td>" + tbCHITIETDONHANGG.Rows[i]["TENSP"] + @"</td>
            //        <td>" + tbCHITIETDONHANGG.Rows[i]["SOLUONGSP"] + @"</td>

            //    </tr>";
            //    }

            //    LbReturn.Text = "<a href='/TrangNhanVien.aspx?modul=KhachHang&modul1=DSDonHang' style='text-align:center; color:#000000'>Quay lại</a>";
            //}
            //else
            //{
            //    MaKH = Request.QueryString["MaKH"];
            //    DataTable tbKHACHHANG = DAO.getTable("SELECT * FROM dbo.KHACHHANG WHERE MAKH = '" + MaKH + "'");
            //    LableTieuDe.Text = @"
            //        <p style='text-align:center; text-transform:uppercase;'>Tất cả đơn hàng của khách hàng:" + tbKHACHHANG.Rows[0]["TENKH"] + @"</p>
            //    <tr>
            //        <th class ='Ma'>Mã đơn hàng</th><th class ='NguoiNhap'>Tên Khách Hàng</th><th class ='NCC' style='width:15%'>Ngày đặt</th><th class ='CongCu'style='width:7%'>Công cụ</th>
            //    </tr>";
            //    DataTable tbDONHANG = DAO.getTable("SELECT * FROM dbo.DONHANG, dbo.KHACHHANG WHERE dbo.DONHANG.MAKH = dbo.KHACHHANG.MAKH AND dbo.DONHANG.MaKH= '" + MaKH + "'");
            //    for (int i = 0; i < tbDONHANG.Rows.Count; i++)
            //    {
            //    LiteralLoadSanPham.Text += @"
            //    <tr>
            //        <td>" + tbDONHANG.Rows[i]["MADONHANG"] + @"</td>
            //        <td>" + tbDONHANG.Rows[i]["TENKH"] + @"</td>
            //        <td>" + tbDONHANG.Rows[i]["NGAYDATHANG"] + @"</td>
            //        <td style='background-color:#ffffff; text-align:center; width:30px; height:30px;'>
            //            <a href = '/TrangNhanVien.aspx?modul=KhachHang&modul1=DSDonHang&MaDonHang=" + tbDONHANG.Rows[i]["MADONHANG"] + @"'><img src='../../../../pic/detail.png' title='Detail'/></a>
            //        </td>
            //    </tr>";
            //    }
            //    }

        }

        private void LoadLoaiSP()
        {
            string sql = "SELECT * FROM dbo.LOAISANPHAM";
            DataTable tb = new DataTable();
            tb = DAO.getTable(sql);
            DrLoaiSanPham.DataSource = tb;
            DrLoaiSanPham.DataTextField = "TENLOAI"; //Text hiển thị
            DrLoaiSanPham.DataValueField = "MALOAI"; //Giá trị khi chọn
            DrLoaiSanPham.DataBind();
        }

        protected void DrLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/TrangNhanVien.aspx?modul=SanPham&LoaiSP="+DrLoaiSanPham.SelectedValue+"");
        }

        protected void DrLoaiSanPham_TextChanged(object sender, EventArgs e)
        {
            Response.Redirect("/TrangNhanVien.aspx?modul=SanPham&LoaiSP=" + DrLoaiSanPham.SelectedValue + "");
        }
    }
}