using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Model.Code
{
    public class hoadonnhapss
    {
        public HoaDonNhap hoadonnhap { get; set; }
        public List<cthdn> listchitiet { get; set; }
    }
    public class cthdn
    {

        public int maSanPham { get; set; }
        public int soLuong { get; set; }
        public int donGiaNhap { get; set; }
    }
    public class HoaDonNhap
    {
        
        public int MaNguoiDung { get; set; }
        public int nsx_id { get; set; }
    }
    public class hdnmodel
    {
        public int maNguoiDung { get; set; }
        
        public int nsx_id { get; set; }
        public int sanp_id { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }
     
    }
    public class edithdnmodel
    {
        public int soHoaDon { get; set; }
        public int maNguoiDung { get; set; }
        public DateTime ngayNhap { get; set; }
        public int nsx_id { get; set; }
        public int sanp_id { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }

    }
    public class hienThiHoaDonNhap
    {
        public int soHoaDon { get; set; }
        public int maNguoiDung { get; set; }
        public string nsx_name { get; set; }
        public string sanp_name { get; set; }
        public string hoTen { get; set; }
        public DateTime ngayNhap { get; set; }
        public int nsx_id { get; set; }
        public int sanp_id { get; set; }
        public int soLuong { get; set; }
        public int donGia { get; set; }
    }
    //public class ct
    //{


    //    public int maSanPham { get; set; }
    //    public int soLuong { get; set; }
    //    public int donGiaNhap { get; set; }

    //}
}
