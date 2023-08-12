using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface;
using Model;
using DAL.Interface;
using Model.Code;

namespace BLL
{
    public class NguoiDungBLL:INguoiDung
    {
        private INguoiDungRepository _res;
        public NguoiDungBLL(INguoiDungRepository res)
        {
            _res = res;
        }
        public ThongTinNhanVien Authenticate(string taikhoans, string matkhau)
        {
            return _res.Authenticate(taikhoans, matkhau);
        }
        public NguoiDung GetById(int id)
        {
            return _res.GetById(id);
        }
        public List<ThongTinNhanVien> TimKiem(string ten)
        {
            return _res.TimKiem(ten);
        }
        public List<ThongTinNhanVien> GetAll(int soluong)
        {
            return _res.GetAll(soluong);
        }
        public bool Create(ThongTinNhanVien model)
        {
            return _res.Create(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(ThongTinNhanVien model)
        {
            return _res.Update(model);
        }
    }
}
