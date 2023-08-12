using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;
namespace BLL.Interface
{
    public interface IHoaDonNhapBLL
    {
        List<hoadonnhap> HoaDonNhap(int ten);
        List<getChiTietHoaDonNhap> getChiTietHoaDonNhap(int ten);
        getHoaDonNhap getHoaDonNhap(int ten);
        bool Create(hoadonnhapss model);
        bool CreateChiTiet(ChiTietHoaDonNhapModel model);
        bool taomoi(hdnmodel model);
        bool Update(edithdnmodel model);
        bool Delete(int id);
        hienThiHoaDonNhap GetById(int id);
        List<hienThiHoaDonNhap> GetAll(int soluong);
        List<hienThiHoaDonNhap> TimKiem(int ten);
    }
}
