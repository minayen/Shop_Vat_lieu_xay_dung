using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham.LoaiSanPham
{
    public partial class XoaLoaiSanPham : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["MaLoai"] != null)
            {
               
                //Xóa tất cả sp có mã = mã đơn hàng trong bảng Chi tiết nhap hang
                DAO.Delete("DELETE FROM dbo.LOAISANPHAM WHERE MALOAI ='" + Request.QueryString["MaLoai"] + "'");
            }
            Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DSLoai");
        }
    }
}