using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang
{
    public class NHACUNGCAP
    {
        // Field (còn gọi là trường dữ liệu) 
        string MaNhaCungCap;
        string TenNhaCungCap;
        string Email;
        string SDT;


        // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
        public string MANHACUNGCAP
        {
            get { return MaNhaCungCap; }
            set { MaNhaCungCap = value; }
        }

        public string TENNHACUNGCAP
        {
            get { return TenNhaCungCap; }
            set { TenNhaCungCap = value; }
        }

        public string EMAIL
        {
            get { return Email; }
            set { Email = value; }
        }

        public string SODIENTHOAI
        {
            get { return SDT; }
            set { SDT = value; }
        }


    }
}