using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham
{
    public partial class DanhSachSanPham : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Tất cả sản phẩm</p>
                      ";
                DataTable tbDSSP = DAO.getTable("SELECT * FROM dbo.SANPHAM, dbo.LOAISANPHAM WHERE dbo.SANPHAM.MALOAI = dbo.LOAISANPHAM.MALOAI");
                for (int i = 0; i < tbDSSP.Rows.Count; i++)
                {

                    LiteralDSSP.Text += @"
                    <tr>
                        <td>" + tbDSSP.Rows[i]["MASP"] + @"</td>
                        <td>" + tbDSSP.Rows[i]["TENSP"].ToString() + @"</td>
                        <td style='background-color:#ffffff; text-align:center;'><img src='../../../pic/img/" + tbDSSP.Rows[i]["HINHANH"] + @"' style='width: 100px; height: auto'/></td>
                        <td>" + tbDSSP.Rows[i]["DONVITINH"] + @"</td>
                        <td>" + tbDSSP.Rows[i]["SOLUONG"].ToString() + @"</td>
                        <td>" + tbDSSP.Rows[i]["DONGIA"].ToString() + @"</td>
                        <td>" + tbDSSP.Rows[i]["TENLOAI"] + @"</td>
                        <td class='img' style='background-color:#ffffff; text-align:center;'>
                            <a href = '/Admin.aspx?modul=SanPham&modul1=ChinhSuaSanPham&MaSP=" + tbDSSP.Rows[i]["MASP"].ToString() + @"' title='Edit'><img src='../../../../pic/edit.png'/></a>
                            <a onclick='return Xoa();' href = '/Admin.aspx?modul=SanPham&modul1=DanhSachSanPham&MaSP=" + tbDSSP.Rows[i]["MASP"].ToString() + @"' title='Delete'><img src='../../../../pic/delete.png'/></a>
                        </td>
                    </tr>";
                }
            }

            if (Request.QueryString["MaSP"] != null)
            {

                //Xóa tất cả sp có mã = mã đơn hàng trong bảng Chi tiết nhap hang
                DAO.Delete("DELETE FROM dbo.SANPHAM WHERE MASP ='" + Request.QueryString["MaSP"] + "'"); Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachSanPham");
            }

        }
    }
}