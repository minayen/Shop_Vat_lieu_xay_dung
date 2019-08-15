using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace DeTaiQuanLyBanHang.cms.admin.TaoTaiKhoan
{
    public partial class DanhSachTaiKhoan : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Tất cả nhà cung cấp</p>
                      ";
                DataTable tbDSTaiKhoan = DAO.getTable("SELECT * FROM dbo.QUANLY");
                if (tbDSTaiKhoan.Rows.Count > 0)
                {
                    LiteralDSTaiKhoan.Text += @"<tr>
      <th class ='Ma' style='width: 13 % '>Tên TK</th><th class ='NguoiNhap' style='width: 13 % '>Email</th><th class ='NguoiNhap' style='width: 13 % '>Số điện thoại</th><th class ='NCC' style='width: 10 % '>Địa chỉ</th><th class ='CongCu' style='width: 10 % '>Họ & tên</th><th class ='CongCu' style='width: 10 % '>Công cụ</th>
                 </ tr > ";
                    for (int i = 0; i < tbDSTaiKhoan.Rows.Count; i++)
                    {
                        //< a href = '/Admin.aspx?modul=TaiKhoan&modul1=ChinhSuaTaiKhoan&TaiKhoan=" + tbDSTaiKhoan.Rows[i]["TAIKHOAN"] + @"' title = 'Edit' >< img src = '../../../../pic/edit.png' /></ a >
                        LiteralDSTaiKhoan.Text += @"
                        <tr>
                            <td>" + tbDSTaiKhoan.Rows[i]["TAIKHOAN"] + @"</td>
                            <td>" + tbDSTaiKhoan.Rows[i]["EMAIL"].ToString() + @"</td>
                            <td>" + tbDSTaiKhoan.Rows[i]["SDT"].ToString() + @"</td>
                            <td>" + tbDSTaiKhoan.Rows[i]["DIACHI"].ToString() + @"</td>
                            <td>" + tbDSTaiKhoan.Rows[i]["HOTEN"] + @"</td>
                            <td class='img' style='background-color:#ffffff; text-align:center;'>
                            
                                <a onclick='return Xoa();' href = '/Admin.aspx?modul=TaiKhoan&modul1=DSTaiKhoan&TaiKhoan=" + tbDSTaiKhoan.Rows[i]["TAIKHOAN"] + @"' title='Delete'><img src='../../../../pic/delete.png'/></a>
                             </td>
                        </tr>";
                    }
                }
            }


            if (Request.QueryString["TaiKhoan"] != null)
            {
                if (Request.QueryString["TaiKhoan"].ToString().ToLower() == "admin")
                {
                    Response.Write("<script>alert('Không được xóa tài khoản " + Request.QueryString["TaiKhoan"].ToString() + @"');</script>");
                }
                else
                {
                    DAO.Delete("DELETE FROM dbo.QUANLY WHERE TAIKHOAN = '" + Request.QueryString["TaiKhoan"] + "'");
                    Response.Redirect("/Admin.aspx?modul=TaiKhoan&modul1=DSTaiKhoan");
                }
            }
        }
    }
}