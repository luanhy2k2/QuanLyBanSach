using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
    public partial interface IDanhMucRepository
    {
        DanhMucModel GetDatabyID(int ID);
        bool Create(DanhMucModel model);

        bool Delete(int id);
        bool Update(DanhMucModel model);
        List<DanhMucModel> GetAll(int soluong);
        List<DanhMucModel> Search(int pageIndex, int pageSize, out long total, string tenDanhMuc);

    }
}
