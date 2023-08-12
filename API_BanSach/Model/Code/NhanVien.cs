using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Code
{
    public class NhanVien
    {
        public NguoiDung nguoiDung { get; set; }
        public TaiKhoan taiKhoan { get; set;}
    }
    public class ThongTinNhanVien
    {
        public int maNguoiDung { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string email { get; set; }
        public string? sdt { get; set; }

    
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
  
        public string trangThai { get; set; }
        public string loaiQuyen { get; set; }
    }
}
