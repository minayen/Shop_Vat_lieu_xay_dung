using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang
{
    public partial class Admin : System.Web.UI.Page
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            KiemTraSession();
            if(Request.QueryString["modul"] != null)
            {
                //LabelCay.Text = Request.QueryString["modul"];

                switch (Request.QueryString["modul"])
                {
                    case "SanPham":
                        LabelCay.Text = "Sản phẩm";
                        break;
                    case "KhachHang":
                        LabelCay.Text = "Khách hàng";
                        break;
                    case "TinTuc":
                        LabelCay.Text = "Tin tức";
                        break;
                    case "LienHe":
                        LabelCay.Text = "Liên hệ";
                        break;
                    case "NhaCungCap":
                        LabelCay.Text = "Nhà cung cấp";
                        break;
                    case "GioiThieu":
                        LabelCay.Text = "Giới thiệu";
                        break;
                    case "TaiKhoan":
                        LabelCay.Text = "Tài khoản";
                        break;
                }
            }
            else
            {
                Response.Redirect("/Admin.aspx?modul=GioiThieu");
            }
            if (Request.QueryString["modul1"] != null)
            {
                //LabelCay.Text += ">>" + Request.QueryString["modul1"];
                switch (Request.QueryString["modul1"])
                {
                    case "DanhSachSanPham":
                        LabelCay.Text += " >> Danh sách sản phẩm";
                        break;
                    case "ThemMoiSP":
                        LabelCay.Text += " >> Thêm mới sản phẩm";
                        break;
                    case "ChinhSuaSanPham":
                        LabelCay.Text += " >> Chỉnh sửa sản phẩm";
                        break;
                    case "DSLoai":
                        LabelCay.Text += " >> Danh sách loại sản phẩm";
                        break;
                    case "NhapHang":
                        LabelCay.Text += " >> Nhập hàng";
                        break;
                    //case "DanhSachHoaDon":
                    //    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("DanhSachHoaDon/DanhSachHoaDon.ascx"));
                    //    break;
                    case "ChiTietNhap":
                        LabelCay.Text += " >> Chi tiết đơn nhập";
                        break;
                    case "DanhSachDonNHapHang":
                        LabelCay.Text += " >> Danh sách đơn nhập hàng";
                        break;
                    case "ChinhSuaDonNhapHang":
                        LabelCay.Text += " >> Chỉnh sửa đơn nhập hàng";
                        break;
                    case "ChiTietDonNhapHang":
                        LabelCay.Text += " >> Chi tiết đơn nhập hàng";
                        break;
                    case "XoaDonNhapHang":
                        LabelCay.Text += " >> Xóa đơn nhập hàng";
                        break;
                    case "DanhSachNCC":
                        LabelCay.Text += " >> Danh sách nhà cung cấp";
                        break;
                    case "ThemMoi":
                        LabelCay.Text += " >> Thêm mới nhà cung cấp";
                        break;
                    case "ChinhSua":
                        LabelCay.Text += " >> Chỉnh sửa nhà cung cấp";
                        break;
                    case "DSKH":
                        LabelCay.Text += " >> Danh sách khách hàng";
                        break;
                    case "XemDSDonHang":
                        LabelCay.Text += " >> Danh sách đơn hàng";
                        break;
                    case "DSTaiKhoan":
                        LabelCay.Text += " >> Danh sách tài khoản";
                        break;
                    case "TaoTaiKhoan":
                        LabelCay.Text += " >> Thêm mới tài khoản";
                        break;
                }
            }
        }

        //Kiểm tra session
        private void KiemTraSession()
        {
            if (Session["TAIKHOAN"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {

                    DataTable dtQuanLy = DAO.getTable("SELECT * FROM dbo.QUANLY WHERE TAIKHOAN = '" + Session["TAIKHOAN"]+"'");
                    if (dtQuanLy.Rows.Count > 0)
                    {
                        if (dtQuanLy.Rows[0]["PHANQUYEN"].ToString() != "1")
                        {
                            Response.Redirect("TrangNhanVien.aspx");
                        }
                    }
                    lbXinChao.Text = "Xin chào: " + Session["TAIKHOAN"];
                }
        }

        //Xự kiện khi nhấn nút đăng xuất
        protected void btnDangXuat_Click(object sender, EventArgs e)
                {
            //Huỷ session
            Session["TAIKHOAN"] = null;
            Response.Redirect("Login.aspx");
        }
            }
}