using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang
{
    public class CHITIETDONHANG
    {
        // Field (còn gọi là trường dữ liệu) 
        int MaDonHang;
        string MaSP;
        int SoLuong;

        // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
        public int MADONHANG
        {
            get { return MaDonHang; }
            set { MaDonHang = value; }
        }
        public string MASP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }
        public int SOLUONG
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
    }
}