using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Model.Code
{
    public class DonHang
    {
        public KhachHangModel KhachHang { get; set;}
        public List<ChiTietDonHang> listchitiet {  get; set; }
       
    }






    public class GetByIdDonHang
    {
        public int MaDonHang { get; set; }
        public DateTime NgayDat { get; set; }
        public string tenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public List<listjson_chitiet> listjson_chitiet { get; set; }
        
    }
    public class listjson_chitiet
    {
        public int sanp_id { get; set; }
        public string sanp_name { get; set; }
        public int soLuong { get; set; }
        public int gia { get; set; }
    }
    public class hienthiDonHang
    {
        public int MaDonHang { get; set; }
        public int MaKhachHang { get; set; }
        public DateTime NgayDat { get; set; }
        public string TrangThai { get; set; }
        public int MaChiTietDonHang { get; set; }
        public string tenKhachHang { get; set; }
        public string sanp_name { get; set; }
        public string sanp_id { get; set; }
        public string sdt { get; set; }
        public int soLuong { get; set; }
        public int gia { get; set; }
    }

}
