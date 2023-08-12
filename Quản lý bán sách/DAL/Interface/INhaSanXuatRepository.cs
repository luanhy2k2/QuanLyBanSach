using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
    public partial interface INhaSanXuatRepository
    {
        bool Create(NhaSanXuatModel model);
        bool Update(NhaSanXuatModel model);
        bool Delete(int id);
        NhaSanXuatModel GetById(int id);
        List<NhaSanXuatModel> GetAll(int soluong);
        List<NhaSanXuatModel> TimKiem(string ten);
    }
}
