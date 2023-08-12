using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using Model;
using Model.Code;

namespace BLL.Interface
{
    public interface IHomeBLL
    {
        List<SachModel> sanphammoi(int soluong);
        List<banchay> banchay(int soluong);
        List<SachModel> GetByLoaiSp(int id);
        List<SachModel> TimKiem(string ten);
        List<SachModel> GetSpByLoai(int soluong, int ten);
        List<DanhMucModel> GetDanhMuc(int soluong);
        List<LoaispModel> GetLoaiSpByDanhMuc(int  id);
        List<SachModel> GetByTg(int id);
        List<SachModel> GetByNhasx(int id);
        List<SachModel> SachCungTacGia(int id, int soluong);

    }
}
