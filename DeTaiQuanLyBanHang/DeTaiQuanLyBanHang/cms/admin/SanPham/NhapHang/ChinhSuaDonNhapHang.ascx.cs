using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang
{
    public partial class ChinhSuaDonNhapHang : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        string MaDonHang = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["MaDonHang"] != null)
            {
                
                    MaDonHang = Request.QueryString["MaDonHang"];
                    DataTable dt = DAO.getTable("SELECT * FROM dbo.NHAPHANG WHERE MANHAPHANG = '"+MaDonHang+"'");
                
                    if (dt.Rows.Count > 0)
                    {
                        txtSoHoaDon.Text = dt.Rows[0]["MANHAPHANG"].ToString();
                        txtNgayNhap.Text = dt.Rows[0]["NGAYNHAP"].ToString();
                        DrNhaCungCap.SelectedValue = dt.Rows[0]["MANCC"].ToString();
                    }
              
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachDonNHapHang");
            }
            txtSoHoaDon.ReadOnly = true;
            LoadNCC();
            //txtNgayNhap.ReadOnly = true;
            Calendar.Visible = false;
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


        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                bool Result = DAO.UpDate("UPDATE dbo.NHAPHANG SET  MANCC= '"+DrNhaCungCap.SelectedValue.ToString()+"' , NGAYNHAP ='"+DateTime.Parse(txtNgayNhap.Text) +"'  WHERE MANHAPHANG = '"+MaDonHang+"'");
                Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachDonNHapHang");
                //lbThongBao.Text = "" + txtNgayNhap.Text ;
            }
        }

        protected void Calendar_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            Calendar.Visible = true;
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            Calendar.Visible = false;
            DateTime dt = new DateTime();
            dt = Calendar.SelectedDate;
            String.Format("{0:d}", dt);
            txtNgayNhap.Text = dt.ToString();
            //txtNgayNhap.Text = "" + dt.Month + "/" + dt.Day + "/" + dt.Year;
            //lbThongBao.Text = dt.ToString();
        }
        //Chọn ngày
        protected void btnChoiceDay_Click(object sender, EventArgs e)
        {
            Calendar.Visible = true;
        }
    }
}