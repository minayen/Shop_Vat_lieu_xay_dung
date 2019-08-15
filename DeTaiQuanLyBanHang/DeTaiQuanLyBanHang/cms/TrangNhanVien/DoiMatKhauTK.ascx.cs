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
    public partial class DoiMatKhauTK : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (Session["TAIKHOAN"] != null)
            {
                DataTable dt = DAO.getTable("SELECT * FROM dbo.QUANLY WHERE TAIKHOAN ='" + Session["TAIKHOAN"] + "'");
                if (txtMatKhauMoi.Text == txtMatKhauMoi2.Text)
                {
                    if (txtMatKhauCu.Text == dt.Rows[0]["MATKHAU"].ToString())
                    {
                        bool rs = DAO.UpDate("UPDATE dbo.QUANLY SET  MATKHAU ='" + txtMatKhauMoi.Text + "' WHERE TAIKHOAN = '" + Session["TAIKHOAN"] + "'");
                        if (rs == true)
                        {
                            Response.Write("<script>alert('Đổi mật khẩu thành công!!');</script>");
                        }
                    }
                    else { Response.Write("<script>alert('Mật khẩu không đúng!!');</script>"); }
                }else
                {
                    Response.Write("<script>alert('Mật khẩu không khớp!!');</script>");
                }
            }
        }
    }
}