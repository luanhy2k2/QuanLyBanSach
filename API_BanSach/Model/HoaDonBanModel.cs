using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class hoadonbanmd
    {
        public int SoHoaDon { get; set; }
        public DateTime NgayBan { get; set; }
        public int MaDonHang { get; set; }
        public string tenKhachHang { get; set; }

    }
    public class getHoaDon
    {
        public int SoHoaDon { get; set; }
        public DateTime NgayBan { get; set; }
        public int MaDonHang { get; set; }
        public string tenKhachHang { get; set; }
        public string diaChi { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
    }
    public class ChiTietHoaDonBan
    {
        public int MaChiTietHoaDonBan { get; set; }
        public string sanp_name { get; set; }
        public int SoLuong { get; set; }
        public int GiaBan { get; set; }
    }
    public class HienThiHoaDonBan
    {
        public int SoHoaDon { get; set; }
        public DateTime NgayBan { get; set; }
        public int MaKhachHang { get; set; }
        public int MaChiTietHoaDonBan { get; set; }
        public string tenKhachHang { get; set; }
        public int sanp_id { get; set; }
        public string sanp_name { get; set; }
        public int SoLuong { get; set; }
        public int GiaBan { get; set; }
    }
    public class HoaDonBanModel
    {
        public int SoHoaDon { get; set; }
        public DateTime NgayBan { get; set; }
        public int MaKhachHang { get; set; }

    }
    public class ChiTetHoaDonBanModel
    {
        public int MaChiTietHoaDonBan { get; set; }
        public int SoHoaDon { get; set; }
        public int sanp_id { get; set; }
        public int SoLuong { get; set; }
        public int GiaBan { get; set; }
    }
}
