using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class tk
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
    }
    public class TaiKhoan
    {
        public int MaTaiKhoan { get; set; }
        public int MaNguoiDung { get; set; }
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TrangThai { get; set; }
        public string LoaiQuyen { get; set; }
    }
}
