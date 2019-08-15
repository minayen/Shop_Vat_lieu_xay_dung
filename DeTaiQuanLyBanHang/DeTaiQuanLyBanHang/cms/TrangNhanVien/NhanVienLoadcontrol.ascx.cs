using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.TrangNhanVien
{
    public partial class NhanVienLoadcontrol : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["modul"] != null)
            {
                switch (Request.QueryString["modul"])
                {
                    case "SanPham":
                        PlaceHolderNhanVienLoadcontrol.Controls.Add(LoadControl("SanPham.ascx"));
                        break;
                    case "KhachHang":
                        PlaceHolderNhanVienLoadcontrol.Controls.Add(LoadControl("KhachHang.ascx"));
                        break;
                    case "XemTT":
                        PlaceHolderNhanVienLoadcontrol.Controls.Add(LoadControl("XemTTTaiKhoan.ascx"));
                        break;
                    case "DoiMKTK":
                        PlaceHolderNhanVienLoadcontrol.Controls.Add(LoadControl("DoiMatKhauTK.ascx"));
                        break;
                    case "CapNhatTT":
                        PlaceHolderNhanVienLoadcontrol.Controls.Add(LoadControl("CapNhatTTTaiKhoan.ascx"));
                        break;


                }
                
            }
            else { Response.Redirect("TrangNhanVien.aspx?modul=SanPham"); }
        }
    }
}