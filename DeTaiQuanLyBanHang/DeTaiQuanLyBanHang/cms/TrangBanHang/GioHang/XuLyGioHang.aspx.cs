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
    public partial class XuLyGioHang : System.Web.UI.Page
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            string MaSP = "";
            string ThongBao = "";
            int TonTai = 0;
            if(Request.QueryString["MaSP"] != null)
            {
                MaSP = Request.QueryString["MaSP"];
                DataTable dtSanPham = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MASP = '"+MaSP+"'");
                DataTable GioHang = new DataTable();
                GioHang.Columns.Add("MaSanPham", typeof(string));
                GioHang.Columns.Add("TenSanPham", typeof(string));
                GioHang.Columns.Add("HinhAnh", typeof(string));
                GioHang.Columns.Add("SoLuong", typeof(int));
                GioHang.Columns.Add("DonGia", typeof(double));
                GioHang.Columns.Add("ThanhTien", typeof(double));
                if (dtSanPham.Rows.Count > 0)
                {
                    
                    //Kiểm tra sản phẩm có tồn tại trong giỏ hàng chưa
                    if (Session["GioHang"] != null)
                    {
                        GioHang = (DataTable)Session["GioHang"];
                        int j;
                        for (j= 0; j<GioHang.Rows.Count; j++)
                        {
                            
                            if (dtSanPham.Rows[0]["MASP"].ToString() == GioHang.Rows[j]["MaSanPham"].ToString())
                            {
                                ThongBao="Sản phẩm này đã tồn tại trong giỏ hàng!!";
                                TonTai = 1;
                            }
                        }
                        //Thêm sản phẩm vào giỏ hàng
                        if (TonTai==0)
                        {
                            GioHang.Rows.Add(dtSanPham.Rows[0]["MASP"],dtSanPham.Rows[0]["TENSP"], dtSanPham.Rows[0]["HINHANH"], 1, dtSanPham.Rows[0]["DONGIA"], dtSanPham.Rows[0]["DONGIA"]);
                            ThongBao = "Thêm sản phẩm vào giỏ hàng thành công!!!";
                        }
                    }
                    else {
                        GioHang.Rows.Add(dtSanPham.Rows[0]["MASP"],dtSanPham.Rows[0]["TENSP"], dtSanPham.Rows[0]["HINHANH"], 1, dtSanPham.Rows[0]["DONGIA"], dtSanPham.Rows[0]["DONGIA"]);
                        ThongBao = "Thêm sản phẩm vào giỏ hàng thành công!!!";
                    }

                    Session["GioHang"] = GioHang;
                }
                //Thêm sản phẩm vào giỏ hàng
                else
                {
                    ThongBao = "Sản phẩm này không tồn tại!!";
                }
            }

            Response.Write(ThongBao);
        }
    }
}