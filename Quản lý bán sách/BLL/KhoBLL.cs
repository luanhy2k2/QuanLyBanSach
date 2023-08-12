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
    public class KhoBLL: IKhoBLL
    {
        private IKhoRepository _res;
        public KhoBLL(IKhoRepository res)
        {
            _res = res;
        }
        public khoedit GetById(int id)
        {
            return _res.GetById(id);
        }
        public List<khoedit> TimKiem(int ten)
        {
            return _res.TimKiem(ten);
        }
        public List<khoedit> GetAll()
        {
            return _res.GetAll();
        }
        public bool Create(khoedit model)
        {

            return _res.Create(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(khoedit model)
        {
            return _res.Update(model);
        }
    }
}
