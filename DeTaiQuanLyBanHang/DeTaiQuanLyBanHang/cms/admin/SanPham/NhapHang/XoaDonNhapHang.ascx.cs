using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham.NhapHang
{
    public partial class XoaDonNhapHang : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        string MaDonHang = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["MaDonHang"] != null)
            {
                MaDonHang = Request.QueryString["MaDonHang"];
                DataTable SP;

             //Lấy tất cả sản phẩm của đơn nhập hàng
                DataTable dt = DAO.getTable("SELECT * FROM dbo.CHITIETNHAPHANG WHERE MANHAPHANG ='" + MaDonHang + "'");
                //Duyệt từng sp của đơn nhập hàng
                for (int i = 0; i< dt.Rows.Count; i++)
                {
                    string MaSP = dt.Rows[i]["MASP"].ToString();
                    //Lấy mã sp của đơn nhập hàng, tìm trong bảng sp, cập nhật lai số lượng sp trong bảng sp
                    SP = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MASP = '" + MaSP + "'");
                    int SoLuong = int.Parse(SP.Rows[0]["SOLUONG"].ToString()) - int.Parse(dt.Rows[i]["SOLUONG"].ToString());
                    DAO.UpDate("UPDATE dbo.SANPHAM SET  SOLUONG = "+SoLuong+" WHERE MASP = '"+MaSP+"'");
                }
                //Xóa tất cả sp có mã = mã đơn hàng trong bảng Chi tiết nhap hang
                DAO.Delete("DELETE FROM dbo.CHITIETNHAPHANG WHERE MANHAPHANG ='" + MaDonHang + "'");
                //Xóa hóa đơn
                DAO.Delete("DELETE FROM dbo.NHAPHANG WHERE MANHAPHANG ='" + MaDonHang + "'");

                //Về trang sp/ Danh sách đơn nhập hàng
                Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachDonNHapHang");
            }
            else { Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DanhSachDonNHapHang"); }
        }
    }
}