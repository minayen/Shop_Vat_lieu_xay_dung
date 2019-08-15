using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham
{
    public partial class SanPhamLoadControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string modul1 = "";
            if (Request.QueryString["modul1"] != null)
            {
                //Response.Write("Day la " + Request.QueryString["modul"]);
                modul1 = Request.QueryString["modul1"];
            }
            switch (modul1)
            {
                case "DanhSachSanPham":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("DanhSachSanPham.ascx"));
                    break;
                case "ThemMoiSP":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("ThemMoiSP.ascx"));
                    break;
                case "ChinhSuaSanPham":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("ChinhSuaSanPham.ascx"));
                    break;
                case "DSLoai":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("LoaiSanPham/LoaiSanPham.ascx"));
                    break;
                case "NhapHang":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("NhapHang/NhapHang.ascx"));
                    break;
                //case "DanhSachHoaDon":
                //    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("DanhSachHoaDon/DanhSachHoaDon.ascx"));
                //    break;
                case "ChiTietNhap":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("NhapHang/ChiTietNhapHang.ascx"));
                    break;
                case "DanhSachDonNHapHang":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("NhapHang/DanhSachDonNHapHang.ascx"));
                    break;
                case "ChinhSuaDonNhapHang":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("NhapHang/ChinhSuaDonNhapHang.ascx"));
                    break;
                case "ChiTietDonNhapHang":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("NhapHang/ChiTietDonNhapHang.ascx"));
                    break;
                case "XoaDonNhapHang":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("NhapHang/XoaDonNhapHang.ascx"));
                    break;
                case "XoaLoaiSanPham":
                    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("LoaiSanPham/XoaLoaiSanPham.ascx"));
                    break;
            }
        }
    }
}