using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang
    {
        public class TAIKHOAN
        {
            // Field (còn gọi là trường dữ liệu) 
            string TenTaiKhoan;
            string MatKhau;
            string Email;
            string DiaChi;
            int Quyen;
            string SDT;
            string HoTen; 


            // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
            public string TENTAIKHOAN
            {
                get { return TenTaiKhoan; }
                set { TenTaiKhoan = value; }
            }
        public string SODIENTHOAI
        {
            get { return SDT; }
            set { SDT = value; }
        }
        public string HOTEN
            {
                get { return HoTen; }
                set { HoTen = value; }
            }
        public string MATKHAU
            {
                get { return MatKhau; }
                set { MatKhau = value; }
            }
            public int QUYEN
            {
                get { return Quyen; }
                set { Quyen = value; }
            }
            public string EMAIL
            {
                get { return Email; }
                set { Email = value; }
            }
            public string DIACHI
            {
                get { return DiaChi; }
                set { DiaChi = value; }
            }
    }
}