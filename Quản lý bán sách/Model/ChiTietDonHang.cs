using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChiTietDonHang
    {
        public int MaChiTietDonHang { get; set; }
        public int MaDonHang { get; set; }
        public int sanp_id { get; set; }
        public int soLuong { get; set; }
        public int gia { get; set; }
    }
    public class ChiTiet
    {
        public int MaChiTietDonHang { get; set; }
        public int MaDonHang { get; set; }
        public string sanp_name { get; set; }
        public int soLuong { get; set; }
        public int gia { get; set; }
    }
}
