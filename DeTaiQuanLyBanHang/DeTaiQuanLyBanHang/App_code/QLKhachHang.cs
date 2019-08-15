using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeTaiQuanLyBanHang.App_code
{
    public class QLKhachHang
    {

        // Field (còn gọi là trường dữ liệu) 
        string firstName;
        string lastName;
        string email;
        bool gender;
        string address;
        string userName;
        string passWord;

        // Định nghĩa Property          // cho các Field muốn truy xuất từ bên ngoài
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
    }
}