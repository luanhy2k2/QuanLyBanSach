using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;

namespace DAL.Interface
{
    public partial interface IHomeRepository
    {
        List<SachModel> sanphammoi(int soluong);
        List<banchay> banchay(int soluong);
        List<SachModel> GetByLoaisp(int id);
        List<SachModel> TimKiem(string ten);
        List<SachModel> GetSpByLoai(int ten, int soluong);
        List<LoaispModel> GetLoaiSpByDanhMuc(int id);
        List<DanhMucModel> GetDanhMuc(int soluong);
        List<SachModel> GetByTg(int id);
        List<SachModel> GetByNhasx(int id);
        List<SachModel> SachCungTacGia(int id, int soluong);

    }
}
