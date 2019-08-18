using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang
{
    public partial class ChitietNhapHang : System.Web.UI.UserControl
    {
        string SoHoaDon = "";
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            //Kiểm tra  Số hóa đơn
            if(Request.QueryString["SHD"] == null)
            {
                Response.Redirect("/Admin.aspx?modul=SanPham&modul1=NhapHang");
            }
            else
            {

                //Kiểm tra số hóa đơn đã tồn tại hay chưa, nếu chưa đưa về trang nhaphang
                SoHoaDon = Request.QueryString["SHD"];
                DataTable tb = new DataTable();
                tb = DAO.getTable("SELECT * FROM dbo.NHAPHANG WHERE MANHAPHANG = '"+SoHoaDon+"'");
                if(tb.Rows.Count == 0)
                {
                    Response.Redirect("/Admin.aspx?modul=SanPham&modul1=NhapHang");
                }
                lbSoHoaDon.Text = "Nhập hàng cho hóa đơn: " +SoHoaDon;
            }

        }
        //Xóa form
        protected void btnXoaTrongForm_Click(object sender, EventArgs e)
        {
            txtGiaBanRa.Text = "";
            txtGiaNhapVao.Text = "";
            txtSoLuong.Text = "";
        }
        //Hoàn thành đơn hàng
        protected void btnHoanThanh_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachDonNHapHang");
            //DataTable tb = DAO.getTable("SELECT * FROM dbo.CHITIETNHAPHANG WHERE MANHAPHANG = '" + SoHoaDon + "'");
            //if(tb.Rows.Count == 0)
            //{
            //    lbThongBao.Text 
            //}
        }



        protected void btnNhap_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid == true)
            {

                //Kiểm tra có tồn tại mặt hàng trong hóa đơn chưa
                DataTable tb= DAO.getTable("SELECT * FROM dbo.CHITIETNHAPHANG WHERE MANHAPHANG = '"+SoHoaDon+"' AND MASP = '"+DrTenSanPham.SelectedValue.ToString()+"'");
                if(tb.Rows.Count == 0)
                {

                    //Thêm vào bảng chi tiết hóa đơn
                    CHITIETNHAPHANG NHAPHANG = new CHITIETNHAPHANG
                    {
                        MANHAPHANG = SoHoaDon,
                        MASANPHAM = DrTenSanPham.SelectedValue.ToString(),
                        SOLUONG = int.Parse(txtSoLuong.Text),
                        GIANHAP = int.Parse(txtGiaNhapVao.Text),
                        GIABAN = int.Parse(txtGiaBanRa.Text),
                    };
                    bool result = DAO.InsertCHITETNHAPHANG(NHAPHANG);
                    if (result == true)
                    {

                        //Cập nhật số lượng và giá bán cho sản phẩm trong bản sản phẩm
                        //Lấy số lượng sản phẩm
                        DataTable tbSP = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MASP = '"+DrTenSanPham.SelectedValue.ToString()+"'");
                        int SoLuongSP = int.Parse(tbSP.Rows[0][4].ToString()) + int.Parse(txtSoLuong.Text);
                        DAO.UpDate("UPDATE dbo.SANPHAM SET  SOLUONG ="+SoLuongSP+", DONGIA = "+int.Parse(txtGiaBanRa.Text)+" WHERE MASP ='"+DrTenSanPham.SelectedValue.ToString()+"'");
                        lbThongBao.Text = "Thêm hàng thành công!";
                    }
                    else { lbThongBao.Text = "Thêm hàng thất bại"; }
                }
                else { lbThongBao.Text = "Đã tồn tại mặt hàng này trong hóa đơn nhập!"; }
            }else
            {
                lbThongBao.Text = "Vui lòng điền đầy đủ thông tin";
            }
        }

        /// <summary>
        /// Load sản phẩm
        /// </summary>
        private void LoadSanPham()
        {
            string sql = "SELECT * FROM dbo.SANPHAM";
            DataTable tb = new DataTable();
            tb = DAO.getTable(sql);
            DrTenSanPham.DataSource = tb;
            DrTenSanPham.DataTextField = "TENSP"; //Text hiển thị
            DrTenSanPham.DataValueField = "MASP"; //Giá trị khi chọn
            DrTenSanPham.DataBind();
        }
    }
}