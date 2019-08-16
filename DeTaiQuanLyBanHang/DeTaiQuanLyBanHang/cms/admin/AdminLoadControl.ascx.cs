using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.admin
{
    public partial class AdminLoadControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string modul = "";
            if (Request.QueryString["modul"] != null)
            {
                //Response.Write("Day la " + Request.QueryString["modul"]);
                modul = Request.QueryString["modul"];
            }
            switch (modul)
            {
                case "SanPham":
                    PlaceHolderLoadControlAdmin.Controls.Add(LoadControl("SanPham/SanPham.ascx"));
                    break;
                case "KhachHang":
                        PlaceHolderLoadControlAdmin.Controls.Add(LoadControl("KhachHang/KhachHang.ascx"));
                        break;
                    case "TinTuc":
                        PlaceHolderLoadControlAdmin.Controls.Add(LoadControl("TinTuc/TinTucLoadControl.ascx"));
                        break;

                case "NhaCungCap":
                    PlaceHolderLoadControlAdmin.Controls.Add(LoadControl("NhaCungCap/NhaCungCap.ascx"));
                    break;
                case "TaiKhoan":
                    PlaceHolderLoadControlAdmin.Controls.Add(LoadControl("TaoTaiKhoan/TaiKhoan.ascx"));
                    break;
                default:
                    Response.Redirect("Admin.aspx?modul=SanPham&modul1=DanhSachSanPham");
                    break;
            }

        }
    }
}