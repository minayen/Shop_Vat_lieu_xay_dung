using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham
{
    public partial class ChinhSuaSanPham : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        string MaSanPham;
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Request.QueryString["MaSP"] != null)
            {
                LoadLoaiSP();
                MaSanPham = Request.QueryString["MaSP"];
                DataTable dt = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MASP ='"+MaSanPham+"'");
                if (dt.Rows.Count > 0)
                {
                    LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Cập nhật thông tin sản phẩm có mã: " + MaSanPham + @"</p>
                      ";
                    txtMaSP.ReadOnly = true;
                    txtMaSP.Text = dt.Rows[0]["MASP"].ToString();
                    DrLoaiSP.SelectedValue = dt.Rows[0]["MALOAI"].ToString();
                    txtDonViTinh.Text = dt.Rows[0]["DONVITINH"].ToString();
                    txtTenSP.Text = dt.Rows[0]["TENSP"].ToString();
                    lbHinhAnhSP.Text = "<img src='../../../pic//img/"+dt.Rows[0]["HINHANH"]+ "' style='width: 200px; height: auto'/>";
                    // fileAnh.FileName = dt.Rows[0]["HINHANH"].ToString();
                    //if (fileAnh.FileName == null)
                    //{
                    //    DAO.UpDate("UPDATE dbo.SANPHAM SET  TENSP= '" + txtTenSP + "', MALOAI='" + DrLoaiSP.SelectedValue + "', DONVITINH='" + txtDonViTinh + "' WHERE MASP = '" + MaSanPham + "'");
                    //}
                    //else
                    //{
                    //    DAO.UpDate("UPDATE dbo.SANPHAM SET  TENSP= '" + txtTenSP + "', MALOAI='" + DrLoaiSP.SelectedValue + "', DONVITINH='" + txtDonViTinh + "', HINHANH='"+fileAnh.FileName+"' WHERE MASP = '" + MaSanPham + "'");
                    //}

                    //Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachSanPham");
                }
                else{
                    Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachSanPham");
                }
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachSanPham");
            }
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

        protected void btnCaapNhat_Click(object sender, EventArgs e)
        {
            if (fileAnh.FileName == null || fileAnh.FileName =="")
            {
                DAO.UpDate("UPDATE dbo.SANPHAM SET  TENSP= N'" + txtTenSP.Text + "', MALOAI='" + DrLoaiSP.SelectedValue + "', DONVITINH=N'" + txtDonViTinh.Text + "' WHERE MASP = '" + MaSanPham + "'");
            }
            else
            {
                if (fileAnh.FileName.EndsWith(".jpeg") || fileAnh.FileName.EndsWith(".jpg") || fileAnh.FileName.EndsWith(".png") || fileAnh.FileName.EndsWith(".gif"))
                {
                    fileAnh.SaveAs(Server.MapPath("pic\\img\\" + fileAnh.FileName));
                    lbThongBao.Text = "";
                    DAO.UpDate("UPDATE dbo.SANPHAM SET  TENSP= N'" + txtTenSP.Text + "', MALOAI='" + DrLoaiSP.SelectedValue + "', DONVITINH=N'" + txtDonViTinh.Text + "', HINHANH='" + fileAnh.FileName.ToString() + "' WHERE MASP = '" + MaSanPham + "'");
                }
                else { lbThongBao.Text = "Vui lòng chọn hình ảnh!"; }

            }

            Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachSanPham");
            //Response.Write("<script>alert('"+fileAnh.FileName.ToString()+@"')</script>");
        }
    }
}