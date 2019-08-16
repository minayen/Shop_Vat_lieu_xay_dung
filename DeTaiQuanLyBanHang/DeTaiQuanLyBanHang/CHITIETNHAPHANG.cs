using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang
{
    public class CHITIETNHAPHANG
    {
        // Field (còn gọi là trường dữ liệu) 
        string MaNhapHang;
        string MaSanPham;
        int SoLuong;
        int GiaNhap;
        int GiaBan;

        // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
        public string MANHAPHANG
        {
            get { return MaNhapHang; }
            set { MaNhapHang = value; }
        }
        public string MASANPHAM
        {
            get { return MaSanPham; }
            set { MaSanPham = value; }
        }
        public int SOLUONG
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
        public int GIANHAP
        {
            get { return GiaNhap; }
            set { GiaNhap = value; }
        }

        public int GIABAN
        {
            get { return GiaBan; }
            set { GiaBan = value; }
        }
    }
}