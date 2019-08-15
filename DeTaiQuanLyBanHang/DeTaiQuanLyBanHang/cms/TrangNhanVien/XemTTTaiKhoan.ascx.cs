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
    public partial class XemTTTaiKhoan : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TAIKHOAN"]!= null) {
                DataTable dt = DAO.getTable("SELECT * FROM QUANLY WHERE TAIKHOAN='"+ Session["TAIKHOAN"] + "'");
                if (dt.Rows.Count > 0)
                {
                    txtHoTen.ReadOnly =true;
                    txtEmail.ReadOnly = true;
                    txtDiaChi.ReadOnly = true;
                    txtSDT.ReadOnly = true;
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
            Response.Redirect("TrangNhanVien.aspx?modul=CapNhatTT");
        }
    }
}