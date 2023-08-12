using DAL.Interface;
using Model.Code;
using Model;
using BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class HoaDonBanBLL: IHoaDonBanBLL
    {
        private IHoaDonBanRespository _repository;
        public HoaDonBanBLL(IHoaDonBanRespository repository)
        {
            _repository = repository;
        }
        public bool CreateHoaDon(HoaDonBanModel model)
        {
            return _repository.CreateHoaDon(model);
        }
        public getHoaDon getHoaDon(int id)
        {
            return _repository.getHoaDon(id);
        }
        public bool CreateChiTiet(ChiTetHoaDonBanModel model)
        {
            return _repository.CreateChiTiet(model);
        }
        public bool UpdateHoaDon(HoaDonBanModel model)
        {
            return _repository.UpdateHoaDon(model);
        }
        public bool UpdateChiTiet(ChiTetHoaDonBanModel model)
        {
            return _repository.UpdateChiTiet(model);
        }
        public bool DeleteHoaDon(int ma)
        {
            return _repository.DeleteHoaDon(ma);
        }
        public bool DeleteChiTiet(int ma)
        {
            return _repository.DeleteChiTiet(ma);
        }
        public List<HienThiHoaDonBan> TimKiem(string ma)
        {
            return _repository.TimKiem(ma);
        }
        public List<hoadonbanmd> hoadonban(int ma)
        {
            return _repository.hoadonban(ma);
        }
        public List<ChiTietHoaDonBan> getChiTiet(int ma)
        {
            return _repository.getChiTiet(ma);
        }

        public List<HienThiHoaDonBan> GetAll(int ma)
        {
            return _repository.GetAll(ma);
        }
    }
}
