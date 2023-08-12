using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class hoadonnhap
    {
        public int SoHoaDon { get; set; }
        public DateTime ngayNhap { get; set; }
        public string hoTen { get; set; }
        public string nsx_name { get; set; }
    }
    public class getChiTietHoaDonNhap
    {
        public int MaChiTietHoaDonNhap { get; set; }
        public string sanp_name { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }
    }
    public class getHoaDonNhap
    {
        public int SoHoaDon { get; set; }
        public DateTime ngayNhap { get; set; }
        public string hoTen { get; set; }

    }
    public class HoaDonNhapModel
    {
        public int SoHoaDon { get; set; }
        public DateTime NgayNhap { get; set; }
        public int MaNguoiDung { get; set; }
        public int nsx_id { get; set; }
    }
    
    public class HDN
    {
        public HoaDonNhapModel HoaDonNhapModel { get; set; }
        public List<ChiTietHoaDonNhapModel> ListHDN { get; set; }
    }
}
