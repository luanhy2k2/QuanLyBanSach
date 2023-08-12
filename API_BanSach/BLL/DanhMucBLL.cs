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
    public class DanhMucBLL: IDanhMucBLL
    {
        private  IDanhMucRepository _res;
        public DanhMucBLL(IDanhMucRepository res)
        {
            _res = res;
        }
        public List<DanhMucModel> Search(int pageIndex, int pageSize, out long total, string tenDanhMuc)
        {
            return _res.Search(pageIndex, pageSize, out total, tenDanhMuc);
        }
        public DanhMucModel GetDatabyID(int id)
        {
            return _res.GetDatabyID(id);
        }
        public List<DanhMucModel> GetAll(int soluong)
        {
            return _res.GetAll(soluong);
        }
        public bool Create(DanhMucModel model)
        {
            return _res.Create(model);
        }
        public bool Delete(int id)
        {
            return (_res.Delete(id));
        }
        public bool Update(DanhMucModel model)
        {
            return _res.Update(model);
        }
    }
}
