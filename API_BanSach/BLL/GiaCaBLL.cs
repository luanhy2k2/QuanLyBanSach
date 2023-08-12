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
    public class GiaCaBLL:IGiaSachBLL
    {
        private IGiaSachRepository _res;
        public GiaCaBLL(IGiaSachRepository res)
        {
            _res = res;
        }
        public GiaCaModel GetById(int id)
        {
            return _res.GetById(id);
        }
        public List<GiaCaModel> GetAll()
        {
            return _res.GetAll();
        }
        public bool Create(GiaCaModel model)
        {
            return _res.Create(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(GiaCaModel model)
        {
            return _res.Update(model);
        }
    }
}
