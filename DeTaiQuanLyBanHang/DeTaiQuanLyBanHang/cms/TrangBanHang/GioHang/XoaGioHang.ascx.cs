using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.GioHang
{
    public partial class XoaGioHang : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["GioHang"] != null)
            {
                Session["GioHang"] = null;
            }
            Response.Redirect("TrangBanHang.aspx?modul=GioHang");
        }
    }
}