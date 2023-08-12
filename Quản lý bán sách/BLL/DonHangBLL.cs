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
    public class DonHangBLL:IDonHangBLL
    {
        private IDonHangRepository _repository;
        public DonHangBLL(IDonHangRepository repository)
        {
            _repository = repository;
        }
        public bool Create(DonHang Model)
        {
            return _repository.Create(Model);
        }
        public List<hienthiDonHang> GetAll(int soluong)
        {
            return _repository.GetAll(soluong);
        }
        public List<getdonhang> DonHang(int soluong)
        {
            return _repository.DonHang(soluong);
        }
        public List<getChiTietDonhang> getChiTietDonHangById(int id)
        {
            return _repository.getChiTietDonHangById(id);
        }

        public getDonHang getDonHangById(int id)
        {
            return _repository.getDonHangById(id);
        }

        public List<hienthiDonHang> TimKiem(string soluong)
        {
            return _repository.TimKiem(soluong);
        }
        public List<hienthiDonHang> TimKiemNguoiDung(string soluong)
        {
            return _repository.TimKiemNguoiDung(soluong);
        }
        public bool addHoaDon(addHoaDonBan model)
        {
            return _repository.addHoaDon(model);
        }
        public bool UpdateDonHang(DonHangModel Model)
        {
            return _repository.UpdateDonHang(Model);
        }
        public KhachHangModel getKhachHangById(int id)
        {
            return _repository.getKhachHangById(id);
        }
        public List<ChiTiet> getChiTietById(int id)
        {
            return _repository.getChiTietById(id);
        }
        public bool DeleteDonHang(int Model)
        {
            return _repository.DeleteDonHang(Model);
        }
        public bool DeleteChiTiet(int Model)
        {
            return _repository.DeleteChiTiet(Model);
        }
        public bool CreateDonHang(DonHangModel Model)
        {
            return _repository.CreateDonHang(Model);
        }
        public bool UpdateChiTiet(ChiTietDonHang Model)
        {
            return _repository.UpdateChiTiet(Model);
        }
        public bool CreateChiTiet(ChiTietDonHang Model)
        {
            return _repository.CreateChiTiet(Model);
        }
        public GetByIdDonHang GetById(int id)
        {
            return _repository.GetById(id);
        }
        public List<DonHang> Search(int pageIndex, int pageSize, out long total, string TenKhachHang, int SDT, string Email, DateTime fr_NgayDat, DateTime to_NgayDat, string option)
        {
            return _repository.Search(pageIndex, pageSize,out total, TenKhachHang, SDT, Email, fr_NgayDat, to_NgayDat, option);
        }

    }
}
