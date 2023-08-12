using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BLL.Interface
{
    public interface ITacGiaBLL
    {
        bool Create(TacGiaModel model);
        TacGiaModel GetById(int id);
        bool Update(TacGiaModel model);
        bool Delete(int id);
        List<TacGiaModel> TimKiem(string ten);
        List<TacGiaModel> GetAll(int soluong);
    }
}
