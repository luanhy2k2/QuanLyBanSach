using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;
namespace DAL.Interface
{
    public partial interface IHoaDonNhapRepository
    {
        List<getChiTietHoaDonNhap> getChiTietHoaDonNhap(int ten);
        getHoaDonNhap getHoaDonNhap(int ten);
        List<hoadonnhap> HoaDonNhap(int sl);
        bool Create(hoadonnhapss model);
        bool Update(edithdnmodel model);
        bool taoChiTiet(ChiTietHoaDonNhapModel model);
        bool Delete(int id);
        bool taomoi(hdnmodel model);
        hienThiHoaDonNhap GetById(int id);
        List<hienThiHoaDonNhap> GetAll(int soluong);
        List<hienThiHoaDonNhap> TimKiem(int ten);


    }
}
