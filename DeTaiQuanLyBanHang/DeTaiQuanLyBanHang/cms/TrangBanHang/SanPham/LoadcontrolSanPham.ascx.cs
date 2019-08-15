using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.SanPham
{
    public partial class LoadcontrolSanPham : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string modul1 = "";
            if (Request.QueryString["modul1"] != null)
            {
                //Response.Write("Day la " + Request.QueryString["modul"]);
                modul1 = Request.QueryString["modul1"];
            
                switch (modul1)
                {
                    case "DanhSachSanPham":
                        PlaceHolderLoadcontrolSanPham.Controls.Add(LoadControl("DanhSachSanPham.ascx"));
                        break;
                    case "DanhSachLoaiSanPham":
                        PlaceHolderLoadcontrolSanPham.Controls.Add(LoadControl("DanhSachLoaiSanPham.ascx"));
                        break;
                    case "ChiTietSanPham":
                        PlaceHolderLoadcontrolSanPham.Controls.Add(LoadControl("ChiTietSanPham.ascx"));
                        break;
                }
            }else{
                Response.Redirect("/TrangBanHang.aspx?modul=SanPham&modul1=DanhSachSanPham");
            }
        }
    }
}