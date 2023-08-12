using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL.Interface
{
    public interface IGiaSachBLL
    {
        bool Create(GiaCaModel model);
        bool Update(GiaCaModel model);
        bool Delete(int id);
        GiaCaModel GetById(int id);
        List<GiaCaModel> GetAll();
    }
}
