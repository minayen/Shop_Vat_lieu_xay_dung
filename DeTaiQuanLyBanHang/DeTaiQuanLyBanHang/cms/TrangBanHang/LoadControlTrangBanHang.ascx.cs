using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang
{
    public partial class LoadControlTrangBanHang : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string modul = "";
            if (Request.QueryString["modul"] != null)
            {
                //Response.Write("Day la " + Request.QueryString["modul"]);
                modul = Request.QueryString["modul"];
                switch (modul)
                {
                    case "TrangChu":
                        PlaceHolderLoadcontrolTrangBanHang.Controls.Add(LoadControl("Trangchu/TrangChu.ascx"));
                        break;
                    case "SanPham":
                        PlaceHolderLoadcontrolTrangBanHang.Controls.Add(LoadControl("SanPham/SanPham.ascx"));
                        break;
                    case "GioiThieu":
                        PlaceHolderLoadcontrolTrangBanHang.Controls.Add(LoadControl("GioiThieu/GioiThieu.ascx"));
                        break;
                    case "LienHe":
                        PlaceHolderLoadcontrolTrangBanHang.Controls.Add(LoadControl("LienHe/LienHe.ascx"));
                        break;
                    case "GioHang":
                        PlaceHolderLoadcontrolTrangBanHang.Controls.Add(LoadControl("GioHang/GioHang.ascx"));
                        break;
                    case "XoaSanPhamGioHang":
                        PlaceHolderLoadcontrolTrangBanHang.Controls.Add(LoadControl("GioHang/XoaSanPhamGioHang.ascx"));
                        break;
                    case "XoaGioHang":
                        PlaceHolderLoadcontrolTrangBanHang.Controls.Add(LoadControl("GioHang/XoaGioHang.ascx"));
                        break;
                    case "XacNhanGioHang":
                        PlaceHolderLoadcontrolTrangBanHang.Controls.Add(LoadControl("GioHang/XacNhanGioHang.ascx"));
                        break;
                    case "TimKiem":
                        PlaceHolderLoadcontrolTrangBanHang.Controls.Add(LoadControl("TimKiem/TimKiem.ascx"));
                        break;
                }
            }
            else
            {
                Response.Redirect("/TrangBanHang.aspx?modul=GioiThieu");
            }
        }
    }
}