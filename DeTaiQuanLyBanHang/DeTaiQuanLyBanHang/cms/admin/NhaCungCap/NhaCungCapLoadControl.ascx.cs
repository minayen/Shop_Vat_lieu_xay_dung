using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.admin.NhaCungCap
{
    public partial class NhaCungCapLoadControl1 : System.Web.UI.UserControl
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
                case "DanhSachNCC":
                    PlaceHolderNhaCungCap.Controls.Add(LoadControl("DanhSachNhaCungCap.ascx"));
                    break;
                case "ThemMoi":
                    PlaceHolderNhaCungCap.Controls.Add(LoadControl("ThemMoiNhaCungCap.ascx"));
                    break;
                case "ChinhSua":
                    PlaceHolderNhaCungCap.Controls.Add(LoadControl("ChinhSuaNhaCungCap.ascx"));
                    break;
            }
        }
    }
}