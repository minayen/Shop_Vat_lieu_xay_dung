using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.GioHang
{
    public partial class XoaSanPhamGioHang1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              if (Request.QueryString["MaSP"] != null && Session["GioHang"] != null)
                {
                    string MaSP = Request.QueryString["MaSP"];
                    DataTable dtGioHang = (DataTable)Session["GioHang"];
                    if (dtGioHang.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtGioHang.Rows.Count; i++)
                        {
                            if (dtGioHang.Rows[i]["MaSanPham"].ToString() == MaSP)
                            {
                                dtGioHang.Rows[i].Delete();
                            }
                        }
                    }
                    Session["GioHang"] = dtGioHang;
                }
                Response.Redirect("TrangBanHang.aspx?modul=GioHang");
        }
    }
}
