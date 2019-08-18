using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang
{
    public partial class DanhSachDonNhapHang : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Tất đơn hàng nhập</p>
                      ";
            DataTable tbDSDonNhapHang = DAO.getTable("SELECT * FROM dbo.NHAPHANG, dbo.NHACUNGCAP, dbo.QUANLY WHERE dbo.NHAPHANG.MANCC = dbo.NHACUNGCAP.MANCC AND dbo.NHAPHANG.TAIKHOAN =dbo.QUANLY.TAIKHOAN");
            for (int i = 0; i<tbDSDonNhapHang.Rows.Count; i++)
            {

                LiteralDSDonNhapHang.Text += @"
                    <tr>
                        <td>"+tbDSDonNhapHang.Rows[i]["MANHAPHANG"]+ @"</td>
                        <td>"+tbDSDonNhapHang.Rows[i]["HOTEN"].ToString()+@"</td>
                        <td>"+tbDSDonNhapHang.Rows[i]["TENNCC"].ToString()+@"</td>
                        <td>"+tbDSDonNhapHang.Rows[i]["NGAYNHAP"]+ @"</td>
                        <td class='img' style='background-color:#ffffff; text-align:left;'>
                            <a onclick = 'return Xoa();' href = '/Admin.aspx?modul=SanPham&modul1=XoaDonNhapHang&MaDonHang="+ tbDSDonNhapHang.Rows[i]["MANHAPHANG"].ToString()+ @"' title='Delete'><img src='../../../../pic/delete.png'/></a>
                            <a href = '/Admin.aspx?modul=SanPham&modul1=ChinhSuaDonNhapHang&MaDonHang=" + tbDSDonNhapHang.Rows[i]["MANHAPHANG"].ToString() + @"' title='Edit'><img src='../../../../pic/edit.png'/></a>
                            <a href = '/Admin.aspx?modul=SanPham&modul1=ChiTietDonNhapHang&MaDonHang=" + tbDSDonNhapHang.Rows[i]["MANHAPHANG"].ToString() + @"'><img src='../../../../pic/detail.png' title='Detail'/></a>
                        </td>
                    </tr>";
            }
        }
    }
}