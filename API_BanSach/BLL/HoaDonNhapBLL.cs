using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;
using DAL.Interface;
using BLL.Interface;
namespace BLL
{
    public class HoaDonNhapBLL:IHoaDonNhapBLL
    {
        private IHoaDonNhapRepository _res;
        public HoaDonNhapBLL(IHoaDonNhapRepository res)
        {
            _res = res;
        }
        public List<hienThiHoaDonNhap> TimKiem(int ten)
        {
            return _res.TimKiem(ten);
        }
        public List<getChiTietHoaDonNhap> getChiTietHoaDonNhap(int ten)
        {
            return _res.getChiTietHoaDonNhap(ten);
        }
        public List<hoadonnhap> HoaDonNhap(int ten)
        {
            return _res.HoaDonNhap(ten);
        }
        public getHoaDonNhap getHoaDonNhap(int ten)
        {
            return _res.getHoaDonNhap(ten);
        }
        public hienThiHoaDonNhap GetById(int id)
        {
            return _res.GetById(id);
        }

        public List<hienThiHoaDonNhap> GetAll(int soluong)
        {
            return _res.GetAll(soluong);
        }
        public bool Create(hoadonnhapss model)
        {
            
            return _res.Create(model);
        }
        public bool CreateChiTiet(ChiTietHoaDonNhapModel model)
        {

            return _res.taoChiTiet(model);
        }
        public bool taomoi(hdnmodel model)
        {

            return _res.taomoi(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(edithdnmodel model)
        {
            return _res.Update(model);
        }
    }
}
