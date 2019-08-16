using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham
{
    public partial class ThemMoiSP : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Thêm mói sản phẩm</p>
                      ";
            LoadLoaiSP();
        }

        private void LoadLoaiSP()
        {
            string sql = "SELECT * FROM dbo.LOAISANPHAM";
            DataTable tb = new DataTable();
            tb = DAO.getTable(sql);
            DrLoaiSP.DataSource = tb;
            DrLoaiSP.DataTextField = "TENLOAI"; //Text hiển thị
            DrLoaiSP.DataValueField = "MALOAI"; //Giá trị khi chọn
            DrLoaiSP.DataBind();
        }

        protected void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                DataTable dt = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MASP = '"+txtMaSP.Text+"'");
                if(dt.Rows.Count== 0)
                {
                    int soLuong = 0;
                    float donGia = 0; SANPHAM SANPHAM = new SANPHAM
                    {
                        MASP = txtMaSP.Text,
                        TENSP = txtTenSP.Text,
                        DONGIA = donGia,
                        SOLUONG = soLuong,
                        DONVITINH = txtDonViTinh.Text,
                        HINHANH = fileAnh.FileName.ToString(),
                        MALOAI = DrLoaiSP.SelectedValue.ToString()
                    };
                    bool Result = DAO.InsertSANPHAM(SANPHAM);
                    if (Result == true)
                    {
                        //fileAnh.SaveAs(Server.MapPath("pic\\img\\" + fileAnh.FileName));
                        if (fileAnh.FileContent.Length > 0)
                        {
                            if (fileAnh.FileName.EndsWith(".jpeg") || fileAnh.FileName.EndsWith(".jpg") || fileAnh.FileName.EndsWith(".png") || fileAnh.FileName.EndsWith(".gif"))
                            {
                                fileAnh.SaveAs(Server.MapPath("pic\\img\\" + fileAnh.FileName));
                                lbThongBao.Text = "";
                            }
                            else { lbThongBao.Text = "Vui lòng chọn hình ảnh!"; }
                        }
                        lbThongBao.Text = "Thêm sản phẩm thành công!";
                    }
                }
                else
                {
                    lbThongBao.Text = "Đã tồn tại sản phẩm này!";
                }
            }
            else { lbThongBao.Text = "Vui lòng điền đầy đủ dữ liệu"; }
        }
    }
}