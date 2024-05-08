using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_TaiKhoan
    {
        public int id { get; set; }
        public string tenTaiKhoan { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool trangThai { get; set; }
        public int loaiTaiKhoan { get; set; }
        public int nguoiDungId { get; set; }

        // Constructor không tham số
        public DTO_TaiKhoan() 
        {
        }
        public DTO_TaiKhoan(string username, string password, int loaiTaiKhoan)
        {
            this.username = username;
            this.password = password;
            this.loaiTaiKhoan = loaiTaiKhoan;
        }
        // Constructor với tham số
        public DTO_TaiKhoan(int id, string tenTaiKhoan, string username, string password, bool trangThai, int loaiTaiKhoan, int nguoiDungId)
        {
            this.id = id;
            this.tenTaiKhoan = tenTaiKhoan;
            this.username = username;
            this.password = password;
            this.trangThai = trangThai;
            this.loaiTaiKhoan = loaiTaiKhoan;
            this.nguoiDungId = nguoiDungId;
        }
    }
}
