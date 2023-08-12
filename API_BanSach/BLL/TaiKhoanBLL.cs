using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL.Interface;
using BLL.Interface;
namespace BLL
{
    public class TaiKhoanBLL:ITaiKhoanBLL
    {
        private ITaiKhoanRepository _res;
        public TaiKhoanBLL(ITaiKhoanRepository res)
        {
            _res = res;
        }
        public List<TaiKhoan> GetAll()
        {
            return _res.GetAll();
        }
        public TaiKhoan GetById(int id)
        {
            return _res.GetById(id);
        }
        public bool Create(TaiKhoan model)
        {
            return _res.Create(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(TaiKhoan model)
        {
            return _res.Update(model);
        }
    }
}
