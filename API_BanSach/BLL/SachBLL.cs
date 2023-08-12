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
    public class SachBLL:ISachBLL
    {
        private ISachRepository _res;
        public SachBLL(ISachRepository res)
        {
            _res = res;
        }
        public sachHienthi GetById(int id)
        {
            return _res.GetDataById(id);
        }
        public List<sachHienthi> GetAll()
        {
            return _res.GetAll();
        }
        public List<sachHienthi> TimKiem(string ten)
        {
            return _res.TimKiem(ten);
        }
        public bool Create(SachModel model)
        {
            return _res.Create(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(SachModel model)
        {
            return _res.Update(model);
        }
        public bool CreateSanPham(SanPham model)
        {
            return _res.CreateSanPham(model);
        }
    }
}
