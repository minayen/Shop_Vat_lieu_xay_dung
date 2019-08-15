using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace DeTaiQuanLyBanHang
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["QLBanHang"].ConnectionString;
            //Response.Write(connectionString);
            //Check session
            //CheckSession();
        }

        //Xủ lý sự kiện đăng nhập
        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            XuLyDangNhap();
        }
        //Xử lý đăng nhập
        private void XuLyDangNhap()
        {
            ConnectDatabase DAO = new ConnectDatabase();
            if (txtPass.Text != "" && txtPass.Text != "")
            {
                string userName = txtUserName.Text;
                string pass = txtPass.Text;
                DataTable dtQuanLy = DAO.getTable("SELECT * FROM dbo.QUANLY WHERE TAIKHOAN = '" + userName + "' and MATKHAU = '" + pass + "'");
                if (dtQuanLy.Rows.Count>0)
                {
                    
                    Session["TAIKHOAN"] = userName;
                    if (dtQuanLy.Rows[0]["PHANQUYEN"].ToString() == "1") {
                        Response.Redirect("/Admin.aspx?modul=GioiThieu");
                    }
                    else
                    {
                        Response.Redirect("TrangNhanVien.aspx");
                    }
                }
                else
                {
                    lbThongbao.Text = "Sai tài khoản hoặc mật khẩu";
                }
            }
            else
            {
                lbThongbao.Text = "Vui lòng điền đầy đủ thông tin";
            }
        }
        
        //Kiểm tra đã tồn tại Session Uername
        //private void CheckSession()
        //{
        //    if(Session["TAIKHOAN"] != null)
        //    {
        //        Response.Redirect("/Admin.aspx?modul=GioiThieu");
        //    }
        //}
    }
}