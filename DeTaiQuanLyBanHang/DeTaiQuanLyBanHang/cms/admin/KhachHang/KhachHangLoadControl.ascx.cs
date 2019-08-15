using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.admin.KhachHang
{
    public partial class KhachHangLoadControl : System.Web.UI.UserControl
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
                case "DSKH":
                    PlaceHolderKhachHang.Controls.Add(LoadControl("DanhSachKhachHang.ascx"));
                    break;
                case "XemDSDonHang":
                    PlaceHolderKhachHang.Controls.Add(LoadControl("DanhSachDonHang.ascx"));
                    break;
            }
        }
    }
}