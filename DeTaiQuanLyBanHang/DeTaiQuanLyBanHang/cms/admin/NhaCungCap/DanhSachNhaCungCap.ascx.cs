using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DeTaiQuanLyBanHang.cms.admin.NhaCungCap
{
    public partial class DanhSachNhaCungCap : System.Web.UI.UserControl
    {
        ConnectDatabase DAO = new ConnectDatabase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LableTieuDe.Text = @"
                        <p style='text-align:center; text-transform:uppercase;'>Tất cả nhà cung cấp</p>
                      ";
                DataTable tbDSNCC = DAO.getTable("SELECT * FROM dbo.NHACUNGCAP");
                if (tbDSNCC.Rows.Count > 0)
                {
                    LiteralDSNCC.Text += @"<tr>
        <th class ='Ma'>Mã nhà cung cấp</th><th class ='NguoiNhap' style='width:30%'>Tên nhà cung cấp</th><th class ='NCC'>Email</th><th class ='NgayNhap'>Số liên lạc</th><th class ='CongCu'>Công cụ</th>
    </tr>";
                    for (int i = 0; i < tbDSNCC.Rows.Count; i++)
                    {

                        LiteralDSNCC.Text += @"
                    <tr>
                        <td>" + tbDSNCC.Rows[i]["MANCC"] + @"</td>
                        <td>" + tbDSNCC.Rows[i]["TENNCC"].ToString() + @"</td>
                        <td>" + tbDSNCC.Rows[i]["EMAIL"].ToString() + @"</td>
                        <td>" + tbDSNCC.Rows[i]["SDT"] + @"</td>
                        <td class='img' style='background-color:#ffffff; text-align:center;'>
                            <a href = '/Admin.aspx?modul=NhaCungCap&modul1=ChinhSua&MaNCC=" + tbDSNCC.Rows[i]["MANCC"].ToString() + @"' title='Edit'><img src='../../../../pic/edit.png'/></a>
                            <a onclick='return Xoa();' href = '/Admin.aspx?modul=NhaCungCap&modul1=DanhSachNCC&MaNCC=" + tbDSNCC.Rows[i]["MANCC"].ToString() + @"' title='Delete'><img src='../../../../pic/delete.png'/></a>
                         </td>
                    </tr>";
                    }
                }
            }


            if (Request.QueryString["MaNCC"] != null)
            {

                    DAO.Delete("DELETE FROM dbo.NHACUNGCAP WHERE MANCC = '" + Request.QueryString["MaNCC"] + "'");
                    Response.Redirect("/Admin.aspx?modul=NhaCungCap&modul1=DanhSachNCC");
            }
        }



        ////Chỉnh sửa nhà cung cấp
        //protected void GridViewDanhSachNCC_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string MaNCC = GridViewDanhSachNCC.SelectedRow.Cells[0].Text;
        //    Response.Redirect("/Admin.aspx?modul=NhaCungCap&modul1=ChinhSua&MaNCC="+ MaNCC);
        //}


        ////Xóa nhà cung cấp
        //protected void GridViewDanhSachNCC_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    string MaNhaCungCap = GridViewDanhSachNCC.Rows[e.RowIndex].Cells[0].Text;
        //    string TenNCC = GridViewDanhSachNCC.Rows[e.RowIndex].Cells[1].Text;
        //    string sql = @"DELETE FROM dbo.NHACUNGCAP WHERE MANCC ='" + MaNhaCungCap + "'";
        //    bool result = DAO.Delete(sql);
        //    if (result == true)
        //    {
        //        LoadDanhSachNCC();
        //        lbThongBao.Text = "Đã xóa thành công nhà cung cấp " + TenNCC + " !";
        //    }
        //    else
        //    {
        //        lbThongBao.Text = "Xóa nhà cung cấp thất bại";
        //    }
        //}
    }
}