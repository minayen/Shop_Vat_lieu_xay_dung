using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.admin.TaoTaiKhoan
{
    public partial class TaoTaiKhoanLoadControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul1"] != null)
            {

                switch (Request.QueryString["modul1"])
                {
                    case "DSTaiKhoan":
                        PlaceHolderLoadTaiKhoan.Controls.Add(LoadControl("DanhSachTaiKhoan.ascx"));
                        break;
                    case "TaoTaiKhoan":
                        PlaceHolderLoadTaiKhoan.Controls.Add(LoadControl("TaoMoiTaiKhoan.ascx"));
                        break;
                }
            }
        }
    }
}