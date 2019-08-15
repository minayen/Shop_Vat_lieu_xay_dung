using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang
{
    public class NHAPHANG
    {
        // Field (còn gọi là trường dữ liệu) 
        string MaNhapHang;
        string MaNCC;
        DateTime NgayNhap;
        string TaiKhoan;

        // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
        public string MANHAPHANG
        {
            get { return MaNhapHang; }
            set { MaNhapHang = value; }
        }
        public string MANCC
        {
            get { return MaNCC; }
            set { MaNCC = value; }
        }

        public DateTime NGAYNHAP
        {
            get { return NgayNhap; }
            set { NgayNhap = value; }
        }
        public string  TAIKHOAN
        {
            get { return TaiKhoan; }
            set { TaiKhoan = value; }
        }
    }
}