using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using Model;
using BLL.Interface;
using Model.Code;

namespace BLL
{
    public class HomeBLL:IHomeBLL
    {
        private IHomeRepository _res;
        public HomeBLL(IHomeRepository res)
        {
            _res = res;
        }
        public List<SachModel> sanphammoi(int soluong)
        {
            return _res.sanphammoi(soluong);
        }
        public List<SachModel> GetByTg(int id)
        {
            return _res.GetByTg(id);
        }
        public List<SachModel> GetByNhasx(int id)
        {
            return _res.GetByNhasx(id);
        }
        public List<banchay> banchay(int soluong)
        {
            return _res.banchay(soluong);
        }
        public List<SachModel> GetByLoaiSp(int id)
        {
            return _res.GetByLoaisp(id);
        }
        public List<SachModel> TimKiem(string ten)
        {
            return _res.TimKiem(ten);
        }
        public List<SachModel> GetSpByLoai(int soluong, int ten)
        {
            return _res.GetSpByLoai(ten, soluong);
        }
        public List<DanhMucModel> GetDanhMuc(int soluong)
        {
            return _res.GetDanhMuc(soluong);
        }
        public List<LoaispModel> GetLoaiSpByDanhMuc(int id)
        {
            return _res.GetLoaiSpByDanhMuc(id);
        }
        public List<SachModel> SachCungTacGia(int id, int soluong)
        {
            return _res.SachCungTacGia(id, soluong);
        }
    }
}
