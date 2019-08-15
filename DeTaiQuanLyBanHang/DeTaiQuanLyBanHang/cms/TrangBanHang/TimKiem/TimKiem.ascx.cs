using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.TimKiem
{
    public partial class TimKiem : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectDatabase DAO = new ConnectDatabase();
            if (Request.QueryString["NoiDung"] != null)
            {
                DataTable dt = DAO.getTable("SELECT * FROM SANPHAM WHERE (TENSP like '%" + Request.QueryString["NoiDung"] + "%' or TENSP like '%" + Request.QueryString["NoiDung"] + "' or TENSP like '" + Request.QueryString["NoiDung"] + "%') AND SOLUONG >0");
                if (dt.Rows.Count > 0)
                {
                    ltTimKiem.Text += @"<div class='SanPham'>
    <div class ='LoaiSanPham'>
        <div style = 'text-transform:uppercase; text-align:center; float:left; margin-left:50%' > Kết quả tìm kiếm cho:'" + Request.QueryString["NoiDung"] + @"'</div>
        <div style = 'float:right' > </div>
        <div class='clear'></div>
    </div>";

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ltTimKiem.Text += @"<div>
       <div class='HinhAnh'><a href = '/TrangBanHang.aspx?modul=SanPham&modul1=ChiTietSanPham&idSP=" + dt.Rows[i]["MASP"] + @"'><img src='pic/img/" + dt.Rows[i]["HINHANH"] + @"' />
                Tên Sản Phẩm: " + dt.Rows[i]["TENSP"] + @"
                <br/>
                Giá:" + dt.Rows[i]["DONGIA"] + @"VNĐ/" + dt.Rows[i]["DONVITINH"] + @" </a>
                <br />
        </div>
    </div>";
                    }
                    ltTimKiem.Text += @" </div>
<div class='clear'></div>";
                }
                else
                {
                    ltTimKiem.Text += @"<div class='SanPham'>
                    <div class ='LoaiSanPham'>
                        <div style = 'text-transform:uppercase; text-align:center; float:left; margin-left:37%' >Không tìm thấy kết quả nào cho từ khóa:'" + Request.QueryString["NoiDung"] + @"'</div>
                        <div style = 'float:right' > </div>
                        <div class='clear'></div>
                    </div>
                </div>
                <div class='clear'></div>";
                }


            }
            else
            {
                Response.Redirect("TrangBanHang.aspx?modul=GioiThieu");
            }

        }
    }
}