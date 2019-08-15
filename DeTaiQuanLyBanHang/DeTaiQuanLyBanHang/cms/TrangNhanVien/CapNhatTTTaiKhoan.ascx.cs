using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DeTaiQuanLyBanHang.cms.TrangNhanVien
{
    public partial class CapNhatTTTaiKhoan : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TAIKHOAN"] != null)
            {
                DataTable dt = DAO.getTable("SELECT * FROM QUANLY WHERE TAIKHOAN='" + Session["TAIKHOAN"] + "'");
                if (dt.Rows.Count > 0)
                {
                    txtHoTen.Text = dt.Rows[0]["HOTEN"].ToString();
                    txtSDT.Text = dt.Rows[0]["SDT"].ToString();
                    txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
                    txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                }
            }
            else
            {
            }
        }

        protected void btnDatHang_Click(object sender, EventArgs e)
        {
           bool rs=  DAO.UpDate("UPDATE dbo.QUANLY SET  EMAIL ='"+txtEmail.Text+"',SDT ='"+txtSDT.Text+"',HOTEN ='"+txtHoTen.Text+"',DIACHI ='"+txtDiaChi.Text+"'  WHERE TAIKHOAN = '" + Session["TAIKHOAN"] + "'");
            if (rs == true)
            {
                Response.Write("<script>alert('Cập nhật thông tin tài khoản thành công!!');</script>");
            }
        }
    }
}