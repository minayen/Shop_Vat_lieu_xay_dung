using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.SanPham

{
    public partial class DanhSachSanPham : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSanPham();
            }
        }

        private void LoadSanPham()
        {
            DataTable dt = DAO.getTable("SELECT * FROM dbo.LOAISANPHAM");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dtSp = DAO.getTable("SELECT TOP 5 * FROM dbo.SANPHAM WHERE MALOAI = '" + dt.Rows[i]["MALOAI"] + "' AND DONGIA != 0");
                    if (dtSp.Rows.Count > 0)
                    {
                        ltSanPham.Text += @"<div class='SanPham'>
    <div class ='LoaiSanPham'>
        <div style = 'text-transform:uppercase; text-align:center; float:left; margin-left:50%' >" + dt.Rows[i]["TENLOAI"] + @"</div>
        <div style = 'float:right' > <a href='/TrangBanHang.aspx?modul=SanPham&modul1=DanhSachLoaiSanPham&MaLoai="+dtSp.Rows[0]["MALOAI"]+@"'>Xem thêm</a></div>
        <div class='clear'></div>
    </div>";
                        for (int j = 0; j < dtSp.Rows.Count; j++)
                        {
                            ltSanPham.Text += @"
    <div>
       <div class='HinhAnh'><a href = '/TrangBanHang.aspx?modul=SanPham&modul1=ChiTietSanPham&idSP="+dtSp.Rows[j]["MASP"]+@"' ><img src='pic/img/" + dtSp.Rows[j]["HINHANH"] + @"' />
                <center>Tên Sản Phẩm: " + dtSp.Rows[j]["TENSP"] + @"
                <br/>
                Giá: " + dtSp.Rows[j]["DONGIA"] + @"vnđ/" + dtSp.Rows[j]["DONVITINH"] + @"</a>
                <br /></center>
        </div>
    </div>";
                        }

                        ltSanPham.Text += @"
</div>
<div class='clear'></div>";
                    }
                }
            }
        }
    }
}