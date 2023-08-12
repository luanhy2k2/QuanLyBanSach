using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BLL.Interface;
using DAL.Interface;
namespace BLL
{
    public class NhaSanXuatBLL: INhaSanXuatBLL
    {
        private INhaSanXuatRepository _res;
        public NhaSanXuatBLL(INhaSanXuatRepository res)
        {
            _res = res;
        }
        public NhaSanXuatModel GetById(int id)
        {
            return _res.GetById(id);
        }
        public List<NhaSanXuatModel> GetAll(int soluong)
        {
            return _res.GetAll(soluong);
        }
        public List<NhaSanXuatModel> TimKiem(string ten)
        {
            return _res.TimKiem(ten);
        }
        public bool Create(NhaSanXuatModel model)
        {
            return _res.Create(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(NhaSanXuatModel model)
        {
            return _res.Update(model);
        }
    }
}
