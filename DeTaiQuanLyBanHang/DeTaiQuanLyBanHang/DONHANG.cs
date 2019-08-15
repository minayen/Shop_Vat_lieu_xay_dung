using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang
{
    public class DONHANG
    {
        // Field (còn gọi là trường dữ liệu) 
        string MaKH;
        DateTime NgayDat;
        int MaDonHang;

        // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
        public string MAKH
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public DateTime NGAYDAT
        {
            get { return NgayDat; }
            set { NgayDat = value; }
        }
        public int MADONHANG
        {
            get { return MaDonHang; }
            set { MaDonHang = value; }
        }
    }
}