using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang
{
    public class SANPHAM
    {
        // Field (còn gọi là trường dữ liệu) 
        string MaSP;
        string TenSP;
        string HinhAnh;
        string DonViTinh;
        int SoLuong;
        float DonGia;
        string MaLoai;


        // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
        public string MALOAI
        {
            get { return MaLoai; }
            set { MaLoai = value; }
        }
        public string TENSP
        {
            get { return TenSP; }
            set { TenSP = value; }
        }
        public float DONGIA
        {
            get { return DonGia; }
            set { DonGia = value; }
        }
        public int SOLUONG
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
        public string MASP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }
        public string HINHANH
        {
            get { return HinhAnh; }
            set { HinhAnh = value; }
        }
        public string DONVITINH
        {
            get { return DonViTinh; }
            set { DonViTinh = value; }
        }
    }
}