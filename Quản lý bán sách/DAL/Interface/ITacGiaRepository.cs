using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
    public partial interface ITacGiaRepository
    {
        TacGiaModel GetById(int id);
        bool Create(TacGiaModel model);
        bool Update(TacGiaModel model);
        bool Delete(int model);
        List<TacGiaModel> GetAll(int soluong);
        List<TacGiaModel> TimKiem(string ten);
    }
}
