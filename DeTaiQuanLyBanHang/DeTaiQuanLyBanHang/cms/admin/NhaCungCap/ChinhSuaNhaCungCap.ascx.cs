using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.admin.NhaCungCap
{
    public partial class ChinhSuaNhaCungCap : System.Web.UI.UserControl
    {
        string MaNCC ="";
        ConnectDatabase DAO = new ConnectDatabase();

        //Load thông tin Nhà cung cấp lên các control
        protected void Page_Load(object sender, EventArgs e)
        {
            LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Chỉnh sửa nhà cung cấp:"+ Request.QueryString["MaNCC"] + @"</p>
                      ";
            //Kiểm tra có tồn tại mã nhà cung cấp hay không
            if (Request.QueryString["MaNCC"] != null)
            {
                MaNCC = Request.QueryString["MaNCC"];
                NHACUNGCAP NCC =DAO.LayNCC(MaNCC);
                if (NCC != null)
                {
                    txtMaNCC.Text = NCC.MANHACUNGCAP;
                    txtMaNCC.ReadOnly= true;
                    txtTenNCC.Text = NCC.TENNHACUNGCAP;
                    txtEmail.Text = NCC.EMAIL;
                    txtSDT.Text = NCC.SODIENTHOAI;
                }

            }
            else Response.Redirect("/Admin.aspx?modul=NhaCungCap&modul1=DanhSachNCC");
        }

        protected void txtCapNhat_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                NHACUNGCAP NCC = new NHACUNGCAP
                {
                    // Lấy giá trị theo tên cột trong CSDL
                    MANHACUNGCAP = txtMaNCC.Text,
                    TENNHACUNGCAP = txtTenNCC.Text,
                    EMAIL = txtEmail.Text,
                    SODIENTHOAI = txtSDT.Text,
                };
                bool result = DAO.UpDateNCC(NCC);
                if (result == true)
                {
                    //lbThongBao.Text = "Cập nhật thông tin thành công!";
                    Response.Redirect("/Admin.aspx?modul=NhaCungCap&modul1=DanhSachNCC");
                }
                else lbThongBao.Text = "Cập nhật thông tin thất bai";
                
            }
        }
    }
}