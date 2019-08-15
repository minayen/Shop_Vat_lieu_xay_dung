using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang
{
    public class KHACHHANG
    {
        // Field (còn gọi là trường dữ liệu) 
        string HoTen;
        string DiaChi;
        string SoDienThoai;
        string Email;


        // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
        public string HOTEN
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        public string DIACHI
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        public string SDT
        {
            get { return SoDienThoai; }
            set { SoDienThoai = value; }
        }
        public string EMAIL
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}