using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.GioHang
{
    public partial class XacNhanGioHang : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDatHang_Click(object sender, EventArgs e)
        {
            if (Session["GioHang"] !=null)
            {
                DataTable dtGioHang = (DataTable)Session["GioHang"];
                if (Page.IsValid)
                {
                    KHACHHANG KHACHHANG = new KHACHHANG
                    {
                        HOTEN = txtHoTen.Text,
                        SDT = txtSDT.Text,
                        EMAIL = txtEmail.Text,
                        DIACHI = txtDiaChi.Text,
                    };
                    DataTable ThongTinKH = DAO.getTable("SELECT * FROM dbo.KHACHHANG WHERE EMAIL='" + txtEmail.Text + "'");
                    if (ThongTinKH.Rows.Count > 0) {
                       

                    }
                    else
                    {
                        bool result = DAO.InsertKHACHHANG(KHACHHANG);
                    }
                    DataTable dtKhacHang = DAO.getTable("SELECT * FROM dbo.KHACHHANG WHERE  EMAIL='" + txtEmail.Text + "'");
                    string MaKH = dtKhacHang.Rows[0]["MAKH"].ToString();
                    DateTime NgayDat = DateTime.Now;
                    int MaDH = RanDom();
                    DONHANG DONHANG = new DONHANG
                    {
                        NGAYDAT = NgayDat,
                        MAKH = MaKH,
                        MADONHANG = MaDH
                    };
                    bool result1 = DAO.InsertDONHANG(DONHANG);
                    //DataTable dtDonHang = DAO.getTable("SELECT * FROM dbo.DONHANG WHERE MAKH='" + MaKH + "' AND  NGAYDATHANG='" + NgayDat + "'");
                    //string MaDonHang = dtDonHang.Rows[0]["MADONHANG"].ToString();
                    if (dtGioHang.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtGioHang.Rows.Count; i++)
                        {
                            DataTable dtSanPham = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MASP='" + dtGioHang.Rows[i]["MaSanPham"].ToString() + "'");

                            int SoLuongSP = (int)dtSanPham.Rows[0]["SOLUONG"] - (int)dtGioHang.Rows[i]["SoLuong"];
                            CHITIETDONHANG CHITIETDONHANG = new CHITIETDONHANG
                            {
                                MADONHANG = MaDH,
                                MASP = dtGioHang.Rows[i]["MaSanPham"].ToString(),
                                SOLUONG = (int)dtGioHang.Rows[i]["SoLuong"]

                            };
                            DAO.InsertCHITIETDONHANG(CHITIETDONHANG);

                            DAO.UpDate("UPDATE dbo.SANPHAM SET  SOLUONG = " + SoLuongSP + "");
                        }
                    }
                    Session["GioHang"] = null;
                    Response.Write("<script>alert('Đặt hàng thành công. Đơn hàng của bạn đã đực giao cho bộ phận kĩ thuật vui lòng chờ cuộc gọi từ chúng tôi. Cảm ơn!!');</script>");
                    //Response.Redirect("TrangBanHang.aspx?modul=SanPham&modul1=DanhSachSanPham");
                }
            }
        }
        private int RanDom()
        {
            Random TenBienRanDom = new Random();
            int MaDH = TenBienRanDom.Next(1, 1000000000);//Trả về giá trị kiểu int;
            return MaDH;
        }
    }
}