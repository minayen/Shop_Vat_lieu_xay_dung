using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DeTaiQuanLyBanHang.cms.TrangBanHang.TrangChu
{
    public partial class TrangChu : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThiSanPhamBanChay();
            HienThiSanPhamMoiVe();

        }

        private DataTable LaySanPhamBanChay()
        {
            DataTable SanPhamBanChay = new DataTable();
            DataTable SanPhamBanChaySort = new DataTable();
            SanPhamBanChay.Columns.Add("MaSanPham", typeof(string));
            SanPhamBanChay.Columns.Add("SoLuotMua", typeof(int));
            DataTable dtDSSP= DAO.getTable("SELECT MASP FROM dbo.SANPHAM");
            if (dtDSSP.Rows.Count > 0)
            {
                for (int i = 0; i < dtDSSP.Rows.Count; i++)
                {
                    DataTable DemSoLuotMua = DAO.getTable("SELECT COUNT(MASP) AS SOLUONG FROM dbo.CHITIETDONHANG WHERE MASP='" + dtDSSP.Rows[i]["MASP"] + "'");
                    if (DemSoLuotMua.Rows.Count > 0 && (int)DemSoLuotMua.Rows[0]["SOLUONG"]>0)
                    {
                        SanPhamBanChay.Rows.Add(dtDSSP.Rows[i]["MASP"], DemSoLuotMua.Rows[0]["SOLUONG"]);
                    }
                }
                DataView dv = SanPhamBanChay.DefaultView;

                dv.Sort = "SoLuotMua DESC";
 
                SanPhamBanChaySort = dv.ToTable();
            }
            return SanPhamBanChaySort;
        }
        private void HienThiSanPhamBanChay()
        {
            DataTable getSanPhamBanChay = LaySanPhamBanChay();
            if (getSanPhamBanChay.Rows.Count > 0)
            {
                ltTrangChu.Text += @"<div class='SanPham'>
    <div class ='LoaiSanPham'>
        <div style = 'text-transform:uppercase; float:left; background:#ff0000; padding:5px;color:#FFF; border-radius:3px;' >Sản phẩm bán chạy nhất</div>
       <div class='clear'></div>
    </div>
        <div>
";
                if (getSanPhamBanChay.Rows.Count > 15)
                {
                    for (int i = 0; i < 15; i++)
                    {
                        DataTable getThongTinSanPham = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MASP='" + getSanPhamBanChay.Rows[i]["MaSanPham"] + "'");
                        ltTrangChu.Text += @"<div class='HinhAnh'><a href = '/TrangBanHang.aspx?modul=SanPham&modul1=ChiTietSanPham&idSP=" + getThongTinSanPham.Rows[0]["MASP"] + @"' ><img src='pic/img/" + getThongTinSanPham.Rows[0]["HINHANH"] + @"' />
                <center>Tên Sản Phẩm: " + getThongTinSanPham.Rows[0]["TENSP"] + @"
                <br/>
                Giá: " + getThongTinSanPham.Rows[0]["DONGIA"] + @"VNĐ/" + getThongTinSanPham.Rows[0]["DONVITINH"] + @"</a>
                <br />
</center>
        </div>";
                    }
                }
                else
                {
                    for (int i = 0; i < getSanPhamBanChay.Rows.Count; i++)
                    {
                        DataTable getThongTinSanPham = DAO.getTable("SELECT * FROM dbo.SANPHAM WHERE MASP='" + getSanPhamBanChay.Rows[i]["MaSanPham"] + "'");
                        ltTrangChu.Text += @"<div class='HinhAnh'><a href = '/TrangBanHang.aspx?modul=SanPham&modul1=ChiTietSanPham&idSP=" + getThongTinSanPham.Rows[0]["MASP"] + @"' ><img src='pic/img/" + getThongTinSanPham.Rows[0]["HINHANH"] + @"' />
                <center>Tên Sản Phẩm: " + getThongTinSanPham.Rows[0]["TENSP"] + @"
                <br/>
                Giá: " + getThongTinSanPham.Rows[0]["DONGIA"] + @"VNĐ/" + getThongTinSanPham.Rows[0]["DONVITINH"] + @"</a>
                <br />
</center>
        </div>";
                    }
                }
                ltTrangChu.Text += @"    </div>
    </div>
<div class='clear'></div>";
            }
        }

        //Lấy sản phẩm mới nhập  vào kho
        private DataTable LaySanPhamMoiVe()
        {
            DateTime GetDaTe = DateTime.Now;

            string NgayHienTai = ""+GetDaTe.Month+"/"+GetDaTe.Day+"/"+GetDaTe.Year+"";
            int Thang =0;
            int Nam =0;
            if(GetDaTe.Month == 1)
            {
                Thang = 12;
                Nam = GetDaTe.Year - 1;
            }
            else { Thang = GetDaTe.Month - 1;
                    Nam = GetDaTe.Year;
                }
            string NgayBatDau= ""+Thang+"/01/"+Nam+"";
            DataTable getSanPhamMoiVe = DAO.getTable(@"SELECT DISTINCT CHITIETNHAPHANG.MASP, DONGIA, TENSP, DONVITINH, HINHANH
                      FROM[dbo].[NHAPHANG], CHITIETNHAPHANG, SANPHAM
                      WHERE NHAPHANG.MANHAPHANG = CHITIETNHAPHANG.MANHAPHANG
                      AND NGAYNHAP BETWEEN '" + NgayBatDau.ToString() + @"' AND '"+NgayHienTai.ToString()+@"'
                      AND SANPHAM.MASP = CHITIETNHAPHANG.MASP");
            
            return getSanPhamMoiVe;
        }

        //Hiển thị sản phẩm mói nhập vào kho
        private void HienThiSanPhamMoiVe()
        {
            DataTable getSPMoiVe = LaySanPhamMoiVe();
            if (getSPMoiVe.Rows.Count > 0)
            {
                ltTrangChu.Text += @"<div class='SanPham'>
    <div class ='LoaiSanPham'>
        <div style = 'text-transform:uppercase; float:left; background:#ff0000; padding:5px;color:#FFF; border-radius:3px;' >Sản phẩm mới nhập về</div>
       <div class='clear'></div>
    </div>
        <div>
";

                
                    for (int i = 0; i < getSPMoiVe.Rows.Count; i++)
                    {
                       
                        ltTrangChu.Text += @"<div class='HinhAnh'><a href = '/TrangBanHang.aspx?modul=SanPham&modul1=ChiTietSanPham&idSP=" + getSPMoiVe.Rows[i]["MASP"] + @"' ><img src='pic/img/" + getSPMoiVe.Rows[i]["HINHANH"] + @"' />
                <center>Tên Sản Phẩm: " + getSPMoiVe.Rows[i]["TENSP"] + @"
                <br/>
                Giá: " + getSPMoiVe.Rows[i]["DONGIA"] + @"VNĐ/" + getSPMoiVe.Rows[i]["DONVITINH"] + @"</a>
                <br />
</center>
        </div>";
                    }
                
                ltTrangChu.Text += @"    </div>
    </div>
<div class='clear'></div>";
            }
        }
    }
}