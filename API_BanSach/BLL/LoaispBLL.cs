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
    public class LoaispBLL: ILoaispBLL
    {
        private ILoaispRepository _res;
        public LoaispBLL(ILoaispRepository res)
        {
            _res = res;
        }
        public LoaispModel GetById(int id)
        {
            return _res.GetById(id);
        }
        public List<LoaispModel> GetAll(int soluong)
        {
            return _res.GetAll(soluong);
        }
        public List<LoaispModel> TimKiem(string ten)
        {
            return _res.TimKiem(ten);
        }
        public bool Create(LoaispModel model)
        {
            return _res.Create(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(LoaispModel model)
        {
            return _res.Update(model);
        }
    }
}
