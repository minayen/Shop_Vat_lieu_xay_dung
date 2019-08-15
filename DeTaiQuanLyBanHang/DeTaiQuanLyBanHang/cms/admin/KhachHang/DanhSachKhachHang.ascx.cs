using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.KhachHang
{
    public partial class DanhSachKhachHang : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {

            LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Tất cả khách hàng</p>
                      ";
            DataTable tbKHACHHANG = DAO.getTable("SELECT * FROM dbo.KHACHHANG");
            for (int i = 0; i < tbKHACHHANG.Rows.Count; i++)
            {
                    LiteralDSKH.Text += @"
                    <tr>
                        <td>" + tbKHACHHANG.Rows[i]["MAKH"] + @"</td>
                        <td>" + tbKHACHHANG.Rows[i]["TENKH"]+ @"</td>
                        <td>" + tbKHACHHANG.Rows[i]["DIACHI"]+ @"</td>
                        <td>" + tbKHACHHANG.Rows[i]["EMAIL"] + @"</td>
                        <td>" + tbKHACHHANG.Rows[i]["SDT"] + @"</</td>
                        <td class='img' style='background-color:#ffffff; text-align:left;'>
                            <a href = 'Admin.aspx?modul=KhachHang&modul1=XemDSDonHang&MaKH=" + tbKHACHHANG.Rows[i]["MAKH"] + @"' ><img src='../../../../pic/detail.png' /></a>
                        </td>
                    </tr>";
            }
        }
    }
}