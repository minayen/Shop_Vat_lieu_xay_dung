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
    public partial class GioHang : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["GioHang"] != null)
            {
                DataTable GioHang = (DataTable)Session["GioHang"];
                if (GioHang.Rows.Count > 0)
                {
                    double TongTien = 0;
                    LtGioHang.Text += @"<div style ='background-color:#ffffff; margin:5px;'>
        <table style ='margin:auto;width:980px; text-align:center;'>
            <tr><th class ='Ma' style='width:10%'>Mã Sản Phẩm</th><th class ='NguoiNhap'>Tên Sản phẩm</th><th class ='NCC' style='width:17%'>Hình ảnh</th><th class ='NgayNhap' style='width:10%'>Số lượng</th><th class ='CongCu' style='width:13%'>Đơn giá</th><th class ='NCC' style='width:13%'>Thành tiền</th><th class ='NCC' style='width:13%'></th></tr>";
                    for (int i = 0; i<GioHang.Rows.Count; i++)
                    {
                        TongTien += (double)GioHang.Rows[i]["ThanhTien"];
                        LtGioHang.Text += @"<tr>
                        <td>" + GioHang.Rows[i]["MaSanPham"] + @"</td>
                        <td>" + GioHang.Rows[i]["TenSanPham"].ToString() + @"</td>
                        <td style = 'background-color:#ffffff; text-align:center;' ><img src= '../../../pic/img/" + GioHang.Rows[i]["HinhAnh"] + @"' style= 'width: 100px; height: auto'/></td>
                        <td><input type='number'  id='SP_"+ GioHang.Rows[i]["MaSanPham"] + @"' onchange=SoLuongSanPham('"+ GioHang.Rows[i]["MaSanPham"] + @"') min='1' value='" + GioHang.Rows[i]["SoLuong"] + @"' style = 'width:50px; padding:5px;'/></td>
                        <td>" + GioHang.Rows[i]["DonGia"].ToString() + @"vnđ</td>
                        <td>" + GioHang.Rows[i]["ThanhTien"].ToString() + @" vnđ</td>
                        <td><a onclick='return Xoa();' href='/TrangBanHang.aspx?modul=XoaSanPhamGioHang&MaSP="+ GioHang.Rows[i]["MaSanPham"] + @"' title='Delete'><img src='../../../../pic/delete.png' style= 'width: 30px; height: auto'/></a></tr>";
                    }
                    
                    LtGioHang.Text += @"</table>
<div style='color:#45aefa;font-weight:bold; float:right;margin-right:20px;margin-top:10px;' >Tổng tiền cần thanh toán: "+TongTien.ToString()+@"vnđ</div>
<center><a style='width:30px;color:#000000; margin:10px;background:#00ff21; border-radius:3px;cursor:pointer;display:inline-block;width:150px; height:40px;line-height:40px' href='TrangBanHang.aspx?modul=SanPham&modul1=DanhSachSanPham'>Tiếp tục mua hàng</a><a style='width:30px;color:#000000; margin:10px;background:#00ff21; border-radius:3px;cursor:pointer;display:inline-block;width:150px; height:40px;line-height:40px' href='TrangBanHang.aspx?modul=XacNhanGioHang'>Xác nhận đơn hàng</a><a style='width:30px;color:#000000; margin:10px;background:#00ff21; border-radius:3px;cursor:pointer;display:inline-block;width:150px; height:40px;line-height:40px' onclick='return XoaDonHang()' href='TrangBanHang.aspx?modul=XoaGioHang'>Xóa giỏ hàng</a></center></div>";
                }
                else
                {
                    LableGioHang.Text = @"Chưa có sản phẩm nào trong giỏ hàng của bạn 
<center style=''><a style='width:30px;color:#000000; margin:10px;background:#00ff21; border-radius:3px;cursor:pointer;display:inline-block;width:150px; height:40px;line-height:40px' href='TrangBanHang.aspx?modul=SanPham&modul1=DanhSachSanPham'>Tiếp tục mua hàng</a></center>\";
                }
            }
            else
            {
                LableGioHang.Text = @"Chưa có sản phẩm nào trong giỏ hàng của bạn 
<center ></><a style='width:30px;color:#000000; margin:10px;background:#00ff21; border-radius:3px;cursor:pointer;display:inline-block;width:150px; height:40px;line-height:40px' href='TrangBanHang.aspx?modul=SanPham&modul1=DanhSachSanPham'>Tiếp tục mua hàng</a></center>";
            }
        }
    }
}



