using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang
{
    public partial class NhapHang : System.Web.UI.UserControl
    {
       
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Nhập hàng vào kho</p>
                      ";
            LoadNCC();
            txtNgayNhap.ReadOnly = true;
            Calendar.Visible = false;
        }

        protected void btnNhap_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid == true)
            {
                //Chuyển tới trang chi tiết nhập
                DateTime dt = new DateTime();
                String.Format("{0:MM/dd/yyyy}", dt);
                bool KiemTra;
                KiemTra = DateTime.TryParse(txtNgayNhap.Text, out dt);
                if (KiemTra == true)
                {
                    DataTable tbNhapHang = DAO.getTable("SELECT * FROM dbo.NHAPHANG WHERE MANHAPHANG= '"+txtSoHoaDon.Text+"'");
                    if(tbNhapHang.Rows.Count == 0)
                    {
                        NHAPHANG NHAPHANG = new NHAPHANG
                        {
                            MANHAPHANG = txtSoHoaDon.Text,
                            MANCC = DrNhaCungCap.SelectedValue.ToString(),
                            NGAYNHAP = dt,
                            TAIKHOAN = Session["TAIKHOAN"].ToString(),
                        };
                        //Thêm đơn hàng
                        bool result = DAO.InsertNHAPHANG(NHAPHANG);
                        if (result == true)
                        {
                            //Chuyển sang chi tiết hóa đơn
                            Response.Redirect("/Admin.aspx?modul=SanPham&modul1=ChiTietNhap&SHD=" + txtSoHoaDon.Text);
                        }
                        else lbThongBao.Text = "Không thể thêm hóa đơn";
                    }
                    else { lbThongBao.Text = "Đã tồn tại đơn hàng này trong các đơn hàng đã nhập vào kho"; }
                }
                else
                {
                    lbThongBao.Text = "Ngày nhập không hợp lệ";
                }
            }
            else lbThongBao.Text = "Vui lòng điền đầy đủ thông tin!";
        }
        
        private void LoadNCC()
        {
            string sql = "SELECT * FROM dbo.NHACUNGCAP";
            DataTable tb = new DataTable();
            tb = DAO.getTable(sql);
            DrNhaCungCap.DataSource = tb;
            DrNhaCungCap.DataTextField = "TENNCC"; //Text hiển thị
            DrNhaCungCap.DataValueField = "MaNCC"; //Giá trị khi chọn
            DrNhaCungCap.DataBind();
        }

        protected void btnChoiceDay_Click(object sender, EventArgs e)
        {
            Calendar.Visible = true;
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            Calendar.Visible = false;
            DateTime dt = new DateTime();
            dt = Calendar.SelectedDate;
            String.Format("{0:d}", dt);
            txtNgayNhap.Text =""+dt.Month+"/"+dt.Day+"/"+dt.Year;
            //lbThongBao.Text = dt.ToString();
        }

        protected void Calendar_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Calendar.Visible = true;
        }
    }
}
