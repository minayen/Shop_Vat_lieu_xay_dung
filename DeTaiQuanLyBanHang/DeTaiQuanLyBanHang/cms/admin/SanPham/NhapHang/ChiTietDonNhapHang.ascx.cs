using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang
{
    public partial class ChiTietDonNhapHang : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        string MaHoaDon = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["MaDonHang"] != null)
            {
                MaHoaDon = Request.QueryString["MaDonHang"];
                DataTable dt = DAO.getTable("SELECT * FROM dbo.CHITIETNHAPHANG, dbo.SANPHAM WHERE dbo.CHITIETNHAPHANG.MASP=dbo.SANPHAM.MASP AND dbo.CHITIETNHAPHANG.MANHAPHANG = '" + MaHoaDon+"'");
                for (int i = 0; i<dt.Rows.Count; i++)
                {
                    LiteralChiTietDonNhapHang.Text += @"
                    <tr>
                        <td>"+dt.Rows[i]["MANHAPHANG"]+ @"</td>
                        <td>" + dt.Rows[i]["TENSP"] + @"</td>
                        <td>" + dt.Rows[i]["SOLUONG"] + @"</td>
                        <td>" + dt.Rows[i]["GIANHAP"] + @"</td>
                        <td>" + dt.Rows[i]["GIABAN"] + @"</td>
                    </tr>";
                }
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachDonNHapHang");
            }
        }
    }
}