using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeTaiQuanLyBanHang.cms.admin.Trangchu
{
    public partial class TrangChu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i=0; i<21; i++)
            {
                ltrLap.Text += @"
                        <div style='width: 250px; height: 250px; border: 1px solid #c66723; margin:5px 0px 5px 10px' class='fl'>
                        <img src= '../../../pic/GachOng.png' style= 'width:80%; height:80%; margin-left:10%; margin-top:10px' />
                        <center  ><a href='#' style='margin-right: 20px;color:red'> Xem chi tiết</a> <a href='#' style='color:red'> Đặt hàng</a></center>
                        </div>
                   ";
            }
        }
    }
}