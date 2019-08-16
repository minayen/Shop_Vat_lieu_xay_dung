using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang
{
    public class CHITIETDATHANG
    {
        // Field (còn gọi là trường dữ liệu) 
        string MaLoai;
        string TenLoai;


        // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
        public string MALOAI
        {
            get { return MaLoai; }
            set { MaLoai = value; }
        }
        public string TENLOAI
        {
            get { return TenLoai; }
            set { TenLoai = value; }
        }
    }
}