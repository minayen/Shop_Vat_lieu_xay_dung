using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.SanPham
{
    public partial class ChiTietSanPham : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            string idSanPham = "";
            if (Request.QueryString["idSP"] != null) {
                idSanPham = Request.QueryString["idSP"];
                DataTable dt = DAO.getTable("SELECT * FROM SANPHAM WHERE MASP= '"+idSanPham+"'");
                if (dt.Rows.Count > 0)
                {
                    string TinhTrang = "Còn hàng";
                    if (int.Parse(dt.Rows[0]["SOLUONG"].ToString()) <= 0)
                    {
                        TinhTrang = "Hết Hàng";
                    
                    }
                    ltdetailpr.Text +=
                        @"<div class='chitietsp'>
                        <div class='HinhAnhSP'><img src = 'pic/img/"+dt.Rows[0]["HINHANH"]+ @"' /></div>
 
                         <div class='phancach'>
                            <div class='namepr'>" + dt.Rows[0]["TENSP"] + @"</div> <hr />
                            Mã sản phẩm " + dt.Rows[0]["MASP"] + @"
                            <br /> 
                            <hr />
                            Tình trạng  " +TinhTrang + @" 
                            <br />
                            <hr />
                            Khuyến mãi  Không
                            <br />
                            <hr />
                            Giá " + dt.Rows[0]["DONGIA"] + @" vnđ/ " + dt.Rows[0]["DONVITINH"] + @"
                            <br />
                            <hr />   
                            Phí vận chuyển Tính phí khi thanh toán
                            <br />
                            <hr />
                            <div style = 'margin-top:15px' ><a onclick=ThemVaoGioHang('"+ dt.Rows[0]["MASP"] + @"') href='#'> Thêm vào giỏ hàng</a></div>
                        </div>
                        <div class='clear'>
        
                        </div>
                    </div>";
                }
            }
        }
    }
    //cms/TrangBanHang/GioHang/XuLyGioHang.aspx? idSP = " + dt.Rows[0]["MASP"] + @"
}