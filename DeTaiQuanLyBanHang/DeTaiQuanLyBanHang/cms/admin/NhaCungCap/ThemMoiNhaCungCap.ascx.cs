using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace DeTaiQuanLyBanHang.cms.admin.NhaCungCap
{
    public partial class ThemMoiNhaCungCap : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>THêm mới nhà cung cấp</p>
                      ";
        }

        //Thêm mới một nhà cung cấp
        protected void btnThemmoi_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                DataTable tb = new DataTable();
                tb =DAO.getTable("SELECT * FROM dbo.NHACUNGCAP WHERE MANCC= '"+txtMaNCC.Text+"' ");
                if(tb.Rows.Count ==0)
                {
                    NHACUNGCAP NCC = new NHACUNGCAP
                    {
                        // Lấy giá trị theo tên cột trong CSDL
                        MANHACUNGCAP = txtMaNCC.Text,
                        TENNHACUNGCAP = txtTenNCC.Text,
                        EMAIL = txtEmailNCC.Text,
                        SODIENTHOAI = txtSDT.Text,
                    };
                    DAO.InsertNCC(NCC);
                    lbThongBao.Text = "Thêm nhà cung cấp thành công!";
                }
                else lbThongBao.Text = "Đã tồn tại nhà cung cấp với mã này!"; 
            }
            else
            {
                lbThongBao.Text = "Vui lòng điền đầy đủ thông tin!";
            }
        }


        //Clear form
        protected void btnClearForm_Click(object sender, EventArgs e)
        {
            txtEmailNCC.Text = "";
            txtMaNCC.Text = "";
            txtSDT.Text = "";
            txtTenNCC.Text = "";
        }
    }
}