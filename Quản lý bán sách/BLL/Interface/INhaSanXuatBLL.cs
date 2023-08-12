using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BLL.Interface
{
    public interface INhaSanXuatBLL
    {
        bool Create(NhaSanXuatModel model);
        bool Update(NhaSanXuatModel model);
        bool Delete(int id);
        NhaSanXuatModel GetById(int id);
        List<NhaSanXuatModel> TimKiem(string ten);
        List<NhaSanXuatModel> GetAll(int soluong);
    }
}
