using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BLL.Interface
{
    public interface IDanhMucBLL
    {
        DanhMucModel GetDatabyID(int id);
        bool Create(DanhMucModel model);
        bool Delete(int id);
        bool Update(DanhMucModel model);
        List<DanhMucModel> Search(int pageIndex, int pageSize, out long total, string tenDauSach);
        List<DanhMucModel> GetAll(int soluong);
    }
}
