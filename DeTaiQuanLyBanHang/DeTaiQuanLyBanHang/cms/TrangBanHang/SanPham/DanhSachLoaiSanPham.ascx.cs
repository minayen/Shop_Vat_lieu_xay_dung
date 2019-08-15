using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.SanPham
{
    public partial class DanhSachLoaiSanPham : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string MaLoai = "";
                if (Request.QueryString["MaLoai"] != null)
                {
                    MaLoai = Request.QueryString["MaLoai"];
                    LaySanPhamTheoLoai(MaLoai);
                }
                else
                {
                    Response.Redirect("/TrangBanHang.aspx?modul=SanPham&modul1=DanhSachSanPham");
                }
            }
        }
        private void LaySanPhamTheoLoai(String MaLoai)
        {
            DataTable dtLoai = DAO.getTable("SELECT * FROM dbo.LOAISANPHAM WHERE MALOAI = '" + MaLoai + "'");
            DataTable dt = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MALOAI = '" + MaLoai + "' AND DONGIA != 0");
            if (dt.Rows.Count>0 && dtLoai.Rows.Count>0)
            {
                ltLoaiSanPham.Text += @"<div class ='LoaiSP'>
<div class='TenLoai'>"+dtLoai.Rows[0]["TENLOAI"]+@"</div>
    <hr/>";
                for(int i = 0; i<dt.Rows.Count; i++)
                {
                    ltLoaiSanPham.Text += @"
            <div class='ThongTinSanPham'>
                <div class='AnhSP'><a href = '/TrangBanHang.aspx?modul=SanPham&modul1=ChiTietSanPham&idSP=" + dt.Rows[i]["MASP"] + @"'><img src='pic/img/" + dt.Rows[i]["HINHANH"]+ @"'/>
                Tên Sản Phẩm: " + dt.Rows[i]["TENSP"] + @"
                <br/>
                Giá: " + dt.Rows[i]["DONGIA"] + @"vnđ/" + dt.Rows[i]["DONVITINH"] + @"</a>
                <br/>
                </div>
            </div>";
                }
                ltLoaiSanPham.Text += "</div>";
            }
        }
    }
}