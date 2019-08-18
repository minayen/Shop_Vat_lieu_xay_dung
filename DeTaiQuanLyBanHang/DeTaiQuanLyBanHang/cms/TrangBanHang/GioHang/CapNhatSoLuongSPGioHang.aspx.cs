using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.GioHang
{
    public partial class CapNhatSoLuongSPGioHang : System.Web.UI.Page
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            string ThongBao = "";
            if (Request.Params["MaSP"] != null && Request.Params["SoLuong"] != null && Session["GioHang"]!= null)
            {
                
                DataTable tbGioHang = (DataTable)Session["GioHang"]; 
                string MaSP = Request.Params["MaSP"];
                int SoLuong = int.Parse(Request.Params["SoLuong"]);
                DataTable dtSLuong = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MASP='"+MaSP+"'");
                if (dtSLuong.Rows.Count>0)
                {
                    if((int)dtSLuong.Rows[0]["SOLUONG"] >= SoLuong) {
                        //Cập nhật số lượng cho giỏ hàng
                        if (tbGioHang.Rows.Count > 0)
                        {
                            for(int i=0; i<tbGioHang.Rows.Count; i++)
                            {
                                if (tbGioHang.Rows[i]["MaSanPham"].ToString() == MaSP)
                                {
                                    tbGioHang.Rows[i]["SoLuong"] = SoLuong;
                                    tbGioHang.Rows[i]["ThanhTien"] = (double)(SoLuong * (double)tbGioHang.Rows[i]["DonGia"]);
                                }
                            }
                            Session["GioHang"] = tbGioHang;
                        }
                    }
                    else
                    {
                        //Không cập nhật
                        ThongBao = "Số lượng không đủ đáp ứng";
                    }
                }
            }
            Response.Write(ThongBao);
        }
    }
}