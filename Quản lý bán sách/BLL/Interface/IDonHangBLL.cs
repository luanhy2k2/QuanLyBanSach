using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;

namespace BLL.Interface
{
    public interface IDonHangBLL
    {
        bool Create(DonHang model);

        List<getdonhang> DonHang(int soluong);

        getDonHang getDonHangById(int id);
        List<getChiTietDonhang> getChiTietDonHangById(int id);
        bool DeleteDonHang(int id);
        bool addHoaDon(addHoaDonBan model);
        bool DeleteChiTiet(int id);
        bool CreateDonHang(DonHangModel Model);
        bool CreateChiTiet(ChiTietDonHang Model);
        bool UpdateDonHang(DonHangModel model);
        bool UpdateChiTiet(ChiTietDonHang mode);
        List<hienthiDonHang> GetAll(int soluong);
        List<ChiTiet> getChiTietById(int id);
        KhachHangModel getKhachHangById(int id);
        List<hienthiDonHang> TimKiem(string soluong);
        List<hienthiDonHang> TimKiemNguoiDung(string soluong);
        GetByIdDonHang GetById(int id);
        List<DonHang> Search(int pageIndex, int pageSize, out long total, string TenKhachHang, int SDT, string Email, DateTime fr_NgayDat, DateTime to_NgayDat, string option);
    }
}
