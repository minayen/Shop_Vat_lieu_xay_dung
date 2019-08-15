using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.TrangNhanVien
{
    public partial class KhachHangLoadConTrol : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul1"] != null)
            {
                switch (Request.QueryString["modul1"])
                {
                    case "DanhSachKhachHang":
                        PlaceHolderKachHangLoadConTrol.Controls.Add(LoadControl("DanhSachKhachHang.ascx"));
                        break;
                    case "DSDonHang":
                        PlaceHolderKachHangLoadConTrol.Controls.Add(LoadControl("DanhSachDonHang.ascx"));
                        break;
                }
            }
            else
            {
                Response.Redirect("/TrangNhanVien.aspx?modul=KhachHang&modul1=DSDonHang");
            }
        }
    }
}