
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang
{
    public partial class TrangNhanVien : System.Web.UI.Page
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
                KiemTraSession();
            if (Request.QueryString["modul"] != null)
            {
                //LabelCay.Text = Request.QueryString["modul"];

                switch (Request.QueryString["modul"])
                {
                    case "SanPham":
                        LabelCay.Text = "Sản phẩm";
                        break;
                    case "KhachHang":
                        LabelCay.Text = "Khách hàng";
                        break;
                    case "XemTT":
                        LabelCay.Text = "Thông tin tài khoản";
                        break;

                    case "CapNhatTT":
                        LabelCay.Text = "Cập nhật thông tin";
                        break;

                    case "DoiMKTK":
                        LabelCay.Text = "Đổi mật khẩu";
                        break;

                }
            }
            if (Request.QueryString["modul1"] != null)
            {
                //LabelCay.Text += ">>" + Request.QueryString["modul1"];
                switch (Request.QueryString["modul1"])
                {

                    case "DanhSachKhachHang":
                        LabelCay.Text += " >> Danh sách khách hàng";
                        break;
                    case "DSDonHang":
                        LabelCay.Text += " >> Danh sách đơn hàng";
                        break;

                }
            }
        }

    
        /////Kiểm tra session
        private void KiemTraSession()
            {
                if (Session["TAIKHOAN"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {

                    DataTable dtQuanLy = DAO.getTable("SELECT * FROM dbo.QUANLY WHERE TAIKHOAN = '" + Session["TAIKHOAN"] + "'");
                    if (dtQuanLy.Rows.Count > 0)
                    {
                        if (dtQuanLy.Rows[0]["PHANQUYEN"].ToString() != "0")
                        {
                            Response.Redirect("Admin.aspx");
                        }
                    }
                    lbXinChao.Text = "Xin chào: " + Session["TAIKHOAN"];
            }
            }


        protected void btnDangXuat_Click(object sender, EventArgs e)
        {
            //Huỷ session
            Session["TAIKHOAN"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}