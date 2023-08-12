using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using BLL.Interface;
using Model;
namespace BLL
{
    public class TacGiaBLL: ITacGiaBLL
    {
        private ITacGiaRepository _res;
        public TacGiaBLL(ITacGiaRepository res)
        {
            _res = res;
        }
        public List<TacGiaModel> TimKiem(string ten)
        {
            return _res.TimKiem(ten);
        }
        public List<TacGiaModel> GetAll(int soluong)
        {
            return _res.GetAll(soluong);
        }
        public TacGiaModel GetById(int id)
        {
            return _res.GetById(id);
        }
        public bool Create(TacGiaModel model)
        {
            return _res.Create(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(TacGiaModel model)
        {
            return _res.Update(model);
        }
    }
}
