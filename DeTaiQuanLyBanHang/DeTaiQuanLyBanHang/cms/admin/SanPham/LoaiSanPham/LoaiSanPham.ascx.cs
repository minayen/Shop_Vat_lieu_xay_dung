using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DeTaiQuanLyBanHang.cms.admin.SanPham.LoaiSanPham
{
    public partial class LoaiSanPham : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["MaLoai"] != null)
            {
                DataTable dtLoai = DAO.getTable("SELECT * FROM dbo.LOAISANPHAM WHERE MALOAI ='"+ Request.QueryString["MaLoai"] + "'");
                if (dtLoai.Rows.Count>0)
                {
                    txtMaLoai.Text = dtLoai.Rows[0]["MALOAI"].ToString();
                    txtMaLoai.ReadOnly = true;
                    txtTenLoai.Text = dtLoai.Rows[0]["TENLOAI"].ToString(); 
                }
            }
            LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Loại sản phẩm</p>
                      ";
            if (!IsPostBack)
            {
                DataTable dtLOAISP = DAO.getTable("SELECT * FROM dbo.LOAISANPHAM");
                if (dtLOAISP.Rows.Count > 0)
                {
                    for (int i = 0; i < dtLOAISP.Rows.Count; i++)
                    {
                        LiteralLOAISP.Text += @"
                    <tr>
                        <td>" + dtLOAISP.Rows[i]["MALOAI"].ToString() + @"</td>
                        <td>" + dtLOAISP.Rows[i]["TENLOAI"] + @"</td>
                        <td class='img' style='background-color:#ffffff; text-align:center;'>
                            <a href = '/Admin.aspx?modul=SanPham&modul1=DSLoai&MaLoai=" + dtLOAISP.Rows[i]["MALOAI"].ToString() + @"' title='Edit'><img src='../../../../pic/edit.png'/></a>
                            <a onclick= 'return Xoa();' href = '/Admin.aspx?modul=SanPham&modul1=XoaLoaiSanPham&MaLoai=" + dtLOAISP.Rows[i]["MALOAI"].ToString() + @"' title='Delete'><img src='../../../../pic/delete.png'/></a>
                        </td>
                    </tr>";
                    }
                }
            }
        }




        //Thêm mới loại sản phẩm
        protected void btnThem_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                string query = "Select * from dbo.LOAISANPHAM where MALOAI = '" + txtMaLoai.Text + "'";
                int KiemTra = CheckMaLoai(query);
                if (KiemTra == 0)
                {
                    LOAISANPHAM LOAISP = new LOAISANPHAM();
                    LOAISP = GETLOAISP(txtMaLoai.Text, txtTenLoai.Text);
                    bool Result = DAO.InsertLOAISP(LOAISP);
                    if (Result == true)
                    {
                        lbThongBao.Text = "Thêm thành công";
                        //Response.Write("<script>alert('Thêm loại sản phẩm thành công');</script>");
                        Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DSLoai");
                    }
                    else
                    {
                        lbThongBao.Text = "Thêm thất bại";
                    }
                }
                else
                {
                    lbThongBao.Text = "Đã tồn tại loại sản phẩm này!";
                }
            }
            else
            {
                lbThongBao.Text = "Vui lòng nhập đầy đủ thông tin!";
            }
        }

        //cHECK CÓ TỒN TẠI MÃ LOẠI NÀY KHÔNG
        private int CheckMaLoai(string Query)
        {
            DataTable tb = new DataTable();
            tb = DAO.getTable(Query);
            int KiemTra = tb.Rows.Count;
            return KiemTra;
        }

        //Truyền dữ liệu vào Class LOAISANPHAM
        private LOAISANPHAM GETLOAISP(string maloai, string tenloai)
        {
            LOAISANPHAM LOAISP = new LOAISANPHAM();
            LOAISP.MALOAI = maloai;
            LOAISP.TENLOAI = tenloai;
            return LOAISP;
        }

        //Xóa trống form
        protected void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtMaLoai.Enabled = true;
            txtTenLoai.Enabled = true;
            lbThongBao.Text = "";
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            LOAISANPHAM LoaiSP = new LOAISANPHAM
            {
                // Lấy giá trị theo tên cột trong CSDL
                MALOAI = txtMaLoai.Text,
                TENLOAI = txtTenLoai.Text,
            };
            bool result = DAO.UpDateLoaiSP(LoaiSP);
            if (result == true)
            {
                Response.Redirect("/Admin.aspx?modul=SanPham&modul1=DSLoai");
            }
            else lbThongBao.Text = "Cập nhật thông tin thất bai";
        }

    }
}