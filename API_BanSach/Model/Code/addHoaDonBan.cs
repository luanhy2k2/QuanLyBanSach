using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Code
{
    public class getDonHang
    {
        public int MaDonHang { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime NgayDat { get; set; }
    }
    public class getChiTietDonhang
    { 
       
        public int sanp_id { get; set; }
        public int soLuong { get; set; }
        public int gia { get; set; }
    }
    public class addHoaDonBan
    {
        public int MaKhachHang { get; set; }
        public DateTime NgayBan { get; set; }
        public int MaDonHang { get; set; }
        public List<chitiethoadonban> listchitietdonhang { get; set; }
    }
    public class hdb
    {
        public DateTime NgayBan { get; set; }
        public int MaKhachHang { get; set; }
    }
    public class chitiethoadonban
    {
        public int sanp_id { get; set; }
        public int soLuong { get; set; }
        public int gia { get; set; }
    }
}
