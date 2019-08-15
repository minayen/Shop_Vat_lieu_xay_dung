using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang
{
    public partial class TrangBanHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul"] != null)
            {
                //LabelCay.Text = Request.QueryString["modul"];

                switch (Request.QueryString["modul"])
                {
                    case "SanPham":
                        LabelCay.Text = "Sản phẩm";
                        break;
                    case "TrangChu":
                        LabelCay.Text = "Trang chủ";
                        break;
                    case "TinTuc":
                        LabelCay.Text = "Tin tức";
                        break;
                    case "LienHe":
                        LabelCay.Text = "Liên hệ";
                        break;
                    case "GioHang":
                        LabelCay.Text = "Giỏ hàng";
                        break;
                    case "GioiThieu":
                        LabelCay.Text = "Giới thiệu";
                        break;
                    case "XacNhanGioHang":
                        LabelCay.Text = "Xác nhận đơn hàng";
                        break;


                }
            }
            
            if (Request.QueryString["modul1"] != null)
            {
                //LabelCay.Text += ">>" + Request.QueryString["modul1"];
                switch (Request.QueryString["modul1"])
                {
                    case "DanhSachSanPham":
                        LabelCay.Text += " >> Danh sách sản phẩm";
                        break;
                    case "ChiTietSanPham":
                        LabelCay.Text += " >> Chi tiết sản phẩm";
                        break;
                    //case "DanhSachHoaDon":
                    //    PlaceHolderlSanPhamLoadControl.Controls.Add(LoadControl("DanhSachHoaDon/DanhSachHoaDon.ascx"));
                    //    break;
                    case "DanhSachLoaiSanPham":
                        LabelCay.Text += " >> Chi tiết loại sản phẩm";
                        break;
                    
                }
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string NoiDung = txtSearch.Text;
            if (NoiDung == null || NoiDung == "")
            {
                Response.Write("<script>alert('Vui lòng nhập nội dung tìm kiếm!!')</script>");
            }
            else
            {
                Response.Redirect("/TrangBanHang.aspx?modul=TimKiem&NoiDung=" + NoiDung+ "");
            }
        }
    }
}