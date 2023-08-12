using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IHoaDonBanRespository
    {

        getHoaDon getHoaDon(int ma);
        List<hoadonbanmd> hoadonban(int ma);
        List<ChiTietHoaDonBan> getChiTiet(int ma);
        bool CreateHoaDon(HoaDonBanModel model);
        bool CreateChiTiet(ChiTetHoaDonBanModel model);
        bool UpdateHoaDon(HoaDonBanModel model);
        bool UpdateChiTiet(ChiTetHoaDonBanModel model);
        bool DeleteHoaDon(int ma);
        bool DeleteChiTiet(int ma);
        List<HienThiHoaDonBan> TimKiem(string ma);
        List<HienThiHoaDonBan> GetAll(int ma);
    }
}
