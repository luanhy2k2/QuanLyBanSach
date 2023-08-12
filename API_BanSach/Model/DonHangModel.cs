using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DonHangModel
    {
        public int MaDonHang { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime NgayDat {  get; set; }
        public string TrangThai { get; set; }
    }

    public class getdonhang
    {
        public int MaDonHang { get; set; }
        public string tenKhachHang { get; set; }
        public DateTime NgayDat { get; set; }
       
    }
}
