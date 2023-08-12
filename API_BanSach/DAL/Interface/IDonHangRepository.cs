using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;

namespace DAL.Interface
{
    public partial interface IDonHangRepository
    {
        bool Create(DonHang model);
        List<getdonhang> DonHang(int soluong);
        List<getChiTietDonhang> getChiTietDonHangById(int id);
        getDonHang getDonHangById(int id);
        bool DeleteDonHang(int id);
        bool DeleteChiTiet(int id);
        bool addHoaDon(addHoaDonBan model);
        List<hienthiDonHang> GetAll(int soluong);
        List<ChiTiet> getChiTietById(int id);
        KhachHangModel getKhachHangById(int id);
        List<hienthiDonHang> TimKiem(string soluong);
        List<hienthiDonHang> TimKiemNguoiDung(string soluong);
        bool UpdateDonHang(DonHangModel model);
        bool CreateDonHang(DonHangModel model);
        bool UpdateChiTiet(ChiTietDonHang model);
        bool CreateChiTiet(ChiTietDonHang model);
        GetByIdDonHang GetById(int id);
        List<DonHang> Search(int pageIndex, int pageSize, out long total, string TenKhachHang, int SDT, string Email, DateTime fr_NgayDat, DateTime to_NgayDat, string option);
    }
}
