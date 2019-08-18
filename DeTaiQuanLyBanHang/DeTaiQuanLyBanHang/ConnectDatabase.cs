using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DeTaiQuanLyBanHang
{
    public class ConnectDatabase
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLBanHang"].ConnectionString;

        //Check user có tồn tai hay không
        public bool CheckUser(string userName, string Pass)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string sql = @"SELECT * FROM dbo.QUANLY WHERE TAIKHOAN = '" + userName + "' and MATKHAU = '"+Pass+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        //Lấy dữ liệu từ một table bất kỳ
        public DataTable getTable(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }



        /* Loại sản phẩm*/

        //Thêm một loại san phâm trong bang Loai San Pham
        public bool InsertLOAISP( LOAISANPHAM LOAISP)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"INSERT INTO dbo.LOAISANPHAM(MALOAI,TENLOAI)
                VALUES('" + LOAISP.MALOAI + "',N'" + LOAISP.TENLOAI + "')";
            SqlCommand cmd = new SqlCommand(sql, connection);

            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0) { return true; }
            return false;
        }

        //Xóa một loại sản phẩm trong bảng Loai San Pham
        public bool DeleteLoaiSP(string MaLoaiSP)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"DELETE FROM dbo.LOAISANPHAM WHERE MALOAI ='" + MaLoaiSP + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open(); int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0)
            {
                return true;
            }
            return false;
        }

        //Xóa một bảng ghi bất kì
        public bool Delete(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open(); int result = cmd.ExecuteNonQuery(); connection.Close();
            connection.Close();
            if (result != 0)
            {
                return true;
            }
            return false;
        }

        //Lấy loại sản phẩm thông qua mã loại
        public LOAISANPHAM LayLoaiSP(string MaLoai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT * FROM dbo.LOAISANPHAM WHERE MALOAI = @MaLoai";
                SqlCommand cmd = new SqlCommand(sql, connection); cmd.Parameters.AddWithValue("@MaLoai", MaLoai);
                connection.Open(); SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LOAISANPHAM LoaiSP = new LOAISANPHAM
                    {
                        // Lấy giá trị theo tên cột trong CSDL
                        MALOAI = (string)reader["MALOAI"],
                        TENLOAI = (string)reader["TENLOAI"],
                    };
                    return LoaiSP;
                }
            }
            return null;
        }


        //Lấy nhà cung cấp thông qua mã nhà cung cấp
        public NHACUNGCAP LayNCC(string MaNCC)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT * FROM dbo.NHACUNGCAP WHERE MANCC = @MaLoai";
                SqlCommand cmd = new SqlCommand(sql, connection); cmd.Parameters.AddWithValue("@MaLoai", MaNCC);
                connection.Open(); SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    NHACUNGCAP NCC = new NHACUNGCAP
                    {
                        // Lấy giá trị theo tên cột trong CSDL
                        MANHACUNGCAP = (string)reader["MANCC"],
                        TENNHACUNGCAP = (string)reader["TENNCC"],
                        SODIENTHOAI = (string)reader["SDT"],
                        EMAIL = (string)reader["EMAIL"],

                    };
                    return NCC;
                }
            }
            return null;
        }

        //Cập nhật một Loại sản phẩm
        public bool UpDateLoaiSP(LOAISANPHAM LoaiSP)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"UPDATE dbo.LOAISANPHAM SET  TENLOAI = @TenLoai WHERE MALOAI = @MaLoai";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@MaLoai", LoaiSP.MALOAI);
            cmd.Parameters.AddWithValue("@TenLoai", LoaiSP.TENLOAI);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0)
            {
                return true;
            }
            return false;
        }

        //Cập nhật NCC
        public bool UpDateNCC(NHACUNGCAP NCC)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"UPDATE dbo.NHACUNGCAP SET  TENNCC = @TenNCC, EMAIL = @Email, SDT = @SoDienThoai WHERE MANCC = @MaNCC";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@TenNCC", NCC.TENNHACUNGCAP);
            cmd.Parameters.AddWithValue("@Email", NCC.EMAIL);
            cmd.Parameters.AddWithValue("@SoDienThoai", NCC.SODIENTHOAI);
            cmd.Parameters.AddWithValue("@MaNCC", NCC.MANHACUNGCAP);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0)
            {
                return true;
            }
            return false;
        }


        //Thêm một nhà cung cấp mới
        public bool InsertNCC(NHACUNGCAP NCC)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"INSERT INTO dbo.NHACUNGCAP(MANCC,TENNCC,EMAIL, SDT)
                           VALUES('" + NCC.MANHACUNGCAP + "',N'" + NCC.TENNHACUNGCAP + "', '" + NCC.EMAIL + "','" + NCC.SODIENTHOAI + "')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0) { return true; }
            return false;
        }

        //Thêm một nhà cung cấp mới
        public bool InsertNHAPHANG(NHAPHANG NHAPHANG)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"INSERT INTO dbo.NHAPHANG(MANHAPHANG,TAIKHOAN,MANCC,NGAYNHAP)
                VALUES('" + NHAPHANG.MANHAPHANG + "','" + NHAPHANG.TAIKHOAN + "','" + NHAPHANG.MANCC + "','" + NHAPHANG.NGAYNHAP+ "')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0) { return true; }
            return false;
        }
        //Thêm mới một bảng ghi vào bảng chi tiết đặt hàng
        public bool InsertCHITETNHAPHANG(CHITIETNHAPHANG NHAPHANG) { 
        
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"INSERT INTO dbo.CHITIETNHAPHANG(MANHAPHANG,MASP,SOLUONG, GIANHAP, GIABAN)
                           VALUES('" + NHAPHANG.MANHAPHANG + "','" + NHAPHANG.MASANPHAM + "', '" + NHAPHANG.SOLUONG + "','" + NHAPHANG.GIANHAP + "','" + NHAPHANG.GIABAN + "')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0) { return true; }
            return false;
        }


        //Cập nhật bảng ghi bất kì
        public bool UpDate(string Query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(Query, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0)
            {
                return true;
            }
            return false;
        }

        public bool InsertSANPHAM(SANPHAM SANPHAM)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"INSERT INTO dbo.SANPHAM(MASP,TENSP,HINHANH,DONVITINH,SOLUONG, DONGIA,MALOAI)
                           VALUES('" + SANPHAM.MASP + "',N'" + SANPHAM.TENSP + "', '" + SANPHAM.HINHANH + "',N'" + SANPHAM.DONVITINH + "'," + SANPHAM.SOLUONG + "," + SANPHAM.DONGIA + ",'" + SANPHAM.MALOAI + "')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0) { return true; }
            return false;
        }
        public bool InsertTAIKHOAN(TAIKHOAN TAIKHOAN)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"INSERT INTO dbo.QUANLY(TAIKHOAN,MATKHAU,EMAIL,DIACHI,HOTEN, PHANQUYEN, SDT)
                           VALUES('" + TAIKHOAN.TENTAIKHOAN + "','" + TAIKHOAN.MATKHAU + "', '" +TAIKHOAN.EMAIL+ "','" + TAIKHOAN.DIACHI + "','" + TAIKHOAN.HOTEN + "'," + TAIKHOAN.QUYEN + ",'" + TAIKHOAN.SODIENTHOAI + "')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0) { return true; }
            return false;
        }

        public bool InsertKHACHHANG(KHACHHANG KHACHHANG)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"INSERT INTO dbo.KHACHHANG(TENKH,DIACHI,EMAIL,SDT)
                           VALUES('" + KHACHHANG.HOTEN + "','" + KHACHHANG.DIACHI + "', '" + KHACHHANG.EMAIL + "','" + KHACHHANG.SDT + "')";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0) { return true; }
            return false;
        }

        public bool InsertDONHANG(DONHANG DONHANG)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"INSERT INTO dbo.DONHANG(MAKH,NGAYDATHANG, MADONHANG)
                           VALUES('" + DONHANG.MAKH + "','" + DONHANG.NGAYDAT + "',"+DONHANG.MADONHANG+")";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0) { return true; }
            return false;
        }
        public bool InsertCHITIETDONHANG(CHITIETDONHANG CHITIETDONHANG)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string sql = @"INSERT INTO dbo.CHITIETDONHANG(MASP,MADONHANG, SOLUONGSP)
                           VALUES('" + CHITIETDONHANG.MASP + "','" + CHITIETDONHANG.MADONHANG + "'," + CHITIETDONHANG.SOLUONG + ")";
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            if (result != 0) { return true; }
            return false;
        }
    }
}