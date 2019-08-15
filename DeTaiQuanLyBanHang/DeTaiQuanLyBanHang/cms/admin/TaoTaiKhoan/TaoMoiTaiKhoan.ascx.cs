using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.TaoTaiKhoan
{
    public partial class TaoMoiTaiKhoan : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                DataTable dtCheckTaiKhoan = DAO.getTable("SELECT * FROM dbo.QUANLY WHERE TAIKHOAN='" + txtTenTaiKhoan.Text + "'");
                if (dtCheckTaiKhoan.Rows.Count > 0)
                {
                    Response.Write("<script>alert('Tên tài khoản này đã tồn tại vui lòng chọn một tên mới!');</script>");
                }
                else
                {
                    if (txtMatKhau1.Text == txtMatKhau2.Text)
                    {
                        TAIKHOAN TAIKHOAN = new TAIKHOAN
                        {
                            TENTAIKHOAN = txtTenTaiKhoan.Text,
                            MATKHAU = txtMatKhau1.Text,
                            EMAIL = txtEmail.Text,
                            DIACHI = txtDiaChi.Text,
                            QUYEN = int.Parse(DropDownList1.SelectedValue.ToString()),
                            HOTEN = txtHoTen.Text,
                            SODIENTHOAI = txtSDT.Text,
                        };
                        bool result = DAO.InsertTAIKHOAN(TAIKHOAN);
                        if (result == true)
                        {
                            Response.Write("<script>alert('Thêm tài khoản thành công!');</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Mật khẩu không khớp với nhau!!');</script>");
                    }
                }
            }
        }
    }
}